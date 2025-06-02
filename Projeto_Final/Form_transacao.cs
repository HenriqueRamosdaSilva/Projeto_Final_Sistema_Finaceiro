using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace Projeto_Final
{
    public partial class Form_transacao : Form
    {
        private string connString =
"Host=localhost;Username=postgres;Password=Henrique1207;Database=sistema_financas";
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        public Form_transacao()
        {
            InitializeComponent();
        }

        private void button_fechar_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_minimizar_maximizar_home_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button_minimizar_home_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox_tipo_transacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form_transacoes_Load(object sender, EventArgs e)
        {
            comboBox_tipo_transacao.Items.Add("receita");
            comboBox_tipo_transacao.Items.Add("despesa");
            comboBox_tipo_transacao.DropDownStyle = ComboBoxStyle.DropDownList;

            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT nome_categoria FROM categoria ORDER BY nome_categoria";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_categoria.Items.Add(reader.GetString(0));
                    }
                }
            }
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                SELECT c.tipo_conta, c.instituicao, u.nome
                FROM conta c
                JOIN usuario u ON c.id_usuario = u.id_usuario
                ORDER BY c.tipo_conta";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_conta.Items.Add($"{reader.GetString(2)} - {reader.GetString(0)} - {reader.GetString(1)}");
                    }
                }
            }
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            if (comboBox_tipo_transacao.SelectedIndex == -1 ||
                comboBox_categoria.SelectedIndex == -1 ||
                comboBox_conta.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textBox_valor.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            if (!decimal.TryParse(textBox_valor.Text, out decimal valor))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            string tipoTransacao = comboBox_tipo_transacao.SelectedItem.ToString();
            string categoria = comboBox_categoria.SelectedItem.ToString();
            string contaSelecionada = comboBox_conta.SelectedItem.ToString();
            string descricao = textBox_descricao.Text;

            var partesConta = contaSelecionada.Split(" - ");
            if (partesConta.Length < 3)
            {
                MessageBox.Show("Conta selecionada inválida.");
                return;
            }
            string nome = partesConta[0];
            string tipoConta = partesConta[1];
            string instituicao = partesConta[2];
            int idCategoria = -1;
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string queryCategoria = "SELECT id_categoria FROM categoria WHERE nome_categoria = @nome";
                using (var cmd = new Npgsql.NpgsqlCommand(queryCategoria, conn))
                {
                    cmd.Parameters.AddWithValue("nome", categoria);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        idCategoria = Convert.ToInt32(result);
                    else
                    {
                        MessageBox.Show("Categoria não encontrada.");
                        return;
                    }
                }
            }
            int idConta = -1;
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string queryConta = @"
            SELECT c.id_conta
            FROM conta c
            JOIN usuario u ON c.id_usuario = u.id_usuario
            WHERE u.nome = @nome AND c.tipo_conta = @tipo_Conta AND c.instituicao = @instituicao";
                using (var cmd = new Npgsql.NpgsqlCommand(queryConta, conn))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("tipo_Conta", tipoConta);
                    cmd.Parameters.AddWithValue("instituicao", instituicao);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        idConta = Convert.ToInt32(result);
                    else
                    {
                        MessageBox.Show("Conta não encontrada.");
                        return;
                    }
                }
            }
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string insertQuery = @"
                INSERT INTO transacao (tipo_transacao, valor, descricao, id_categoria, id_conta, data_transacao)
                VALUES (@tipo_transacao, @valor, @descricao, @id_categoria, @id_conta, @data_transacao)";

                using (var cmd = new Npgsql.NpgsqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("tipo_transacao", tipoTransacao);
                    cmd.Parameters.AddWithValue("valor", valor);
                    cmd.Parameters.AddWithValue("descricao", descricao ?? "");
                    cmd.Parameters.AddWithValue("id_categoria", idCategoria);
                    cmd.Parameters.AddWithValue("id_conta", idConta);
                    cmd.Parameters.AddWithValue("data_transacao", dateTimePicker_data.Value);


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Transação salva com sucesso!");
            comboBox_tipo_transacao.SelectedIndex = -1;
            comboBox_categoria.SelectedIndex = -1;
            comboBox_conta.SelectedIndex = -1;
            textBox_valor.Clear();
            textBox_descricao.Clear();
            dateTimePicker_data.Value = DateTime.Now;


        }

        private void textBox_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

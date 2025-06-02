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

namespace Projeto_Final
{
    public partial class Form_conta : Form
    {
        private string connString = "Host=localhost;Username=postgres;Password=Henrique1207;Database=sistema_financas";
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


        public Form_conta()
        {
            InitializeComponent();
        }

        private void button_fechar__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_minimizar_maximizar_Click(object sender, EventArgs e)
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

        private void textBox_tipo_de_conta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_instituição_financeira_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            if (comboBox_usuario.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário.");
                return;
            }

            string tipo_conta = textBox_tipo_de_conta.Text;
            string instituicao = textBox_instituição_financeira.Text;
            decimal saldoInicial;
            if (!decimal.TryParse(textBox_saldo_inicial.Text, out saldoInicial))
            {
                MessageBox.Show("Saldo inicial inválido. Digite um número válido.");
                return;
            }


            if (string.IsNullOrWhiteSpace(tipo_conta))
            {
                MessageBox.Show("Preencha o tipo de conta.");
                return;
            }
            if (string.IsNullOrWhiteSpace(instituicao))
            {
                MessageBox.Show("Preencha a instituição financeira.");
                return;
            }

            int id_usuario = ((KeyValuePair<string, int>)comboBox_usuario.SelectedItem).Value;

            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO conta (tipo_conta, instituicao, saldo, id_usuario) VALUES (@tipo_conta, @instituicao, @saldo, @id_usuario)";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo_conta", tipo_conta);
                    cmd.Parameters.AddWithValue("@instituicao", instituicao);
                    cmd.Parameters.AddWithValue("@saldo", saldoInicial);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Conta salva com sucesso!");
            textBox_tipo_de_conta.Clear();
            textBox_instituição_financeira.Clear();
            textBox_saldo_inicial.Clear();
        }

        private void numericUpDown_saldo_inicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form_conta_Load(object sender, EventArgs e)
        {

            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT id_usuario, nome FROM usuario";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    Dictionary<string, int> usuarios = new Dictionary<string, int>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nome = reader.GetString(1);
                        usuarios[nome] = id;
                    }

                    comboBox_usuario.DataSource = new BindingSource(usuarios, null);
                    comboBox_usuario.DisplayMember = "Key";
                    comboBox_usuario.ValueMember = "Value";
                }
            }

        }

        private void Form_conta_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void textBox_saldo_inicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

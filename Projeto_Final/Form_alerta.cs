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
using Npgsql;

namespace Projeto_Final
{
    public partial class Form_alerta : Form
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


        public Form_alerta()
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

        private void comboBox_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form_alerta_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nome FROM usuario", conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_usuario.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT nome_categoria FROM categoria", conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_categoria.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = comboBox_usuario.SelectedItem?.ToString();
            string nomeCategoria = comboBox_categoria.SelectedItem?.ToString();
            string descricao = textBox_descricao.Text;

            // Verifica se o valor é numérico e válido
            if (!decimal.TryParse(textBox_valor_limite.Text, out decimal valor))
            {
                MessageBox.Show("Valor limite inválido.");
                return;
            }

            if (string.IsNullOrEmpty(nomeUsuario) || string.IsNullOrEmpty(nomeCategoria) || string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            int idUsuario = -1;
            int idCategoria = -1;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Buscar id_usuario
                using (var cmd = new NpgsqlCommand("SELECT id_usuario FROM usuario WHERE nome = @nome", conn))
                {
                    cmd.Parameters.AddWithValue("nome", nomeUsuario);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        idUsuario = Convert.ToInt32(result);
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                        return;
                    }
                }

                // Buscar id_categoria
                using (var cmd = new NpgsqlCommand("SELECT id_categoria FROM categoria WHERE nome_categoria = @nome", conn))
                {
                    cmd.Parameters.AddWithValue("nome", nomeCategoria);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        idCategoria = Convert.ToInt32(result);
                    else
                    {
                        MessageBox.Show("Categoria não encontrada.");
                        return;
                    }
                }

                // Inserir alerta no banco
                using (var cmd = new NpgsqlCommand(@"
            INSERT INTO alerta (id_usuario, descricao_alerta, valor_limite, id_categoria)
            VALUES (@id_usuario, @descricao, @valor, @id_categoria)", conn))
                {
                    cmd.Parameters.AddWithValue("id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("descricao", descricao);
                    cmd.Parameters.AddWithValue("valor", valor);
                    cmd.Parameters.AddWithValue("id_categoria", idCategoria);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Alerta salvo com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar alerta: {ex.Message}");
                    }
                }
            }
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT a.id_alerta, u.nome, c.nome_categoria, a.descricao_alerta, a.valor_limite FROM alerta a JOIN usuario u ON a.id_usuario = u.id_usuario JOIN categoria c ON a.id_categoria = c.id_categoria", conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_alertas.DataSource = dt;
                reader.Close();
            }

        }

        private void listBox_alertas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            if (dataGridView_alertas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um alerta para remover.");
                return;
            }
            int idAlerta = Convert.ToInt32(dataGridView_alertas.SelectedRows[0].Cells["id_alerta"].Value);
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM alerta WHERE id_alerta = @id_alerta", conn);
                cmd.Parameters.AddWithValue("id_alerta", idAlerta);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Alerta removido com sucesso!");
                    button_listar_Click(sender, e); // Atualiza a lista de alertas
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover alerta: {ex.Message}");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_alertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox_alertas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

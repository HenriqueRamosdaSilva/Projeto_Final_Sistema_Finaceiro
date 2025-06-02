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
    public partial class Form_usuarios : Form
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

        public Form_usuarios()
        {
            InitializeComponent();
        }

        private void button_fechar_Usuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_minimizar_maximizar_Usuarios_Click(object sender, EventArgs e)
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

        private void button_minimizar_Usuarios_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            string nome = textBox_nome_usuarios.Text;
            string email = textBox_email_usuarios.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite um nome.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Digite um email.");
                return;
            }
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO usuario (nome, email) VALUES (@nome, @email)";
                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Dados salvos com sucesso!");
                textBox_nome_usuarios.Clear();
                textBox_email_usuarios.Clear();
            }
            catch (PostgresException ex)
            {
                if (ex.SqlState == "23505") // Unique violation
                {
                    MessageBox.Show("Este e-mail já está cadastrado.");
                }
                else
                {
                    MessageBox.Show($"Erro do PostgreSQL: {ex.MessageText}");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro de formato nos dados: " + ex.Message);
            }
        }

        private void button_Listar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM usuario";
                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro ao listar usuários: " + ex.Message);
            }
        }

        private void button_remover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um usuário para remover.");
                return;
            }
            int idUsuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_usuario"].Value);
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM usuario WHERE id_usuario = @id_usuario";
                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuário removido com sucesso!");
                button_Listar_Click(sender, e); // Atualiza a lista
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro ao remover usuário: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

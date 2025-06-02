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
    public partial class Form_categoria : Form
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


        public Form_categoria()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_tipo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            string nomeCategoria = textBox_nome.Text.Trim();
            string tipoCategoria = comboBox_tipo_categoria.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nomeCategoria) || string.IsNullOrEmpty(tipoCategoria))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO categoria (nome_categoria, tipo_categoria) VALUES (@nome_Categoria, @tipo_Categoria)";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome_Categoria", nomeCategoria);
                    cmd.Parameters.AddWithValue("@tipo_Categoria", tipoCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Categoria salva com sucesso!");
            comboBox_tipo_categoria.SelectedIndex = -1;
            textBox_nome.Clear();

        }
        private void Form_categoria_Load(object sender, EventArgs e)
        {
            comboBox_tipo_categoria.Items.Add("receita");
            comboBox_tipo_categoria.Items.Add("despesa");
            comboBox_tipo_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView_categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT id_categoria, nome_categoria, tipo_categoria FROM categoria";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView_categoria.DataSource = dt;
                }
            }
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            if (dataGridView_categoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma categoria para remover.");
                return;
            }
            int idCategoria = Convert.ToInt32(dataGridView_categoria.SelectedRows[0].Cells["id_categoria"].Value);
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM categoria WHERE id_categoria = @id_categoria";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Categoria removida com sucesso!");
            button_listar.PerformClick();
        }
    }
}

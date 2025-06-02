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
    public partial class Form_meta_financeira : Form
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


        public Form_meta_financeira()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_valor_meta_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_data_limite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_descricao.Text) ||
                string.IsNullOrWhiteSpace(textBox_valor_meta.Text) ||
                comboBox_categoria.SelectedIndex == -1 ||
                comboBox_usuario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(textBox_valor_meta.Text, out decimal valorMeta))
            {
                MessageBox.Show("Valor da meta inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string descricao = textBox_descricao.Text;
            DateTime dataLimite = dateTimePicker_data_limite.Value;
            string nomeCategoria = comboBox_categoria.SelectedItem.ToString();
            string nomeUsuario = comboBox_usuario.SelectedItem.ToString();

            int idCategoria = -1;
            int idUsuario = -1;

            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string queryCategoria = "SELECT id_categoria FROM categoria WHERE nome_categoria = @nome";
                using (var cmd = new Npgsql.NpgsqlCommand(queryCategoria, conn))
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
            }

            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string queryUsuario = "SELECT id_usuario FROM usuario WHERE nome = @nome";
                using (var cmd = new Npgsql.NpgsqlCommand(queryUsuario, conn))
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
            }

            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string insertQuery = @"
        INSERT INTO metafinanceira (id_usuario, descricao_meta, valor_meta, data_limite, id_categoria)
        VALUES (@id_usuario, @descricao, @valor, @data, @id_categoria)";
                using (var cmd = new Npgsql.NpgsqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("descricao", descricao);
                    cmd.Parameters.AddWithValue("valor", valorMeta);
                    cmd.Parameters.AddWithValue("data", dataLimite);
                    cmd.Parameters.AddWithValue("id_categoria", idCategoria);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Meta financeira salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_descricao.Clear();
            textBox_valor_meta.Clear();
            comboBox_categoria.SelectedIndex = -1;
            comboBox_usuario.SelectedIndex = -1;
            dateTimePicker_data_limite.Value = DateTime.Now;

        }
        private void loadGeral(object sender, EventArgs e)
        {
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
                SELECT u.nome
                FROM usuario u
                ORDER BY u.nome";
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox_usuario.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"
                SELECT mf.id_meta, u.nome AS usuario, mf.descricao_meta, mf.valor_meta, mf.data_limite, c.nome_categoria
                FROM metafinanceira mf
                JOIN usuario u ON mf.id_usuario = u.id_usuario
                JOIN categoria c ON mf.id_categoria = c.id_categoria
                ORDER BY mf.data_limite DESC";
                
                using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView_metas.DataSource = dt;
                }
            }
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            if (dataGridView_metas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma meta para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idMeta = Convert.ToInt32(dataGridView_metas.SelectedRows[0].Cells["id_meta"].Value);
            using (var conn = new Npgsql.NpgsqlConnection(connString))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM metafinanceira WHERE id_meta = @id_meta";
                using (var cmd = new Npgsql.NpgsqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("id_meta", idMeta);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Meta financeira removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button_listar.PerformClick();
        }

        private void dataGridView_metas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

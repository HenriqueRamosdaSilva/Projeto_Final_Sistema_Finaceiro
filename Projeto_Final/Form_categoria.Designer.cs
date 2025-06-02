namespace Projeto_Final
{
    partial class Form_categoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_categoria));
            panel_home = new Panel();
            button_minimizar_home = new Button();
            button_minimizar_maximizar_home = new Button();
            label_titulo_home = new Label();
            button_fechar_home = new Button();
            comboBox_tipo_categoria = new ComboBox();
            textBox_nome = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            button_Salvar = new Button();
            label1 = new Label();
            dataGridView_categoria = new DataGridView();
            button_Remover = new Button();
            button_listar = new Button();
            label4 = new Label();
            panel_home.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_categoria).BeginInit();
            SuspendLayout();
            // 
            // panel_home
            // 
            panel_home.BackColor = Color.Black;
            panel_home.Controls.Add(button_minimizar_home);
            panel_home.Controls.Add(button_minimizar_maximizar_home);
            panel_home.Controls.Add(label_titulo_home);
            panel_home.Controls.Add(button_fechar_home);
            panel_home.Dock = DockStyle.Top;
            panel_home.Location = new Point(0, 0);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(800, 71);
            panel_home.TabIndex = 1;
            panel_home.MouseMove += panel1_MouseDown;
            // 
            // button_minimizar_home
            // 
            button_minimizar_home.Cursor = Cursors.Cross;
            button_minimizar_home.Dock = DockStyle.Right;
            button_minimizar_home.FlatAppearance.BorderColor = Color.White;
            button_minimizar_home.FlatAppearance.BorderSize = 0;
            button_minimizar_home.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_minimizar_home.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            button_minimizar_home.FlatStyle = FlatStyle.Flat;
            button_minimizar_home.Image = (Image)resources.GetObject("button_minimizar_home.Image");
            button_minimizar_home.Location = new Point(674, 0);
            button_minimizar_home.Name = "button_minimizar_home";
            button_minimizar_home.Size = new Size(42, 71);
            button_minimizar_home.TabIndex = 3;
            button_minimizar_home.UseVisualStyleBackColor = true;
            button_minimizar_home.Click += button_minimizar_home_Click;
            // 
            // button_minimizar_maximizar_home
            // 
            button_minimizar_maximizar_home.Cursor = Cursors.Cross;
            button_minimizar_maximizar_home.Dock = DockStyle.Right;
            button_minimizar_maximizar_home.FlatAppearance.BorderColor = Color.White;
            button_minimizar_maximizar_home.FlatAppearance.BorderSize = 0;
            button_minimizar_maximizar_home.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_minimizar_maximizar_home.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            button_minimizar_maximizar_home.FlatStyle = FlatStyle.Flat;
            button_minimizar_maximizar_home.Image = (Image)resources.GetObject("button_minimizar_maximizar_home.Image");
            button_minimizar_maximizar_home.Location = new Point(716, 0);
            button_minimizar_maximizar_home.Name = "button_minimizar_maximizar_home";
            button_minimizar_maximizar_home.Size = new Size(42, 71);
            button_minimizar_maximizar_home.TabIndex = 2;
            button_minimizar_maximizar_home.UseVisualStyleBackColor = true;
            button_minimizar_maximizar_home.Click += button_minimizar_maximizar_home_Click;
            // 
            // label_titulo_home
            // 
            label_titulo_home.AutoSize = true;
            label_titulo_home.Font = new Font("Segoe UI", 20F);
            label_titulo_home.ForeColor = SystemColors.ButtonHighlight;
            label_titulo_home.Location = new Point(21, 12);
            label_titulo_home.Name = "label_titulo_home";
            label_titulo_home.Size = new Size(316, 46);
            label_titulo_home.TabIndex = 1;
            label_titulo_home.Text = "Adicionar Categoria";
            // 
            // button_fechar_home
            // 
            button_fechar_home.Cursor = Cursors.Cross;
            button_fechar_home.Dock = DockStyle.Right;
            button_fechar_home.FlatAppearance.BorderColor = Color.White;
            button_fechar_home.FlatAppearance.BorderSize = 0;
            button_fechar_home.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_fechar_home.FlatAppearance.MouseOverBackColor = Color.Red;
            button_fechar_home.FlatStyle = FlatStyle.Flat;
            button_fechar_home.Image = (Image)resources.GetObject("button_fechar_home.Image");
            button_fechar_home.Location = new Point(758, 0);
            button_fechar_home.Name = "button_fechar_home";
            button_fechar_home.Size = new Size(42, 71);
            button_fechar_home.TabIndex = 1;
            button_fechar_home.UseVisualStyleBackColor = true;
            button_fechar_home.Click += button_fechar_home_Click;
            // 
            // comboBox_tipo_categoria
            // 
            comboBox_tipo_categoria.FormattingEnabled = true;
            comboBox_tipo_categoria.Location = new Point(88, 103);
            comboBox_tipo_categoria.Name = "comboBox_tipo_categoria";
            comboBox_tipo_categoria.Size = new Size(194, 28);
            comboBox_tipo_categoria.TabIndex = 3;
            comboBox_tipo_categoria.SelectedIndexChanged += comboBox_tipo_categoria_SelectedIndexChanged;
            // 
            // textBox_nome
            // 
            textBox_nome.Location = new Point(88, 42);
            textBox_nome.Name = "textBox_nome";
            textBox_nome.Size = new Size(194, 27);
            textBox_nome.TabIndex = 4;
            textBox_nome.TextChanged += textBox_nome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 108);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 7;
            label2.Text = "Tipo:";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(button_Salvar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox_tipo_categoria);
            panel1.Controls.Add(textBox_nome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 379);
            panel1.TabIndex = 8;
            // 
            // button_Salvar
            // 
            button_Salvar.FlatAppearance.BorderColor = Color.Black;
            button_Salvar.FlatAppearance.MouseDownBackColor = Color.White;
            button_Salvar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_Salvar.FlatStyle = FlatStyle.Flat;
            button_Salvar.ForeColor = Color.White;
            button_Salvar.Location = new Point(88, 184);
            button_Salvar.Name = "button_Salvar";
            button_Salvar.Size = new Size(194, 42);
            button_Salvar.TabIndex = 9;
            button_Salvar.Text = "Salvar";
            button_Salvar.UseVisualStyleBackColor = true;
            button_Salvar.Click += button_Salvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 8;
            label1.Text = "Nome:";
            // 
            // dataGridView_categoria
            // 
            dataGridView_categoria.BackgroundColor = SystemColors.Control;
            dataGridView_categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_categoria.Location = new Point(354, 153);
            dataGridView_categoria.Name = "dataGridView_categoria";
            dataGridView_categoria.RowHeadersWidth = 51;
            dataGridView_categoria.Size = new Size(404, 184);
            dataGridView_categoria.TabIndex = 30;
            dataGridView_categoria.CellContentClick += dataGridView_categoria_CellContentClick;
            // 
            // button_Remover
            // 
            button_Remover.FlatAppearance.BorderColor = Color.Black;
            button_Remover.FlatAppearance.MouseDownBackColor = Color.White;
            button_Remover.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_Remover.FlatStyle = FlatStyle.Flat;
            button_Remover.Location = new Point(556, 360);
            button_Remover.Name = "button_Remover";
            button_Remover.Size = new Size(202, 42);
            button_Remover.TabIndex = 29;
            button_Remover.Text = "Remover";
            button_Remover.UseVisualStyleBackColor = true;
            button_Remover.Click += button_Remover_Click;
            // 
            // button_listar
            // 
            button_listar.FlatAppearance.BorderColor = Color.Black;
            button_listar.FlatAppearance.MouseDownBackColor = Color.White;
            button_listar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_listar.FlatStyle = FlatStyle.Flat;
            button_listar.Location = new Point(354, 360);
            button_listar.Name = "button_listar";
            button_listar.Size = new Size(202, 42);
            button_listar.TabIndex = 28;
            button_listar.Text = "Listar";
            button_listar.UseVisualStyleBackColor = true;
            button_listar.Click += button_listar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(492, 104);
            label4.Name = "label4";
            label4.Size = new Size(133, 35);
            label4.TabIndex = 27;
            label4.Text = "Categorias";
            // 
            // Form_categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_categoria);
            Controls.Add(button_Remover);
            Controls.Add(button_listar);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_categoria";
            Load += Form_categoria_Load;
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_categoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_home;
        private Button button_minimizar_home;
        private Button button_minimizar_maximizar_home;
        private Label label_titulo_home;
        private Button button_fechar_home;
        private ComboBox comboBox_tipo_categoria;
        private TextBox textBox_nome;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button button_Salvar;
        private DataGridView dataGridView_categoria;
        private Button button_Remover;
        private Button button_listar;
        private Label label4;
    }
}
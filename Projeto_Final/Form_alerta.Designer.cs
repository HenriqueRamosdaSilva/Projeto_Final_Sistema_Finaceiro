namespace Projeto_Final
{
    partial class Form_alerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_alerta));
            panel_home = new Panel();
            button_minimizar_home = new Button();
            button_minimizar_maximizar_home = new Button();
            label_titulo_home = new Label();
            button_fechar_home = new Button();
            panel1 = new Panel();
            dataGridView_alertas = new DataGridView();
            comboBox_categoria = new ComboBox();
            label2 = new Label();
            button_salvar = new Button();
            textBox_descricao = new TextBox();
            label1 = new Label();
            textBox_valor_limite = new TextBox();
            label3 = new Label();
            label5 = new Label();
            comboBox_usuario = new ComboBox();
            label4 = new Label();
            button_listar = new Button();
            button_Remover = new Button();
            panel_home.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_alertas).BeginInit();
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
            panel_home.Size = new Size(904, 71);
            panel_home.TabIndex = 2;
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
            button_minimizar_home.Location = new Point(778, 0);
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
            button_minimizar_maximizar_home.Location = new Point(820, 0);
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
            label_titulo_home.Size = new Size(109, 46);
            label_titulo_home.TabIndex = 1;
            label_titulo_home.Text = "Alerta";
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
            button_fechar_home.Location = new Point(862, 0);
            button_fechar_home.Name = "button_fechar_home";
            button_fechar_home.Size = new Size(42, 71);
            button_fechar_home.TabIndex = 1;
            button_fechar_home.UseVisualStyleBackColor = true;
            button_fechar_home.Click += button_fechar_home_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(comboBox_categoria);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_salvar);
            panel1.Controls.Add(textBox_descricao);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_valor_limite);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_usuario);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 379);
            panel1.TabIndex = 19;
            // 
            // dataGridView_alertas
            // 
            dataGridView_alertas.BackgroundColor = SystemColors.Control;
            dataGridView_alertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_alertas.Location = new Point(478, 144);
            dataGridView_alertas.Name = "dataGridView_alertas";
            dataGridView_alertas.RowHeadersWidth = 51;
            dataGridView_alertas.Size = new Size(404, 184);
            dataGridView_alertas.TabIndex = 26;
            dataGridView_alertas.CellContentClick += dataGridView_alertas_CellContentClick;
            // 
            // comboBox_categoria
            // 
            comboBox_categoria.FormattingEnabled = true;
            comboBox_categoria.Location = new Point(117, 100);
            comboBox_categoria.Name = "comboBox_categoria";
            comboBox_categoria.Size = new Size(309, 28);
            comboBox_categoria.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 6;
            label2.Text = "Usuário:";
            // 
            // button_salvar
            // 
            button_salvar.FlatAppearance.BorderColor = Color.Black;
            button_salvar.FlatAppearance.MouseDownBackColor = Color.White;
            button_salvar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_salvar.FlatStyle = FlatStyle.Flat;
            button_salvar.Location = new Point(132, 303);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(157, 42);
            button_salvar.TabIndex = 3;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // textBox_descricao
            // 
            textBox_descricao.Location = new Point(117, 144);
            textBox_descricao.Multiline = true;
            textBox_descricao.Name = "textBox_descricao";
            textBox_descricao.Size = new Size(309, 113);
            textBox_descricao.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 7;
            label1.Text = "Valor Limite:";
            // 
            // textBox_valor_limite
            // 
            textBox_valor_limite.Location = new Point(117, 60);
            textBox_valor_limite.Name = "textBox_valor_limite";
            textBox_valor_limite.Size = new Size(309, 27);
            textBox_valor_limite.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 10;
            label3.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 13;
            label5.Text = "Categoria:";
            // 
            // comboBox_usuario
            // 
            comboBox_usuario.FormattingEnabled = true;
            comboBox_usuario.Location = new Point(117, 17);
            comboBox_usuario.Name = "comboBox_usuario";
            comboBox_usuario.Size = new Size(309, 28);
            comboBox_usuario.TabIndex = 2;
            comboBox_usuario.SelectedIndexChanged += comboBox_usuario_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(628, 106);
            label4.Name = "label4";
            label4.Size = new Size(91, 35);
            label4.TabIndex = 22;
            label4.Text = "Alertas";
            label4.Click += label4_Click;
            // 
            // button_listar
            // 
            button_listar.FlatAppearance.BorderColor = Color.Black;
            button_listar.FlatAppearance.MouseDownBackColor = Color.White;
            button_listar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_listar.FlatStyle = FlatStyle.Flat;
            button_listar.Location = new Point(478, 351);
            button_listar.Name = "button_listar";
            button_listar.Size = new Size(202, 42);
            button_listar.TabIndex = 24;
            button_listar.Text = "Listar";
            button_listar.UseVisualStyleBackColor = true;
            button_listar.Click += button_listar_Click;
            // 
            // button_Remover
            // 
            button_Remover.FlatAppearance.BorderColor = Color.Black;
            button_Remover.FlatAppearance.MouseDownBackColor = Color.White;
            button_Remover.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_Remover.FlatStyle = FlatStyle.Flat;
            button_Remover.Location = new Point(680, 351);
            button_Remover.Name = "button_Remover";
            button_Remover.Size = new Size(202, 42);
            button_Remover.TabIndex = 25;
            button_Remover.Text = "Remover";
            button_Remover.UseVisualStyleBackColor = true;
            button_Remover.Click += button_Remover_Click;
            // 
            // Form_alerta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(dataGridView_alertas);
            Controls.Add(button_Remover);
            Controls.Add(button_listar);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(panel_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_alerta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_alerta";
            Load += Form_alerta_Load;
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_alertas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_home;
        private Button button_minimizar_home;
        private Button button_minimizar_maximizar_home;
        private Label label_titulo_home;
        private Button button_fechar_home;
        private Panel panel1;
        private ComboBox comboBox_categoria;
        private Label label2;
        private Button button_salvar;
        private TextBox textBox_descricao;
        private Label label1;
        private TextBox textBox_valor_limite;
        private Label label3;
        private Label label5;
        private ComboBox comboBox_usuario;
        private Label label4;
        private Button button_listar;
        private Button button_Remover;
        private DataGridView dataGridView_alertas;
    }
}
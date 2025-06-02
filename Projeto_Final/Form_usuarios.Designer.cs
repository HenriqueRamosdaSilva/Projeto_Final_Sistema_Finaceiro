namespace Projeto_Final
{
    partial class Form_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_usuarios));
            panel_home = new Panel();
            button_minimizar_Usuarios = new Button();
            button_minimizar_maximizar_Usuarios = new Button();
            label_titulo_home = new Label();
            button_fechar_Usuarios = new Button();
            textBox_nome_usuarios = new TextBox();
            textBox_email_usuarios = new TextBox();
            button_salvar = new Button();
            button_Listar = new Button();
            button_remover = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel_home.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_home
            // 
            panel_home.BackColor = Color.Black;
            panel_home.Controls.Add(button_minimizar_Usuarios);
            panel_home.Controls.Add(button_minimizar_maximizar_Usuarios);
            panel_home.Controls.Add(label_titulo_home);
            panel_home.Controls.Add(button_fechar_Usuarios);
            panel_home.Dock = DockStyle.Top;
            panel_home.Location = new Point(0, 0);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(800, 71);
            panel_home.TabIndex = 1;
            panel_home.MouseMove += panel1_MouseDown;
            // 
            // button_minimizar_Usuarios
            // 
            button_minimizar_Usuarios.Cursor = Cursors.Cross;
            button_minimizar_Usuarios.Dock = DockStyle.Right;
            button_minimizar_Usuarios.FlatAppearance.BorderColor = Color.White;
            button_minimizar_Usuarios.FlatAppearance.BorderSize = 0;
            button_minimizar_Usuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_minimizar_Usuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            button_minimizar_Usuarios.FlatStyle = FlatStyle.Flat;
            button_minimizar_Usuarios.Image = (Image)resources.GetObject("button_minimizar_Usuarios.Image");
            button_minimizar_Usuarios.Location = new Point(674, 0);
            button_minimizar_Usuarios.Name = "button_minimizar_Usuarios";
            button_minimizar_Usuarios.Size = new Size(42, 71);
            button_minimizar_Usuarios.TabIndex = 3;
            button_minimizar_Usuarios.UseVisualStyleBackColor = true;
            button_minimizar_Usuarios.Click += button_minimizar_Usuarios_Click;
            // 
            // button_minimizar_maximizar_Usuarios
            // 
            button_minimizar_maximizar_Usuarios.Cursor = Cursors.Cross;
            button_minimizar_maximizar_Usuarios.Dock = DockStyle.Right;
            button_minimizar_maximizar_Usuarios.FlatAppearance.BorderColor = Color.White;
            button_minimizar_maximizar_Usuarios.FlatAppearance.BorderSize = 0;
            button_minimizar_maximizar_Usuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_minimizar_maximizar_Usuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            button_minimizar_maximizar_Usuarios.FlatStyle = FlatStyle.Flat;
            button_minimizar_maximizar_Usuarios.Image = (Image)resources.GetObject("button_minimizar_maximizar_Usuarios.Image");
            button_minimizar_maximizar_Usuarios.Location = new Point(716, 0);
            button_minimizar_maximizar_Usuarios.Name = "button_minimizar_maximizar_Usuarios";
            button_minimizar_maximizar_Usuarios.Size = new Size(42, 71);
            button_minimizar_maximizar_Usuarios.TabIndex = 2;
            button_minimizar_maximizar_Usuarios.UseVisualStyleBackColor = true;
            button_minimizar_maximizar_Usuarios.Click += button_minimizar_maximizar_Usuarios_Click;
            // 
            // label_titulo_home
            // 
            label_titulo_home.AutoSize = true;
            label_titulo_home.Font = new Font("Segoe UI", 20F);
            label_titulo_home.ForeColor = SystemColors.ButtonHighlight;
            label_titulo_home.Location = new Point(3, 9);
            label_titulo_home.Name = "label_titulo_home";
            label_titulo_home.Size = new Size(147, 46);
            label_titulo_home.TabIndex = 1;
            label_titulo_home.Text = "Usuarios";
            // 
            // button_fechar_Usuarios
            // 
            button_fechar_Usuarios.Cursor = Cursors.Cross;
            button_fechar_Usuarios.Dock = DockStyle.Right;
            button_fechar_Usuarios.FlatAppearance.BorderColor = Color.White;
            button_fechar_Usuarios.FlatAppearance.BorderSize = 0;
            button_fechar_Usuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_fechar_Usuarios.FlatAppearance.MouseOverBackColor = Color.Red;
            button_fechar_Usuarios.FlatStyle = FlatStyle.Flat;
            button_fechar_Usuarios.Image = (Image)resources.GetObject("button_fechar_Usuarios.Image");
            button_fechar_Usuarios.Location = new Point(758, 0);
            button_fechar_Usuarios.Name = "button_fechar_Usuarios";
            button_fechar_Usuarios.Size = new Size(42, 71);
            button_fechar_Usuarios.TabIndex = 1;
            button_fechar_Usuarios.UseVisualStyleBackColor = true;
            button_fechar_Usuarios.Click += button_fechar_Usuarios_Click;
            // 
            // textBox_nome_usuarios
            // 
            textBox_nome_usuarios.Location = new Point(64, 71);
            textBox_nome_usuarios.Name = "textBox_nome_usuarios";
            textBox_nome_usuarios.Size = new Size(246, 27);
            textBox_nome_usuarios.TabIndex = 2;
            // 
            // textBox_email_usuarios
            // 
            textBox_email_usuarios.Location = new Point(64, 119);
            textBox_email_usuarios.Name = "textBox_email_usuarios";
            textBox_email_usuarios.Size = new Size(246, 27);
            textBox_email_usuarios.TabIndex = 3;
            // 
            // button_salvar
            // 
            button_salvar.FlatAppearance.BorderColor = Color.Black;
            button_salvar.FlatAppearance.MouseDownBackColor = Color.White;
            button_salvar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_salvar.FlatStyle = FlatStyle.Flat;
            button_salvar.Location = new Point(617, 71);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(131, 42);
            button_salvar.TabIndex = 4;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // button_Listar
            // 
            button_Listar.FlatAppearance.BorderColor = Color.Black;
            button_Listar.FlatAppearance.MouseDownBackColor = Color.White;
            button_Listar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_Listar.FlatStyle = FlatStyle.Flat;
            button_Listar.Location = new Point(617, 289);
            button_Listar.Name = "button_Listar";
            button_Listar.Size = new Size(131, 42);
            button_Listar.TabIndex = 6;
            button_Listar.Text = "LIstar";
            button_Listar.UseVisualStyleBackColor = true;
            button_Listar.Click += button_Listar_Click;
            // 
            // button_remover
            // 
            button_remover.FlatAppearance.BorderColor = Color.Black;
            button_remover.FlatAppearance.MouseDownBackColor = Color.White;
            button_remover.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_remover.FlatStyle = FlatStyle.Flat;
            button_remover.Location = new Point(617, 360);
            button_remover.Name = "button_remover";
            button_remover.Size = new Size(131, 42);
            button_remover.TabIndex = 7;
            button_remover.Text = "Remover";
            button_remover.UseVisualStyleBackColor = true;
            button_remover.Click += button_remover_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_nome_usuarios);
            panel1.Controls.Add(textBox_email_usuarios);
            panel1.Controls.Add(button_salvar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 166);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(117, 14);
            label3.Name = "label3";
            label3.Size = new Size(121, 35);
            label3.TabIndex = 6;
            label3.Text = "Cadastrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 122);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 71);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(248, 240);
            label4.Name = "label4";
            label4.Size = new Size(74, 35);
            label4.TabIndex = 9;
            label4.Text = "Listar";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(568, 158);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form_usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(button_remover);
            Controls.Add(button_Listar);
            Controls.Add(panel_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_usuarios";
            Load += Form_usuarios_Load;
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_home;
        private Button button_minimizar_Usuarios;
        private Button button_minimizar_maximizar_Usuarios;
        private Label label_titulo_home;
        private Button button_fechar_Usuarios;
        private TextBox textBox_nome_usuarios;
        private TextBox textBox_email_usuarios;
        private Button button_salvar;
        private Button button_Listar;
        private Button button_remover;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
namespace Projeto_Final
{
    partial class pag_home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pag_home));
            panel_home = new Panel();
            button_minimizar_home = new Button();
            button_minimizar_maximizar_home = new Button();
            label_titulo_home = new Label();
            button_fechar_home = new Button();
            panel_lateral_home = new Panel();
            button1 = new Button();
            button_alerta = new Button();
            button_categoria = new Button();
            button_logtransacao = new Button();
            button_metafinanceira = new Button();
            button_transação = new Button();
            button_conta_home = new Button();
            button_home_usuarios = new Button();
            panel_home.SuspendLayout();
            panel_lateral_home.SuspendLayout();
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
            panel_home.Size = new Size(968, 71);
            panel_home.TabIndex = 0;
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
            button_minimizar_home.Location = new Point(842, 0);
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
            button_minimizar_maximizar_home.Location = new Point(884, 0);
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
            label_titulo_home.Size = new Size(319, 46);
            label_titulo_home.TabIndex = 1;
            label_titulo_home.Text = "Sistema de Finanças";
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
            button_fechar_home.Location = new Point(926, 0);
            button_fechar_home.Name = "button_fechar_home";
            button_fechar_home.Size = new Size(42, 71);
            button_fechar_home.TabIndex = 1;
            button_fechar_home.UseVisualStyleBackColor = true;
            button_fechar_home.Click += button_fechar_home_Click;
            // 
            // panel_lateral_home
            // 
            panel_lateral_home.BackColor = Color.FromArgb(45, 45, 48);
            panel_lateral_home.Controls.Add(button1);
            panel_lateral_home.Controls.Add(button_alerta);
            panel_lateral_home.Controls.Add(button_categoria);
            panel_lateral_home.Controls.Add(button_logtransacao);
            panel_lateral_home.Controls.Add(button_metafinanceira);
            panel_lateral_home.Controls.Add(button_transação);
            panel_lateral_home.Controls.Add(button_conta_home);
            panel_lateral_home.Controls.Add(button_home_usuarios);
            panel_lateral_home.Dock = DockStyle.Left;
            panel_lateral_home.Location = new Point(0, 71);
            panel_lateral_home.Name = "panel_lateral_home";
            panel_lateral_home.Size = new Size(253, 485);
            panel_lateral_home.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Cursor = Cursors.Cross;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 439);
            button1.Name = "button1";
            button1.Size = new Size(253, 46);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_alerta
            // 
            button_alerta.FlatAppearance.BorderColor = Color.White;
            button_alerta.FlatAppearance.BorderSize = 0;
            button_alerta.FlatAppearance.MouseDownBackColor = Color.White;
            button_alerta.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_alerta.FlatStyle = FlatStyle.Flat;
            button_alerta.ForeColor = Color.White;
            button_alerta.Image = (Image)resources.GetObject("button_alerta.Image");
            button_alerta.ImageAlign = ContentAlignment.MiddleLeft;
            button_alerta.Location = new Point(21, 261);
            button_alerta.Name = "button_alerta";
            button_alerta.Size = new Size(229, 45);
            button_alerta.TabIndex = 8;
            button_alerta.Text = "Alerta";
            button_alerta.UseVisualStyleBackColor = true;
            button_alerta.Click += button_alerta_Click;
            // 
            // button_categoria
            // 
            button_categoria.FlatAppearance.BorderColor = Color.White;
            button_categoria.FlatAppearance.BorderSize = 0;
            button_categoria.FlatAppearance.MouseDownBackColor = Color.White;
            button_categoria.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_categoria.FlatStyle = FlatStyle.Flat;
            button_categoria.ForeColor = Color.White;
            button_categoria.Image = (Image)resources.GetObject("button_categoria.Image");
            button_categoria.ImageAlign = ContentAlignment.MiddleLeft;
            button_categoria.Location = new Point(21, 159);
            button_categoria.Name = "button_categoria";
            button_categoria.Size = new Size(229, 45);
            button_categoria.TabIndex = 7;
            button_categoria.Text = "Adicionar Categoria";
            button_categoria.UseVisualStyleBackColor = true;
            button_categoria.Click += button_categoria_Click;
            // 
            // button_logtransacao
            // 
            button_logtransacao.FlatAppearance.BorderColor = Color.White;
            button_logtransacao.FlatAppearance.BorderSize = 0;
            button_logtransacao.FlatAppearance.MouseDownBackColor = Color.White;
            button_logtransacao.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_logtransacao.FlatStyle = FlatStyle.Flat;
            button_logtransacao.ForeColor = Color.White;
            button_logtransacao.Image = (Image)resources.GetObject("button_logtransacao.Image");
            button_logtransacao.ImageAlign = ContentAlignment.MiddleLeft;
            button_logtransacao.Location = new Point(21, 312);
            button_logtransacao.Name = "button_logtransacao";
            button_logtransacao.Size = new Size(229, 45);
            button_logtransacao.TabIndex = 6;
            button_logtransacao.Text = "LogTransacao";
            button_logtransacao.UseVisualStyleBackColor = true;
            button_logtransacao.Click += button_logtransacao_Click;
            // 
            // button_metafinanceira
            // 
            button_metafinanceira.FlatAppearance.BorderColor = Color.White;
            button_metafinanceira.FlatAppearance.BorderSize = 0;
            button_metafinanceira.FlatAppearance.MouseDownBackColor = Color.White;
            button_metafinanceira.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_metafinanceira.FlatStyle = FlatStyle.Flat;
            button_metafinanceira.ForeColor = Color.White;
            button_metafinanceira.Image = (Image)resources.GetObject("button_metafinanceira.Image");
            button_metafinanceira.ImageAlign = ContentAlignment.MiddleLeft;
            button_metafinanceira.Location = new Point(21, 210);
            button_metafinanceira.Name = "button_metafinanceira";
            button_metafinanceira.Size = new Size(229, 45);
            button_metafinanceira.TabIndex = 5;
            button_metafinanceira.Text = "MetaFinanceira";
            button_metafinanceira.UseVisualStyleBackColor = true;
            button_metafinanceira.Click += button_metafinanceira_Click;
            // 
            // button_transação
            // 
            button_transação.FlatAppearance.BorderColor = Color.White;
            button_transação.FlatAppearance.BorderSize = 0;
            button_transação.FlatAppearance.MouseDownBackColor = Color.White;
            button_transação.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_transação.FlatStyle = FlatStyle.Flat;
            button_transação.ForeColor = Color.White;
            button_transação.Image = (Image)resources.GetObject("button_transação.Image");
            button_transação.ImageAlign = ContentAlignment.MiddleLeft;
            button_transação.Location = new Point(21, 108);
            button_transação.Name = "button_transação";
            button_transação.Size = new Size(229, 45);
            button_transação.TabIndex = 4;
            button_transação.Text = "Transação";
            button_transação.UseVisualStyleBackColor = true;
            button_transação.Click += button_transação_Click;
            // 
            // button_conta_home
            // 
            button_conta_home.FlatAppearance.BorderColor = Color.White;
            button_conta_home.FlatAppearance.BorderSize = 0;
            button_conta_home.FlatAppearance.MouseDownBackColor = Color.White;
            button_conta_home.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_conta_home.FlatStyle = FlatStyle.Flat;
            button_conta_home.ForeColor = Color.White;
            button_conta_home.Image = (Image)resources.GetObject("button_conta_home.Image");
            button_conta_home.ImageAlign = ContentAlignment.MiddleLeft;
            button_conta_home.Location = new Point(21, 57);
            button_conta_home.Name = "button_conta_home";
            button_conta_home.Size = new Size(229, 45);
            button_conta_home.TabIndex = 3;
            button_conta_home.Text = "Abrir Conta";
            button_conta_home.UseVisualStyleBackColor = true;
            button_conta_home.Click += button_conta_home_Click;
            // 
            // button_home_usuarios
            // 
            button_home_usuarios.FlatAppearance.BorderColor = Color.White;
            button_home_usuarios.FlatAppearance.BorderSize = 0;
            button_home_usuarios.FlatAppearance.MouseDownBackColor = Color.White;
            button_home_usuarios.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_home_usuarios.FlatStyle = FlatStyle.Flat;
            button_home_usuarios.ForeColor = Color.White;
            button_home_usuarios.Image = (Image)resources.GetObject("button_home_usuarios.Image");
            button_home_usuarios.ImageAlign = ContentAlignment.MiddleLeft;
            button_home_usuarios.Location = new Point(21, 6);
            button_home_usuarios.Name = "button_home_usuarios";
            button_home_usuarios.Size = new Size(229, 46);
            button_home_usuarios.TabIndex = 2;
            button_home_usuarios.Text = "Usuarios";
            button_home_usuarios.UseVisualStyleBackColor = true;
            button_home_usuarios.Click += button_home_usuarios_Click;
            // 
            // pag_home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 556);
            Controls.Add(panel_lateral_home);
            Controls.Add(panel_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pag_home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += pag_home_Load;
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            panel_lateral_home.ResumeLayout(false);
            panel_lateral_home.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_home;
        private Button button_fechar_home;
        private Label label_titulo_home;
        private Panel panel_lateral_home;
        private Button button_home_usuarios;
        private Button button_minimizar_maximizar_home;
        private Button button_minimizar_home;
        private Button button_conta_home;
        private Button button_alerta;
        private Button button_categoria;
        private Button button_logtransacao;
        private Button button_metafinanceira;
        private Button button_transação;
        private Button button1;
    }
}

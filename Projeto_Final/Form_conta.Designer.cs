namespace Projeto_Final
{
    partial class Form_conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_conta));
            panel_home = new Panel();
            button_minimizar = new Button();
            button_minimizar_maximizar = new Button();
            label_titulo_home = new Label();
            button_fechar_ = new Button();
            textBox_tipo_de_conta = new TextBox();
            textBox_instituição_financeira = new TextBox();
            button_salvar = new Button();
            comboBox_usuario = new ComboBox();
            textBox_saldo_inicial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel_home.SuspendLayout();
            SuspendLayout();
            // 
            // panel_home
            // 
            panel_home.BackColor = Color.Black;
            panel_home.Controls.Add(button_minimizar);
            panel_home.Controls.Add(button_minimizar_maximizar);
            panel_home.Controls.Add(label_titulo_home);
            panel_home.Controls.Add(button_fechar_);
            panel_home.Dock = DockStyle.Top;
            panel_home.Location = new Point(0, 0);
            panel_home.Name = "panel_home";
            panel_home.Size = new Size(800, 71);
            panel_home.TabIndex = 2;
            panel_home.MouseMove += panel1_MouseDown;
            // 
            // button_minimizar
            // 
            button_minimizar.Cursor = Cursors.Cross;
            button_minimizar.Dock = DockStyle.Right;
            button_minimizar.FlatAppearance.BorderColor = Color.White;
            button_minimizar.FlatAppearance.BorderSize = 0;
            button_minimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_minimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            button_minimizar.FlatStyle = FlatStyle.Flat;
            button_minimizar.Image = (Image)resources.GetObject("button_minimizar.Image");
            button_minimizar.Location = new Point(674, 0);
            button_minimizar.Name = "button_minimizar";
            button_minimizar.Size = new Size(42, 71);
            button_minimizar.TabIndex = 3;
            button_minimizar.UseVisualStyleBackColor = true;
            button_minimizar.Click += button_minimizar_Click;
            // 
            // button_minimizar_maximizar
            // 
            button_minimizar_maximizar.Cursor = Cursors.Cross;
            button_minimizar_maximizar.Dock = DockStyle.Right;
            button_minimizar_maximizar.FlatAppearance.BorderColor = Color.White;
            button_minimizar_maximizar.FlatAppearance.BorderSize = 0;
            button_minimizar_maximizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_minimizar_maximizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            button_minimizar_maximizar.FlatStyle = FlatStyle.Flat;
            button_minimizar_maximizar.Image = (Image)resources.GetObject("button_minimizar_maximizar.Image");
            button_minimizar_maximizar.Location = new Point(716, 0);
            button_minimizar_maximizar.Name = "button_minimizar_maximizar";
            button_minimizar_maximizar.Size = new Size(42, 71);
            button_minimizar_maximizar.TabIndex = 2;
            button_minimizar_maximizar.UseVisualStyleBackColor = true;
            button_minimizar_maximizar.Click += button_minimizar_maximizar_Click;
            // 
            // label_titulo_home
            // 
            label_titulo_home.AutoSize = true;
            label_titulo_home.Font = new Font("Segoe UI", 20F);
            label_titulo_home.ForeColor = SystemColors.ButtonHighlight;
            label_titulo_home.Location = new Point(3, 9);
            label_titulo_home.Name = "label_titulo_home";
            label_titulo_home.Size = new Size(192, 46);
            label_titulo_home.TabIndex = 1;
            label_titulo_home.Text = "Abrir Conta";
            // 
            // button_fechar_
            // 
            button_fechar_.Cursor = Cursors.Cross;
            button_fechar_.Dock = DockStyle.Right;
            button_fechar_.FlatAppearance.BorderColor = Color.White;
            button_fechar_.FlatAppearance.BorderSize = 0;
            button_fechar_.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button_fechar_.FlatAppearance.MouseOverBackColor = Color.Red;
            button_fechar_.FlatStyle = FlatStyle.Flat;
            button_fechar_.Image = (Image)resources.GetObject("button_fechar_.Image");
            button_fechar_.Location = new Point(758, 0);
            button_fechar_.Name = "button_fechar_";
            button_fechar_.Size = new Size(42, 71);
            button_fechar_.TabIndex = 1;
            button_fechar_.UseVisualStyleBackColor = true;
            button_fechar_.Click += button_fechar__Click;
            // 
            // textBox_tipo_de_conta
            // 
            textBox_tipo_de_conta.Location = new Point(171, 135);
            textBox_tipo_de_conta.Name = "textBox_tipo_de_conta";
            textBox_tipo_de_conta.Size = new Size(293, 27);
            textBox_tipo_de_conta.TabIndex = 3;
            // 
            // textBox_instituição_financeira
            // 
            textBox_instituição_financeira.Location = new Point(236, 174);
            textBox_instituição_financeira.Name = "textBox_instituição_financeira";
            textBox_instituição_financeira.Size = new Size(228, 27);
            textBox_instituição_financeira.TabIndex = 4;
            textBox_instituição_financeira.TextChanged += textBox_instituição_financeira_TextChanged;
            // 
            // button_salvar
            // 
            button_salvar.FlatAppearance.BorderColor = Color.Black;
            button_salvar.FlatAppearance.MouseDownBackColor = Color.White;
            button_salvar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_salvar.FlatStyle = FlatStyle.Flat;
            button_salvar.Location = new Point(323, 267);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(141, 47);
            button_salvar.TabIndex = 5;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // comboBox_usuario
            // 
            comboBox_usuario.FormattingEnabled = true;
            comboBox_usuario.Location = new Point(111, 90);
            comboBox_usuario.Name = "comboBox_usuario";
            comboBox_usuario.Size = new Size(353, 28);
            comboBox_usuario.TabIndex = 7;
            comboBox_usuario.SelectedIndexChanged += comboBox_usuario_SelectedIndexChanged;
            // 
            // textBox_saldo_inicial
            // 
            textBox_saldo_inicial.Location = new Point(153, 213);
            textBox_saldo_inicial.Name = "textBox_saldo_inicial";
            textBox_saldo_inicial.Size = new Size(311, 27);
            textBox_saldo_inicial.TabIndex = 8;
            textBox_saldo_inicial.TextChanged += textBox_saldo_inicial_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 90);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 9;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 173);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 10;
            label2.Text = "Instituição Financeira";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(26, 134);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 11;
            label3.Text = "Tipo de Conta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(26, 212);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 12;
            label4.Text = "Saldo Inicial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(26, 90);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 13;
            label5.Text = "Usuário:";
            // 
            // Form_conta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_saldo_inicial);
            Controls.Add(comboBox_usuario);
            Controls.Add(button_salvar);
            Controls.Add(textBox_instituição_financeira);
            Controls.Add(textBox_tipo_de_conta);
            Controls.Add(panel_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_conta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_conta";
            Load += Form_conta_Load;
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_home;
        private Button button_minimizar;
        private Button button_minimizar_maximizar;
        private Label label_titulo_home;
        private Button button_fechar_;
        private TextBox textBox_tipo_de_conta;
        private TextBox textBox_instituição_financeira;
        private Button button_salvar;
        private ComboBox comboBox_usuario;
        private TextBox textBox_saldo_inicial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
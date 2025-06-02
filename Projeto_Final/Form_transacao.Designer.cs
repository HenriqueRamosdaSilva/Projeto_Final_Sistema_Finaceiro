namespace Projeto_Final
{
    partial class Form_transacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_transacao));
            panel_home = new Panel();
            button_minimizar_home = new Button();
            button_minimizar_maximizar_home = new Button();
            label_titulo_home = new Label();
            button_fechar_home = new Button();
            comboBox_tipo_transacao = new ComboBox();
            button_salvar = new Button();
            label2 = new Label();
            textBox_valor = new TextBox();
            textBox_descricao = new TextBox();
            label1 = new Label();
            label3 = new Label();
            comboBox_conta = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox_categoria = new ComboBox();
            dateTimePicker_data = new DateTimePicker();
            label6 = new Label();
            panel1 = new Panel();
            panel_home.SuspendLayout();
            panel1.SuspendLayout();
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
            label_titulo_home.Size = new Size(167, 46);
            label_titulo_home.TabIndex = 1;
            label_titulo_home.Text = "Transação";
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
            // comboBox_tipo_transacao
            // 
            comboBox_tipo_transacao.FormattingEnabled = true;
            comboBox_tipo_transacao.Location = new Point(117, 61);
            comboBox_tipo_transacao.Name = "comboBox_tipo_transacao";
            comboBox_tipo_transacao.Size = new Size(309, 28);
            comboBox_tipo_transacao.TabIndex = 2;
            comboBox_tipo_transacao.SelectedIndexChanged += comboBox_tipo_transacao_SelectedIndexChanged;
            // 
            // button_salvar
            // 
            button_salvar.FlatAppearance.BorderColor = Color.Black;
            button_salvar.FlatAppearance.MouseDownBackColor = Color.White;
            button_salvar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_salvar.FlatStyle = FlatStyle.Flat;
            button_salvar.Location = new Point(269, 318);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(157, 42);
            button_salvar.TabIndex = 3;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 6;
            label2.Text = "Tipo:";
            // 
            // textBox_valor
            // 
            textBox_valor.Location = new Point(117, 105);
            textBox_valor.Name = "textBox_valor";
            textBox_valor.Size = new Size(309, 27);
            textBox_valor.TabIndex = 8;
            textBox_valor.TextChanged += textBox_valor_TextChanged;
            // 
            // textBox_descricao
            // 
            textBox_descricao.Location = new Point(117, 187);
            textBox_descricao.Multiline = true;
            textBox_descricao.Name = "textBox_descricao";
            textBox_descricao.Size = new Size(309, 113);
            textBox_descricao.TabIndex = 9;
            textBox_descricao.TextChanged += textBox_descricao_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 109);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 7;
            label1.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 226);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 10;
            label3.Text = "Descrição:";
            // 
            // comboBox_conta
            // 
            comboBox_conta.FormattingEnabled = true;
            comboBox_conta.Location = new Point(117, 14);
            comboBox_conta.Name = "comboBox_conta";
            comboBox_conta.Size = new Size(309, 28);
            comboBox_conta.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 19);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 12;
            label4.Text = "Conta:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 163);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 13;
            label5.Text = "Categoria:";
            label5.Click += label5_Click;
            // 
            // comboBox_categoria
            // 
            comboBox_categoria.FormattingEnabled = true;
            comboBox_categoria.Location = new Point(117, 153);
            comboBox_categoria.Name = "comboBox_categoria";
            comboBox_categoria.Size = new Size(309, 28);
            comboBox_categoria.TabIndex = 14;
            comboBox_categoria.SelectedIndexChanged += comboBox_categoria_SelectedIndexChanged;
            // 
            // dateTimePicker_data
            // 
            dateTimePicker_data.Format = DateTimePickerFormat.Short;
            dateTimePicker_data.Location = new Point(117, 323);
            dateTimePicker_data.Name = "dateTimePicker_data";
            dateTimePicker_data.Size = new Size(128, 27);
            dateTimePicker_data.TabIndex = 15;
            dateTimePicker_data.Value = new DateTime(2025, 6, 2, 14, 24, 33, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 327);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 16;
            label6.Text = "Data:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 48);
            panel1.Controls.Add(comboBox_categoria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker_data);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox_conta);
            panel1.Controls.Add(textBox_descricao);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_valor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button_salvar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_tipo_transacao);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 379);
            panel1.TabIndex = 17;
            // 
            // Form_transacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_transacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_transacao";
            Load += Form_transacoes_Load;
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_home;
        private Button button_minimizar_home;
        private Button button_minimizar_maximizar_home;
        private Label label_titulo_home;
        private Button button_fechar_home;
        private ComboBox comboBox_tipo_transacao;
        private Button button_salvar;
        private Label label2;
        private TextBox textBox_valor;
        private TextBox textBox_descricao;
        private Label label1;
        private Label label3;
        private ComboBox comboBox_conta;
        private Label label4;
        private Label label5;
        private ComboBox comboBox_categoria;
        private DateTimePicker dateTimePicker_data;
        private Label label6;
        private Panel panel1;
    }
}
namespace Projeto_Final
{
    partial class Form_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log));
            panel_home = new Panel();
            button_minimizar_home = new Button();
            button_minimizar_maximizar_home = new Button();
            label_titulo_home = new Label();
            button_fechar_home = new Button();
            dataGridView_logs = new DataGridView();
            button_listar = new Button();
            panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_logs).BeginInit();
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
            panel_home.TabIndex = 3;
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
            label_titulo_home.Size = new Size(223, 46);
            label_titulo_home.TabIndex = 1;
            label_titulo_home.Text = "LogTransacao";
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
            // dataGridView_logs
            // 
            dataGridView_logs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_logs.Location = new Point(21, 98);
            dataGridView_logs.Name = "dataGridView_logs";
            dataGridView_logs.RowHeadersWidth = 51;
            dataGridView_logs.Size = new Size(579, 295);
            dataGridView_logs.TabIndex = 4;
            // 
            // button_listar
            // 
            button_listar.FlatAppearance.BorderColor = Color.Black;
            button_listar.FlatAppearance.MouseDownBackColor = Color.White;
            button_listar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button_listar.FlatStyle = FlatStyle.Flat;
            button_listar.Location = new Point(623, 98);
            button_listar.Name = "button_listar";
            button_listar.Size = new Size(165, 42);
            button_listar.TabIndex = 25;
            button_listar.Text = "Listar";
            button_listar.UseVisualStyleBackColor = true;
            button_listar.Click += button_listar_Click;
            // 
            // Form_log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_listar);
            Controls.Add(dataGridView_logs);
            Controls.Add(panel_home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_log";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_log";
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_logs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_home;
        private Button button_minimizar_home;
        private Button button_minimizar_maximizar_home;
        private Label label_titulo_home;
        private Button button_fechar_home;
        private DataGridView dataGridView_logs;
        private Button button_listar;
    }
}
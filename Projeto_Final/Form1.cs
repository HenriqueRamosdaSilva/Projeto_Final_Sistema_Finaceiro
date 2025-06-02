using System.Runtime.InteropServices;

namespace Projeto_Final
{
    public partial class pag_home : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public pag_home()
        {
            InitializeComponent();
        }

        private void button_fechar_home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_home_usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form_usuarios>();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pag_home_Load(object sender, EventArgs e)
        {

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

        private void button_conta_home_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form_conta>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_transação_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form_transacao>();
        }

        private void button_categoria_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form_categoria>();
        }

        private void button_metafinanceira_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form_meta_financeira>();
        }

        private void button_alerta_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form_alerta>();
        }

        private void button_logtransacao_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form_log>();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();

        }
    }
}

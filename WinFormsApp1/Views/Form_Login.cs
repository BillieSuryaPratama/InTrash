namespace WinFormsApp1.Views
{
    public partial class Form_Login : Form
    {
        public int LoginSebagai = 0;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Admin nextpage = new Beranda_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            int LoginSebagai = 1;
        }

        private void rbNasabah_CheckedChanged(object sender, EventArgs e)
        {
            int LoginSebagai = 2;
        }

        private void rbKurir_CheckedChanged(object sender, EventArgs e)
        {
            int LoginSebagai = 3;
        }
    }
}

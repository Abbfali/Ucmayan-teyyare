namespace UcmayanTeyyare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKalkis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teyyare kalkdırıldı");
        }

        private void btnInis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teyyare iniş edildi");
        }

        private void btnSola_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teyyare sola keçdi");
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teyyare sağa keçdi");
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teyyare önə keçdi");
        }

        private void btnArxa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teyyare arxa keçdi");
        }
    }
}

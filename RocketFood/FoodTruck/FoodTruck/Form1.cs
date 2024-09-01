namespace FoodTruck
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        //Función del botón cerrar
        private void btnCerrar_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Función del botón minimizar
        private void btnMin_Click_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        bool val = false;

        private void UpBar_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;
        }

        private void UpBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void UpBar_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;
        }
    }
}

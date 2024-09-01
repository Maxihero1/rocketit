    using System;
using System.Windows.Forms;

namespace Rocket Fast Food
{
    public class MainForm : Form
    {
        private Button btnSaludar;

        public MainForm()
        {
            // Configuración de la ventana principal
            this.Text = "Página de Inicio - Windows Forms";
            this.Size = new System.Drawing.Size(400, 300);

            // Creación y configuración del botón
            btnSaludar = new Button();
            btnSaludar.Text = "Haz clic aquí";
            btnSaludar.Size = new System.Drawing.Size(100, 30);
            btnSaludar.Location = new System.Drawing.Point(150, 100);
            btnSaludar.Click += new EventHandler(BtnSaludar_Click);

            // Añadir controles a la ventana
            this.Controls.Add(btnSaludar);
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola! Gracias por usar esta aplicación.");
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

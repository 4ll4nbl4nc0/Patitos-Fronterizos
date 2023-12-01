using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //En esta parte del código se carga el form y se centra el texto de bienvenida por comando, también asegura que el texto se coloque en la altura deseada.
        private void Login_Load(object sender, EventArgs e)
        {
            TextoBienvenida.Left = (this.ClientSize.Width - TextoBienvenida.Width) / 2;
            TextoBienvenida.Top = 20;
        }
        //En esta otra parte se crea una instancia del form LoginEstudiante en la cuál se realiza la validación de datos como estudiante.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginEstudiante loginEstudianteForm = new LoginEstudiante();
            loginEstudianteForm.Show();
            this.Hide();
        }
        //Al igual que la parte pasada, se crea una instancia del form en este caso LoginProfesor en la cuál se realiza la validación de datos como profesor.

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginProfesor loginProfesorForm = new LoginProfesor();
            loginProfesorForm.Show();
            this.Hide();
        }
    }
}
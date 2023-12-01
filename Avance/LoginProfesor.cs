using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avance.Enums;
using Avance.Services;

namespace Avance
{
    public partial class LoginProfesor : Form
    {
        public LoginProfesor()
        {
            InitializeComponent();
        }
        //En la acción que manejará el botón de IngresarProfesor al dar click
        //se incluyen las restricciones necesarias para que los textbox de usuario y contraseña no excedan el límite de dígitos
        private void IngresarProfesor_Click(object sender, EventArgs e)
        {
            var CorreoElectronico = UsuarioProfesor.Text.Trim();
            var Contrasena = ContraseñaProfesor.Text.Trim();

            if (string.IsNullOrEmpty(CorreoElectronico) || string.IsNullOrEmpty(Contrasena))
            {
                MessageBox.Show("Por favor, rellene ambos campos: Usuario y Contraseña.");
                return;
            }
            if (CorreoElectronico.Length > 25)
            {
                MessageBox.Show("El usuario no debe exceder los 25 caracteres.");
                return;
            }

            if (Contrasena.Length > 15)
            {
                MessageBox.Show("La contraseña no debe exceder los 15 caracteres.");
                return;
            }
            //Aquí se realiza la autenticación de los datos ingresados previamente, si son correctos se dirige al form de LandingProfesor
            //Si los datos son incorrectos, se mostrará un mensaje en pantalla que dirá "Usuario y/o contraseña incorrectos.".
            //y se borrarán de los espacios los datos ingresados.
            var authService = new AuthenticationService();
            var profesorID = authService.AuthenticateProfessor(CorreoElectronico, Contrasena);

            if (profesorID.HasValue)
            {
                Landigpage_Profesor landingForm = new Landigpage_Profesor(profesorID.Value); // Aquí pasamos el profesorID al constructor
                this.Hide(); // Opcional: Oculta el formulario de inicio de sesión
                landingForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.");
                UsuarioProfesor.Text = "";
                ContraseñaProfesor.Text = "";
            }
        }
    }
}
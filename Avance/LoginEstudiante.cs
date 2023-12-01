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
    public partial class LoginEstudiante : Form
    {
        public LoginEstudiante()
        {
            InitializeComponent();
        }
        //En la acción que manejará el botón de IngresarEstudiante al dar click
        //se incluyen las restricciones necesarias para que los textbox de usuario y contraseña no excedan el límite de dígitos
        private void IngresarEstudiante_Click(object sender, EventArgs e)
        {
            var correoElectronico = UsuarioEstudiante.Text.Trim();
            var contrasena = ContraseñaEstudiante.Text.Trim();

            AuthenticationService authService = new AuthenticationService();
            var estudianteID = authService.AuthenticateStudent(correoElectronico, contrasena);

            if (estudianteID.HasValue)
            {
                // Obtener los cursos del estudiante
                var cursos = authService.GetCursosDelEstudiante(estudianteID.Value);

                // Crear y mostrar el formulario InterfazInicialEstudiante
                InterfazInicialEstudiante interfazInicial = new InterfazInicialEstudiante(cursos);
                interfazInicial.Show();
                this.Hide(); // Oculta el formulario de inicio de sesión actual
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.");
                UsuarioEstudiante.Text = "";
                ContraseñaEstudiante.Text = "";
                UsuarioEstudiante.Focus();
            }
        }
    }
}
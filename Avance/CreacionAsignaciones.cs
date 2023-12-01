using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance
{
    public partial class CreacionAsignaciones : Form
    {
        public CreacionAsignaciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Titulo = textBox1.Text.Trim();
            string Descripcion = textBox2.Text.Trim();
            string FechaPublicacion = textBox3.Text;
            string FechaCierre = textBox5.Text;
            string Entrega = textBox6.Text;
            string Valor = textBox7.Text;

            // Validar que el nombre del grupo no sea nulo y que tenga una longitud máxima de 10 caracteres.
            if (string.IsNullOrEmpty(Titulo))
            {
                MessageBox.Show("El titulo no puede estar vacío.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Titulo.Length > 60)
            {
                MessageBox.Show("El nombre del grupo no puede tener más de 60 caracteres.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el nombre del grupo no sea nulo y que tenga una longitud máxima de 10 caracteres.
            if (string.IsNullOrEmpty(Descripcion))
            {
                MessageBox.Show("La descripcion no puede estar vacía.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Descripcion.Length > 10)
            {
                MessageBox.Show("La descripcion no puede tener más de 400 caracteres.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=AllanPC;Initial Catalog=Patitos_Fronterizos;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Asignaciones (Titulo, Descripcion, FechaPublicacion, FechaCierre, Entrega, Valor) VALUES (@Titulo, @Descripcion, @FechaPublicacion, @FechaCierre, @Entrega, @Valor)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar parámetros para evitar SQL injection
                        command.Parameters.AddWithValue("@Titulo", Titulo);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@FechaPublicacion", FechaPublicacion);
                        command.Parameters.AddWithValue("@FechaCierre", FechaCierre);
                        command.Parameters.AddWithValue("@Entrega", Entrega);
                        command.Parameters.AddWithValue("@Valor", Valor);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();

                        MessageBox.Show("Datos guardados correctamente en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar datos en la base de datos: " + ex.Message);
                }
            }
            AsigmentsAnalisis asigments = new AsigmentsAnalisis();
            asigments.Show();
            this.Hide();
        }
    }
}

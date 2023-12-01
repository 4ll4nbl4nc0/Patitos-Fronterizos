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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Avance
{
    public partial class DetalleAsigmentAnalisis : Form
    {
        public DetalleAsigmentAnalisis()
        {
            InitializeComponent();
        }
        
        private void DetalleAsigmentAnalisis_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AllanPC;Initial Catalog=Patitos_Fronterizos;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               

                string query = "SELECT * FROM Asignaciones";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string valor = string.Format("{0}",
                                reader["Titulo"]);
                            textBox1.Text = valor;
                            string valor2 = string.Format("{0}",
                                reader["Descripcion"]);
                            textBox2.Text = valor2;
                            string valor3 = string.Format("{0}",
                                reader["FechaPublicacion"]);
                            textBox3.Text = valor3;
                            string valor4 = string.Format("{0}",
                                reader["FechaCierre"]);
                            textBox4.Text = valor4;
                            string valor5 = string.Format("{0}",
                                reader["Entrega"]);
                            textBox5.Text = valor5;
                            string valor6 = string.Format("{0}",
                                reader["Valor"]);
                            textBox6.Text = valor6;
                        }
                        
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Titulo = textBox1.Text;

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el grupo '{Titulo}' y todos sus integrantes?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection("server = ALLANPC; database= Patitos_Fronterizos; integrated security = true;"))
                    {
                        conexion.Open();

                        // Use parameterized query to prevent SQL injection
                        string cadena = "DELETE FROM Asignaciones WHERE Titulo = @Titulo";

                        using (SqlCommand comando = new SqlCommand(cadena, conexion))
                        {
                            // Add parameter to the SqlCommand
                            comando.Parameters.AddWithValue("@Titulo", Titulo);

                            int canti_borrados = comando.ExecuteNonQuery();
                            if (canti_borrados > 0)
                            {
                                MessageBox.Show("El registro fue borrado");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro o no se pudo eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al eliminar la asignacion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            AsigmentsAnalisis As = new AsigmentsAnalisis();
            As.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Titulo = textBox1.Text;

            var confirmResult = MessageBox.Show($"¿Está seguro de que desea modificar la asignación '{Titulo}'?",
                                                "Confirmar Modificación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                        !string.IsNullOrWhiteSpace(textBox2.Text) &&
                        !string.IsNullOrWhiteSpace(textBox3.Text) &&
                        !string.IsNullOrWhiteSpace(textBox4.Text) &&
                        !string.IsNullOrWhiteSpace(textBox5.Text) &&
                        !string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        using (SqlConnection conexion = new SqlConnection("server= ALLANPC; database =  Patitos_Fronterizos; integrated security = true"))
                        {
                            conexion.Open();

                            string cadena = "UPDATE Asignaciones SET Titulo = @Titulo, " +
                                            "Descripcion = @Descripcion, " +
                                            "FechaPublicacion = @FechaPublicacion, " +
                                            "FechaCierre = @FechaCierre, " +
                                            "Entrega = @Entrega, " +
                                            "Valor = @Valor " +
                                            "WHERE Titulo = @TituloParam";

                            using (SqlCommand comando = new SqlCommand(cadena, conexion))
                            {
                                // Add parameters to the SqlCommand
                                comando.Parameters.AddWithValue("@Titulo", textBox1.Text);
                                comando.Parameters.AddWithValue("@Descripcion", textBox2.Text);
                                comando.Parameters.AddWithValue("@FechaPublicacion", textBox3.Text);
                                comando.Parameters.AddWithValue("@FechaCierre", textBox4.Text);
                                comando.Parameters.AddWithValue("@Entrega", textBox5.Text);
                                comando.Parameters.AddWithValue("@Valor", textBox6.Text);
                                comando.Parameters.AddWithValue("@TituloParam", Titulo);

                                int cantidad_modi = comando.ExecuteNonQuery();

                                if (cantidad_modi == 1)
                                {
                                    MessageBox.Show("Se ha modificado la asignación");
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";
                                    textBox6.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el registro para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete todos los campos antes de modificar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al modificar la asignación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}

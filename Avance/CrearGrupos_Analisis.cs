using Avance.Config;
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
using Avance.Models;

namespace Avance
{
    public partial class CrearGrupos_Analisis : Form
    {
        public CrearGrupos_Analisis()
        {
            InitializeComponent();
            PopulateDataGridView();
        }
        private void PopulateDataGridView()
        {
            string query = @"
        SELECT E.EstudianteID, (E.Nombre + ' ' + E.Apellidos) AS NombreCompleto
        FROM EstudiantesAnálisis E
        LEFT JOIN EstudiantesGruposAnálisis EG ON E.EstudianteID = EG.EstudianteID
        WHERE EG.NombreGrupo IS NULL";

            using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridViewEstudiantes.DataSource = dt;
                    dataGridViewEstudiantes.ReadOnly = true; // Esto hace que la DataGridView sea de solo lectura.
                    dataGridViewEstudiantes.AllowUserToAddRows = false; // Esto impide que se agreguen nuevas filas.
                }
            }
        }
        private void dataGridViewEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int estudianteID = Convert.ToInt32(dataGridViewEstudiantes.Rows[e.RowIndex].Cells["EstudianteID"].Value);
                string nombreCompleto = dataGridViewEstudiantes.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                Estudiante estudiante = new Estudiante { EstudianteID = estudianteID, NombreCompleto = nombreCompleto };
                var existingItem = listBoxSeleccionados.Items.Cast<Estudiante>().FirstOrDefault(est => est.EstudianteID == estudiante.EstudianteID);
                if (existingItem != null)
                {
                    listBoxSeleccionados.Items.Remove(existingItem);
                }
                else
                {
                    if (listBoxSeleccionados.Items.Count < 5)
                    {
                        listBoxSeleccionados.Items.Add(estudiante);
                    }
                    else
                    {
                        MessageBox.Show("No puede agregar más de 5 estudiantes a un grupo.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void buttonCrearGrupo_Click(object sender, EventArgs e)
        {
            string nombreGrupo = textBoxNombreGrupo.Text.Trim();

            // Validar que el nombre del grupo no sea nulo y que tenga una longitud máxima de 10 caracteres.
            if (string.IsNullOrEmpty(nombreGrupo))
            {
                MessageBox.Show("El nombre del grupo no puede estar vacío.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nombreGrupo.Length > 10)
            {
                MessageBox.Show("El nombre del grupo no puede tener más de 10 caracteres.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cantidadEstudiantes = listBoxSeleccionados.Items.Count;
            if (cantidadEstudiantes < 3 || cantidadEstudiantes > 5)
            {
                string mensaje = cantidadEstudiantes < 3 ? "Debe seleccionar al menos 3 estudiantes para crear un grupo." : "No puede agregar más de 5 estudiantes a un grupo.";
                MessageBox.Show(mensaje, "Cantidad de Estudiantes Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                con.Open();
                string queryGrupo = "INSERT INTO GruposAnálisis (NombreGrupo) OUTPUT INSERTED.GrupoID VALUES (@NombreGrupo)";
                using (SqlCommand cmdGrupo = new SqlCommand(queryGrupo, con))
                {
                    cmdGrupo.Parameters.AddWithValue("@NombreGrupo", nombreGrupo);
                    int nuevoGrupoID = (int)cmdGrupo.ExecuteScalar();
                    string queryEstudianteGrupo = "INSERT INTO EstudiantesGruposAnálisis (EstudianteID, NombreGrupo, NombreCompleto) VALUES (@EstudianteID, @NombreGrupo, @NombreCompleto)";
                    using (SqlCommand cmdEstudianteGrupo = new SqlCommand(queryEstudianteGrupo, con))
                    {
                        foreach (Estudiante estudiante in listBoxSeleccionados.Items)
                        {
                            cmdEstudianteGrupo.Parameters.Clear();
                            cmdEstudianteGrupo.Parameters.AddWithValue("@EstudianteID", estudiante.EstudianteID);
                            cmdEstudianteGrupo.Parameters.AddWithValue("@NombreGrupo", nombreGrupo);
                            cmdEstudianteGrupo.Parameters.AddWithValue("@NombreCompleto", estudiante.NombreCompleto);
                            cmdEstudianteGrupo.ExecuteNonQuery();
                        }
                    }
                }
            }
            MessageBox.Show("Grupo y estudiantes agregados correctamente.");
            textBoxNombreGrupo.Clear();
            listBoxSeleccionados.Items.Clear();
        }

        private void IrAListaGrupos_Click(object sender, EventArgs e)
        {
            ListaGrupos listaGrupos = new ListaGrupos();
            listaGrupos.Show();
        }
    }
}

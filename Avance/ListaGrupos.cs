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


namespace Avance
{
    public partial class ListaGrupos : Form
    {
        public ListaGrupos()
        {
            InitializeComponent();
            CargarGruposEnListView();
        }
        private void CargarGruposEnListView()
        {
            string query = "SELECT GrupoID, NombreGrupo FROM GruposAnálisis";
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["GrupoID"].ToString());
                                item.SubItems.Add(reader["NombreGrupo"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string nombreGrupo = listView1.SelectedItems[0].SubItems[1].Text;
                ActualizarlistBox1(nombreGrupo);
            }
        }
        private void ActualizarlistBox1(string nombreGrupo)
        {
            listBox1.Items.Clear();

            string query = @"
        SELECT NombreCompleto
        FROM EstudiantesGruposAnálisis
        WHERE NombreGrupo = @NombreGrupo";
            using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NombreGrupo", nombreGrupo);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["NombreCompleto"].ToString());
                        }
                    }
                }
            }
        }
        private void buttonEliminarGrupo_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string nombreGrupo = listView1.SelectedItems[0].SubItems[1].Text;

                var confirmResult = MessageBox.Show($"¿Está seguro de que desea eliminar el grupo '{nombreGrupo}' y todos sus integrantes?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(DatabaseConfig.ConnectionString))
                        {
                            con.Open();
                            string queryEliminarGrupo = "DELETE FROM GruposAnálisis WHERE NombreGrupo = @NombreGrupo";
                            using (SqlCommand cmdEliminarGrupo = new SqlCommand(queryEliminarGrupo, con))
                            {
                                cmdEliminarGrupo.Parameters.AddWithValue("@NombreGrupo", nombreGrupo);
                                int rowsAffected = cmdEliminarGrupo.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("El grupo ha sido eliminado exitosamente.", "Grupo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarGruposEnListView();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró el grupo o no se pudo eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al eliminar el grupo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un grupo para eliminar.", "Grupo No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearGrupos_Analisis Ca = new CrearGrupos_Analisis();
            Ca.Show();
        }
    }
}

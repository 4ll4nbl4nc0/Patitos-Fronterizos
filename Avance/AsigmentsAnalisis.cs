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
    public partial class AsigmentsAnalisis : Form
    {
        public AsigmentsAnalisis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreacionAsignaciones Ca = new CreacionAsignaciones();
            Ca.Show();
        }

        private void AsigmentsAnalisis_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server = ALLANPC; database= Patitos_Fronterizos; integrated security = true;");
            conexion.Open();

            DataTable dt = new DataTable();
            //DataAdapter es un objeto que almacena n numero de DataTables
            SqlDataAdapter adaptador = new SqlDataAdapter("select Titulo from Asignaciones", conexion);
            //LLena el adaptador con la instruccion sql 
            adaptador.Fill(dt);
            //carga el data
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleAsigmentAnalisis Da = new DetalleAsigmentAnalisis();
            Da.Show();
        }
    }
}

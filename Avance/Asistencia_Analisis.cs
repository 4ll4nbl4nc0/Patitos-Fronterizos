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
    public partial class Asistencia_Analisis : Form
    {
        public Asistencia_Analisis()
        {
            InitializeComponent();
        }

        private void Asistencia_Analisis_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server = ALLANPC; database= Patitos_Fronterizos; integrated security = true;");
            conexion.Open();

            DataTable dt = new DataTable();
            //DataAdapter es un objeto que almacena n numero de DataTables
            SqlDataAdapter adaptador = new SqlDataAdapter("select Estudiante_name from Analisis", conexion);
            //LLena el adaptador con la instruccion sql 
            adaptador.Fill(dt);
            //carga el data
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Button>().ToList();

            ((Button)sender).BackColor = Color.Green;

            SqlConnection conexion = new SqlConnection("server = ALLANPC; database= Patitos_Fronterizos; integrated security = true;");
            conexion.Open();

            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Button>().ToList();

            ((Button)sender).BackColor = Color.Yellow;

            SqlConnection conexion = new SqlConnection("server = ALLANPC; database= Patitos_Fronterizos; integrated security = true;");
            conexion.Open();

            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<Button>().ToList();

            ((Button)sender).BackColor = Color.Red;

            SqlConnection conexion = new SqlConnection("server = ALLANPC; database= Patitos_Fronterizos; integrated security = true;");
            conexion.Open();

            conexion.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

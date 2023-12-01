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
    public partial class Analisis : Form
    {
        public Analisis()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Asistencia_Analisis AsisA = new Asistencia_Analisis();
            AsisA.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsigmentsAnalisis As = new AsigmentsAnalisis();
            As.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaGrupos Lc = new ListaGrupos();
            Lc.Show();
        }
    }
}

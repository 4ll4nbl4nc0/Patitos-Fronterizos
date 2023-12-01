using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Avance
{
    public partial class Landigpage_Profesor : Form
    {
        private int _profesorID;
        public Landigpage_Profesor(int profesorID)
        {
            InitializeComponent();
            _profesorID = profesorID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Grupos_Analisis GA = new Grupos_Analisis();
            GA.Show();
        }
    }
}

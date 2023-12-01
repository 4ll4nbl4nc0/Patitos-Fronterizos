using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance
{
    public partial class Grupos_Analisis : Form
    {
        public Grupos_Analisis()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Analisis analisis = new Analisis();
            analisis.Show();
        }

        private void Grupos_Analisis_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 20;
        }
    }
}

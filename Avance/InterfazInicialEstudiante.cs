using Avance.Cursos;
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
    public partial class InterfazInicialEstudiante : Form
    {
        private List<Curso> _cursos;

        public InterfazInicialEstudiante(List<Curso> cursos)
        {
            InitializeComponent();
            _cursos = cursos;
        }

        private void InterfazInicialEstudiante_Load(object sender, EventArgs e)
        {
            TextoBienvenidaEstudiante.Left = (this.ClientSize.Width - TextoBienvenidaEstudiante.Width) / 2;
            TextoBienvenidaEstudiante.Top = 20;
            listViewCursos.View = View.Details;

            listViewCursos.Columns.Add("ID");
            listViewCursos.Columns.Add("Nombre del Curso");

            foreach (var curso in _cursos)
            {
                var item = new ListViewItem(curso.CursoID.ToString());
                item.SubItems.Add(curso.NombreCurso);
                listViewCursos.Items.Add(item);
            }

            listViewCursos.Columns[0].Width = -2;
            listViewCursos.Columns[1].Width = -2;
        }
        private void ListViewCursos_ItemActivate(object sender, EventArgs e)
        {
            if (listViewCursos.SelectedItems.Count > 0)
            {
                MenuInterfaz menuInterfazForm = new MenuInterfaz();
                menuInterfazForm.Show();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance.Models
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        public string NombreCompleto { get; set; }

        public override string ToString()
        {
            return $"{EstudianteID} - {NombreCompleto}";
        }
    }
}

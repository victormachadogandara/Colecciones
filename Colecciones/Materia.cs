using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Materia
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        public Materia()
        {
            Nombre = "sexo";
            Identificador = "123";
        }

        public Materia (string nombre)
            {
            Nombre = nombre;
            }
    }
}

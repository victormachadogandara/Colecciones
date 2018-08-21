using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Sebastian Encinas";
            alumno1.Matricula = "179149";

            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT123558";

            alumno1.Materias.Add(new Materia());
            alumno1.Materias.Add(matematicas);

            alumno1.Materias[0].Nombre = "Historia";
            alumno1.Materias[0].Identificador = "HT96465";

            alumno1.Materias.Add(new Materia());
            alumno1.Materias[2].Nombre = "Español";
            alumno1.Materias[2].Identificador = "ES852";

            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.Clear();

            Console.WriteLine("Alumno 1: " + alumno1.Nombre);
            Console.WriteLine("Numero de materias: " + alumno1.Materias.Count);

            //for (int i = 0; i< alumno.Materias.Count; i++)
            //{
            //    Console.WriteLine("Materia: " + alumno.Materias[i].Nombre);
            //}

            foreach (Materia materia in alumno1.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            alumno1.Materias.Add(new Materia());
            alumno1.Materias.Add(matematicas);

            alumno1.Materias[0].Nombre = "Historia";
            alumno1.Materias[0].Identificador = "HT96465";

            alumno1.Materias.Add(new Materia());
            alumno1.Materias[2].Nombre = "Español";
            alumno1.Materias[2].Identificador = "ES852";

            Console.ReadLine();
        }
    }
}

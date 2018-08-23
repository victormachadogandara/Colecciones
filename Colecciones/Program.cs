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

            Alumno alumno2 = new Alumno();

            alumno2.Nombre = "Pablo Gay";
            alumno2.Matricula = "139028";

            alumno2.Materias.Add(new Materia());
            alumno2.Materias.Add(matematicas);

            alumno2.Materias[0].Nombre = "Programacion";
            alumno2.Materias[0].Identificador = "PR23987";

            alumno2.Materias.Add(new Materia());
            alumno2.Materias[2].Nombre = "Dibujo";
            alumno2.Materias[2].Identificador = "DJ23912";

            Console.WriteLine("Alumno 2: " + alumno2.Nombre);
            Console.WriteLine("Numero de materias: " + alumno2.Materias.Count);

            foreach (Materia materia in alumno2.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Alumno alumno3 = new Alumno();

            alumno3.Nombre = "Andres gay";
            alumno3.Matricula = "179420";

            alumno3.Materias.Add(new Materia());
            alumno3.Materias.Add(matematicas);

            alumno3.Materias[0].Nombre = "Introduccion a diseño y gestion de la moda";
            alumno3.Materias[0].Identificador = "DM23344";

            alumno3.Materias.Add(new Materia());
            alumno3.Materias[2].Nombre = "Foto";
            alumno3.Materias[2].Identificador = "FT12325";

            Console.WriteLine("Alumno 3: " + alumno3.Nombre);
            Console.WriteLine("Numero de materias: " + alumno3.Materias.Count);

            foreach(Materia materia in alumno3.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
            }

            Alumno alumno4 = new Alumno();

            alumno4.Nombre = "Sofia gay";
            alumno4.Materias.Add(new Materia("Ingenieria Industrial"));
            alumno4.Materias.Add(new Materia("Foto"));
            alumno4.Materias.Add(new Materia("Mendez"));
            alumnos.Add(alumno4);

            Console.WriteLine("Numero de materias: " + alumno4.Materias.Count);

            foreach (Materia elemento in alumnos)
            {
                Console.WriteLine("Materia: " + elemento.Nombre);
                foreach(Materia materia in elemento.Materias)
                {

                }
            }

            Console.ReadLine();
        }
    }
}

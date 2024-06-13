using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

       private int idAutomatico()
       {
            int idAlumno;

            if (Program.listaAlumno.Count <= 0)
            {
                idAlumno = 1;
            }
            else
            {
                idAlumno = Program.listaAlumno[Program.listaAlumno.Count - 1].IdAlumno + 1;
            }
            return idAlumno;


       }

        public void aniadirAlumno()
        {

            bool alumnoNuevo = true;
          
                do
                {

                    AlumnoDto alumno = new AlumnoDto();

                    Console.WriteLine("Introduzca el nombre del alumno.");
                    alumno.Nombre = Console.ReadLine();
                    Console.WriteLine("Introduzca el primer apellido del alumno.");
                    alumno.Apellido1 = Console.ReadLine();
                    Console.WriteLine("Introduzca el segundo apellido del alumno.");
                    alumno.Apellido2 = Console.ReadLine();
                    Console.WriteLine("Introduzca el DNI del alumno.");
                    alumno.Dni = Console.ReadLine();
                    Console.WriteLine("Introduzca el teléfono del alumno.");
                    alumno.Telefono = Console.ReadLine();
                    Console.WriteLine("Introduzca el email del alumno.");
                    alumno.Email = Console.ReadLine();
                    Console.WriteLine("Introduzca la dirección del alumno.");
                    alumno.Direccion = Console.ReadLine();

                    alumno.IdAlumno = idAutomatico();

                    Program.listaAlumno.Add(alumno);

                    Console.WriteLine("¿Desea añadir algún alumno más?  (Si/No)");
                    String respuesta = Console.ReadLine();

                    if (respuesta.Equals("No"))
                    {

                        alumnoNuevo = false;

                    }

                } while (alumnoNuevo);   
        }


        public void borrarAlumno()
        {
            bool eliminarAlumno = true;

            do
            {


                foreach (AlumnoDto mostrar in Program.listaAlumno)
                {
                    Console.WriteLine(String.Concat("Nombre:", mostrar.Nombre, "\n", "DNI: ", mostrar.Dni));
                }

                Console.WriteLine("Escriba el DNI del alumno que desea eliminar.");
                string dni = Console.ReadLine();

                foreach (AlumnoDto eliminar in Program.listaAlumno)
                {
                    if (dni.Equals(eliminar.Dni))
                    {
                        Program.listaAlumno.Remove(eliminar);

                    }
                }


                Console.WriteLine("¿Desea eliminar algún alumno más?  (Si/No)");
                String respuesta = Console.ReadLine();

                if (respuesta.Equals("No"))
                {

                    eliminarAlumno = false;

                }

            } while (eliminarAlumno);

        }

        public void modificarAlumno()
        {





        }

    }
}

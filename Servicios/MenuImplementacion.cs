using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenu()
        {
            try
            {


                int mostrarMenu;

                Console.WriteLine("");
                Console.WriteLine("0. Cerrar menú.");
                Console.WriteLine("1. Dar de alta a un alumno.");
                Console.WriteLine("2. Borrar a un alumno.");
                Console.WriteLine("3. Ver el listado de los alumnos por consola.");
                Console.WriteLine("4. Ver el listado de los alumnos por fichero.");
                mostrarMenu = Console.ReadKey(true).KeyChar - ('0');

                return mostrarMenu;

            }
            catch (Exception ex)
            {
                throw;

            }
        }
    }
}

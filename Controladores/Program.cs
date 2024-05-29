using EduRecuperacionC.Dtos;
using EduRecuperacionC.Servicios;
using EduRecuperacionC.Util;

namespace EduRecuperacionC
{

    class Program
    {

        public static string rutaCarpetaLog = "C:\\Users\\csi23-linflez\\source\\repos\\EduRecuperacionC\\Logs\\";
        public static string rutaFicheroLog = String.Concat(rutaCarpetaLog, Utilidades.crearNombreLog());

        public static string ficheroAlumno = "C:\\Users\\csi23-linflez\\source\\repos\\EduRecuperacionC\\FicheroAlumnos\\";
        public static string ficheroAlumnoCompleto = String.Concat(ficheroAlumno, "fichero.txt");

        public static List<AlumnoDto> listaAlumno = new List<AlumnoDto>();
        public static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            int opcionSeleccionada;
            bool cerrarMenu = true;

             do
             {
                opcionSeleccionada = mi.mostrarMenu();

                try
                {
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("");
                            Console.WriteLine("[INFO] Se ha cerrado el menú.");
                            fi.escribirFichero("[INFO] Se ha cerrado el menú.");
                            cerrarMenu = false;
                            break;
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("[INFO] Se dará de alta a un alumno.");
                            fi.escribirFichero("[INFO] Se dará de alta a un alumno.");
                            oi.aniadirAlumno();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("[INFO] Se borrara un alumno.");
                            fi.escribirFichero("[INFO] Se borrara un alumno.");
                            oi.borrarAlumno();
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("[INFO] Se mostrara el listado de los alumnos.");
                            fi.escribirFichero("[INFO] Se mostrara el listado de los alumnos .");
                            foreach (AlumnoDto mostrar in listaAlumno)
                            {
                                Console.WriteLine(mostrar.ToString());

                            }
                            break;
                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine("[INFO] Se mostrara el listado de los alumnos.");
                            fi.crearAlumnoFichero("[INFO] Se mostrara el listado de los alumnos .");
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("[INFO] La opción introducida no existe escoja otra.");
                            break;

                    }

                }
                catch(Exception ex)
                {
                    try
                    {
                        fi.escribirFichero("[INFO] Se ha producido un error vuelva más tarde.");

                    }
                    catch(Exception ex2)
                    {


                    }
                }
               
             }while(cerrarMenu);



        }
    }
}

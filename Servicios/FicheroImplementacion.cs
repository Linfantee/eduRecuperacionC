using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        
        public void escribirFichero(string mensaje)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(Program.rutaFicheroLog, true);
                sw.WriteLine(mensaje);
                

            }catch (Exception ex)
            {
                Console.WriteLine("[INFO] Se ha detectado un error en el fichero estamos solucionándolo, vuelva en 15 min.");

            }finally 
            {

                if (sw != null)
                {
                    sw.Close();
                }
            }

        }

        public void crearAlumnoFichero(string mensaje)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(Program.ficheroAlumnoCompleto, true);
               foreach(AlumnoDto mostrar in Program.listaAlumno)
                {
                    sw.WriteLine(mostrar.ToString(';'));
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("[INFO] Se ha detectado un error en el fichero estamos solucionándolo, vuelva en 15 min.");

            }
            finally
            {
                if(sw != null)
                {
                    sw.Close();
                }
                
            }







        }

    }
}

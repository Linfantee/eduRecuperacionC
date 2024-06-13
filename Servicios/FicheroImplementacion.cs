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
                foreach (AlumnoDto mostrar in Program.listaAlumno)
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
                if (sw != null)
                {
                    sw.Close();
                }

            }

        }
        public void cargaInicial()
        {
            try
            {
                StreamReader sr = new StreamReader(Program.ficheroAlumnoCompleto);
                string linea;

                while((linea = sr.ReadLine()) != null){

                    string[] separado = linea.Split(";");

                    foreach (string separado2 in separado)
                    {
                        string[] campos = separado2.Split(";");
                        Program.listaArray.Add(campos);

                    }

                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[INFO] Se ha detectado un error en el fichero estamos solucionándolo, vuelva en 15 min.");

            }


        }

    }
}

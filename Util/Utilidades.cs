using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Util
{
    internal class Utilidades
    {
        
        public static string crearNombreLog()
        {
            String fechaTotal = "9";
            try
            {
                DateTime fecha = DateTime.Now;

                string fechaConvertida = Convert.ToString(fecha.ToString("ddMMyy"));

                fechaTotal = String.Concat("log- ", fechaConvertida, ".txt");

                
            }catch (Exception ex)
            {
                Console.WriteLine("[INFO] Se ha detectado un error en el fichero estamos solucionándolo, vuelva en 15 min.");
            }
            return fechaTotal;
        }
    }
}

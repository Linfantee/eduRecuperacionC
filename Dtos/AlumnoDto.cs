using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Dtos
{
    internal class AlumnoDto
    {
        int idAlumno;
        string nombre = "aaaaa";
        string apellido1 = "aaaaa";
        string apellido2 = "aaaaa";
        string dni = "aaaaa";
        string telefono = "aaaaa";
        string email = "aaaaa";
        string direccion = "aaaaa";
        DateTime fechaNac = DateTime.Now;

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }


        override
        public string ToString()
        {
            string mostrar = string.Concat(dni, " ", "-", " ", nombre);

            return mostrar;
        }

        public string ToString(char c)
        {
            return string.Concat(dni, c, nombre);


        }

    }
}

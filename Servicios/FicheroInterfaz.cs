﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    internal interface FicheroInterfaz
    {
        public void escribirFichero(string mensaje);

        public void crearAlumnoFichero(string mensaje);

        public void cargaInicial();
    }
}

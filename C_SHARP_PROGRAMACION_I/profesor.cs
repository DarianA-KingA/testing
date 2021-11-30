using System;
using System.Collections.Generic;
using System.Text;

namespace C_SHARP_PROGRAMACION_I
{
    public class profesor
    {
        public string id_profesor;
        public string nombreP;
        public string apellidoP;
        public string carerraP;
        public string HorarioP;

        estudiantes estudiantes = new estudiantes();
        carrera carrera = new carrera();
        aulas aulas = new aulas();
    }
}

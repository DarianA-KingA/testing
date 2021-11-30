using System;
using System.Collections.Generic;
using System.Text;

namespace C_SHARP_PROGRAMACION_I
{
     public class estudiantes
    {
        public string nombreP;
        public string apellidoP;
        public string mmatricula;
        public string carreraE = carrera.id_carrera;
        public string horario;

        aulas aulas = new aulas();
        profesor profesor = new profesor();
        carrera carrera = new carrera();
        public void presentacionE()
        {
            Console.WriteLine($"El nommbre del estudiante es:" + nombreP);
        }
        public void presentacionP()
        {
            Console.WriteLine($"Su profesor es:  {profesor.nombreP}  en el horario {aulas.horarios}" );
        }
    }

}

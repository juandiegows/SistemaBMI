using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Clase
{
    class Usuario
    {
        public int ID { get; set; }
        public  String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Edad { get; set; }
        public String Genero { get; set; }
        public decimal Peso { get; set; }

        public decimal Estatura { get; set; }
        public decimal BMI { get; set; }
        public decimal BMR { get; set; }
        public string Nivel_Actividad { get; set; }

    }
}

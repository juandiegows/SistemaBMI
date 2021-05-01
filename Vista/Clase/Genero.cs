using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Clase
{
    class Genero
    {
        public string Nombre { set; get; }

        public static List<Genero> GetGeneros()
        {
            return new List<Genero> { new Genero { Nombre = "Masculino" }, new Genero{ Nombre = "Femenino"} };
        } 
    }
}

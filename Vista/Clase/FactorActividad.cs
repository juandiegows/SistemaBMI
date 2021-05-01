using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Clase
{
    class FactorActividad
    {
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public double Valor { set; get; }

        public static List<FactorActividad> GetFactorActividads()
        {
            return new List<FactorActividad> {
                new FactorActividad {
                Nombre = "sedentario",
                Descripcion = "Muy poco o no hace ejercicio en su puesto de trabajo",
                Valor = 1.2
                },
                new FactorActividad {
                Nombre = "ligeramente activo",
                Descripcion = "Practica ejercicio o un deporte entre 1 y 3 veces por semana",
                Valor = 1.375
                },
                new FactorActividad {
                Nombre = "moderadamente activo",
                Descripcion = "Ejercicio moderado de 3 a 5 días por semana",
                Valor = 1.55
                },
                 new FactorActividad {
                Nombre = "muy activo",
                Descripcion = "Alto ejercicio 6 a 7 días por semana",
                Valor = 1.725
                },
                 new FactorActividad {
                Nombre = "extremadamente active",
                Descripcion = "Practica ejercicio o deporte diario y tiene un trabajo con alto requerimiento físico. ",
                Valor = 1.9
                }


            };
        }
    }
}

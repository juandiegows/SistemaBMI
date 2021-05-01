using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Clase
{
    class Categoria
    {
        public String Nombre { get; set; }
        public double Minimo { get; set; }
        public double Maximo { get; set; }

        public Image Imagen { get; set; }


        public static List<Categoria> GetCategorias()
        {
            return new List<Categoria> {
                new Categoria { Nombre = "bajo de peso",
                    Maximo = 18.5,
                    Minimo =0,
                    Imagen = global::Vista.Properties.Resources.delgado
                },
                new Categoria { Nombre = "saludable",
                    Maximo = 24.9,
                    Minimo =18.5 ,
                    Imagen = global::Vista.Properties.Resources.saludable
                },
                 new Categoria { Nombre = "sobrepeso",
                    Maximo = 29.9,
                    Minimo =25 ,
                    Imagen = global::Vista.Properties.Resources.sobrepeso
                },
                 new Categoria { Nombre = "obeso",
                    Maximo = 9999,
                    Minimo =30 ,
                    Imagen = global::Vista.Properties.Resources.obeso
                }

            };
        }
    }
}

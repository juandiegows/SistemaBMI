//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vista.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public int ID { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public Nullable<System.DateTime> FECHA_NACIMIENTO { get; set; }
        public string GENERO { get; set; }
        public Nullable<decimal> PESO { get; set; }
        public Nullable<decimal> ESTATURA { get; set; }
        public Nullable<decimal> BMI { get; set; }
        public Nullable<decimal> BMR { get; set; }
        public string NIVEL_DE_ACTIVIDAD { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Clase;
using Vista.Modelo;

namespace Vista
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenarTabla()
        {
            string genero = CGenero.SelectedValue.ToString();
            string categoria = CCategoria.SelectedValue.ToString();
            string nivel = CNivel.SelectedValue.ToString();

            Categoria c = Categoria.GetCategorias().FirstOrDefault(x => x.Nombre == categoria);
            decimal? minimo = 0;
            decimal? maximo = 0;
            if (c != null && c != default(Categoria))
            {
                    minimo = (decimal?)c.Minimo;
                    maximo = (decimal?)c.Maximo;
            }
           
            using (sistemaBMIEntities modelo = new sistemaBMIEntities())
            {

                List<Usuario> usuarios = (from u in modelo.usuario
                                         where (u.GENERO == genero || CGenero.SelectedIndex == 0)
                                         && ((u.BMI >= minimo && u.BMI<=maximo) || CCategoria.SelectedIndex == 0)
                                         && ((u.NIVEL_DE_ACTIVIDAD == nivel) || CNivel.SelectedIndex == 0)
                                          select new Usuario {
                                             Apellido = u.APELLIDOS,
                                             Nombre = u.NOMBRES,
                                             BMI =(decimal) u.BMI,
                                             BMR = (decimal) u.BMR,
                                             Edad = DateTime.Now.Year - u.FECHA_NACIMIENTO.Value.Year,
                                             Estatura = (decimal) u.ESTATURA,
                                             Genero = u.GENERO,
                                             Nivel_Actividad = u.NIVEL_DE_ACTIVIDAD,
                                             ID = u.ID,
                                             Peso = (decimal) u.PESO

                                         }).ToList();
                TablaUsuario.DataSource =usuarios;
            }
             

          
        }
        private void Consulta_Load(object sender, EventArgs e)
        {
            List<Genero> generos = Genero.GetGeneros();
            generos.Insert(0, new Genero { Nombre = "Ambos" });
            CGenero.DataSource = generos;
            CGenero.DisplayMember = "Nombre";
            CGenero.ValueMember = "Nombre";

            List<Categoria> categorias = Categoria.GetCategorias();
            categorias.Insert(0, new Categoria{ Nombre = "Todas" });
            CCategoria.DataSource = categorias;
            CCategoria.DisplayMember = "Nombre";
            CCategoria.ValueMember = "Nombre";

            List<FactorActividad> factorActividads = FactorActividad.GetFactorActividads();
            factorActividads.Insert(0, new FactorActividad { Nombre = "Todas" });
            CNivel.DataSource = factorActividads;
            CNivel.DisplayMember = "Nombre";
            CNivel.ValueMember = "Nombre";
            llenarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}

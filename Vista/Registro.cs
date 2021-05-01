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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GHombre.BackColor = SystemColors.ControlDark;
            GMujer.BackColor = SystemColors.Control;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GMujer.BackColor = SystemColors.ControlDark;
            GHombre.BackColor = SystemColors.Control;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            List<FactorActividad> factorActividads = FactorActividad.GetFactorActividads();
            comboBox1.DataSource = factorActividads;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso = (double)numericUpDown1.Value;
            double altura = (double)numericUpDown2.Value / 100;
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0)
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            if (DateTime.Now.Year - dateTimePicker1.Value.Year == 0)
            {
                MessageBox.Show("Por favor selecione una fecha correcta, no es posible que tenga 0 años");
                return;
            }

            FactorActividad factorActividad = FactorActividad.GetFactorActividads().FirstOrDefault(x=>x.Nombre == comboBox1.SelectedValue.ToString());

            textBox3.Text = factorActividad.Descripcion;

      
            BMI.Value =(decimal) (peso / (altura * altura));
            double bmi =(double) BMI.Value;
            Categoria categoria = Categoria.GetCategorias().FirstOrDefault(x => bmi >= x.Minimo &&  bmi<=x.Maximo);
            if(categoria != null && categoria != default(Categoria))
            {
                pictureBox3.Image = categoria.Imagen;
                lblCategoria.Text = categoria.Nombre;
            }
          
            if (GHombre.BackColor == SystemColors.ControlDark)
            {
                BMR.Value = (decimal)(66 + (13.7 * peso) + (5 * altura) - (6.8 * (DateTime.Now.Year - dateTimePicker1.Value.Year)));
            }
            else
            {
                BMR.Value = (decimal)(655 + (9.6 * peso) + (1.8 * altura) - (4.7 * (DateTime.Now.Year - dateTimePicker1.Value.Year)));
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            using (sistemaBMIEntities modelo = new sistemaBMIEntities())
            {
                modelo.usuario.Add(new usuario {

                    NOMBRES = textBox1.Text,
                    APELLIDOS = textBox2.Text,
                    GENERO = (GHombre.BackColor == SystemColors.ControlDark) ? "Masculino" : "Femenino",
                    BMI = BMI.Value,
                    BMR = BMR.Value,
                    ESTATURA = numericUpDown2.Value,
                    PESO = numericUpDown1.Value,
                    FECHA_NACIMIENTO = dateTimePicker1.Value,
                    NIVEL_DE_ACTIVIDAD = comboBox1.SelectedValue.ToString()

                });

                if (modelo.SaveChanges() > 0)
                {
                    MessageBox.Show("Se ha guardado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha guardado correctamente");
                }
            }
        }
    }
}

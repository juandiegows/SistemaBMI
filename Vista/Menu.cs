using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Registro() { StartPosition = FormStartPosition.CenterScreen }.Show();
            this.Hide();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Consulta() { StartPosition = FormStartPosition.CenterScreen }.Show();
            this.Hide();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Application.OpenForms.Count ==1 && !this.Visible)
            {
                this.Show();
                timer1.Enabled = false;
            }
        }
    }
}

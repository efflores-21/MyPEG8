using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_4
{
    public partial class Ejemplo1 : Form
    {
        public int Porcentaje { get; set; } 

        public Ejemplo1()
        {
            InitializeComponent();
            Porcentaje = (int)(this.Opacity*100);
            nudPorcentaje.Value = Porcentaje;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Opacity = (this.Opacity >= 1) ? 1 : this.Opacity += 0.01;
            MostrarOpacity();
            this.nudPorcentaje.Value = (int)(this.Opacity * 100);
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            this.Opacity = (this.Opacity <= 0.2) ? 0.2 : this.Opacity -= 0.01;
            MostrarOpacity();
            this.nudPorcentaje.Value = (int)(this.Opacity * 100);
        }

        private void MostrarOpacity()
        {
            this.Text = "";
            
            this.Text += (this.Opacity * 100).ToString() + "%";
            if (this.Opacity < 0.5)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Green;
            }
        }

        private void nudPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = (double)(nudPorcentaje.Value / 100);
            MostrarOpacity();
            progressBar1.Value = (int)nudPorcentaje.Value;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

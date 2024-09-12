using Sesion5_Ejercicio_1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion5_Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbNumber1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(tbNumber1.Text);
                int num2 = int.Parse(tbNumero2.Text);
                Exercise exercise = new Exercise();

                if (exercise.esMayor(num1, num2))
                {
                    lblAnswer.Text = num1 + " es mayor que " + num2;
                }
                else if (exercise.esMayor(num2,num1))
                {
                    lblAnswer.Text = num2 + " Es mayor que " + num1;

                }else
                {
                    lblAnswer.Text = $"{num1} es igual a{num2}";
                }
            }
            catch (Exception ex)
            {
                lblAnswer.Text = ex.Message;
            }

            
        }

        private void lblMenor_Click(object sender, EventArgs e)
        {
            try 
            {
                int num1 = Convert.ToInt32(tbNumber1.Text);
                int num2 = int.Parse(tbNumero2.Text);
                Exercise exercise = new Exercise();

                if (exercise.esMenor(num1, num2))
                {
                    lblAnswer.Text = num1 + " Es menor " + num2;
                }
                else if(exercise.esMenor(num1,num2))
                {
                    lblAnswer.Text = num2 + " Es menor " + num1;

                }
                else 
                {
                    lblAnswer.Text = num1+ "es igual" + num2;
                }
            }
            catch(Exception ex) 
            {
                lblAnswer.Text = ex.Message;
            }
        
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }

        
    }
}

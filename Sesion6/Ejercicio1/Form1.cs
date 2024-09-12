using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }
        private void agregar()
        {
            if(TbTitulo.Text.Trim().Length > 0)
            {
                string titulo = TbTitulo.Text.Trim();
                LbLibros.Items.Add(titulo);
                TbTitulo.Clear();
                TbTitulo.Focus();
            }
        }

        private void TbTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                agregar();
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            int cant = LbLibros.Items.Count;
            for(int i=0; i<cant; i++)
            {
                string titulo = LbLibros.Items[i].ToString();
                LbCopia.Items.Add(titulo);
            }
        }

        private void BtnMover_Click(object sender, EventArgs e)
        {
            if (LbLibros.Items.Count > 0)
            {
                string titulo = LbLibros.SelectedItem.ToString();
                LbCopia.Items.Add(titulo);
                int index = LbLibros.SelectedIndex;
                LbLibros.Items.RemoveAt(index);
                BtnMover.Enabled = false;
            }
        }

        private void LbLibros_Click(object sender, EventArgs e)
        {
            if (LbLibros.Items.Count > 0)
            {
                BtnMover.Enabled = true;
            }
        }
    }
}

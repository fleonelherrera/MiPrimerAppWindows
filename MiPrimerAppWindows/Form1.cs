using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAppWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int longitudApellido = txtApellido.Text.Length;
            int longitudNombre = txtNombre.Text.Length;
            int longitudEdad = txtEdad.Text.Length;
            int longitudDireccion = txtDireccion.Text.Length;

            if (longitudApellido > 0 & longitudNombre > 0 & longitudEdad > 0 & longitudDireccion > 0)
            {
                txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text + Environment.NewLine + "Edad: " + txtEdad.Text + Environment.NewLine + "Direccion: " + txtDireccion.Text;
            }
            else
            {
                if (longitudApellido == 0)
                {
                    txtApellido.BackColor = Color.Red;
                }
                if (longitudNombre == 0)
                {
                    txtNombre.BackColor = Color.Red;
                }
                if (longitudEdad == 0)
                {
                    txtEdad.BackColor = Color.Red;
                }
                if (longitudDireccion == 0)
                {
                    txtDireccion.BackColor = Color.Red;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoSemana10TemaFormulariosTareaDeSemanal
{
    public partial class Saul : Form
    {
        public Saul()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt16(txtEdad.Text);
            string fnacimiento = txtFNacimiento.Text;
            string direccion = txtDireccion.Text;
            int hijos = Convert.ToInt16(txtHijos.Text);
            string elaboral = txtELaboral.Text;
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            if (nombre == "" || fnacimiento == "" || direccion == "" || elaboral == "")
            {
                MessageBox.Show("Ingrese todos los datos requeridos");
                return;
            }
            if (!int.TryParse(txtEdad.Text, out edad) || !int.TryParse(txtHijos.Text, out hijos) || !double.TryParse(txtSueldo.Text, out sueldo))
            {
                txtEdad.Text = "";
                txtHijos.Text = "";
                txtSueldo.Text = "";
                MessageBox.Show("Ingrese sólo valores numericos en los espacios correspondientes ");
                return;
            }
            MessageBox.Show("Empleado Registrado correctamente");
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            txtEdad.ResetText();
            txtFNacimiento.ResetText();
            txtDireccion.ResetText();
            txtHijos.ResetText();
            txtELaboral.ResetText();
            txtSueldo.ResetText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

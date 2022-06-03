using proyectoSemana10TemaFormulariosTareaDeSemanal.datos;
using proyectoSemana10TemaFormulariosTareaDeSemanal.modelo;
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
            string dni = txtDNI.Text;
            string direccion = txtDireccion.Text;
            int hijos = Convert.ToInt16(txtHijos.Text);
            string elaboral = txtELaboral.Text;
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            if (nombre == "" || direccion == "" || elaboral == ""||dni=="")
            {
                MessageBox.Show("Ingrese todos los datos requeridos");
                return;
            }
            else if (!int.TryParse(txtHijos.Text, out hijos) || !double.TryParse(txtSueldo.Text, out sueldo))
            {
                txtHijos.Text = "";
                txtSueldo.Text = "";
                MessageBox.Show("Ingrese sólo valores numericos en los espacios correspondientes ");
                return;
            }
            else
            {
                try
                {
                    Saul_Empleado s = new Saul_Empleado();
                    s.NombreEmpleado1 = nombre;
                    s.DNIempleado1 = dni;
                    s.DireccionEmpleado1 = direccion;
                    s.HijosEmpleados1 = hijos;
                    s.ExperienciaLaboralEmpleado1 = elaboral;
                    s.SueldoFijoEmpleado1 = (float) sueldo;

                    if (Saul_EmpleadoCAD.guardar(s))
                    {
                        MessageBox.Show("Empleado Registrado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe otro empleado");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            txtDNI.ResetText();
            txtDireccion.ResetText();
            txtHijos.ResetText();
            txtELaboral.ResetText();
            txtSueldo.ResetText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

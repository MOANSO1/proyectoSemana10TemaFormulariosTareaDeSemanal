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
    public partial class Camila : Form
    {
        public Camila()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSalarioTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idCalculoSueldo = txtIdCalculoSueldo.Text;
            string nombreTrabajador = txtNombreTrabajador.Text;
            if (nombreTrabajador.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre");
            }

            double salarioFijo = 0;
            if (cboSalarioFijo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Salario");
            }
            if (cboSalarioFijo.SelectedIndex == 0)
            {
                salarioFijo = 1000;
            }
            if (cboSalarioFijo.SelectedIndex == 1)
            {
                salarioFijo = 1250;
            }
            if (cboSalarioFijo.SelectedIndex == 2)
            {
                salarioFijo = 1300;
            }
            if (cboSalarioFijo.SelectedIndex == 3)
            {
                salarioFijo = 1500;
            }
            if (cboSalarioFijo.SelectedIndex == 4)
            {
                salarioFijo = 1650;
            }

            double comisionPorVenta = 0;
            if (cboComisionPorVenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Salario");
            }
            if (cboComisionPorVenta.SelectedIndex == 0)
            {
                comisionPorVenta = 5;
            }
            if (cboComisionPorVenta.SelectedIndex == 1)
            {
                comisionPorVenta = 10;
            }
            if (cboComisionPorVenta.SelectedIndex == 2)
            {
                comisionPorVenta = 15;
            }

            int cantidadVentasRealizadas = 0;

            double salarioTotal = 0;
            salarioTotal = salarioFijo + comisionPorVenta * cantidadVentasRealizadas;
            txtSalarioTotal.Text= salarioTotal.ToString();

            //MessageBox.Show("Hola " + nombreTrabajador + "! Tu salario total del mes es: S/." + salarioTotal);

            try
            {
                Camila_CalcularSalario c = new Camila_CalcularSalario();
                c.IDsalario1=idCalculoSueldo;
                c.NombreTrabajador1 = nombreTrabajador;
                c.SalarioFijo1 = (float)salarioFijo;
                c.ComisionPorVenta1 = (float)comisionPorVenta;
                c.SalarioTotal1 = (float)salarioTotal;

                if (Camila_CalcularSalarioCAD.guardar(c))
                {
                    llenarTabla();
                    MessageBox.Show("Calculo de Salario Registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Ya existe otro Calculo de Salario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboSalarioFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtNombreTrabajador.ResetText();
            cboSalarioFijo.ResetText();
            cboComisionPorVenta.ResetText();
            txtCantidadDeVentasRealizadas.ResetText();
        }

        private void llenarTabla()
        {
            DataTable datos = Camila_CalcularSalarioCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                listaSalarioTrabajador.DataSource = datos.DefaultView;

            }
        }
    }
}

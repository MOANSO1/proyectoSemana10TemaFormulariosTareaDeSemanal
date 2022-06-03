using proyectoSemana10TemaFormulariosTareaDeSemanal.datos;
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
    public partial class Joycee : Form
    {
        public Joycee()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void imageRegister_Click(object sender, EventArgs e)
        {
            double costoVenta = 0;
            double costoCompra = 0;
            double resultGanancia = 0;
            string resultCadena;

            if (string.IsNullOrEmpty(txtIdProduct.Text) || string.IsNullOrEmpty(txtNameProduct.Text) ||
                string.IsNullOrEmpty(txtCostoCompra.Text) || string.IsNullOrEmpty(txtCostoVenta.Text))
            {
                MessageBox.Show("Debes completar las casillas");
                return;
            }

           else if (!double.TryParse(txtCostoVenta.Text, out costoVenta) || !double.TryParse(txtCostoCompra.Text, out costoCompra))
            {
                txtCostoVenta.Text = "";
                txtCostoCompra.Text = "";

                MessageBox.Show("Debes ingresar correctamente los numeros en ciertas casillas.");
                return;
            }

           
            resultGanancia = (costoVenta - costoCompra);



            resultCadena = "Resumen del proceso:\nIDProducto: " + txtIdProduct.Text + "\nNombre del producto: " + txtNameProduct.Text +
                            "\nCosto de venta: " + txtCostoVenta.Text + "\nCosto de compra: " + txtCostoCompra.Text +
                            "\nGanancia: " + resultGanancia;

            MessageBox.Show(resultCadena);

            try
            {
                Joyce_CalcularGanancia j = new Joyce_CalcularGanancia();
                j.IDganancia1 = txtIdProduct.Text;
                j.NombreProducto1 = txtNameProduct.Text;
                j.CostoCompraProducto1 = (float)costoCompra;
                j.CostoVentaProducto1 = (float)costoVenta;
                j.GananciaProducto1 = (float)resultGanancia;

                if (Joyce_CalcularGananciaCAD.guardar(j))
                {
                    llenarTabla();
                    MessageBox.Show("Calculo de Ganancia correctamente");
                }
                else
                {
                    MessageBox.Show("Ya existe otro Calculo de Ganancia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imagenCancelRegister_Click(object sender, EventArgs e)
        {
            txtCostoCompra.ResetText();
            txtCostoVenta.ResetText();
            txtIdProduct.ResetText();
            txtNameProduct.ResetText();
        }
        private void llenarTabla()
        {
            DataTable datos = Joyce_CalcularGananciaCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                listaGanancia.DataSource = datos.DefaultView;

            }
        }
    }
}

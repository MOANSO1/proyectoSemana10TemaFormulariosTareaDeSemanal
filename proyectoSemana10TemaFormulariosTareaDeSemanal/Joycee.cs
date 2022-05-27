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
        }

        private void imageRegister_Click(object sender, EventArgs e)
        {
            int tempNum1 = 0;
            int tempNum2 = 0;
            int resultGanancia = 0;
            string resultCadena;

            if (string.IsNullOrEmpty(txtIdProduct.Text) || string.IsNullOrEmpty(txtNameProduct.Text) ||
                string.IsNullOrEmpty(txtCostoCompra.Text) || string.IsNullOrEmpty(txtCostoVenta.Text))
            {
                MessageBox.Show("Debes completar las casillas");
                return;
            }

            if (!int.TryParse(txtCostoVenta.Text, out tempNum1) || !int.TryParse(txtCostoCompra.Text, out tempNum2))
            {
                txtCostoVenta.Text = "";
                txtCostoCompra.Text = "";

                MessageBox.Show("Debes ingresar correctamente los numeros en ciertas casillas.");
                return;
            }

            int venta = int.Parse(txtCostoVenta.Text);
            int compra = int.Parse(txtCostoCompra.Text);

            resultGanancia = (venta - compra);



            resultCadena = "Resumen del proceso:\nIDProducto: " + txtIdProduct.Text + "\nNombre del producto: " + txtNameProduct.Text +
                            "\nCosto de venta: " + txtCostoVenta.Text + "\nCosto de compra: " + txtCostoCompra.Text +
                            "\nGanancia: " + resultGanancia;

            MessageBox.Show(resultCadena);
        }

        private void imagenCancelRegister_Click(object sender, EventArgs e)
        {
            txtCostoCompra.ResetText();
            txtCostoVenta.ResetText();
            txtIdProduct.ResetText();
            txtNameProduct.ResetText();
        }
    }
}

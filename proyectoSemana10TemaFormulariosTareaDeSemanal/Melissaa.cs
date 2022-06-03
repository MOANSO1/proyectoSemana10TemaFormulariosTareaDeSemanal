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
    public partial class Melissaa : Form
    {
        public Melissaa()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idprod = txtIDproducto.Text;
            string idprov = txtIDProv.Text;
            string nombre = txtNombre.Text;
            double precio = Convert.ToDouble(txtPrecio.Text);
            if (idprod == "" || idprov == "" || nombre == "")
            {
                MessageBox.Show("Ingrese todos los datos requeridos en los campos");
                return;
            }
            else if (!double.TryParse(txtPrecio.Text, out precio))
            {
                txtPrecio.Text = "";
                MessageBox.Show("Ingrese sólo valores numericos en los campos correspondientes ");
                return;
            }
            else
            {
                try
                {
                    Productos p = new Productos();
                    p.IDproducto1 = idprod;
                    p.IDproveedor1 = idprov;
                    p.NombreProducto1 = nombre;
                    p.PrecioProducto1 = (float)precio;

                    if (ProductosMCAD.guardar(p))
                    {
                        llenarTabla();
                        MessageBox.Show("Se ha registrado de forma correcta el nuevo producto");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe este producto");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDproducto.ResetText();
            txtIDProv.ResetText();
            txtNombre.ResetText();
            txtPrecio.ResetText();
        }

        private void llenarTabla()
        {
            DataTable datos = ProductosMCAD.listar();
            if(datos == null)
            {
                MessageBox.Show("No se pueden acceder a los datos");
            }
            else
            {
                dgLista.DataSource = datos.DefaultView;
            }

        }

        private void Melissaa_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}

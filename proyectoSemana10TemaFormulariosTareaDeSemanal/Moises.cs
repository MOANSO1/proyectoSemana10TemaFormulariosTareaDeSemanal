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
    public partial class Moises : Form
    {
        public Moises()
        {
            InitializeComponent();
        }

        private void Moises_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            String nombre = textNOMBRE.Text;
            String id = textID.Text;
            String telefono = textTELEFONO.Text;
            String correo = textCORREO.Text;

            if (nombre == "" || id == "" || telefono == "" || correo == "")
            {
                MessageBox.Show("Ingrese todos los datos requeridos en los campos.");
                return;
            }

            else
            {
                try
                {
                    Proveedor p = new Proveedor();
                    p.NombreProveedor1 = nombre;
                    p.IDproveedor1 = id;
                    p.TelefonoProveedor1 = telefono;
                    p.CorreoCliente1 = correo;

                    if (ProveedorMCAD.guardar(p))
                    {
                        llenarTabla();
                        MessageBox.Show("Se ha registrado de forma correcta el nuevo proveedor");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe este proveedor en la base de datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void llenarTabla()
        {
            DataTable datos = ProveedorMCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se pueden acceder a los datos");
            }
            else
            {
                dgListar.DataSource = datos.DefaultView;
            }

        }


        private void textTELEFONO_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = !char.IsDigit(KeyPressEvent.KeyChar);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNOMBRE.ResetText();
            textID.ResetText();
            textTELEFONO.ResetText();
            textCORREO.ResetText();
        }
    }



}

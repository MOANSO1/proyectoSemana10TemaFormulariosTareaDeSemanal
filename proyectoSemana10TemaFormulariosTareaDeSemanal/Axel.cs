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
    public partial class Axel : Form
    {
        public Axel()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Axel_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellidos.Text;
            string dni = txtDni.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;

            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellidos.Text) && string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese los datos a las casillas vacias  correspondientes  ");

                return;
            }

            else
            {
                try
                {
                    Axel_Cliente a = new Axel_Cliente();
                    a.NombreCliente1 = nombre;
                    a.ApellidosCliente1 = apellido;
                    a.DNIcliente1 = dni;
                    a.TelefonoCliente1 = telefono;
                    a.DireccionCliente1 = direccion;
                    a.CorreoCliente1 = correo;

                    if (Axel_ClienteCAD.guardar(a))
                    {
                        llenarTabla();
                        MessageBox.Show("Cliente Registrado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe otro cliente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
        }

        private void llenarTabla()
        {
            DataTable datos = Axel_ClienteCAD.listar();
            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                listaCliente.DataSource = datos.DefaultView;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarTabla();

        }
    }
}

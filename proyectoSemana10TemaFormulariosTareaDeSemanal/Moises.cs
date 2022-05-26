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

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            String nombre = textNOMBRE.Text;
            String id = textID.Text;
            String telefono = textTELEFONO.Text;
            String correo = textCORREO.Text;
            MessageBox.Show("Proveedor Agregado");
            textCORREO.Text = "";
            textNOMBRE.Text = "";
            textTELEFONO.Text = "";
            textID.Text = "";


        }
    }
}

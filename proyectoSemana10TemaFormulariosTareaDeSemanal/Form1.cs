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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dicarlo myNewForm = new Dicarlo();

            myNewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camila formCamila = new Camila();

            formCamila.ShowDialog();
        }

        private void btnFormSaul_Click(object sender, EventArgs e)
        {
            Saúl formSaúl = new Saúl();

            formSaúl.ShowDialog();
        }
    }
}

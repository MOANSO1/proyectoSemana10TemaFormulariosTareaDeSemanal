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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Axel FormAxel = new Axel();

            FormAxel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Moises ForMoises = new Moises();

            ForMoises.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Melissa formMelissa = new Melissa();
            formMelissa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Joycee formJoyce = new Joycee();
            formJoyce.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Saul saul = new Saul();
            saul.ShowDialog();
        }
    }
}

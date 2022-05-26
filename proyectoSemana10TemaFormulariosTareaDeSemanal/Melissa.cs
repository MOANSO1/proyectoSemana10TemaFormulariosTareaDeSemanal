﻿using System;
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
    public partial class Melissa : Form
    {
        public Melissa()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreP.Text))
            {
                MessageBox.Show("Ingrese el nombre de producto.");
            }

            if (string.IsNullOrEmpty(txtCodigoP.Text))
            {
                MessageBox.Show("Ingrese el codigo de producto.");
            }

            int precioP = 0;
            if (!int.TryParse(txtPrecioP.Text, out precioP))
            {
                txtPrecioP.Text = "";

                MessageBox.Show("Ingrese el precio. ");
                return;
            }

            else
                MessageBox.Show("El producto ha sido registrado con exito.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreP.ResetText();
            txtCodigoP.ResetText();
            txtPrecioP.ResetText();
        }

        private void txtPrecioP_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPrecioP_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            KeyPressEvent.Handled = !char.IsDigit(KeyPressEvent.KeyChar);
        }
    }
}

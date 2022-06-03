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
    public partial class Dicarlo : Form
    {
        double costo1, costo2, costo3, costo4, costo5;

        private void chkMueble_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMueble.Checked)
            {
                
                txtmueble.Text = "650";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();
            }
            else
            {
                txtmueble.Text = "0";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();


            }
        }

        private void chkMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMesa.Checked)
            {
               
                txtmesa.Text = "450";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();
            }
            else
            {
                txtmesa.Text = "0";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();


            }
        }

        private void chkRepisa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRepisa.Checked)
            {
                
                txtRepisa.Text = "320";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();
            }
            else
            {
                txtRepisa.Text = "0";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();


            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                VentaProducto em = new VentaProducto();
                em.IDcompra1 = txtidcompra.Text;
                em.DNIempleado1 = DniEmpleado.Text;
                em.DNIcliente1 = dniCliente.Text;
                em.CostoTotal1 = txttotal.Text;
                MessageBox.Show("Compra Realizada exitosamente");
                if (DicarloCAD.guardarVenta(em))
                {
                    llenarGrid();
                    MessageBox.Show("guardado en la base");
                }
                else
                {
                    MessageBox.Show("no guardado en la base");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dicarlo_Load(object sender, EventArgs e)
        {

        }

        private void chkCocina_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCocina.Checked)
            {
               
                txtcocina.Text = "120";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();
            }
            else
            {
                txtcocina.Text = "0";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();


            }
        }

        private void chkLaptop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaptop.Checked)
            {
               
                txtlaptop.Text = "1500";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();
            }
            else
            {
                txtlaptop.Text = "0";
                costo1 = Double.Parse(txtcocina.Text);
                costo2 = Double.Parse(txtlaptop.Text);
                costo3 = Double.Parse(txtmueble.Text);
                costo4 = Double.Parse(txtmesa.Text);
                costo5 = Double.Parse(txtRepisa.Text);
                txttotal.Text = (costo1 + costo2 + costo3 + costo4 + costo5).ToString();


            }
        }

        public Dicarlo()
        {
            InitializeComponent();
            llenarGrid();
        }



        private void txtcocina_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void llenarGrid()
        {
            DataTable datos = DicarloCAD.listar();
            if(datos == null)
            {
                MessageBox.Show("No se logro acceder");
            }
            else
            {
                dglista.DataSource = datos.DefaultView;
            }

        }
    }
}

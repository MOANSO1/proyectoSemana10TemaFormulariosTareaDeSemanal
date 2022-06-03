namespace proyectoSemana10TemaFormulariosTareaDeSemanal
{
    partial class Dicarlo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dicarlo));
            this.dglista = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidcompra = new System.Windows.Forms.TextBox();
            this.dniCliente = new System.Windows.Forms.TextBox();
            this.DniEmpleado = new System.Windows.Forms.TextBox();
            this.imgComprar = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.chkRepisa = new System.Windows.Forms.CheckBox();
            this.txtRepisa = new System.Windows.Forms.TextBox();
            this.chkMesa = new System.Windows.Forms.CheckBox();
            this.chkMueble = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtmesa = new System.Windows.Forms.TextBox();
            this.txtmueble = new System.Windows.Forms.TextBox();
            this.txtlaptop = new System.Windows.Forms.TextBox();
            this.txtcocina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).BeginInit();
            this.SuspendLayout();
            // 
            // dglista
            // 
            this.dglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglista.Location = new System.Drawing.Point(554, 96);
            this.dglista.Name = "dglista";
            this.dglista.RowHeadersWidth = 51;
            this.dglista.RowTemplate.Height = 24;
            this.dglista.Size = new System.Drawing.Size(382, 242);
            this.dglista.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "DNI Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "idCompraProducto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "DNI Cliente";
            // 
            // txtidcompra
            // 
            this.txtidcompra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtidcompra.Location = new System.Drawing.Point(149, 45);
            this.txtidcompra.Name = "txtidcompra";
            this.txtidcompra.Size = new System.Drawing.Size(100, 22);
            this.txtidcompra.TabIndex = 51;
            // 
            // dniCliente
            // 
            this.dniCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dniCliente.Location = new System.Drawing.Point(621, 45);
            this.dniCliente.Name = "dniCliente";
            this.dniCliente.Size = new System.Drawing.Size(100, 22);
            this.dniCliente.TabIndex = 50;
            // 
            // DniEmpleado
            // 
            this.DniEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DniEmpleado.Location = new System.Drawing.Point(399, 45);
            this.DniEmpleado.Name = "DniEmpleado";
            this.DniEmpleado.Size = new System.Drawing.Size(100, 22);
            this.DniEmpleado.TabIndex = 49;
            // 
            // imgComprar
            // 
            this.imgComprar.AutoSize = true;
            this.imgComprar.ForeColor = System.Drawing.SystemColors.Window;
            this.imgComprar.Image = ((System.Drawing.Image)(resources.GetObject("imgComprar.Image")));
            this.imgComprar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.imgComprar.Location = new System.Drawing.Point(483, 401);
            this.imgComprar.Name = "imgComprar";
            this.imgComprar.Size = new System.Drawing.Size(61, 32);
            this.imgComprar.TabIndex = 48;
            this.imgComprar.Text = "                  \r\n 1 ";
            this.imgComprar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imgComprar.Click += new System.EventHandler(this.imgComprar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(581, 408);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 47;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click_1);
            // 
            // chkRepisa
            // 
            this.chkRepisa.AutoSize = true;
            this.chkRepisa.Location = new System.Drawing.Point(136, 235);
            this.chkRepisa.Name = "chkRepisa";
            this.chkRepisa.Size = new System.Drawing.Size(73, 20);
            this.chkRepisa.TabIndex = 46;
            this.chkRepisa.Text = "Repisa";
            this.chkRepisa.UseVisualStyleBackColor = true;
            this.chkRepisa.CheckedChanged += new System.EventHandler(this.chkRepisa_CheckedChanged_1);
            // 
            // txtRepisa
            // 
            this.txtRepisa.Location = new System.Drawing.Point(387, 235);
            this.txtRepisa.Name = "txtRepisa";
            this.txtRepisa.ReadOnly = true;
            this.txtRepisa.Size = new System.Drawing.Size(100, 22);
            this.txtRepisa.TabIndex = 45;
            this.txtRepisa.Text = "0";
            // 
            // chkMesa
            // 
            this.chkMesa.AutoSize = true;
            this.chkMesa.Location = new System.Drawing.Point(136, 193);
            this.chkMesa.Name = "chkMesa";
            this.chkMesa.Size = new System.Drawing.Size(63, 20);
            this.chkMesa.TabIndex = 44;
            this.chkMesa.Text = "Mesa";
            this.chkMesa.UseVisualStyleBackColor = true;
            this.chkMesa.CheckedChanged += new System.EventHandler(this.chkMesa_CheckedChanged_1);
            // 
            // chkMueble
            // 
            this.chkMueble.AutoSize = true;
            this.chkMueble.Location = new System.Drawing.Point(136, 154);
            this.chkMueble.Name = "chkMueble";
            this.chkMueble.Size = new System.Drawing.Size(74, 20);
            this.chkMueble.TabIndex = 43;
            this.chkMueble.Text = "mueble";
            this.chkMueble.UseVisualStyleBackColor = true;
            this.chkMueble.CheckedChanged += new System.EventHandler(this.chkMueble_CheckedChanged_1);
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(136, 116);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(71, 20);
            this.chkLaptop.TabIndex = 42;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            this.chkLaptop.CheckedChanged += new System.EventHandler(this.chkLaptop_CheckedChanged_1);
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(136, 82);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(71, 20);
            this.chkCocina.TabIndex = 41;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            this.chkCocina.CheckedChanged += new System.EventHandler(this.chkCocina_CheckedChanged_1);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(377, 411);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 40;
            // 
            // txtmesa
            // 
            this.txtmesa.Location = new System.Drawing.Point(387, 193);
            this.txtmesa.Name = "txtmesa";
            this.txtmesa.ReadOnly = true;
            this.txtmesa.Size = new System.Drawing.Size(100, 22);
            this.txtmesa.TabIndex = 39;
            this.txtmesa.Text = "0";
            // 
            // txtmueble
            // 
            this.txtmueble.Location = new System.Drawing.Point(387, 152);
            this.txtmueble.Name = "txtmueble";
            this.txtmueble.ReadOnly = true;
            this.txtmueble.Size = new System.Drawing.Size(100, 22);
            this.txtmueble.TabIndex = 38;
            this.txtmueble.Text = "0";
            // 
            // txtlaptop
            // 
            this.txtlaptop.Location = new System.Drawing.Point(387, 114);
            this.txtlaptop.Name = "txtlaptop";
            this.txtlaptop.ReadOnly = true;
            this.txtlaptop.Size = new System.Drawing.Size(100, 22);
            this.txtlaptop.TabIndex = 37;
            this.txtlaptop.Text = "0";
            // 
            // txtcocina
            // 
            this.txtcocina.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtcocina.Location = new System.Drawing.Point(387, 80);
            this.txtcocina.Name = "txtcocina";
            this.txtcocina.ReadOnly = true;
            this.txtcocina.Size = new System.Drawing.Size(100, 22);
            this.txtcocina.TabIndex = 36;
            this.txtcocina.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Total";
            // 
            // Dicarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 490);
            this.Controls.Add(this.dglista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidcompra);
            this.Controls.Add(this.dniCliente);
            this.Controls.Add(this.DniEmpleado);
            this.Controls.Add(this.imgComprar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.chkRepisa);
            this.Controls.Add(this.txtRepisa);
            this.Controls.Add(this.chkMesa);
            this.Controls.Add(this.chkMueble);
            this.Controls.Add(this.chkLaptop);
            this.Controls.Add(this.chkCocina);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtmesa);
            this.Controls.Add(this.txtmueble);
            this.Controls.Add(this.txtlaptop);
            this.Controls.Add(this.txtcocina);
            this.Controls.Add(this.label4);
            this.Name = "Dicarlo";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dglista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidcompra;
        private System.Windows.Forms.TextBox dniCliente;
        private System.Windows.Forms.TextBox DniEmpleado;
        private System.Windows.Forms.Label imgComprar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.CheckBox chkRepisa;
        private System.Windows.Forms.TextBox txtRepisa;
        private System.Windows.Forms.CheckBox chkMesa;
        private System.Windows.Forms.CheckBox chkMueble;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtmesa;
        private System.Windows.Forms.TextBox txtmueble;
        private System.Windows.Forms.TextBox txtlaptop;
        private System.Windows.Forms.TextBox txtcocina;
        private System.Windows.Forms.Label label4;
    }
}
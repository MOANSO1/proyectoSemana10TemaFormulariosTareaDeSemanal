namespace proyectoSemana10TemaFormulariosTareaDeSemanal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button6 = new System.Windows.Forms.Button();
            this.btnCamila = new System.Windows.Forms.Button();
            this.btnFormSaul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(212, 321);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 19);
            this.button6.TabIndex = 12;
            this.button6.Text = "Comprar Productos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCamila
            // 
            this.btnCamila.Location = new System.Drawing.Point(199, 286);
            this.btnCamila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCamila.Name = "btnCamila";
            this.btnCamila.Size = new System.Drawing.Size(174, 19);
            this.btnCamila.TabIndex = 13;
            this.btnCamila.Text = "Calcular Salario Trabajador";
            this.btnCamila.UseVisualStyleBackColor = true;
            this.btnCamila.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFormSaul
            // 
            this.btnFormSaul.Location = new System.Drawing.Point(182, 209);
            this.btnFormSaul.Name = "btnFormSaul";
            this.btnFormSaul.Size = new System.Drawing.Size(191, 23);
            this.btnFormSaul.TabIndex = 14;
            this.btnFormSaul.Text = "Registrar Empleado";
            this.btnFormSaul.UseVisualStyleBackColor = true;
            this.btnFormSaul.Click += new System.EventHandler(this.btnFormSaul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnFormSaul);
            this.Controls.Add(this.btnCamila);
            this.Controls.Add(this.button6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnCamila;
        private System.Windows.Forms.Button btnFormSaul;
    }
}


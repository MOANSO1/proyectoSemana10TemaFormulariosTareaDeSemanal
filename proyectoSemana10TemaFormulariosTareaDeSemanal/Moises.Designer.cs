
namespace proyectoSemana10TemaFormulariosTareaDeSemanal
{
    partial class Moises
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
            this.btninsertar = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textTELEFONO = new System.Windows.Forms.TextBox();
            this.textCORREO = new System.Windows.Forms.TextBox();
            this.textNOMBRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(77, 282);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 17;
            this.btninsertar.Text = "INSERTAR";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(178, 135);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 16;
            // 
            // textTELEFONO
            // 
            this.textTELEFONO.Location = new System.Drawing.Point(178, 180);
            this.textTELEFONO.Name = "textTELEFONO";
            this.textTELEFONO.Size = new System.Drawing.Size(100, 20);
            this.textTELEFONO.TabIndex = 15;
            this.textTELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTELEFONO_KeyPress);
            // 
            // textCORREO
            // 
            this.textCORREO.Location = new System.Drawing.Point(178, 230);
            this.textCORREO.Name = "textCORREO";
            this.textCORREO.Size = new System.Drawing.Size(100, 20);
            this.textCORREO.TabIndex = 14;
            // 
            // textNOMBRE
            // 
            this.textNOMBRE.Location = new System.Drawing.Point(178, 91);
            this.textNOMBRE.Name = "textNOMBRE";
            this.textNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.textNOMBRE.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TELEFONO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CORREO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoSemana10TemaFormulariosTareaDeSemanal.Properties.Resources.descarga__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(178, 282);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgListar
            // 
            this.dgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListar.Location = new System.Drawing.Point(317, 91);
            this.dgListar.Name = "dgListar";
            this.dgListar.Size = new System.Drawing.Size(440, 214);
            this.dgListar.TabIndex = 20;
            // 
            // Moises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgListar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textTELEFONO);
            this.Controls.Add(this.textCORREO);
            this.Controls.Add(this.textNOMBRE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Moises";
            this.Text = "Agregar Proveedor";
            this.Load += new System.EventHandler(this.Moises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textTELEFONO;
        private System.Windows.Forms.TextBox textCORREO;
        private System.Windows.Forms.TextBox textNOMBRE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgListar;
    }
}
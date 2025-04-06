namespace sistemaAlquilerDonChusSA
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonAlquiler = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALQUILER DE AUTOS DON CHUS";
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(69, 81);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(177, 43);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(69, 161);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(177, 43);
            this.buttonAuto.TabIndex = 2;
            this.buttonAuto.Text = "Auto";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonAlquiler
            // 
            this.buttonAlquiler.Location = new System.Drawing.Point(367, 81);
            this.buttonAlquiler.Name = "buttonAlquiler";
            this.buttonAlquiler.Size = new System.Drawing.Size(180, 43);
            this.buttonAlquiler.TabIndex = 3;
            this.buttonAlquiler.Text = "Alquiler";
            this.buttonAlquiler.UseVisualStyleBackColor = true;
            this.buttonAlquiler.Click += new System.EventHandler(this.buttonAlquiler_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(367, 161);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(180, 43);
            this.buttonReporte.TabIndex = 4;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 236);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.buttonAlquiler);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonAlquiler;
        private System.Windows.Forms.Button buttonReporte;
    }
}


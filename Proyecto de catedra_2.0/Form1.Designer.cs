namespace Proyecto_de_catedra_2._0
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
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.btnControlAutobuses = new System.Windows.Forms.Button();
            this.btnAdquirirBoleto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.AutoSize = true;
            this.lblTituloInicio.Location = new System.Drawing.Point(278, 38);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(193, 16);
            this.lblTituloInicio.TabIndex = 0;
            this.lblTituloInicio.Text = "Inicio Para Reserva de Boletos";
            // 
            // btnControlAutobuses
            // 
            this.btnControlAutobuses.Location = new System.Drawing.Point(259, 110);
            this.btnControlAutobuses.Name = "btnControlAutobuses";
            this.btnControlAutobuses.Size = new System.Drawing.Size(186, 36);
            this.btnControlAutobuses.TabIndex = 1;
            this.btnControlAutobuses.Text = "Control de Autobuses";
            this.btnControlAutobuses.UseVisualStyleBackColor = true;
            this.btnControlAutobuses.Click += new System.EventHandler(this.btnControlAutobuses_Click);
            // 
            // btnAdquirirBoleto
            // 
            this.btnAdquirirBoleto.Location = new System.Drawing.Point(296, 185);
            this.btnAdquirirBoleto.Name = "btnAdquirirBoleto";
            this.btnAdquirirBoleto.Size = new System.Drawing.Size(114, 24);
            this.btnAdquirirBoleto.TabIndex = 2;
            this.btnAdquirirBoleto.Text = "Adquirir Boleto";
            this.btnAdquirirBoleto.UseVisualStyleBackColor = true;
            this.btnAdquirirBoleto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(319, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdquirirBoleto);
            this.Controls.Add(this.btnControlAutobuses);
            this.Controls.Add(this.lblTituloInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloInicio;
        private System.Windows.Forms.Button btnControlAutobuses;
        private System.Windows.Forms.Button btnAdquirirBoleto;
        private System.Windows.Forms.Button btnSalir;
    }
}


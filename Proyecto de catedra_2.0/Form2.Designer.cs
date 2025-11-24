namespace Proyecto_de_catedra_2._0
{
    partial class Form2
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
            this.lblTituloControl = new System.Windows.Forms.Label();
            this.lblRutaBus = new System.Windows.Forms.Label();
            this.txtRutaBus = new System.Windows.Forms.TextBox();
            this.lblNumUnidades = new System.Windows.Forms.Label();
            this.txtNumUnidades = new System.Windows.Forms.TextBox();
            this.lblHoraLlegada = new System.Windows.Forms.Label();
            this.txtHoraLlegada = new System.Windows.Forms.TextBox();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.txtHoraSalidaBus = new System.Windows.Forms.TextBox();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.txtUnidadesDisponibles = new System.Windows.Forms.TextBox();
            this.lblUnidadesFuera = new System.Windows.Forms.Label();
            this.txtUnidadesFuera = new System.Windows.Forms.TextBox();
            this.lblLugarSalida = new System.Windows.Forms.Label();
            this.txtLugarSalida = new System.Windows.Forms.TextBox();
            this.lblPuntoLlegada = new System.Windows.Forms.Label();
            this.txtPuntoLlegada = new System.Windows.Forms.TextBox();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.btnSalirControl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloControl
            // 
            this.lblTituloControl.AutoSize = true;
            this.lblTituloControl.Location = new System.Drawing.Point(291, 9);
            this.lblTituloControl.Name = "lblTituloControl";
            this.lblTituloControl.Size = new System.Drawing.Size(109, 16);
            this.lblTituloControl.TabIndex = 0;
            this.lblTituloControl.Text = "Control de Buses";
            // 
            // lblRutaBus
            // 
            this.lblRutaBus.AutoSize = true;
            this.lblRutaBus.Location = new System.Drawing.Point(69, 67);
            this.lblRutaBus.Name = "lblRutaBus";
            this.lblRutaBus.Size = new System.Drawing.Size(80, 16);
            this.lblRutaBus.TabIndex = 1;
            this.lblRutaBus.Text = "Ruta de Bus";
            // 
            // txtRutaBus
            // 
            this.txtRutaBus.Location = new System.Drawing.Point(239, 61);
            this.txtRutaBus.Name = "txtRutaBus";
            this.txtRutaBus.Size = new System.Drawing.Size(100, 22);
            this.txtRutaBus.TabIndex = 2;
            // 
            // lblNumUnidades
            // 
            this.lblNumUnidades.AutoSize = true;
            this.lblNumUnidades.Location = new System.Drawing.Point(387, 67);
            this.lblNumUnidades.Name = "lblNumUnidades";
            this.lblNumUnidades.Size = new System.Drawing.Size(136, 16);
            this.lblNumUnidades.TabIndex = 3;
            this.lblNumUnidades.Text = "Número de Unidades";
            // 
            // txtNumUnidades
            // 
            this.txtNumUnidades.Location = new System.Drawing.Point(540, 67);
            this.txtNumUnidades.Name = "txtNumUnidades";
            this.txtNumUnidades.Size = new System.Drawing.Size(100, 22);
            this.txtNumUnidades.TabIndex = 4;
            // 
            // lblHoraLlegada
            // 
            this.lblHoraLlegada.AutoSize = true;
            this.lblHoraLlegada.Location = new System.Drawing.Point(67, 114);
            this.lblHoraLlegada.Name = "lblHoraLlegada";
            this.lblHoraLlegada.Size = new System.Drawing.Size(109, 16);
            this.lblHoraLlegada.TabIndex = 5;
            this.lblHoraLlegada.Text = "Hora de Llegada";
            // 
            // txtHoraLlegada
            // 
            this.txtHoraLlegada.Location = new System.Drawing.Point(239, 108);
            this.txtHoraLlegada.Name = "txtHoraLlegada";
            this.txtHoraLlegada.Size = new System.Drawing.Size(100, 22);
            this.txtHoraLlegada.TabIndex = 6;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(387, 108);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(98, 16);
            this.lblHoraSalida.TabIndex = 7;
            this.lblHoraSalida.Text = "Hora de Salida";
            this.lblHoraSalida.Click += new System.EventHandler(this.lblHoraSalida_Click);
            // 
            // txtHoraSalidaBus
            // 
            this.txtHoraSalidaBus.Location = new System.Drawing.Point(540, 114);
            this.txtHoraSalidaBus.Name = "txtHoraSalidaBus";
            this.txtHoraSalidaBus.Size = new System.Drawing.Size(100, 22);
            this.txtHoraSalidaBus.TabIndex = 8;
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(67, 175);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(141, 16);
            this.lblUnidadesDisponibles.TabIndex = 9;
            this.lblUnidadesDisponibles.Text = "Unidades Disponibles";
            // 
            // txtUnidadesDisponibles
            // 
            this.txtUnidadesDisponibles.Location = new System.Drawing.Point(239, 175);
            this.txtUnidadesDisponibles.Name = "txtUnidadesDisponibles";
            this.txtUnidadesDisponibles.Size = new System.Drawing.Size(100, 22);
            this.txtUnidadesDisponibles.TabIndex = 10;
            // 
            // lblUnidadesFuera
            // 
            this.lblUnidadesFuera.AutoSize = true;
            this.lblUnidadesFuera.Location = new System.Drawing.Point(381, 178);
            this.lblUnidadesFuera.Name = "lblUnidadesFuera";
            this.lblUnidadesFuera.Size = new System.Drawing.Size(104, 16);
            this.lblUnidadesFuera.TabIndex = 11;
            this.lblUnidadesFuera.Text = "Unidades Fuera";
            // 
            // txtUnidadesFuera
            // 
            this.txtUnidadesFuera.Location = new System.Drawing.Point(540, 178);
            this.txtUnidadesFuera.Name = "txtUnidadesFuera";
            this.txtUnidadesFuera.Size = new System.Drawing.Size(100, 22);
            this.txtUnidadesFuera.TabIndex = 12;
            // 
            // lblLugarSalida
            // 
            this.lblLugarSalida.AutoSize = true;
            this.lblLugarSalida.Location = new System.Drawing.Point(72, 236);
            this.lblLugarSalida.Name = "lblLugarSalida";
            this.lblLugarSalida.Size = new System.Drawing.Size(68, 16);
            this.lblLugarSalida.TabIndex = 13;
            this.lblLugarSalida.Text = "Salida de:";
            this.lblLugarSalida.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLugarSalida
            // 
            this.txtLugarSalida.Location = new System.Drawing.Point(239, 230);
            this.txtLugarSalida.Name = "txtLugarSalida";
            this.txtLugarSalida.Size = new System.Drawing.Size(100, 22);
            this.txtLugarSalida.TabIndex = 14;
            // 
            // lblPuntoLlegada
            // 
            this.lblPuntoLlegada.AutoSize = true;
            this.lblPuntoLlegada.Location = new System.Drawing.Point(381, 236);
            this.lblPuntoLlegada.Name = "lblPuntoLlegada";
            this.lblPuntoLlegada.Size = new System.Drawing.Size(113, 16);
            this.lblPuntoLlegada.TabIndex = 15;
            this.lblPuntoLlegada.Text = "Punto de Llegada";
            this.lblPuntoLlegada.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPuntoLlegada
            // 
            this.txtPuntoLlegada.Location = new System.Drawing.Point(540, 230);
            this.txtPuntoLlegada.Name = "txtPuntoLlegada";
            this.txtPuntoLlegada.Size = new System.Drawing.Size(100, 22);
            this.txtPuntoLlegada.TabIndex = 16;
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.Location = new System.Drawing.Point(404, 323);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(128, 23);
            this.btnActualizarDatos.TabIndex = 17;
            this.btnActualizarDatos.Text = "Actualizar Datos";
            this.btnActualizarDatos.UseVisualStyleBackColor = true;
            this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
            // 
            // btnSalirControl
            // 
            this.btnSalirControl.Location = new System.Drawing.Point(579, 313);
            this.btnSalirControl.Name = "btnSalirControl";
            this.btnSalirControl.Size = new System.Drawing.Size(75, 23);
            this.btnSalirControl.TabIndex = 18;
            this.btnSalirControl.Text = "Salir";
            this.btnSalirControl.UseVisualStyleBackColor = true;
            this.btnSalirControl.Click += new System.EventHandler(this.btnSalirControl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(202, 96);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalirControl);
            this.Controls.Add(this.btnActualizarDatos);
            this.Controls.Add(this.txtPuntoLlegada);
            this.Controls.Add(this.lblPuntoLlegada);
            this.Controls.Add(this.txtLugarSalida);
            this.Controls.Add(this.lblLugarSalida);
            this.Controls.Add(this.txtUnidadesFuera);
            this.Controls.Add(this.lblUnidadesFuera);
            this.Controls.Add(this.txtUnidadesDisponibles);
            this.Controls.Add(this.lblUnidadesDisponibles);
            this.Controls.Add(this.txtHoraSalidaBus);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.txtHoraLlegada);
            this.Controls.Add(this.lblHoraLlegada);
            this.Controls.Add(this.txtNumUnidades);
            this.Controls.Add(this.lblNumUnidades);
            this.Controls.Add(this.txtRutaBus);
            this.Controls.Add(this.lblRutaBus);
            this.Controls.Add(this.lblTituloControl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.txtLugarSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloControl;
        private System.Windows.Forms.Label lblRutaBus;
        private System.Windows.Forms.TextBox txtRutaBus;
        private System.Windows.Forms.Label lblNumUnidades;
        private System.Windows.Forms.TextBox txtNumUnidades;
        private System.Windows.Forms.Label lblHoraLlegada;
        private System.Windows.Forms.TextBox txtHoraLlegada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.TextBox txtHoraSalidaBus;
        private System.Windows.Forms.Label lblUnidadesDisponibles;
        private System.Windows.Forms.TextBox txtUnidadesDisponibles;
        private System.Windows.Forms.Label lblUnidadesFuera;
        private System.Windows.Forms.TextBox txtUnidadesFuera;
        private System.Windows.Forms.Label lblLugarSalida;
        private System.Windows.Forms.TextBox txtLugarSalida;
        private System.Windows.Forms.Label lblPuntoLlegada;
        private System.Windows.Forms.TextBox txtPuntoLlegada;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.Button btnSalirControl;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
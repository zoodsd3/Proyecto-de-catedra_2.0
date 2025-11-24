using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_catedra_2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Asume que los eventos están conectados en el diseñador:
            // btnActualizarDatos.Click += btnActualizarDatos_Click;
            // btnSalirControl.Click += btnSalirControl_Click;
        }

        private void lblHoraSalida_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtLugarSalida_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtRutaBus.Text))
            {
                MessageBox.Show("La ruta es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parseo de números y horas con control de errores
            int numUnidades = string.IsNullOrEmpty(txtNumUnidades.Text)
                  ? 0
                  : int.Parse(txtNumUnidades.Text);

            int unidadesDisponibles = string.IsNullOrEmpty(txtUnidadesDisponibles.Text)
                              ? 0
                              : int.Parse(txtUnidadesDisponibles.Text);

            int unidadesFuera = string.IsNullOrEmpty(txtUnidadesFuera.Text)
                              ? 0
                              : int.Parse(txtUnidadesFuera.Text);

            TimeSpan? horaLlegada = null;
            TimeSpan? horaSalida = null;

            TimeSpan parsed;
            if (TimeSpan.TryParse(txtHoraLlegada.Text, out parsed)) horaLlegada = parsed;
            if (TimeSpan.TryParse(txtHoraSalidaBus.Text, out parsed)) horaSalida = parsed;

            try
            {
                DataAccess.SaveOrUpdateBus(
               rutaBus: txtRutaBus.Text.Trim(),
               numeroUnidades: numUnidades,
               horaLlegada: horaLlegada,
               horaSalida: horaSalida,
               unidadesDisponibles: unidadesDisponibles,
               unidadesFuera: unidadesFuera,
               lugarSalida: txtLugarSalida.Text.Trim(),
               puntoLlegada: txtPuntoLlegada.Text.Trim()
           );

                MessageBox.Show("Datos actualizados correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        }

        private void btnSalirControl_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dt = DataAccess.GetAllBuses();
                // dataGridViewBuses.DataSource = dt; // si tienes un DataGridView en el form
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los buses: " + ex.Message);
            }
        }
    }

}




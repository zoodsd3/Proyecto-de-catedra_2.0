using System;
using System.Globalization;
using System.Windows.Forms;


namespace Proyecto_de_catedra_2._0
{
    public partial class Form3 : Form
    {
        private TimeSpan tx;

        public Form3()
        {

            InitializeComponent();
            // btnGenerarBoleto.Click += btnGenerarBoleto_Click;
            // btnLimpiarBoleto.Click += btnLimpiarBoleto_Click;
            // btnSalirBoleto.Click += btnSalirBoleto_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarBoleto_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtValorBoleto.Text) ||
          string.IsNullOrWhiteSpace(txtDestinoFinal.Text) ||
          string.IsNullOrWhiteSpace(txtHoraSalidaBoleto.Text) ||
          string.IsNullOrWhiteSpace(txtRutaAbordar.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            // Parseo del valor y hora
            decimal valor;
            if (!decimal.TryParse(txtValorBoleto.Text.Trim(), out valor))
            {
                MessageBox.Show("Valor no válido.");
                return;
            }

            if (!TimeSpan.TryParse(txtHoraSalidaBoleto.Text.Trim(), out tx))
            {
                MessageBox.Show("Hora de salida no válida. Use formato HH:mm (ejemplo: 07:00).",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Guardar en la base de datos
                DataAccess.InsertBoleto(
          valor,
          txtDestinoFinal.Text.Trim(),
          tx,
          txtRutaAbordar.Text.Trim()
      );

                MessageBox.Show(
        $"¡Boleto generado!\n" +
        $"Ruta: {txtRutaAbordar.Text}\n" +
        $"Destino: {txtDestinoFinal.Text}\n" +
        $"Hora: {tx}\n" +
        $"Valor: ${valor}"
    );

                // Mensaje con los datos ingresados
                MessageBox.Show(
                    $"¡Boleto generado y guardado exitosamente!\n\n" +
                    $"Ruta: {txtRutaAbordar.Text.Trim()}\n" +
                    $"Destino: {txtDestinoFinal.Text.Trim()}\n" +
                    $"Hora de salida: {txtHoraSalidaBoleto}\n" +
                    $"Valor: ${valor}",
                    "Boleto Generado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el boleto: " + ex.Message,
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void btnSalirBoleto_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void btnLimpiarBoleto_Click(object sender, EventArgs e)
        {
            txtValorBoleto.Clear();
            txtDestinoFinal.Clear();
            txtHoraSalidaBoleto.Clear();
            txtRutaAbordar.Clear();

        }
    }
}


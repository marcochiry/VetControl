using System.Text;

namespace VetControl
{
    public partial class Form1 : Form
    {
        private readonly string archivoMascotas = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "VetControl", "mascotas.txt");
        private bool registrosDisponibles = true;

        public Form1()
        {
            InitializeComponent();
            Load -= Form1_Load;
            Load += Form1_Load;

            btnAgregar.Click -= btnAgregar_Click;
            btnAgregar.Click += btnAgregar_Click;

            btnLimpiar.Click -= btnLimpiar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            btnColor.Click -= btnColor_Click;
            btnColor.Click += btnColor_Click;

            btnSAlir.Click -= btnSAlir_Click;
            btnSAlir.Click += btnSAlir_Click;
            eliminarToolStripMenuItem.Click -= eliminarToolStripMenuItem_Click;
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            limpiarListaToolStripMenuItem.Click -= limpiarListaToolStripMenuItem_Click;
            limpiarListaToolStripMenuItem.Click += limpiarListaToolStripMenuItem_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "VetControl - Registro de mascotas";
            lblTitulo.Font = new Font("Segoe UI", 16, FontStyle.Bold);

            txtSexo.MaxLength = 1;
            txtSexo.CharacterCasing = CharacterCasing.Upper;

            lblEtapa.AutoSize = false;
            lblEtapa.BorderStyle = BorderStyle.FixedSingle;

            LimpiarResultados();
            CargarMascotas();
            ActualizarTotal();
        }

        private void CargarMascotas()
        {
            try
            {
                if (File.Exists(archivoMascotas))
                {
                    string[] registros = File.ReadAllLines(archivoMascotas, Encoding.UTF8);
                    lstMascotas.Items.Clear();
                    foreach (string registro in registros)
                        if (!string.IsNullOrWhiteSpace(registro))
                            lstMascotas.Items.Add(registro);
                }
            }
            catch (Exception ex)
            {
                registrosDisponibles = false;
                MessageBox.Show("No se pudo recuperar la lista guardada. " +
                    "Cierre el programa y revise el archivo antes de continuar.\n" + ex.Message,
                    "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> ObtenerRegistros()
        {
            List<string> registros = new List<string>();
            foreach (object elemento in lstMascotas.Items)
                registros.Add(elemento.ToString());
            return registros;
        }

        private bool GuardarMascotas(List<string> registros)
        {
            if (!registrosDisponibles)
            {
                MessageBox.Show("La lista guardada no se pudo cargar. No se modificaron los registros.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string temporal = archivoMascotas + "." + Guid.NewGuid().ToString("N") + ".tmp";
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(archivoMascotas));
                File.WriteAllLines(temporal, registros, Encoding.UTF8);
                if (File.Exists(archivoMascotas))
                    File.Replace(temporal, archivoMascotas, null);
                else
                    File.Move(temporal, archivoMascotas);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el cambio. La lista anterior se conserva.\n" +
                    ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                try { if (File.Exists(temporal)) File.Delete(temporal); }
                catch (IOException) { }
                catch (UnauthorizedAccessException) { }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtEspecie.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtSexo.Clear();
            lstServicios.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void LimpiarResultados()
        {
            lblEtapa.Text = "-";
            lblEtapa.BackColor = Color.White;
            lblMeses.Text = "";
            lblCosto.Text = "";
            lblMensaje.Text = "";
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = "Mascotas: " + lstMascotas.Items.Count;
        }

        private void MostrarMensaje(string mensaje, Color color)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = color;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string especie = txtEspecie.Text.Trim();
            string sexo = txtSexo.Text.Trim().ToUpper();

            if (nombre == "" || especie == "" ||
                txtEdad.Text.Trim() == "" ||
                txtPeso.Text.Trim() == "" ||
                sexo == "")
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "Datos no válidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show(
                    "La edad debe ser un número entero.",
                    "Datos no válidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (edad < 0 || edad > 30)
            {
                MessageBox.Show(
                    "La edad debe estar entre 0 y 30 años.",
                    "Datos no válidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPeso.Text, out decimal peso))
            {
                MessageBox.Show(
                    "El peso debe ser un número.",
                    "Datos no válidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (peso <= 0)
            {
                MessageBox.Show(
                    "El peso debe ser mayor que 0.",
                    "Datos no válidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (sexo != "M" && sexo != "H")
            {
                MessageBox.Show(
                    "El sexo debe ser M o H.",
                    "Datos no válidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (lstServicios.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un servicio.",
                    "Datos no válidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Asignar el costo según el servicio seleccionado.
            decimal costo;

            switch (lstServicios.Text)
            {
                case "Consulta general":
                    costo = 15000m;
                    break;

                case "Vacunación":
                    costo = 20000m;
                    break;

                case "Desparasitación":
                    costo = 10000m;
                    break;

                case "Baño":
                    costo = 12000m;
                    break;

                default:
                    MessageBox.Show(
                        "Seleccione un servicio.",
                        "Datos no válidos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }
            // Convertir la letra del sexo a su nombre completo.
            char sexoLetra = sexo[0];
            string sexoCompleto;

            switch (sexoLetra)
            {
                case 'M':
                    sexoCompleto = "Macho";
                    break;

                case 'H':
                    sexoCompleto = "Hembra";
                    break;

                default:
                    MessageBox.Show(
                        "El sexo debe ser M o H.",
                        "Datos no válidos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
            }

            string etapa;

            if (edad < 1)
            {
                etapa = "Cachorro";
                lblEtapa.BackColor = Color.LightSkyBlue;
            }
            else if (edad <= 7)
            {
                etapa = "Adulto";
                lblEtapa.BackColor = Color.LightGreen;
            }
            else
            {
                etapa = "Senior";
                lblEtapa.BackColor = Color.Khaki;
            }

            int meses = edad * 12;
            decimal descuento = 0m;

            if (etapa == "Cachorro" || etapa == "Senior")
            {
                descuento = costo * 0.10m;
            }

            decimal subtotal = costo - descuento;
            decimal impuesto = subtotal * 0.13m;
            decimal total = subtotal + impuesto;

            lblEtapa.Text = etapa;
            lblMeses.Text = "Meses: " + meses;

            lblCosto.Text =
                $"Base: ₡{costo:N2}\n" +
                $"Descuento: ₡{descuento:N2}\n" +
                $"Subtotal: ₡{subtotal:N2}\n" +
                $"IVA (13 %): ₡{impuesto:N2}\n" +
                $"Total: ₡{total:N2}";

            string registro = $"{nombre} ({sexoCompleto}) - {especie} - {etapa} - {lstServicios.Text} - ₡{total:N2}";
            List<string> registros = ObtenerRegistros();
            registros.Add(registro);
            if (!GuardarMascotas(registros)) return;
            lstMascotas.Items.Add(registro);

            // Mostrar el resumen de la mascota registrada.
            MessageBox.Show(
                $"Nombre: {nombre}\n" +
                $"Servicio: {lstServicios.Text}\n" +
                $"Etapa: {etapa}\n" +
                $"Total: ₡{total:N2}",
                "Mascota registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ActualizarTotal();
            MostrarMensaje("Mascota agregada: " + nombre, Color.Green);
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            LimpiarResultados();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void btnSAlir_Click(object sender, EventArgs e)
        {
            // Cerrar únicamente si el usuario confirma.
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de VetControl?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMascotas.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Primero seleccione una mascota de la lista.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Pedir confirmación antes de eliminar.
            string mascota = lstMascotas.SelectedItem.ToString();

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar a " + mascota + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                List<string> registros = ObtenerRegistros();
                registros.RemoveAt(lstMascotas.SelectedIndex);
                if (!GuardarMascotas(registros)) return;
                lstMascotas.Items.RemoveAt(lstMascotas.SelectedIndex);
                ActualizarTotal();
            }
        }
        private void limpiarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMascotas.Items.Count == 0) return;

            DialogResult confirmar = MessageBox.Show(
                "¿Desea borrar TODOS los registros guardados? Esta acción no se puede deshacer.",
                "Borrar registros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (confirmar != DialogResult.Yes) return;

            DialogResult respuesta = MessageBox.Show(
                "¿Desea limpiar también los campos de texto?",
                "Limpiar lista", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Cancel) return;
            if (!GuardarMascotas(new List<string>())) return;

            lstMascotas.Items.Clear();
            if (respuesta == DialogResult.Yes)
            {
                LimpiarCampos();
                LimpiarResultados();
            }
            ActualizarTotal();
            MostrarMensaje("Registros borrados.", Color.Green);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void lstMascotas_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }

        private void cmsLista_Opening(
            object sender,
            System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void lstServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
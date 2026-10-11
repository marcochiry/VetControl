namespace VetControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtEspecie = new TextBox();
            txtEdad = new TextBox();
            txtSexo = new TextBox();
            txtPeso = new TextBox();
            lblEtapa = new Label();
            lblMeses = new Label();
            lblCosto = new Label();
            lblMensaje = new Label();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnColor = new Button();
            btnSAlir = new Button();
            lstMascotas = new ListBox();
            cmsLista = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            limpiarListaToolStripMenuItem = new ToolStripMenuItem();
            lblLista = new Label();
            lblTotal = new Label();
            colorDialog1 = new ColorDialog();
            lstServicios = new ListBox();
            cmsLista.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(27, 9);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(295, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Mascotas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 127);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 186);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 2;
            label2.Text = "Especie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 238);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 3;
            label3.Text = "Edad en años";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 286);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 4;
            label4.Text = "peso en Kg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 340);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 5;
            label5.Text = "Sexo (M-H)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 403);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 6;
            label6.Text = "Servicio";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.MenuHighlight;
            txtNombre.Location = new Point(183, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(264, 43);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtEspecie
            // 
            txtEspecie.BackColor = SystemColors.MenuHighlight;
            txtEspecie.Location = new Point(183, 186);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(264, 43);
            txtEspecie.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = SystemColors.MenuHighlight;
            txtEdad.Location = new Point(183, 235);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(264, 43);
            txtEdad.TabIndex = 9;
            // 
            // txtSexo
            // 
            txtSexo.BackColor = SystemColors.MenuHighlight;
            txtSexo.Location = new Point(183, 333);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(264, 43);
            txtSexo.TabIndex = 10;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = SystemColors.MenuHighlight;
            txtPeso.Location = new Point(183, 284);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(264, 43);
            txtPeso.TabIndex = 11;
            // 
            // lblEtapa
            // 
            lblEtapa.BorderStyle = BorderStyle.FixedSingle;
            lblEtapa.Location = new Point(110, 569);
            lblEtapa.Name = "lblEtapa";
            lblEtapa.Size = new Size(132, 46);
            lblEtapa.TabIndex = 13;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeses.Location = new Point(58, 558);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(71, 28);
            lblMeses.TabIndex = 14;
            lblMeses.Text = "Meses";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCosto.Location = new Point(575, 570);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(55, 23);
            lblCosto.TabIndex = 15;
            lblCosto.Text = "Costo";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(47, 678);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(91, 28);
            lblMensaje.TabIndex = 16;
            lblMensaje.Text = "Mensaje";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ButtonShadow;
            btnAgregar.Location = new Point(12, 769);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(173, 51);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonShadow;
            btnLimpiar.Location = new Point(287, 769);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 51);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnColor
            // 
            btnColor.BackColor = SystemColors.ButtonShadow;
            btnColor.Location = new Point(549, 769);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(173, 51);
            btnColor.TabIndex = 19;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // 
            // btnSAlir
            // 
            btnSAlir.BackColor = SystemColors.ButtonShadow;
            btnSAlir.Location = new Point(767, 769);
            btnSAlir.Name = "btnSAlir";
            btnSAlir.Size = new Size(173, 51);
            btnSAlir.TabIndex = 20;
            btnSAlir.Text = "Salir";
            btnSAlir.UseVisualStyleBackColor = false;
            btnSAlir.Click += btnSAlir_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.BackColor = SystemColors.ScrollBar;
            lstMascotas.ContextMenuStrip = cmsLista;
            lstMascotas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(787, 127);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(635, 172);
            lstMascotas.TabIndex = 21;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // cmsLista
            // 
            cmsLista.ImageScalingSize = new Size(20, 20);
            cmsLista.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem, limpiarListaToolStripMenuItem });
            cmsLista.Name = "cmsLista";
            cmsLista.Size = new Size(160, 52);
            cmsLista.Opening += cmsLista_Opening;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(159, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // limpiarListaToolStripMenuItem
            // 
            limpiarListaToolStripMenuItem.Name = "limpiarListaToolStripMenuItem";
            limpiarListaToolStripMenuItem.Size = new Size(159, 24);
            limpiarListaToolStripMenuItem.Text = "Limpiar lista";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(972, 63);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(291, 38);
            lblLista.TabIndex = 22;
            lblLista.Text = "Mascotas registradas";
            lblLista.Click += lblTotal_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1072, 351);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(171, 38);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Mascotas: 0";
            // 
            // lstServicios
            // 
            lstServicios.BackColor = SystemColors.MenuHighlight;
            lstServicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstServicios.FormattingEnabled = true;
            lstServicios.Items.AddRange(new object[] { "Consulta general", "Vacunación", "Desparasitación", "Baño" });
            lstServicios.Location = new Point(183, 382);
            lstServicios.Name = "lstServicios";
            lstServicios.Size = new Size(291, 144);
            lstServicios.TabIndex = 24;
            lstServicios.SelectedIndexChanged += lstServicios_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1600, 832);
            ContextMenuStrip = cmsLista;
            Controls.Add(lstServicios);
            Controls.Add(lblTotal);
            Controls.Add(lblLista);
            Controls.Add(lstMascotas);
            Controls.Add(btnSAlir);
            Controls.Add(btnColor);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(lblMensaje);
            Controls.Add(lblCosto);
            Controls.Add(lblMeses);
            Controls.Add(lblEtapa);
            Controls.Add(txtPeso);
            Controls.Add(txtSexo);
            Controls.Add(txtEdad);
            Controls.Add(txtEspecie);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Load += Form1_Load;
            EnabledChanged += Form1_EnabledChanged;
            cmsLista.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEspecie;
        private TextBox txtEdad;
        private TextBox txtSexo;
        private TextBox txtPeso;
        private Label lblEtapa;
        private Label lblMeses;
        private Label lblCosto;
        private Label lblMensaje;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnColor;
        private Button btnSAlir;
        private ListBox lstMascotas;
        private Label lblLista;
        private Label lblTotal;
        private ContextMenuStrip cmsLista;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem limpiarListaToolStripMenuItem;
        private ListBox lstServicios;
    }
}

namespace Seprise
{
    partial class FormPaciente
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlTarjetaContenedor;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblSeccionDatos;
        private System.Windows.Forms.Label lblNota;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblSeccionDatos = new System.Windows.Forms.Label();
            
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlTarjetaContenedor = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNota = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlTarjetaContenedor.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            var colorTealSePrice = System.Drawing.Color.FromArgb(0, 150, 136);
            var colorTextoOscuro = System.Drawing.Color.FromArgb(33, 33, 33);
            var colorTextoGrisClaro = System.Drawing.Color.FromArgb(220, 240, 235);
            var colorFondoGrisForm = System.Drawing.Color.FromArgb(238, 242, 243);
            var colorNotaFondo = System.Drawing.Color.FromArgb(198, 234, 212);
            var colorNotaTexto = System.Drawing.Color.FromArgb(0, 75, 68);

            var fontTitulo = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            var fontSubtitulo = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            var fontSeccion = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            var fontLabels = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            var fontControles = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            var fontBotones = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.pnlHeader.BackColor = colorTealSePrice;
            this.pnlHeader.Controls.Add(this.lblIcono);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 75);
            this.pnlHeader.TabIndex = 0;

            this.lblIcono.AutoSize = true;
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblIcono.ForeColor = System.Drawing.Color.White;
            this.lblIcono.Location = new System.Drawing.Point(18, 16);
            this.lblIcono.Size = new System.Drawing.Size(47, 37);
            this.lblIcono.Text = "👤";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = fontTitulo;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(75, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 32);
            this.lblTitulo.Text = "Crear paciente";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = fontSubtitulo;
            this.lblSubtitulo.ForeColor = colorTextoGrisClaro;
            this.lblSubtitulo.Location = new System.Drawing.Point(77, 48);
            this.lblSubtitulo.Size = new System.Drawing.Size(350, 15);
            this.lblSubtitulo.Text = "Complete los datos para administrar la información del paciente.";

            this.pnlTarjetaContenedor.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaContenedor.Controls.Add(this.lblSeccionDatos);
            this.pnlTarjetaContenedor.Controls.Add(this.lblDNI);
            this.pnlTarjetaContenedor.Controls.Add(this.txtDNI);
            this.pnlTarjetaContenedor.Controls.Add(this.lblNombre);
            this.pnlTarjetaContenedor.Controls.Add(this.txtNombre);
            this.pnlTarjetaContenedor.Controls.Add(this.lblApellido);
            this.pnlTarjetaContenedor.Controls.Add(this.txtApellido);
            this.pnlTarjetaContenedor.Controls.Add(this.lblTelefono);
            this.pnlTarjetaContenedor.Controls.Add(this.txtTelefono);
            this.pnlTarjetaContenedor.Controls.Add(this.lblEmail);
            this.pnlTarjetaContenedor.Controls.Add(this.txtEmail);
            this.pnlTarjetaContenedor.Controls.Add(this.lblDireccion);
            this.pnlTarjetaContenedor.Controls.Add(this.txtDireccion);
            this.pnlTarjetaContenedor.Controls.Add(this.lblFechaNacimiento);
            this.pnlTarjetaContenedor.Controls.Add(this.dtpFechaNacimiento);
            this.pnlTarjetaContenedor.Controls.Add(this.lblObraSocial);
            this.pnlTarjetaContenedor.Controls.Add(this.cboObraSocial);
            this.pnlTarjetaContenedor.Controls.Add(this.btnGuardar);
            this.pnlTarjetaContenedor.Location = new System.Drawing.Point(24, 95);
            this.pnlTarjetaContenedor.Name = "pnlTarjetaContenedor";
            this.pnlTarjetaContenedor.Size = new System.Drawing.Size(552, 385); 
            this.pnlTarjetaContenedor.TabIndex = 1;

            this.lblSeccionDatos.AutoSize = true;
            this.lblSeccionDatos.Font = fontSeccion;
            this.lblSeccionDatos.ForeColor = colorTealSePrice;
            this.lblSeccionDatos.Location = new System.Drawing.Point(20, 15);
            this.lblSeccionDatos.Size = new System.Drawing.Size(200, 17);
            this.lblSeccionDatos.Text = "📄 DATOS DEL PACIENTE";

            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = fontLabels;
            this.lblDNI.ForeColor = colorTextoOscuro;
            this.lblDNI.Location = new System.Drawing.Point(20, 45);
            this.lblDNI.Size = new System.Drawing.Size(31, 17);
            this.lblDNI.Text = "DNI";

            this.txtDNI.Font = fontControles;
            this.txtDNI.Location = new System.Drawing.Point(20, 67);
            this.txtDNI.Mask = "000000000000000";
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PromptChar = ' ';
            this.txtDNI.Size = new System.Drawing.Size(240, 24);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;

            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = fontLabels;
            this.lblTelefono.ForeColor = colorTextoOscuro;
            this.lblTelefono.Location = new System.Drawing.Point(290, 45);
            this.lblTelefono.Size = new System.Drawing.Size(62, 17);
            this.lblTelefono.Text = "Teléfono";

            this.txtTelefono.Font = fontControles;
            this.txtTelefono.Location = new System.Drawing.Point(290, 67);
            this.txtTelefono.Mask = "000000000000000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PromptChar = ' ';
            this.txtTelefono.Size = new System.Drawing.Size(240, 24);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;

            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = fontLabels;
            this.lblNombre.ForeColor = colorTextoOscuro;
            this.lblNombre.Location = new System.Drawing.Point(20, 105);
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.Text = "Nombre";

            this.txtNombre.Font = fontControles;
            this.txtNombre.Location = new System.Drawing.Point(20, 127);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 24);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);

            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = fontLabels;
            this.lblApellido.ForeColor = colorTextoOscuro;
            this.lblApellido.Location = new System.Drawing.Point(290, 105);
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.Text = "Apellido";

            this.txtApellido.Font = fontControles;
            this.txtApellido.Location = new System.Drawing.Point(290, 127);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(240, 24);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);

            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = fontLabels;
            this.lblEmail.ForeColor = colorTextoOscuro;
            this.lblEmail.Location = new System.Drawing.Point(20, 165);
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.Text = "Email";

            this.txtEmail.Font = fontControles;
            this.txtEmail.Location = new System.Drawing.Point(20, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(510, 24);
            this.txtEmail.TabIndex = 6;

            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = fontLabels;
            this.lblDireccion.ForeColor = colorTextoOscuro;
            this.lblDireccion.Location = new System.Drawing.Point(20, 225);
            this.lblDireccion.Size = new System.Drawing.Size(66, 17);
            this.lblDireccion.Text = "Dirección";

            this.txtDireccion.Font = fontControles;
            this.txtDireccion.Location = new System.Drawing.Point(20, 247);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(510, 24);
            this.txtDireccion.TabIndex = 7;

            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = fontLabels;
            this.lblFechaNacimiento.ForeColor = colorTextoOscuro;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 285);
            this.lblFechaNacimiento.Size = new System.Drawing.Size(137, 17);
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";

            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Font = fontControles;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(20, 307);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(240, 24);
            this.dtpFechaNacimiento.TabIndex = 8;

            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = fontLabels;
            this.lblObraSocial.ForeColor = colorTextoOscuro;
            this.lblObraSocial.Location = new System.Drawing.Point(290, 285);
            this.lblObraSocial.Size = new System.Drawing.Size(78, 17);
            this.lblObraSocial.Text = "Obra Social";

            this.cboObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObraSocial.Font = fontControles;
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Items.AddRange(new object[] { "OSDE","Swiss Medical","IOMA","PAMI","Particular","GALENO","OSECAC","MEDIFE","SANCOR SALUD" });
            this.cboObraSocial.Location = new System.Drawing.Point(290, 307);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(240, 25);
            this.cboObraSocial.TabIndex = 9;

            this.btnGuardar.BackColor = colorTealSePrice;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = fontBotones;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(20, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(510, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "💾 Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 490);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(600, 80);
            this.pnlFooter.TabIndex = 11;

            this.lblNota.BackColor = colorNotaFondo;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblNota.ForeColor = colorNotaTexto;
            this.lblNota.Location = new System.Drawing.Point(24, 10);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.lblNota.Size = new System.Drawing.Size(400, 55);
            this.lblNota.Text = "ℹ   Los datos de cobertura médica cargados impactarán directamente sobre la validación de turnos y las órdenes del paciente.";

            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 210);
            this.btnCancelar.Font = fontBotones;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancelar.Location = new System.Drawing.Point(448, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "🚪 Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondoGrisForm;
            this.ClientSize = new System.Drawing.Size(600, 570);
            
            this.Controls.Add(this.pnlTarjetaContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SePrice - Administrar Paciente";
            this.Load += new System.EventHandler(this.FormPaciente_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTarjetaContenedor.ResumeLayout(false);
            this.pnlTarjetaContenedor.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
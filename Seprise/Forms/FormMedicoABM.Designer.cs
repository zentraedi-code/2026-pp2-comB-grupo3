namespace Seprise
{
    partial class FormMedicoABM
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblSeccionDatos;
        
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblHonorario;
        private System.Windows.Forms.TextBox txtHonorario;
        
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlTarjetaContenedor;
        private System.Windows.Forms.Panel pnlFooter;
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
            
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblHonorario = new System.Windows.Forms.Label();
            this.txtHonorario = new System.Windows.Forms.TextBox();
            
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
            this.lblTitulo.Text = "Gestionar Médico";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = fontSubtitulo;
            this.lblSubtitulo.ForeColor = colorTextoGrisClaro;
            this.lblSubtitulo.Location = new System.Drawing.Point(77, 48);
            this.lblSubtitulo.Size = new System.Drawing.Size(350, 15);
            this.lblSubtitulo.Text = "Complete los datos para administrar la información del profesional.";

            this.pnlTarjetaContenedor.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaContenedor.Controls.Add(this.lblSeccionDatos);
            this.pnlTarjetaContenedor.Controls.Add(this.lblMatricula);
            this.pnlTarjetaContenedor.Controls.Add(this.txtMatricula);
            this.pnlTarjetaContenedor.Controls.Add(this.lblNombre);
            this.pnlTarjetaContenedor.Controls.Add(this.txtNombre);
            this.pnlTarjetaContenedor.Controls.Add(this.lblApellido);
            this.pnlTarjetaContenedor.Controls.Add(this.txtApellido);
            this.pnlTarjetaContenedor.Controls.Add(this.lblEspecialidad);
            this.pnlTarjetaContenedor.Controls.Add(this.cmbEspecialidad);
            this.pnlTarjetaContenedor.Controls.Add(this.lblHonorario);
            this.pnlTarjetaContenedor.Controls.Add(this.txtHonorario);
            this.pnlTarjetaContenedor.Controls.Add(this.btnGuardar);
            this.pnlTarjetaContenedor.Location = new System.Drawing.Point(24, 95);
            this.pnlTarjetaContenedor.Name = "pnlTarjetaContenedor";
            this.pnlTarjetaContenedor.Size = new System.Drawing.Size(552, 290);
            this.pnlTarjetaContenedor.TabIndex = 1;

            this.lblSeccionDatos.AutoSize = true;
            this.lblSeccionDatos.Font = fontSeccion;
            this.lblSeccionDatos.ForeColor = colorTealSePrice;
            this.lblSeccionDatos.Location = new System.Drawing.Point(20, 18);
            this.lblSeccionDatos.Size = new System.Drawing.Size(200, 17);
            this.lblSeccionDatos.Text = "📄 DATOS DEL PROFESIONAL";

            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = fontLabels;
            this.lblMatricula.ForeColor = colorTextoOscuro;
            this.lblMatricula.Location = new System.Drawing.Point(20, 52);
            this.lblMatricula.Size = new System.Drawing.Size(64, 17);
            this.lblMatricula.Text = "Matrícula";

            this.txtMatricula.Font = fontControles;
            this.txtMatricula.Location = new System.Drawing.Point(20, 74);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PlaceholderText = "Ej: MN12345";
            this.txtMatricula.Size = new System.Drawing.Size(240, 24);
            this.txtMatricula.TabIndex = 2;

            this.lblHonorario.AutoSize = true;
            this.lblHonorario.Font = fontLabels;
            this.lblHonorario.ForeColor = colorTextoOscuro;
            this.lblHonorario.Location = new System.Drawing.Point(290, 52);
            this.lblHonorario.Size = new System.Drawing.Size(70, 17);
            this.lblHonorario.Text = "Honorario";

            this.txtHonorario.Font = fontControles;
            this.txtHonorario.Location = new System.Drawing.Point(290, 74);
            this.txtHonorario.Name = "txtHonorario";
            this.txtHonorario.PlaceholderText = "Ej: 15000";
            this.txtHonorario.Size = new System.Drawing.Size(240, 24);
            this.txtHonorario.TabIndex = 3;

            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = fontLabels;
            this.lblNombre.ForeColor = colorTextoOscuro;
            this.lblNombre.Location = new System.Drawing.Point(20, 115);
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.Text = "Nombre";

            this.txtNombre.Font = fontControles;
            this.txtNombre.Location = new System.Drawing.Point(20, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 24);
            this.txtNombre.TabIndex = 4;

            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = fontLabels;
            this.lblApellido.ForeColor = colorTextoOscuro;
            this.lblApellido.Location = new System.Drawing.Point(290, 115);
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.Text = "Apellido";

            this.txtApellido.Font = fontControles;
            this.txtApellido.Location = new System.Drawing.Point(290, 137);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(240, 24);
            this.txtApellido.TabIndex = 5;

            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = fontLabels;
            this.lblEspecialidad.ForeColor = colorTextoOscuro;
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 180);
            this.lblEspecialidad.Size = new System.Drawing.Size(84, 17);
            this.lblEspecialidad.Text = "Especialidad";

            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Font = fontControles;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(20, 202);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(510, 25);
            this.cmbEspecialidad.TabIndex = 6;

            this.btnGuardar.BackColor = colorTealSePrice;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = fontBotones;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(20, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(508, 42); 
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "💾 Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 460);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(600, 80);
            this.pnlFooter.TabIndex = 8;

            this.lblNota.BackColor = colorNotaFondo;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblNota.ForeColor = colorNotaTexto;
            this.lblNota.Location = new System.Drawing.Point(24, 10);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.lblNota.Size = new System.Drawing.Size(400, 55);
            this.lblNota.Text = "ℹ  Los honorarios cargados impactarán de forma automática en los próximos cálculos de liquidación del profesional.";

            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 210);
            this.btnCancelar.Font = fontBotones;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancelar.Location = new System.Drawing.Point(448, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "🚪 Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondoGrisForm;
            this.ClientSize = new System.Drawing.Size(600, 470);
            
            this.Controls.Add(this.pnlTarjetaContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedicoABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SePrice - Administrar Médico";
            
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTarjetaContenedor.ResumeLayout(false);
            this.pnlTarjetaContenedor.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
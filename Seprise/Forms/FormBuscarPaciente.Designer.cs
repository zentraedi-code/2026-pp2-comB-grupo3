namespace Seprise
{
    partial class FormBuscarPaciente
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlTarjetaContenedor;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblNota;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLeyendaDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblLeyendaNomApe;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnSeleccionar; 
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            
            this.pnlTarjetaContenedor = new System.Windows.Forms.Panel();
            this.lblLeyendaDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblLeyendaNomApe = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            
            this.btnSeleccionar = new System.Windows.Forms.Button(); 
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlTarjetaContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            var colorTealSePrice = System.Drawing.Color.FromArgb(0, 150, 136);
            var colorTextoOscuro = System.Drawing.Color.FromArgb(33, 33, 33);
            var colorTextoGrisClaro = System.Drawing.Color.FromArgb(220, 240, 235);
            var colorFondoGrisForm = System.Drawing.Color.FromArgb(238, 242, 243);
            var colorNotaFondo = System.Drawing.Color.FromArgb(230, 242, 240);
            var colorNotaTexto = System.Drawing.Color.FromArgb(0, 75, 68);

            var fontTitulo = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            var fontSubtitulo = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            var fontLabels = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            var fontControles = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            var fontBotones = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.pnlHeader.BackColor = colorTealSePrice;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(680, 68);
            this.pnlHeader.TabIndex = 0;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = fontTitulo;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 25);
            this.lblTitulo.Text = "👤 Buscar Paciente";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = fontSubtitulo;
            this.lblSubtitulo.ForeColor = colorTextoGrisClaro;
            this.lblSubtitulo.Location = new System.Drawing.Point(18, 40);
            this.lblSubtitulo.Text = "Filtre por documento o apellido para asignar al turno médico.";

            this.pnlTarjetaContenedor.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaContenedor.Controls.Add(this.lblLeyendaDni);
            this.pnlTarjetaContenedor.Controls.Add(this.txtDni);
            this.pnlTarjetaContenedor.Controls.Add(this.lblLeyendaNomApe);
            this.pnlTarjetaContenedor.Controls.Add(this.txtNombreApellido);
            this.pnlTarjetaContenedor.Controls.Add(this.btnBuscar);
            this.pnlTarjetaContenedor.Controls.Add(this.dgvPacientes);
            this.pnlTarjetaContenedor.Location = new System.Drawing.Point(16, 84);
            this.pnlTarjetaContenedor.Name = "pnlTarjetaContenedor";
            this.pnlTarjetaContenedor.Size = new System.Drawing.Size(648, 185); 
            this.pnlTarjetaContenedor.TabIndex = 1;

            this.lblLeyendaDni.AutoSize = true;
            this.lblLeyendaDni.Font = fontLabels;
            this.lblLeyendaDni.ForeColor = colorTextoOscuro;
            this.lblLeyendaDni.Location = new System.Drawing.Point(16, 16);
            this.lblLeyendaDni.Name = "lblLeyendaDni";
            this.lblLeyendaDni.Size = new System.Drawing.Size(32, 15);
            this.lblLeyendaDni.Text = "DNI:";

            this.txtDni.Font = fontControles;
            this.txtDni.Location = new System.Drawing.Point(16, 36);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(150, 24);
            this.txtDni.TabIndex = 2;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCampo_KeyDown);

            this.lblLeyendaNomApe.AutoSize = true;
            this.lblLeyendaNomApe.Font = fontLabels;
            this.lblLeyendaNomApe.ForeColor = colorTextoOscuro;
            this.lblLeyendaNomApe.Location = new System.Drawing.Point(182, 16);
            this.lblLeyendaNomApe.Name = "lblLeyendaNomApe";
            this.lblLeyendaNomApe.Size = new System.Drawing.Size(56, 15);
            this.lblLeyendaNomApe.Text = "Apellido:";

            this.txtNombreApellido.Font = fontControles;
            this.txtNombreApellido.Location = new System.Drawing.Point(182, 36);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(315, 24);
            this.txtNombreApellido.TabIndex = 4;
            this.txtNombreApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCampo_KeyDown);

            this.btnBuscar.BackColor = colorTealSePrice;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = fontBotones;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(512, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(16, 78);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(616, 90);
            this.dgvPacientes.TabIndex = 6;
            this.dgvPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellContentClick);
            this.dgvPacientes.SelectionChanged += new System.EventHandler(this.dgvPacientes_SelectionChanged);

            this.btnSeleccionar.BackColor = colorTealSePrice;
            this.btnSeleccionar.Enabled = true;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = fontBotones;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(16, 282); 
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(648, 35);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "✓ Seleccionar Paciente";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);

            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 335); 
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(680, 65);
            this.pnlFooter.TabIndex = 7;

            this.lblNota.AutoSize = false;
            this.lblNota.BackColor = System.Drawing.Color.FromArgb(198, 234, 212);
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNota.ForeColor = colorNotaTexto;
            this.lblNota.Location = new System.Drawing.Point(16, 8);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lblNota.Size = new System.Drawing.Size(350, 48);
            this.lblNota.Text = "ℹ Seleccione la fila del paciente y confirme los datos presionando Seleccionar.";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 210);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = fontBotones;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancelar.Location = new System.Drawing.Point(544, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "🚪 Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondoGrisForm;
            this.ClientSize = new System.Drawing.Size(690, 430); 
            this.ControlBox = false;
            
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.pnlTarjetaContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SePrice - Buscar Paciente";
            
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTarjetaContenedor.ResumeLayout(false);
            this.pnlTarjetaContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
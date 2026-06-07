namespace Seprise
{
    partial class FormPacientesPendientes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvCola;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFiltrosContenedor;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblSeccionFiltros;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnCancelar; 

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
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFiltrosContenedor = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblSeccionFiltros = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltrosContenedor.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(900, 75);
            this.pnlHeader.TabIndex = 0;

            this.lblIcono.AutoSize = true;
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblIcono.ForeColor = System.Drawing.Color.White;
            this.lblIcono.Location = new System.Drawing.Point(18, 16);
            this.lblIcono.Size = new System.Drawing.Size(47, 37);
            this.lblIcono.Text = "⏳";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = fontTitulo;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(75, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 32);
            this.lblTitulo.Text = "Pacientes Pendientes";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = fontSubtitulo;
            this.lblSubtitulo.ForeColor = colorTextoGrisClaro;
            this.lblSubtitulo.Location = new System.Drawing.Point(77, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(560, 15);
            this.lblSubtitulo.Text = "Pacientes recepcionados que todavía no fueron atendidos, ordenados por fecha/hora de recepción.";

            this.pnlFiltrosContenedor.BackColor = System.Drawing.Color.White;
            this.pnlFiltrosContenedor.Controls.Add(this.lblSeccionFiltros);
            this.pnlFiltrosContenedor.Controls.Add(this.lblMedico);
            this.pnlFiltrosContenedor.Controls.Add(this.cmbMedico);
            this.pnlFiltrosContenedor.Controls.Add(this.lblFecha);
            this.pnlFiltrosContenedor.Controls.Add(this.dtpFecha);
            this.pnlFiltrosContenedor.Controls.Add(this.btnActualizar);
            this.pnlFiltrosContenedor.Location = new System.Drawing.Point(20, 95);
            this.pnlFiltrosContenedor.Name = "pnlFiltrosContenedor";
            this.pnlFiltrosContenedor.Size = new System.Drawing.Size(860, 100);
            this.pnlFiltrosContenedor.TabIndex = 1;

            this.lblSeccionFiltros.AutoSize = true;
            this.lblSeccionFiltros.Font = fontSeccion;
            this.lblSeccionFiltros.ForeColor = colorTealSePrice;
            this.lblSeccionFiltros.Location = new System.Drawing.Point(15, 12);
            this.lblSeccionFiltros.Size = new System.Drawing.Size(160, 17);
            this.lblSeccionFiltros.Text = "🔍 FILTROS DE BÚSQUEDA";

            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = fontLabels;
            this.lblMedico.ForeColor = colorTextoOscuro;
            this.lblMedico.Location = new System.Drawing.Point(15, 40);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(53, 17);
            this.lblMedico.Text = "Médico";

            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.Font = fontControles;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(15, 60);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(320, 25);
            this.cmbMedico.TabIndex = 3;

            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = fontLabels;
            this.lblFecha.ForeColor = colorTextoOscuro;
            this.lblFecha.Location = new System.Drawing.Point(360, 40);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 17);
            this.lblFecha.Text = "Fecha";

            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = fontControles;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(360, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(180, 24);
            this.dtpFecha.TabIndex = 5;

            this.btnActualizar.BackColor = colorTealSePrice;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = fontBotones;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(665, 52);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 32);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "🔄 Actualizar lista";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.dgvCola.BackgroundColor = System.Drawing.Color.White;
            this.dgvCola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCola.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            headerStyle.BackColor = colorTealSePrice;
            headerStyle.Font = fontLabels;
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = colorTealSePrice;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCola.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvCola.EnableHeadersVisualStyles = false;

            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            cellStyle.Font = fontControles;
            cellStyle.ForeColor = colorTextoOscuro;
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 240, 235);
            cellStyle.SelectionForeColor = colorTextoOscuro;
            this.dgvCola.DefaultCellStyle = cellStyle;

            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Location = new System.Drawing.Point(20, 215);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowTemplate.Height = 30;
            this.dgvCola.Size = new System.Drawing.Size(860, 290); 
            this.dgvCola.TabIndex = 7;
            this.dgvCola.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCola_CellClick);

            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 525);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 85);
            this.pnlFooter.TabIndex = 8;

            this.lblNota.BackColor = colorNotaFondo;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblNota.ForeColor = colorNotaTexto;
            this.lblNota.Location = new System.Drawing.Point(20, 15);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.lblNota.Size = new System.Drawing.Size(620, 55);
            this.lblNota.Text = "ℹ   Haga clic sobre una fila de la grilla para gestionar la llamada o el cambio de estado en la sala de espera en tiempo real.";

            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 210);
            this.btnCancelar.Font = fontBotones;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancelar.Location = new System.Drawing.Point(732, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(148, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "🚪 Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += (s, e) => { this.Close(); };

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondoGrisForm;
            this.ClientSize = new System.Drawing.Size(900, 590); 
            
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.pnlFiltrosContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPacientesPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SePrice - Monitoreo de Pacientes Pendientes";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltrosContenedor.ResumeLayout(false);
            this.pnlFiltrosContenedor.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
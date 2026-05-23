namespace Seprise
{
    partial class FormReservarTurnoMedico
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnPrimeraDisponible;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnSalir;

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
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPrimeraDisponible = new System.Windows.Forms.Button();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CU07 - Reservar turno médico";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Muestra primera fecha disponible y permite consultar disponibilidad por otra fecha.";

            // lblEspecialidad
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 90);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(72, 15);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad";

            // cmbEspecialidad
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(20, 110);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(250, 23);
            this.cmbEspecialidad.TabIndex = 3;

            // lblProfesional
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(290, 90);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(66, 15);
            this.lblProfesional.TabIndex = 4;
            this.lblProfesional.Text = "Profesional";

            // cmbProfesional
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(290, 110);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(250, 23);
            this.cmbProfesional.TabIndex = 5;

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(560, 90);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 15);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha deseada";

            // dtpFecha
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(560, 110);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 7;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(20, 150);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar disponibilidad";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // btnPrimeraDisponible
            this.btnPrimeraDisponible.Location = new System.Drawing.Point(180, 150);
            this.btnPrimeraDisponible.Name = "btnPrimeraDisponible";
            this.btnPrimeraDisponible.Size = new System.Drawing.Size(150, 30);
            this.btnPrimeraDisponible.TabIndex = 9;
            this.btnPrimeraDisponible.Text = "Primera disponible";
            this.btnPrimeraDisponible.UseVisualStyleBackColor = true;
            this.btnPrimeraDisponible.Click += new System.EventHandler(this.btnPrimeraDisponible_Click);

            // dgvTurnos
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(20, 200);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowTemplate.Height = 25;
            this.dgvTurnos.Size = new System.Drawing.Size(860, 300);
            this.dgvTurnos.TabIndex = 10;
            this.dgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellClick);

            // lblNota
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(20, 510);
            this.lblNota.Name = "lblNota";
            this.lblNota.TabIndex = 11;
            this.lblNota.Text = "El DNI del paciente se solicita recién al presionar Reservar.";

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(780, 505);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // FormReservarTurnoMedico
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.btnPrimeraDisponible);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReservarTurnoMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservar turno médico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

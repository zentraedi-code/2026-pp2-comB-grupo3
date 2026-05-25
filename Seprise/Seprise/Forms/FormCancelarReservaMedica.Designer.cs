namespace Seprise
{
    partial class FormCancelarReservaMedica
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
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
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.lblTitulo.Text = "CU08 - Cancelar reserva de turno médico";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "El paciente cancela la reserva. El turno vuelve a quedar disponible.";

            // lblDniPaciente
            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Location = new System.Drawing.Point(20, 90);
            this.lblDniPaciente.Name = "lblDniPaciente";
            this.lblDniPaciente.Size = new System.Drawing.Size(95, 15);
            this.lblDniPaciente.TabIndex = 2;
            this.lblDniPaciente.Text = "DNI del paciente";

            // txtDniPaciente
            this.txtDniPaciente.Location = new System.Drawing.Point(20, 110);
            this.txtDniPaciente.Name = "txtDniPaciente";
            this.txtDniPaciente.PlaceholderText = "Ej: 30111222";
            this.txtDniPaciente.Size = new System.Drawing.Size(200, 23);
            this.txtDniPaciente.TabIndex = 3;

            // btnBuscarPaciente
            this.btnBuscarPaciente.Location = new System.Drawing.Point(230, 110);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPaciente.TabIndex = 4;
            this.btnBuscarPaciente.Text = "🔍 Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);

            // lblPaciente
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(320, 90);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 15);
            this.lblPaciente.TabIndex = 5;
            this.lblPaciente.Text = "Paciente";

            // txtPaciente
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(320, 110);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(300, 23);
            this.txtPaciente.TabIndex = 6;

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 150);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(84, 15);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha del turno";

            // dtpFecha
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(20, 170);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 23);
            this.dtpFecha.TabIndex = 8;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(20, 210);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar turnos reservados";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // dgvTurnos
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(20, 260);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowTemplate.Height = 25;
            this.dgvTurnos.Size = new System.Drawing.Size(860, 250);
            this.dgvTurnos.TabIndex = 10;
            this.dgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnos_CellClick);

            // lblNota
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(20, 520);
            this.lblNota.Name = "lblNota";
            this.lblNota.TabIndex = 11;
            this.lblNota.Text = "Al cancelar: se desasigna el paciente, se borra fecha de reserva y el turno vuelve a DISPONIBLE.";

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(780, 515);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // FormCancelarReservaMedica
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txtDniPaciente);
            this.Controls.Add(this.lblDniPaciente);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCancelarReservaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancelar reserva de turno médico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

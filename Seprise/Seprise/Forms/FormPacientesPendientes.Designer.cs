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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pacientes Pendientes";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Pacientes recepcionados que todavía no fueron atendidos, ordenados por fecha/hora de recepción.";

            // lblMedico
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(20, 90);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(47, 15);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Médico";

            // cmbMedico
            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(20, 110);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(300, 23);
            this.cmbMedico.TabIndex = 3;

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(340, 90);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";

            // dtpFecha
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(340, 110);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 5;

            // btnActualizar
            this.btnActualizar.Location = new System.Drawing.Point(20, 150);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 30);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // dgvCola
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Location = new System.Drawing.Point(20, 200);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowTemplate.Height = 25;
            this.dgvCola.Size = new System.Drawing.Size(860, 330);
            this.dgvCola.TabIndex = 7;
            this.dgvCola.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCola_CellClick);

            // FormPacientesPendientes
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPacientesPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pacientes Pendientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

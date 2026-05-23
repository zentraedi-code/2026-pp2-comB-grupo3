namespace Seprise
{
    partial class FormCancelarAgendaMedica
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvAgendas;
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvAgendas = new System.Windows.Forms.DataGridView();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CU07 - Cancelar agenda médica";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Cancela la agenda médica y elimina todos los turnos asociados.";

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(20, 90);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(82, 15);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar agenda";

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(20, 110);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Fecha / médico / consultorio";
            this.txtBuscar.Size = new System.Drawing.Size(300, 23);
            this.txtBuscar.TabIndex = 3;

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(340, 90);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(42, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";

            // cmbEstado
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(340, 110);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 23);
            this.cmbEstado.TabIndex = 5;

            // dgvAgendas
            this.dgvAgendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendas.Location = new System.Drawing.Point(20, 150);
            this.dgvAgendas.Name = "dgvAgendas";
            this.dgvAgendas.RowTemplate.Height = 25;
            this.dgvAgendas.Size = new System.Drawing.Size(860, 300);
            this.dgvAgendas.TabIndex = 6;
            this.dgvAgendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendas_CellClick);

            // lblNota
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(20, 460);
            this.lblNota.Name = "lblNota";
            this.lblNota.TabIndex = 7;
            this.lblNota.Text = "Al cancelar, el sistema elimina todos los turnos asociados a esta agenda.";

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(780, 455);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // FormCancelarAgendaMedica
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.dgvAgendas);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCancelarAgendaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancelar agenda médica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

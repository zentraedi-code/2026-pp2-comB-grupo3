namespace Seprise
{
    partial class FormConfirmarAgendaMedica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpFiltros = new GroupBox();
            chkFecha = new CheckBox();
            dtpFecha = new DateTimePicker();
            lblMedico = new Label();
            cmbMedico = new ComboBox();
            btnBuscar = new Button();
            dgvAgendas = new DataGridView();
            lblNota = new Label();
            btnSalir = new Button();
            grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendas).BeginInit();
            SuspendLayout();

            lblTitulo.BackColor = Color.FromArgb(30, 107, 160);
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(900, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "   Confirmar agenda médica";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            grpFiltros.Location = new Point(15, 62);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(870, 70);
            grpFiltros.TabIndex = 1;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros de búsqueda";

            chkFecha.AutoSize = true;
            chkFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFecha.Location = new Point(12, 26);
            chkFecha.Name = "chkFecha";
            chkFecha.Size = new Size(56, 19);
            chkFecha.TabIndex = 0;
            chkFecha.Text = "Fecha:";
            chkFecha.CheckedChanged += chkFecha_CheckedChanged;

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(75, 24);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(140, 23);
            dtpFecha.TabIndex = 1;

            lblMedico.AutoSize = true;
            lblMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedico.Location = new Point(230, 27);
            lblMedico.Name = "lblMedico";
            lblMedico.TabIndex = 2;
            lblMedico.Text = "Médico:";

            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(285, 24);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(280, 23);
            cmbMedico.TabIndex = 3;

            btnBuscar.BackColor = Color.FromArgb(30, 107, 160);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(580, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 28);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;

            grpFiltros.Controls.Add(chkFecha);
            grpFiltros.Controls.Add(dtpFecha);
            grpFiltros.Controls.Add(lblMedico);
            grpFiltros.Controls.Add(cmbMedico);
            grpFiltros.Controls.Add(btnBuscar);

            dgvAgendas.AllowUserToAddRows = false;
            dgvAgendas.AllowUserToDeleteRows = false;
            dgvAgendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgendas.Location = new Point(15, 144);
            dgvAgendas.Name = "dgvAgendas";
            dgvAgendas.ReadOnly = true;
            dgvAgendas.RowTemplate.Height = 25;
            dgvAgendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendas.Size = new Size(870, 290);
            dgvAgendas.TabIndex = 2;
            dgvAgendas.CellClick += dgvAgendas_CellClick;

            lblNota.BackColor = Color.FromArgb(232, 244, 248);
            lblNota.BorderStyle = BorderStyle.FixedSingle;
            lblNota.Location = new Point(15, 444);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(6, 4, 6, 4);
            lblNota.Size = new Size(760, 28);
            lblNota.TabIndex = 3;
            lblNota.Text = "Al confirmar, el sistema crea turnos en estado DISPONIBLE y agrega 1 sobreturno por hora.";

            btnSalir.BackColor = Color.FromArgb(100, 149, 180);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(785, 440);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 32);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 487);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(lblNota);
            Controls.Add(dgvAgendas);
            Controls.Add(grpFiltros);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfirmarAgendaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar Agenda Médica - Sistema SEPRISE";
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendas).EndInit();
            ResumeLayout(false);
        }

        private Label lblTitulo;
        private GroupBox grpFiltros;
        private CheckBox chkFecha;
        private DateTimePicker dtpFecha;
        private Label lblMedico;
        private ComboBox cmbMedico;
        private Button btnBuscar;
        private DataGridView dgvAgendas;
        private Label lblNota;
        private Button btnSalir;
    }
}

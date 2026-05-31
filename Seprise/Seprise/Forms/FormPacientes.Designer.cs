namespace Seprise
{
    partial class FormPacientes
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnCrear = new Button();
            btnSalir = new Button();
            dgvPacientes = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            Paciente = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnConsultar = new DataGridViewButtonColumn();
            btnModificar = new DataGridViewButtonColumn();
            btnDesactivar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(36, 52, 71);
            lblTitulo.Location = new Point(26, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(229, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de pacientes";
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(102, 102, 102);
            lblSubtitulo.Location = new Point(26, 56);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(0, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Visible = false;
            btnCrear.BackColor = Color.FromArgb(47, 143, 85);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(954, 424);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(131, 26);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear paciente";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            btnSalir.BackColor = Color.FromArgb(47, 143, 85);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(955, 465);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 26);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.FromArgb(250, 250, 250);
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { DNI, Paciente, Telefono, Estado, btnConsultar, btnModificar, btnDesactivar });
            dgvPacientes.Location = new Point(26, 68);
            dgvPacientes.Margin = new Padding(3, 2, 3, 2);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(1046, 345);
            dgvPacientes.TabIndex = 3;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            DNI.FillWeight = 70F;
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            Paciente.FillWeight = 150F;
            Paciente.HeaderText = "Paciente";
            Paciente.MinimumWidth = 6;
            Paciente.Name = "Paciente";
            Paciente.ReadOnly = true;
            Telefono.FillWeight = 110F;
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Estado.FillWeight = 90F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            btnConsultar.FillWeight = 95F;
            btnConsultar.HeaderText = "";
            btnConsultar.MinimumWidth = 6;
            btnConsultar.Name = "btnConsultar";
            btnConsultar.ReadOnly = true;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseColumnTextForButtonValue = true;
            btnModificar.FillWeight = 95F;
            btnModificar.HeaderText = "";
            btnModificar.MinimumWidth = 6;
            btnModificar.Name = "btnModificar";
            btnModificar.ReadOnly = true;
            btnModificar.Text = "Modificar";
            btnModificar.UseColumnTextForButtonValue = true;
            btnDesactivar.FillWeight = 95F;
            btnDesactivar.HeaderText = "";
            btnDesactivar.MinimumWidth = 6;
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.ReadOnly = true;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseColumnTextForButtonValue = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1098, 502);
            Controls.Add(dgvPacientes);
            Controls.Add(btnSalir);
            Controls.Add(btnCrear);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM Pacientes - Sistema SEPRISE";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnCrear;
        private Button btnSalir;
        private DataGridView dgvPacientes;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Paciente;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn btnConsultar;
        private DataGridViewButtonColumn btnModificar;
        private DataGridViewButtonColumn btnDesactivar;
    }
}

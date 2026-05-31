namespace Seprise
{
    partial class FormBuscarPaciente
    {
        private System.ComponentModel.IContainer components = null;
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
            lblTitulo = new Label();
            lblLeyendaDni = new Label();
            txtDni = new TextBox();
            lblLeyendaNomApe = new Label();
            txtNombreApellido = new TextBox();
            btnBuscar = new Button();
            dgvPacientes = new DataGridView();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            lblTitulo.BackColor = Color.FromArgb(30, 107, 160);
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(660, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "  Buscar paciente";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblLeyendaDni.AutoSize = true;
            lblLeyendaDni.Font = new Font("Segoe UI", 9F);
            lblLeyendaDni.Location = new Point(15, 55);
            lblLeyendaDni.Name = "lblLeyendaDni";
            lblLeyendaDni.Size = new Size(30, 15);
            lblLeyendaDni.TabIndex = 1;
            lblLeyendaDni.Text = "DNI:";
            txtDni.Font = new Font("Segoe UI", 9.5F);
            txtDni.Location = new Point(15, 73);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(190, 24);
            txtDni.TabIndex = 2;
            txtDni.KeyDown += txtCampo_KeyDown;
            lblLeyendaNomApe.AutoSize = true;
            lblLeyendaNomApe.Font = new Font("Segoe UI", 9F);
            lblLeyendaNomApe.Location = new Point(220, 55);
            lblLeyendaNomApe.Name = "lblLeyendaNomApe";
            lblLeyendaNomApe.Size = new Size(54, 15);
            lblLeyendaNomApe.TabIndex = 3;
            lblLeyendaNomApe.Text = "Apellido:";
            txtNombreApellido.Font = new Font("Segoe UI", 9.5F);
            txtNombreApellido.Location = new Point(220, 73);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(300, 24);
            txtNombreApellido.TabIndex = 4;
            txtNombreApellido.KeyDown += txtCampo_KeyDown;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscar.Location = new Point(532, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 28);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(15, 112);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(630, 230);
            dgvPacientes.TabIndex = 6;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            dgvPacientes.SelectionChanged += dgvPacientes_SelectionChanged;
            btnSeleccionar.BackColor = Color.FromArgb(30, 107, 160);
            btnSeleccionar.Enabled = true;
            btnSeleccionar.FlatAppearance.BorderSize = 0;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(415, 358);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(115, 32);
            btnSeleccionar.TabIndex = 7;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            btnCancelar.BackColor = Color.FromArgb(180, 180, 180);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(540, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 32);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 406);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(lblLeyendaDni);
            Controls.Add(txtDni);
            Controls.Add(lblLeyendaNomApe);
            Controls.Add(txtNombreApellido);
            Controls.Add(btnBuscar);
            Controls.Add(dgvPacientes);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscarPaciente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar paciente";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
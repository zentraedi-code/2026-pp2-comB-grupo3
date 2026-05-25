namespace Seprise
{
    partial class FormPaciente
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
            lblDNI = new Label();
            txtDNI = new MaskedTextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new MaskedTextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblObraSocial = new Label();
            cboObraSocial = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(36, 52, 71);
            lblTitulo.Location = new Point(18, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(135, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ABM Paciente";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDNI.Location = new Point(18, 52);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(29, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(18, 70);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Mask = "000000000000000";
            txtDNI.Name = "txtDNI";
            txtDNI.PromptChar = ' ';
            txtDNI.Size = new Size(263, 23);
            txtDNI.TabIndex = 2;
            txtDNI.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(306, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(306, 70);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 23);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(18, 105);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(18, 122);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(263, 23);
            txtApellido.TabIndex = 6;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(306, 105);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(306, 122);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Mask = "000000000000000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PromptChar = ' ';
            txtTelefono.Size = new Size(263, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(18, 175);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(552, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDireccion.Location = new Point(18, 210);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(18, 227);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(552, 23);
            txtDireccion.TabIndex = 12;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(18, 262);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(121, 15);
            lblFechaNacimiento.TabIndex = 13;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new Point(18, 280);
            dtpFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(263, 23);
            dtpFechaNacimiento.TabIndex = 14;
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblObraSocial.Location = new Point(306, 262);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(69, 15);
            lblObraSocial.TabIndex = 15;
            lblObraSocial.Text = "Obra Social";
            // 
            // cboObraSocial
            // 
            cboObraSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboObraSocial.FormattingEnabled = true;
            cboObraSocial.Items.AddRange(new object[] { "OSDE", "Swiss Medical", "IOMA", "PAMI", "Particular" });
            cboObraSocial.Location = new Point(306, 280);
            cboObraSocial.Margin = new Padding(3, 2, 3, 2);
            cboObraSocial.Name = "cboObraSocial";
            cboObraSocial.Size = new Size(263, 23);
            cboObraSocial.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(47, 143, 85);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(18, 322);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 26);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(131, 322);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 26);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(586, 364);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cboObraSocial);
            Controls.Add(lblObraSocial);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPaciente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Paciente";
            Load += FormPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblDNI;
        private MaskedTextBox txtDNI;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblTelefono;
        private MaskedTextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblObraSocial;
        private ComboBox cboObraSocial;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}

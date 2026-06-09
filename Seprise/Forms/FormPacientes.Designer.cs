namespace Seprise
{
    partial class FormPacientes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblIcono; 
        private System.Windows.Forms.Panel pnlTarjetaContenedor; 
        private System.Windows.Forms.Label lblNota;

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
            
            pnlHeader = new Panel();
            pnlFooter = new Panel();
            lblIcono = new Label();
            pnlTarjetaContenedor = new Panel();
            lblNota = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            pnlHeader.SuspendLayout();
            pnlTarjetaContenedor.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();

            var colorTealSePrice = Color.FromArgb(0, 150, 136);
            var colorTextoOscuro = Color.FromArgb(33, 33, 33);
            var colorTextoGrisClaro = Color.FromArgb(220, 240, 235);
            var colorFondoGrisForm = Color.FromArgb(238, 242, 243); 
            var colorFondoFooter = Color.FromArgb(225, 230, 232);
            var colorGrisBordes = Color.FromArgb(224, 224, 224);

            var fontTitulo = new Font("Segoe UI", 18F, FontStyle.Bold); 
            var fontSubtitulo = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            var fontBotones = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            var fontGrid = new Font("Segoe UI", 9.5F);

            pnlHeader.BackColor = colorTealSePrice;
            pnlHeader.Controls.Add(lblIcono);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1120, 75); 
            pnlHeader.TabIndex = 4;

            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI", 20F);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(18, 16);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(47, 37);
            lblIcono.TabIndex = 6;
            lblIcono.Text = "👤";

            lblTitulo.AutoSize = true;
            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(75, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Pacientes";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = fontSubtitulo;
            lblSubtitulo.ForeColor = colorTextoGrisClaro;
            lblSubtitulo.Location = new Point(77, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(400, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Visible = true;
            lblSubtitulo.Text = "Administración, consulta, actualización y estado de pacientes registrados.";

            pnlTarjetaContenedor.BackColor = Color.White;
            pnlTarjetaContenedor.Controls.Add(btnCrear);
            pnlTarjetaContenedor.Controls.Add(dgvPacientes);
            pnlTarjetaContenedor.Location = new Point(24, 95); 
            pnlTarjetaContenedor.Name = "pnlTarjetaContenedor";
            pnlTarjetaContenedor.Size = new Size(1072, 400); 
            pnlTarjetaContenedor.TabIndex = 7;

            btnCrear.BackColor = colorTealSePrice;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = fontBotones;
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(20, 18);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(160, 36);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "+ CREAR PACIENTE";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;

            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { DNI, Paciente, Telefono, Estado, btnConsultar, btnModificar, btnDesactivar });
            dgvPacientes.GridColor = colorGrisBordes;
            dgvPacientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvPacientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvPacientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 200, 190);
            dgvPacientes.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPacientes.Location = new Point(20, 70);
            dgvPacientes.Margin = new Padding(3, 2, 3, 2);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new Size(1032, 310);
            dgvPacientes.TabIndex = 3;
            dgvPacientes.RowTemplate.Height = 30;
            dgvPacientes.DefaultCellStyle.Font = fontGrid;
            dgvPacientes.DefaultCellStyle.ForeColor = colorTextoOscuro;
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

            pnlFooter.BackColor = colorFondoFooter;
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 520);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1120, 75);
            pnlFooter.TabIndex = 6;
            pnlFooter.Controls.Add(btnSalir);
            pnlFooter.Controls.Add(lblNota);

            lblNota.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            lblNota.ForeColor = Color.FromArgb(0, 75, 68);
            lblNota.Location = new Point(24, 15);
            lblNota.Name = "lblNota";
            lblNota.Padding = new Padding(12, 6, 12, 6);
            lblNota.Size = new Size(750, 45);
            lblNota.Text = "ℹ   Utilice los botones de acción integrados en la grilla para consultar la historia clínica, modificar datos o dar de baja a un paciente.";

            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 210);
            btnSalir.Font = fontBotones;
            btnSalir.ForeColor = Color.FromArgb(100, 100, 100);
            btnSalir.Location = new Point(971, 20);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 35);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "🚪 Volver";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = colorFondoGrisForm;
            ClientSize = new Size(1120, 595);
            
            Controls.Add(pnlTarjetaContenedor);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFooter);
            
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = true;
            
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SePrice - Gestión de Pacientes";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlTarjetaContenedor.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
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
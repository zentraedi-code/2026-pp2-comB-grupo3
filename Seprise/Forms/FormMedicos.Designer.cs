namespace Seprise
{
    partial class FormMedicos
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
            dgvMedicos = new DataGridView();
            
            Matricula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            ImporteConsulta = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnConsultar = new DataGridViewButtonColumn();
            btnModificar = new DataGridViewButtonColumn();
            btnDesactivar = new DataGridViewButtonColumn();
            
            pnlHeader = new Panel();
            pnlFooter = new Panel();
            lblIcono = new Label();
            pnlTarjetaContenedor = new Panel();
            lblNota = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
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
            var fontSubtitulo = new Font("Segoe UI", 9F, FontStyle.Regular);
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
            lblIcono.Text = "👥";

            lblTitulo.AutoSize = true;
            lblTitulo.Font = fontTitulo;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(75, 14); 
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(244, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Médicos";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = fontSubtitulo;
            lblSubtitulo.ForeColor = colorTextoGrisClaro;
            lblSubtitulo.Location = new Point(77, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(400, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Alta, baja, modificación y consulta de honorarios de profesionales médicos.";

            pnlTarjetaContenedor.BackColor = Color.White;
            pnlTarjetaContenedor.Controls.Add(btnCrear);
            pnlTarjetaContenedor.Controls.Add(dgvMedicos);
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
            btnCrear.Text = "+ CREAR MÉDICO";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;

            dgvMedicos.AllowUserToAddRows = false;
            dgvMedicos.AllowUserToDeleteRows = false;
            dgvMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicos.BackgroundColor = Color.White;
            dgvMedicos.BorderStyle = BorderStyle.None; 
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Columns.AddRange(new DataGridViewColumn[] { Matricula, Nombre, Especialidad, ImporteConsulta, Estado, btnConsultar, btnModificar, btnDesactivar });
            dgvMedicos.GridColor = colorGrisBordes;
            dgvMedicos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dgvMedicos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvMedicos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 200, 190);
            dgvMedicos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMedicos.Location = new Point(20, 70);
            dgvMedicos.Margin = new Padding(3, 2, 3, 2);
            dgvMedicos.MultiSelect = false;
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.ReadOnly = true;
            dgvMedicos.RowHeadersVisible = false;
            dgvMedicos.RowHeadersWidth = 51;
            dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicos.Size = new Size(1032, 310); 
            dgvMedicos.TabIndex = 3;
            dgvMedicos.ScrollBars = ScrollBars.Both; 
            dgvMedicos.RowTemplate.Height = 30;
            dgvMedicos.DefaultCellStyle.Font = fontGrid;
            dgvMedicos.DefaultCellStyle.ForeColor = colorTextoOscuro;
            dgvMedicos.CellContentClick += dgvMedicos_CellContentClick;

            Matricula.FillWeight = 70F;
            Matricula.HeaderText = "Matrícula";
            Matricula.MinimumWidth = 6;
            Matricula.Name = "Matricula";
            Matricula.ReadOnly = true;

            Nombre.FillWeight = 140F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;

            Especialidad.FillWeight = 120F;
            Especialidad.HeaderText = "Especialidad";
            Especialidad.MinimumWidth = 6;
            Especialidad.Name = "Especialidad";
            Especialidad.ReadOnly = true;

            ImporteConsulta.FillWeight = 90F;
            ImporteConsulta.HeaderText = "Importe Consulta";
            ImporteConsulta.MinimumWidth = 6;
            ImporteConsulta.Name = "ImporteConsulta";
            ImporteConsulta.ReadOnly = true;

            Estado.FillWeight = 70F;
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
            lblNota.Text = "ℹ   Utilice los botones de acción integrados en la grilla para consultar legajos, modificar datos o gestionar el estado del profesional médico.";

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
            btnSalir.Click += (s, e) => { this.Close(); };

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
            Name = "FormMedicos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SePrice - Gestión de Médicos"; 
            
            ((System.ComponentModel.ISupportInitialize)(dgvMedicos)).EndInit();
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
        private DataGridView dgvMedicos;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewTextBoxColumn ImporteConsulta;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn btnConsultar;
        private DataGridViewButtonColumn btnModificar;
        private DataGridViewButtonColumn btnDesactivar;
    }
}
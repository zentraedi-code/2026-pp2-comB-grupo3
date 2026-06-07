namespace Seprise
{
    partial class FormMedicos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvMedicos;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblIcono; 
        private System.Windows.Forms.Panel pnlTarjetaContenedor; 
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblIcono = new System.Windows.Forms.Label();
            this.pnlTarjetaContenedor = new System.Windows.Forms.Panel();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlTarjetaContenedor.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            var colorTealSePrice = System.Drawing.Color.FromArgb(0, 150, 136);
            var colorTextoOscuro = System.Drawing.Color.FromArgb(33, 33, 33);
            var colorTextoGrisClaro = System.Drawing.Color.FromArgb(220, 240, 235);
            var colorFondoGrisForm = System.Drawing.Color.FromArgb(238, 242, 243); 
            var colorFondoFooter = System.Drawing.Color.FromArgb(225, 230, 232);
            var colorGrisBordes = System.Drawing.Color.FromArgb(224, 224, 224);

            var fontTitulo = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold); 
            var fontSubtitulo = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            var fontBotones = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            var fontGrid = new System.Drawing.Font("Segoe UI", 9.5F);

            this.pnlHeader.BackColor = colorTealSePrice;
            this.pnlHeader.Controls.Add(this.lblIcono);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 75); 
            this.pnlHeader.TabIndex = 4;

            this.lblIcono.AutoSize = true;
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblIcono.ForeColor = System.Drawing.Color.White;
            this.lblIcono.Location = new System.Drawing.Point(18, 16);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(47, 37);
            this.lblIcono.TabIndex = 6;
            this.lblIcono.Text = "👥";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = fontTitulo;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(75, 14); 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Médicos";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = fontSubtitulo;
            this.lblSubtitulo.ForeColor = colorTextoGrisClaro;
            this.lblSubtitulo.Location = new System.Drawing.Point(77, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(364, 15);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Alta, baja y modificación de médicos, incluyendo honorarios.";

            this.pnlTarjetaContenedor.BackColor = System.Drawing.Color.White;
            this.pnlTarjetaContenedor.Controls.Add(this.btnCrear);
            this.pnlTarjetaContenedor.Controls.Add(this.dgvMedicos);
            this.pnlTarjetaContenedor.Location = new System.Drawing.Point(24, 95); 
            this.pnlTarjetaContenedor.Name = "pnlTarjetaContenedor";
            this.pnlTarjetaContenedor.Size = new System.Drawing.Size(902, 375); 
            this.pnlTarjetaContenedor.TabIndex = 7;

            this.btnCrear.BackColor = colorTealSePrice;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = fontBotones;
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(20, 18);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(160, 36);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "+ CREAR MÉDICO";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);

            this.dgvMedicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None; 
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 150, 136);
            this.dgvMedicos.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            this.dgvMedicos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 200, 190);
            this.dgvMedicos.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvMedicos.GridColor = colorGrisBordes;
            this.dgvMedicos.Location = new System.Drawing.Point(20, 70);
            this.dgvMedicos.Size = new System.Drawing.Size(862, 285); 
            this.dgvMedicos.TabIndex = 3;
            this.dgvMedicos.ScrollBars = System.Windows.Forms.ScrollBars.Both; 
            this.dgvMedicos.RowTemplate.Height = 30;
            this.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicos.DefaultCellStyle.Font = fontGrid;
            this.dgvMedicos.DefaultCellStyle.ForeColor = colorTextoOscuro;

            var colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMatricula.HeaderText = "Matrícula";
            colMatricula.Name = "Matricula";
            this.dgvMedicos.Columns.Add(colMatricula);

            var colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "Nombre";
            this.dgvMedicos.Columns.Add(colNombre);

            var colEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEspecialidad.HeaderText = "Especialidad";
            colEspecialidad.Name = "Especialidad";
            this.dgvMedicos.Columns.Add(colEspecialidad);

            var colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colImporte.HeaderText = "Importe Consulta";
            colImporte.Name = "ImporteConsulta";
            this.dgvMedicos.Columns.Add(colImporte);

            var colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colActivo.HeaderText = "Estado";
            colActivo.Name = "Activo";
            this.dgvMedicos.Columns.Add(colActivo);

            this.pnlFooter.BackColor = colorFondoFooter;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 495);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(950, 75);
            this.pnlFooter.TabIndex = 6;
            this.pnlFooter.Controls.Add(this.btnSalir);
            this.pnlFooter.Controls.Add(this.lblNota);

            this.lblNota.BackColor = System.Drawing.Color.FromArgb(198, 234, 212);
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(0, 75, 68);
            this.lblNota.Location = new System.Drawing.Point(24, 15);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.lblNota.Size = new System.Drawing.Size(650, 45);
            this.lblNota.Text = "ℹ   Haga doble clic sobre un registro de la grilla para editar o gestionar la baja de un profesional médico del sistema.";

            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 210);
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnSalir.Location = new System.Drawing.Point(800, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 35);
            this.btnSalir.Text = "🚪 Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += (s, e) => { this.Close(); };

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colorFondoGrisForm; 
            this.ClientSize = new System.Drawing.Size(950, 570);
            
            this.Controls.Add(this.pnlTarjetaContenedor);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; 
            this.MinimizeBox = true;  
            
            this.Name = "FormMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SePrice - Gestión de Médicos"; 
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTarjetaContenedor.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
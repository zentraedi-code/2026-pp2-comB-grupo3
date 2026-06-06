namespace Seprise
{
    partial class FormMedicos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvMedicos;

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CU03 - ABM Médicos";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 50);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Alta, baja y modificación de médicos, incluyendo honorarios.";

            this.btnCrear.Location = new System.Drawing.Point(20, 80);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 30);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear médico";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);

            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicos.Location = new System.Drawing.Point(20, 120);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowTemplate.Height = 25;
            this.dgvMedicos.Size = new System.Drawing.Size(860, 400);
            this.dgvMedicos.TabIndex = 3;

            // Columnas del grid
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

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABM Médicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

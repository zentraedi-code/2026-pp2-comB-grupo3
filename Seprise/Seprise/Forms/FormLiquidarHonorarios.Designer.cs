namespace Seprise
{
    partial class FormLiquidarHonorarios
    {
        private System.ComponentModel.IContainer components = null;
        
        // Paneles de Estructura y Contenedores
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlResumenCard;
        
        // Elementos del Encabezado
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        
        // Elementos de Filtros
        private System.Windows.Forms.Label lblSeccionFiltros;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel pnlFooter;
        // Elementos de Resumen del Período
        private System.Windows.Forms.Label lblSeccionResumen;
        private System.Windows.Forms.Label lblResumenMedico;
        private System.Windows.Forms.Label lblResumenEspecialidad;
        private System.Windows.Forms.Label lblResumenConsultasTitulo;
        private System.Windows.Forms.Label lblResumenConsultasValor;
        private System.Windows.Forms.Label lblResumenHonorariosTitulo;
        private System.Windows.Forms.Label lblResumenHonorariosValor;
        private System.Windows.Forms.Label lblResumenTotalTitulo;
        private System.Windows.Forms.Label lblResumenTotalValor;
        private System.Windows.Forms.Button btnPagar;

        // Elementos de Detalle (Tabla)
        private System.Windows.Forms.Label lblSeccionDetalle;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Label lblMensajes;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            
            this.lblSeccionFiltros = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            
            this.lblSeccionResumen = new System.Windows.Forms.Label();
            this.pnlResumenCard = new System.Windows.Forms.Panel();
            this.lblResumenMedico = new System.Windows.Forms.Label();
            this.lblResumenEspecialidad = new System.Windows.Forms.Label();
            this.lblResumenConsultasTitulo = new System.Windows.Forms.Label();
            this.lblResumenConsultasValor = new System.Windows.Forms.Label();
            this.lblResumenHonorariosTitulo = new System.Windows.Forms.Label();
            this.lblResumenHonorariosValor = new System.Windows.Forms.Label();
            this.lblResumenTotalTitulo = new System.Windows.Forms.Label();
            this.lblResumenTotalValor = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            
            this.lblSeccionDetalle = new System.Windows.Forms.Label();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            
            this.pnlHeader.SuspendLayout();
            this.pnlResumenCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
        

            // Color Personalizado Principal
            System.Drawing.Color colorPrincipal = System.Drawing.Color.FromArgb(0, 150, 136);

            // ==========================================
            // pnlHeader (Franja Superior)
            // ==========================================
            this.pnlHeader.BackColor = colorPrincipal;
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 85);
            this.pnlHeader.TabIndex = 0;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 30);
            this.lblTitulo.Text = "💰 LIQUIDAR HONORARIOS";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(220, 240, 240);
            this.lblSubtitulo.Location = new System.Drawing.Point(21, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(224, 19);
            this.lblSubtitulo.Text = "Reporte de facturación por médico";

            // ==========================================
            // SECCIÓN: FILTROS DE BÚSQUEDA
            // ==========================================
            this.lblSeccionFiltros.AutoSize = true;
            this.lblSeccionFiltros.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionFiltros.ForeColor = colorPrincipal;
            this.lblSeccionFiltros.Location = new System.Drawing.Point(20, 105);
            this.lblSeccionFiltros.Text = "🔍 FILTROS DE BÚSQUEDA";

            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMedico.ForeColor = System.Drawing.Color.DimGray;
            this.lblMedico.Location = new System.Drawing.Point(20, 132);
            this.lblMedico.Text = "Médico";

            this.cmbMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedico.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbMedico.Location = new System.Drawing.Point(20, 152);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(180, 25);

            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.DimGray;
            this.lblDesde.Location = new System.Drawing.Point(215, 132);
            this.lblDesde.Text = "Desde";

            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(215, 152);
            this.dtpDesde.Size = new System.Drawing.Size(110, 25);

            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.DimGray;
            this.lblHasta.Location = new System.Drawing.Point(340, 132);
            this.lblHasta.Text = "Hasta";

            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(340, 152);
            this.dtpHasta.Size = new System.Drawing.Size(110, 25);

            this.btnGenerar.BackColor = colorPrincipal;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(470, 150);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(95, 25);
            this.btnGenerar.Text = "🔍 Buscar";
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(575, 150);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(95, 25);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);

            // ==========================================
            // SECCIÓN: RESUMEN DEL PERÍODO
            // ==========================================
            this.lblSeccionResumen.AutoSize = true;
            this.lblSeccionResumen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionResumen.ForeColor = colorPrincipal;
            this.lblSeccionResumen.Location = new System.Drawing.Point(20, 200);
            this.lblSeccionResumen.Text = "📊 RESUMEN DEL PERÍODO";

            // pnlResumenCard (Tarjeta contenedora gris/azul clara)
            this.pnlResumenCard.BackColor = System.Drawing.Color.FromArgb(242, 247, 247);
            this.pnlResumenCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlResumenCard.Controls.Add(this.lblResumenMedico);
            this.pnlResumenCard.Controls.Add(this.lblResumenEspecialidad);
            this.pnlResumenCard.Controls.Add(this.lblResumenConsultasTitulo);
            this.pnlResumenCard.Controls.Add(this.lblResumenConsultasValor);
            this.pnlResumenCard.Controls.Add(this.lblResumenHonorariosTitulo);
            this.pnlResumenCard.Controls.Add(this.lblResumenHonorariosValor);
            this.pnlResumenCard.Controls.Add(this.lblResumenTotalTitulo);
            this.pnlResumenCard.Controls.Add(this.lblResumenTotalValor);
            this.pnlResumenCard.Controls.Add(this.btnPagar);
            this.pnlResumenCard.Location = new System.Drawing.Point(20, 225);
            this.pnlResumenCard.Name = "pnlResumenCard";
            this.pnlResumenCard.Size = new System.Drawing.Size(650, 95);

            this.lblResumenMedico.AutoSize = true;
            this.lblResumenMedico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResumenMedico.Location = new System.Drawing.Point(15, 15);
            this.lblResumenMedico.Text = "Médico";

            this.lblResumenEspecialidad.AutoSize = true;
            this.lblResumenEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic);
            this.lblResumenEspecialidad.ForeColor = System.Drawing.Color.Gray;
            this.lblResumenEspecialidad.Location = new System.Drawing.Point(15, 38);
            this.lblResumenEspecialidad.Text = "Especialidad";

            // Bloque Consultas
            this.lblResumenConsultasTitulo.AutoSize = true;
            this.lblResumenConsultasTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResumenConsultasTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblResumenConsultasTitulo.Location = new System.Drawing.Point(170, 18);
            this.lblResumenConsultasTitulo.Text = "Consultas";

            this.lblResumenConsultasValor.AutoSize = true;
            this.lblResumenConsultasValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResumenConsultasValor.Location = new System.Drawing.Point(170, 38);
            this.lblResumenConsultasValor.Text = "0";

            // Bloque Honorarios
            this.lblResumenHonorariosTitulo.AutoSize = true;
            this.lblResumenHonorariosTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResumenHonorariosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblResumenHonorariosTitulo.Location = new System.Drawing.Point(270, 18);
            this.lblResumenHonorariosTitulo.Text = "Honorarios";

            this.lblResumenHonorariosValor.AutoSize = true;
            this.lblResumenHonorariosValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResumenHonorariosValor.Location = new System.Drawing.Point(270, 38);
            this.lblResumenHonorariosValor.Text = "$0,00";

            // Bloque Total a Pagar
            this.lblResumenTotalTitulo.AutoSize = true;
            this.lblResumenTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblResumenTotalTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblResumenTotalTitulo.Location = new System.Drawing.Point(400, 18);
            this.lblResumenTotalTitulo.Text = "Total a pagar";

            this.lblResumenTotalValor.AutoSize = true;
            this.lblResumenTotalValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResumenTotalValor.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113); // Verde
            this.lblResumenTotalValor.Location = new System.Drawing.Point(400, 38);
            this.lblResumenTotalValor.Text = "$0,00";

            // Botón Pagar dentro de la tarjeta
            this.btnPagar.BackColor = colorPrincipal;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(540, 30);
            this.btnPagar.Size = new System.Drawing.Size(90, 35);
            this.btnPagar.Text = "💳 Pagar";
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.UseVisualStyleBackColor = false;

            // ==========================================
            // SECCIÓN: DETALLE DE CONSULTAS (Tabla)
            // ==========================================
            this.lblSeccionDetalle.AutoSize = true;
            this.lblSeccionDetalle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionDetalle.ForeColor = colorPrincipal;
            this.lblSeccionDetalle.Location = new System.Drawing.Point(20, 340);
            this.lblSeccionDetalle.Text = "📋 DETALLE DE CONSULTAS";

            // dgvConsultas Estilo e Inserción
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            
            // Estilo del encabezado de tabla
            dataGridViewCellStyle1.BackColor = colorPrincipal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = colorPrincipal;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultas.ColumnHeadersHeight = 30;
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.ScrollBars = ScrollBars.Vertical;
            this.dgvConsultas.Location = new System.Drawing.Point(20, 365);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(650, 150);
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.Visible = true;

            // pnlResultados (panel para tarjetas de honorarios)
            this.pnlResultados.Visible = false;

            // lblMensajes (estado del formulario)
            this.lblMensajes.AutoSize = false;
            this.lblMensajes.Location = new System.Drawing.Point(20, 495);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(650, 25);
            this.lblMensajes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMensajes.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblMensajes.Text = string.Empty;

            // ==========================================
            // DISEÑO FINAL DEL FORMULARIO (700 de Ancho)
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 570);


            // Agregar controles al Formulario
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.lblSeccionDetalle);
            this.Controls.Add(this.pnlResumenCard);
            this.Controls.Add(this.lblSeccionResumen);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblSeccionFiltros);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLiquidarHonorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liquidar honorarios médicos";
            
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlResumenCard.ResumeLayout(false);
            this.pnlResumenCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(242, 247, 247);
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.Controls.Add(this.btnSalir);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 515);
            this.pnlFooter.Size = new System.Drawing.Size(700, 65);

            // btnSalir
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSalir.FlatAppearance.BorderSize = 1;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnSalir.Location = new System.Drawing.Point(650, 12);
            this.btnSalir.Size = new System.Drawing.Size(120, 38);
            this.btnSalir.Text = "🚪 Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        }
    }
}
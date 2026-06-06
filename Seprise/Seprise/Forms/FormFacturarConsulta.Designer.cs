namespace Seprise
{
    partial class FormFacturarConsulta
    {
        private System.ComponentModel.IContainer components = null;

        // Paneles Contenedores (Tarjetas)
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDatosPaciente;
        private System.Windows.Forms.Panel pnlFacturacion;
        private System.Windows.Forms.Panel pnlInfoImportante;
        private System.Windows.Forms.Panel pnlInfoPacienteCard; 

        // Encabezado principal
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        // Datos del Paciente
        private System.Windows.Forms.Label lblSeccionPaciente;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.TextBox txtDniPaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Label lblDatosPacienteInfo; 

        // Facturación
        private System.Windows.Forms.Label lblSeccionFacturacion;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label lblObraSocialNombre;
        private System.Windows.Forms.TextBox txtObraSocialNombre;
        private System.Windows.Forms.Label lblNumeroSocio;
        private System.Windows.Forms.TextBox txtNumeroSocio;
        private System.Windows.Forms.Label lblNumeroCobertura;
        private System.Windows.Forms.TextBox txtNumeroCobertura;

        // Consultas Recepcionadas
        private System.Windows.Forms.Label lblMensajes;

        // Panel Lateral (Información Importante)
        private System.Windows.Forms.Label lblSeccionInfo;
        private System.Windows.Forms.Label lblInfoTitulo1;
        private System.Windows.Forms.Label lblInfoDesc1;
        private System.Windows.Forms.Label lblInfoTitulo2;
        private System.Windows.Forms.Label lblInfoDesc2;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Panel pnlFooter;
        // Botones de acción inferiores
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Button btnImprimir;
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
            this.pnlDatosPaciente = new System.Windows.Forms.Panel();
            this.lblSeccionPaciente = new System.Windows.Forms.Label();
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.txtDniPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.pnlInfoPacienteCard = new System.Windows.Forms.Panel();
            this.lblDatosPacienteInfo = new System.Windows.Forms.Label();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.pnlFacturacion = new System.Windows.Forms.Panel();
            this.lblSeccionFacturacion = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.lblObraSocialNombre = new System.Windows.Forms.Label();
            this.txtObraSocialNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroSocio = new System.Windows.Forms.Label();
            this.txtNumeroSocio = new System.Windows.Forms.TextBox();
            this.lblNumeroCobertura = new System.Windows.Forms.Label();
            this.txtNumeroCobertura = new System.Windows.Forms.TextBox();
            this.pnlInfoImportante = new System.Windows.Forms.Panel();
            this.lblSeccionInfo = new System.Windows.Forms.Label();
            this.lblInfoTitulo1 = new System.Windows.Forms.Label();
            this.lblInfoDesc1 = new System.Windows.Forms.Label();
            this.lblInfoTitulo2 = new System.Windows.Forms.Label();
            this.lblInfoDesc2 = new System.Windows.Forms.Label();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            
            // Componentes del Footer Institucional
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            
            this.pnlHeader.SuspendLayout();
            this.pnlDatosPaciente.SuspendLayout();
            this.pnlInfoPacienteCard.SuspendLayout();
            this.pnlFacturacion.SuspendLayout();
            this.pnlInfoImportante.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // 
            // FormFacturarConsulta (Ventana principal)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 249, 250); 
            this.ClientSize = new System.Drawing.Size(800, 650); 
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.pnlFacturacion);
            this.Controls.Add(this.pnlDatosPaciente);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFacturarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📋 Facturar Consulta Médica";

            // 
            // pnlHeader (Franja Azul Superior)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(0, 150, 136); 
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 90);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(25, 18);
            this.lblTitulo.Text = "🧾 FACTURAR CONSULTA";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 52);
            this.lblSubtitulo.Text = "Emisión de factura para consultas médicas";

            // 
            // pnlDatosPaciente (Tarjeta superior izquierda)
            // 
            this.pnlDatosPaciente.BackColor = System.Drawing.Color.White;
            this.pnlDatosPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlDatosPaciente.Controls.Add(this.lblSeccionPaciente);
            this.pnlDatosPaciente.Controls.Add(this.lblDniPaciente);
            this.pnlDatosPaciente.Controls.Add(this.txtDniPaciente);
            this.pnlDatosPaciente.Controls.Add(this.btnBuscarPaciente);
            this.pnlDatosPaciente.Controls.Add(this.pnlInfoPacienteCard);
            this.pnlDatosPaciente.Controls.Add(this.lblMensajes);
            this.pnlDatosPaciente.Location = new System.Drawing.Point(20, 110);
            this.pnlDatosPaciente.Size = new System.Drawing.Size(760, 185);
            this.pnlDatosPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // lblSeccionPaciente
            this.lblSeccionPaciente.AutoSize = true;
            this.lblSeccionPaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSeccionPaciente.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblSeccionPaciente.Location = new System.Drawing.Point(20, 15);
            this.lblSeccionPaciente.Text = "👤 DATOS DEL PACIENTE";

            // lblDniPaciente
            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDniPaciente.ForeColor = System.Drawing.Color.DimGray;
            this.lblDniPaciente.Location = new System.Drawing.Point(20, 48);
            this.lblDniPaciente.Text = "DNI del paciente";

            // txtDniPaciente
            this.txtDniPaciente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDniPaciente.Location = new System.Drawing.Point(20, 68);
            this.txtDniPaciente.Size = new System.Drawing.Size(440, 40);
            this.txtDniPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniPaciente.PlaceholderText = " Ingresá el DNI del paciente";

            // btnBuscarPaciente
            this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(593, 66);
            this.btnBuscarPaciente.Size = new System.Drawing.Size(145, 28);
            this.btnBuscarPaciente.Text = "🔍 Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = false;
            this.btnBuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);

            // pnlInfoPacienteCard (Alerta celeste)
            this.pnlInfoPacienteCard.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            this.pnlInfoPacienteCard.Controls.Add(this.lblDatosPacienteInfo);
            this.pnlInfoPacienteCard.Location = new System.Drawing.Point(20, 108);
            this.pnlInfoPacienteCard.Size = new System.Drawing.Size(720, 55);
            this.pnlInfoPacienteCard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // lblDatosPacienteInfo
            this.lblDatosPacienteInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDatosPacienteInfo.ForeColor = System.Drawing.Color.FromArgb(0, 160, 136);
            this.lblDatosPacienteInfo.Location = new System.Drawing.Point(15, 10);
            this.lblDatosPacienteInfo.Size = new System.Drawing.Size(400, 55);
            this.lblDatosPacienteInfo.Text = "Los datos del paciente aparecerán aquí\nBuscá por DNI para ver la información del paciente.";

            // lblMensajes
            this.lblMensajes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMensajes.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblMensajes.Location = new System.Drawing.Point(20, 165);
            this.lblMensajes.Size = new System.Drawing.Size(735, 15);
            this.lblMensajes.Text = string.Empty;

            // 
            // pnlFacturacion (Tarjeta intermedia izquierda)
            // 
            this.pnlFacturacion.BackColor = System.Drawing.Color.White;
            this.pnlFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlFacturacion.Controls.Add(this.lblSeccionFacturacion);
            this.pnlFacturacion.Controls.Add(this.lblMedico);
            this.pnlFacturacion.Controls.Add(this.txtMedico);
            this.pnlFacturacion.Controls.Add(this.lblImporte);
            this.pnlFacturacion.Controls.Add(this.txtImporte);
            this.pnlFacturacion.Controls.Add(this.lblMedioPago);
            this.pnlFacturacion.Controls.Add(this.cmbMedioPago);
            this.pnlFacturacion.Controls.Add(this.lblObraSocialNombre);
            this.pnlFacturacion.Controls.Add(this.txtObraSocialNombre);
            this.pnlFacturacion.Controls.Add(this.lblNumeroSocio);
            this.pnlFacturacion.Controls.Add(this.txtNumeroSocio);
            this.pnlFacturacion.Controls.Add(this.lblConcepto);
            this.pnlFacturacion.Controls.Add(this.txtConcepto);
            this.pnlFacturacion.Controls.Add(this.lblNumeroCobertura);
            this.pnlFacturacion.Controls.Add(this.txtNumeroCobertura);
            this.pnlFacturacion.Location = new System.Drawing.Point(20, 310);
            this.pnlFacturacion.Size = new System.Drawing.Size(760, 220);
            this.pnlFacturacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // lblSeccionFacturacion
            this.lblSeccionFacturacion.AutoSize = true;
            this.lblSeccionFacturacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSeccionFacturacion.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblSeccionFacturacion.Location = new System.Drawing.Point(20, 15);
            this.lblSeccionFacturacion.Text = "📄 FACTURACIÓN";

            // lblMedico
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedico.ForeColor = System.Drawing.Color.DimGray;
            this.lblMedico.Location = new System.Drawing.Point(17, 48);
            this.lblMedico.Text = "Médico";

            // txtMedico
            this.txtMedico.BackColor = System.Drawing.Color.FromArgb(242, 243, 245);
            this.txtMedico.Enabled = false;
            this.txtMedico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMedico.Location = new System.Drawing.Point(20, 68);
            this.txtMedico.Size = new System.Drawing.Size(340, 25);
            this.txtMedico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblConcepto
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConcepto.ForeColor = System.Drawing.Color.DimGray;
            this.lblConcepto.Location = new System.Drawing.Point(397, 48);
            this.lblConcepto.Text = "Concepto";

            // txtConcepto
            this.txtConcepto.BackColor = System.Drawing.Color.FromArgb(242, 243, 245);
            this.txtConcepto.Enabled = false;
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConcepto.Location = new System.Drawing.Point(400, 68);
            this.txtConcepto.Size = new System.Drawing.Size(340, 25);
            this.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConcepto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // lblMedioPago
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMedioPago.ForeColor = System.Drawing.Color.DimGray;
            this.lblMedioPago.Location = new System.Drawing.Point(17, 112);
            this.lblMedioPago.Text = "Medio de pago";

            // cmbMedioPago
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMedioPago.Location = new System.Drawing.Point(20, 132);
            this.cmbMedioPago.Size = new System.Drawing.Size(220, 25);
            this.cmbMedioPago.Items.Add("Efectivo");
            this.cmbMedioPago.SelectedIndex = 0; 

            // lblObraSocialNombre
            this.lblObraSocialNombre.AutoSize = true;
            this.lblObraSocialNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblObraSocialNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblObraSocialNombre.Location = new System.Drawing.Point(267, 112);
            this.lblObraSocialNombre.Text = "Obra social";
            this.lblObraSocialNombre.Visible = false;

            // txtObraSocialNombre
            this.txtObraSocialNombre.BackColor = System.Drawing.Color.FromArgb(242, 243, 245);
            this.txtObraSocialNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObraSocialNombre.Location = new System.Drawing.Point(270, 132);
            this.txtObraSocialNombre.Size = new System.Drawing.Size(220, 25);
            this.txtObraSocialNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObraSocialNombre.Visible = false;

            // lblNumeroSocio
            this.lblNumeroSocio.AutoSize = true;
            this.lblNumeroSocio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumeroSocio.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumeroSocio.Location = new System.Drawing.Point(517, 112);
            this.lblNumeroSocio.Text = "Número de socio";
            this.lblNumeroSocio.Visible = false;

            // txtNumeroSocio
            this.txtNumeroSocio.BackColor = System.Drawing.Color.FromArgb(242, 243, 245);
            this.txtNumeroSocio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroSocio.Location = new System.Drawing.Point(520, 132);
            this.txtNumeroSocio.Size = new System.Drawing.Size(220, 25);
            this.txtNumeroSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroSocio.Visible = false;

            // lblNumeroCobertura
            this.lblNumeroCobertura.AutoSize = true;
            this.lblNumeroCobertura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumeroCobertura.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumeroCobertura.Location = new System.Drawing.Point(17, 170);
            this.lblNumeroCobertura.Text = "Número de cobertura";
            this.lblNumeroCobertura.Visible = false;

            // txtNumeroCobertura
            this.txtNumeroCobertura.BackColor = System.Drawing.Color.FromArgb(242, 243, 245);
            this.txtNumeroCobertura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroCobertura.Location = new System.Drawing.Point(20, 190);
            this.txtNumeroCobertura.Size = new System.Drawing.Size(220, 25);
            this.txtNumeroCobertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroCobertura.Visible = false;

             // lblImporte
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblImporte.ForeColor = System.Drawing.Color.DimGray;
            this.lblImporte.Location = new System.Drawing.Point(517, 170);
            this.lblImporte.Text = "Importe Total:";

            // txtImporte
            this.txtImporte.BackColor = System.Drawing.Color.FromArgb(242, 243, 245);
            this.txtImporte.Enabled = false;
            this.txtImporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtImporte.Location = new System.Drawing.Point(520, 190);
            this.txtImporte.Size = new System.Drawing.Size(220, 25);
            this.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // BOTONES DE ACCIÓN MEDIOS
            // 
            // btnEmitir
            this.btnEmitir.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnEmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitir.FlatAppearance.BorderSize = 0;
            this.btnEmitir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmitir.ForeColor = System.Drawing.Color.White;
            this.btnEmitir.Location = new System.Drawing.Point(20, 542);
            this.btnEmitir.Size = new System.Drawing.Size(370, 38);
            this.btnEmitir.Text = "COBRAR";
            this.btnEmitir.UseVisualStyleBackColor = false;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);

            // btnImprimir
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnImprimir.FlatAppearance.BorderSize = 1;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.btnImprimir.Location = new System.Drawing.Point(410, 542);
            this.btnImprimir.Padding = new Padding(0, 2, 0, 0);
            this.btnImprimir.Size = new System.Drawing.Size(370, 38);
            this.btnImprimir.Text = "🖨️ Imprimir comprobante";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);

            // =======================================================================
            // PNLFOOTER (Barra inferior con Nota y Botón perfectamente alineados)
            // =======================================================================
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlFooter.Controls.Add(this.btnSalir);
            this.pnlFooter.Controls.Add(this.lblNota);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 585);
            this.pnlFooter.Size = new System.Drawing.Size(800, 65);

            // lblNota (Estilo verde complementario y alineación exacta a Y=12)
            this.lblNota.BackColor = System.Drawing.Color.FromArgb(198, 234, 212);
            this.lblNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(0, 75, 75);
            this.lblNota.Location = new System.Drawing.Point(20, 12);
            this.lblNota.Name = "lblNota";
            this.lblNota.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.lblNota.Size = new System.Drawing.Size(620, 45);
            this.lblNota.TabIndex = 13;
            this.lblNota.Text = "ℹ   La facturación procesa la consulta actual, valida la cobertura de la obra social e imprime el comprobante de pago.";

            // btnSalir (Centrado de forma vertical con respecto a lblNota en Y=12)
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 210, 220);
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnSalir.Location = new System.Drawing.Point(660, 12);
            this.btnSalir.Size = new System.Drawing.Size(120, 35);
            this.btnSalir.Text = "🚪 Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Finalizaciones de layouts
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDatosPaciente.ResumeLayout(false);
            this.pnlDatosPaciente.PerformLayout();
            this.pnlInfoPacienteCard.ResumeLayout(false);
            this.pnlInfoPacienteCard.PerformLayout();
            this.pnlFacturacion.ResumeLayout(false);
            this.pnlFacturacion.PerformLayout();
            this.pnlInfoImportante.ResumeLayout(false);
            this.pnlInfoImportante.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
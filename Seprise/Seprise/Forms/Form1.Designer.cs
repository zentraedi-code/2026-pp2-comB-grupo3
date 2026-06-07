namespace Seprise
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelContenido = new Panel();
            panelFooter = new Panel();
            lblWelcome = new Label();
            lblIcono = new Label();
            lblSubtitulo = new Label();
            btnSalir = new Button();
            lblSeccionComun = new Label();
            btnGestionMedicos = new Button();
            btnPacientes = new Button();
            lblSeccionConsultorios = new Label();
            btnGestionAgenda = new Button();
            btnGestionTurnos = new Button();
            btnRecepcionarPaciente = new Button();
            btnAtencionPaciente = new Button();
            sepAdministracion = new Panel();
            lblSeccionEstudios = new Label();
            btnGestionAgendaEstudios = new Button();
            btnGestionTurnosEstudios = new Button();
            btnRecepcionarPacienteEstudio = new Button();
            btnSolicitudEstudios = new Button();
            btnConfirmacionEstudios = new Button();
            btnProcesamientoEstudios = new Button();
            panelHeader.SuspendLayout();
            panelContenido.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();

            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblIcono);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1254, 100);
            panelHeader.TabIndex = 0;

            lblIcono.AutoSize = true;
            lblIcono.BackColor = Color.Transparent;
            lblIcono.Font = new Font("Segoe UI", 45F, FontStyle.Regular);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(26, 0);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(300, 70);
            lblIcono.Text = "🩺|";

            lblTitulo.Dock = DockStyle.None;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(150, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1254, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Gestión - Clínica SEPRISE";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(204, 242, 239);
            lblSubtitulo.Location = new Point(150, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione la opción que desea gestionar.";

            sepAdministracion.BackColor = Color.FromArgb(225, 230, 232);
            sepAdministracion.Location = new Point(40, 225);
            sepAdministracion.Size = new Size(1130,1);

            panelContenido.AutoScroll = true;
            panelContenido.BackColor = Color.FromArgb(244, 246, 247);
            panelContenido.Controls.Add(lblSeccionComun);
            panelContenido.Controls.Add(btnGestionMedicos);
            panelContenido.Controls.Add(btnPacientes);
            panelContenido.Controls.Add(lblSeccionConsultorios);
            panelContenido.Controls.Add(btnGestionAgenda);
            panelContenido.Controls.Add(btnGestionTurnos);
            panelContenido.Controls.Add(btnRecepcionarPaciente);
            panelContenido.Controls.Add(btnAtencionPaciente);
            panelContenido.Controls.Add(lblSeccionEstudios);
            panelContenido.Controls.Add(btnGestionAgendaEstudios);
            panelContenido.Controls.Add(btnGestionTurnosEstudios);
            panelContenido.Controls.Add(btnRecepcionarPacienteEstudio);
            panelContenido.Controls.Add(btnSolicitudEstudios);
            panelContenido.Controls.Add(btnConfirmacionEstudios);
            panelContenido.Controls.Add(btnProcesamientoEstudios);
            panelContenido.Controls.Add(sepAdministracion);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 100);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1254, 533);
            panelContenido.TabIndex = 1;

            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(lblWelcome);
            panelFooter.Controls.Add(btnSalir);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 633);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1254, 70);
            panelFooter.TabIndex = 2;

            lblWelcome.Font = new Font("Segoe UI", 9F);
            lblWelcome.ForeColor = Color.FromArgb(100, 110, 115);
            lblWelcome.Location = new Point(35, 15);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(600, 40);
            lblWelcome.Text = "ℹ️  Bienvenido al Sistema SEPRISE\r\nUtilice las opciones disponibles para gestionar la información de la clínica.";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;

            btnSalir.BackColor = Color.White;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(220, 224, 224);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(33, 37, 41);
            btnSalir.Location = new Point(1050, 18);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(165, 36);
            btnSalir.Text = "🚪 Salir del sistema";
            btnSalir.Click += btnSalir_Click;
            btnSalir.UseVisualStyleBackColor = false;

            ConfigurarEncabezadoSeccion(lblSeccionComun, "👥", "ADMINISTRACIÓN", "Gestión de la información principal del sistema.", 35, 25);

            ConfigurarBotonTarjeta(btnGestionMedicos, "👨‍⚕️", "Gestión de Médicos", "Administre los datos\ndel personal médico.", 40, 105);
            btnGestionMedicos.Click += btnGestionMedicos_Click;

            ConfigurarBotonTarjeta(btnPacientes, "👥", "Gestión de Pacientes", "Administre los datos\nde los pacientes.", 315, 105);
            btnPacientes.Click += btnPacientes_Click;

            ConfigurarEncabezadoSeccion(lblSeccionConsultorios, "📅", "CONSULTORIOS EXTERNOS", "Gestión de la atención en consultorios externos.", 35, 250);

            ConfigurarBotonTarjeta(btnGestionAgenda, "📅", "Gestión de Agenda", "Administre la agenda\nde turnos.", 40, 320);
            btnGestionAgenda.Click += btnGestionAgenda_Click;

            ConfigurarBotonTarjeta(btnGestionTurnos, "🕐", "Gestión de Turnos", "Administre y\ncontrole los turnos.", 315, 320);
            btnGestionTurnos.Click += btnGestionTurnos_Click;

            ConfigurarBotonTarjeta(btnRecepcionarPaciente, "📋", "Recepcionar Pacientes", "Registre la llegada\nde pacientes.", 590, 320);
            btnRecepcionarPaciente.Click += btnRecepcionarPaciente_Click;

            ConfigurarBotonTarjeta(btnAtencionPaciente, "🏥", "Atención de Pacientes", "Gestione la atención\nde pacientes.", 865, 320);
            btnAtencionPaciente.Click += btnAtencionPaciente_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 613);
            Controls.Add(panelContenido);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema SEPRISE - Consultorios y Estudios Clínicos";
            panelHeader.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ConfigurarEncabezadoSeccion(Label label, string iconoSeccion, string titulo, string subtitulo, int x, int y)
        {
            label.Location = new Point(x, y);
            label.Size = new Size(1180, 65); 
            label.BackColor = Color.Transparent;
            label.Text = ""; 

            label.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Color colorPrincipal = Color.FromArgb(0, 150, 136); 

                using (Brush brushCirculo = new SolidBrush(colorPrincipal))
                {
                    g.FillEllipse(brushCirculo, 0, 0, 60, 60);
                }

                using (Font fontIcono = new Font("Segoe UI Emoji", 22F, FontStyle.Regular))
                using (Brush brushIcono = new SolidBrush(Color.White))
                {
                    RectangleF rectCirculo = new RectangleF(2, 2, 60, 60);
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(iconoSeccion, fontIcono, brushIcono, rectCirculo, sf);
                }

                using (Font fontTitulo = new Font("Segoe UI", 12F, FontStyle.Bold))
                using (Brush brushTitulo = new SolidBrush(colorPrincipal))
                {
                    g.DrawString(titulo, fontTitulo, brushTitulo, 65, 2);
                }

                using (Pen penTitulo = new Pen(colorPrincipal, 4))
                {
                    g.DrawLine(penTitulo, 67, 32, 120, 32);
                }

                using (Font fontSub = new Font("Segoe UI", 9F, FontStyle.Regular))
                using (Brush brushSub = new SolidBrush(Color.FromArgb(120, 125, 130)))
                {
                    g.DrawString(subtitulo, fontSub, brushSub, 65, 37);
                }
            };
        }

        private void ConfigurarBotonTarjeta(Button boton, string icono, string titulo, string descripcion, int x, int y)
        {
            boton.Location = new Point(x, y);
            boton.Size = new Size(260, 100);
            boton.BackColor = Color.White;
            boton.Cursor = Cursors.Hand;
            boton.FlatStyle = FlatStyle.Flat;
            boton.Text = ""; 

            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = Color.FromArgb(230, 234, 236);
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 246, 247);
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(225, 235, 236);

            boton.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (Brush brushFondoIcono = new SolidBrush(Color.FromArgb(242, 247, 247)))
                {
                    g.FillRectangle(brushFondoIcono, 15, 35, 60, 60);
                }

                using (Font fontIcono = new Font("Segoe UI Emoji", 22F))
                using (Brush brushIcono = new SolidBrush(Color.FromArgb(0, 150, 136))) 
                {
                    g.DrawString(icono, fontIcono, brushIcono, new RectangleF(15, 35, 60, 60), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }

                using (Font fontTitulo = new Font("Segoe UI", 10.5F, FontStyle.Bold))
                using (Brush brushTitulo = new SolidBrush(Color.FromArgb(33, 37, 41)))
                {
                    g.DrawString(titulo, fontTitulo, brushTitulo, 92, 20);
                }

                using (Font fontDesc = new Font("Segoe UI", 8.5F, FontStyle.Regular))
                using (Brush brushDesc = new SolidBrush(Color.FromArgb(120, 125, 130)))
                {
                    g.DrawString(descripcion, fontDesc, brushDesc, 92, 58);
                }
            };
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelContenido;
        private Panel panelFooter;
        private Label lblWelcome;
        private Label lblSubtitulo;
        private Button btnSalir;
        private Label lblSeccionComun;
        private Button btnPacientes;
        private Label lblSeccionConsultorios;
        private Button btnGestionMedicos;
        private Button btnGestionAgenda;
        private Button btnGestionTurnos;
        private Button btnRecepcionarPaciente;
        private Panel sepAdministracion;
        private Button btnAtencionPaciente;
        private Label lblSeccionEstudios;
        private Label lblIcono;
        private Button btnGestionAgendaEstudios;
        private Button btnGestionTurnosEstudios;
        private Button btnRecepcionarPacienteEstudio;
        private Button btnSolicitudEstudios;
        private Button btnConfirmacionEstudios;
        private Button btnProcesamientoEstudios;
    }
}
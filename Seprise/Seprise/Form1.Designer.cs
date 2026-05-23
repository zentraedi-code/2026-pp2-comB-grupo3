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
            panelMenu = new Panel();
            btnInicio = new Button();
            lblComun = new Label();
            btnPacientes = new Button();
            btnSolicitudEstudio = new Button();
            lblConsultorios = new Label();
            btnGestionMedicos = new Button();
            btnGestionAgenda = new Button();
            btnGestionTurnos = new Button();
            btnRecepcionarPaciente = new Button();
            btnAtencionPaciente = new Button();
            lblEstudios = new Label();
            btnCrearAgendaEstudios = new Button();
            btnConfirmarAgendaEstudios = new Button();
            btnCancelarAgendaEstudios = new Button();
            btnReservarTurnoEstudio = new Button();
            btnCancelarReservaEstudio = new Button();
            btnRecepcionarEstudio = new Button();
            btnFacturarEstudio = new Button();
            btnFinalizarEstudio = new Button();
            btnGenerarInformeEstudio = new Button();
            btnEntregarEstudio = new Button();
            panelContenido = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();

            ConfigurarPanelMenu();
            ConfigurarBotonesMenu();
            ConfigurarPanelContenido();
            ConfigurarFormulario();

            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ResumeLayout(false);
        }

        private void ConfigurarPanelMenu()
        {
            panelMenu.AutoScroll = true;
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(280, 700);
            panelMenu.TabIndex = 0;

            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(lblComun);
            panelMenu.Controls.Add(btnPacientes);
            panelMenu.Controls.Add(btnSolicitudEstudio);
            panelMenu.Controls.Add(lblConsultorios);
            panelMenu.Controls.Add(btnGestionMedicos);
            panelMenu.Controls.Add(btnGestionAgenda);
            panelMenu.Controls.Add(btnGestionTurnos);
            panelMenu.Controls.Add(btnRecepcionarPaciente);
            panelMenu.Controls.Add(btnAtencionPaciente);
            panelMenu.Controls.Add(lblEstudios);
            panelMenu.Controls.Add(btnCrearAgendaEstudios);
            panelMenu.Controls.Add(btnConfirmarAgendaEstudios);
            panelMenu.Controls.Add(btnCancelarAgendaEstudios);
            panelMenu.Controls.Add(btnReservarTurnoEstudio);
            panelMenu.Controls.Add(btnCancelarReservaEstudio);
            panelMenu.Controls.Add(btnRecepcionarEstudio);
            panelMenu.Controls.Add(btnFacturarEstudio);
            panelMenu.Controls.Add(btnFinalizarEstudio);
            panelMenu.Controls.Add(btnGenerarInformeEstudio);
            panelMenu.Controls.Add(btnEntregarEstudio);
        }

        private void ConfigurarBotonesMenu()
        {
            // Botón Inicio
            btnInicio.Location = new Point(10, 10);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(250, 35);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.Click += btnInicio_Click;

            // Label Común
            lblComun.AutoSize = true;
            lblComun.Location = new Point(10, 60);
            lblComun.Name = "lblComun";
            lblComun.TabIndex = 1;
            lblComun.Text = "COMÚN";

            // Botones Común
            ConfigurarBotonMenu(btnPacientes, "ABM Pacientes", 85, btnPacientes_Click);
            ConfigurarBotonMenu(btnSolicitudEstudio, "Crear solicitud de estudio", 120, btnSolicitudEstudio_Click);

            // Label Consultorios
            lblConsultorios.AutoSize = true;
            lblConsultorios.Location = new Point(10, 170);
            lblConsultorios.Name = "lblConsultorios";
            lblConsultorios.TabIndex = 4;
            lblConsultorios.Text = "CONSULTORIOS EXTERNOS";

            // Botones Consultorios
            ConfigurarBotonMenu(btnGestionMedicos, "Gestión Médicos", 195, btnGestionMedicos_Click);
            ConfigurarBotonMenu(btnGestionAgenda, "Gestión de Agenda", 230, btnGestionAgenda_Click);
            ConfigurarBotonMenu(btnGestionTurnos, "Gestión de Turnos", 265, btnGestionTurnos_Click);
            ConfigurarBotonMenu(btnRecepcionarPaciente, "Recepcionar paciente", 300, btnRecepcionarPaciente_Click);
            ConfigurarBotonMenu(btnAtencionPaciente, "Atención paciente", 335, btnAtencionPaciente_Click);

            // Label Estudios
            lblEstudios.AutoSize = true;
            lblEstudios.Location = new Point(10, 385);
            lblEstudios.Name = "lblEstudios";
            lblEstudios.TabIndex = 14;
            lblEstudios.Text = "ESTUDIOS CLÍNICOS";

            // Botones Estudios
            ConfigurarBotonMenu(btnCrearAgendaEstudios, "Crear agenda estudios", 410, btnCrearAgendaEstudios_Click);
            ConfigurarBotonMenu(btnConfirmarAgendaEstudios, "Confirmar agenda estudios", 445, btnConfirmarAgendaEstudios_Click);
            ConfigurarBotonMenu(btnCancelarAgendaEstudios, "Cancelar agenda estudios", 480, btnCancelarAgendaEstudios_Click);
            ConfigurarBotonMenu(btnReservarTurnoEstudio, "Reservar turno estudio", 515, btnReservarTurnoEstudio_Click);
            ConfigurarBotonMenu(btnCancelarReservaEstudio, "Cancelar reserva estudio", 550, btnCancelarReservaEstudio_Click);
            ConfigurarBotonMenu(btnRecepcionarEstudio, "Recepcionar paciente estudio", 585, btnRecepcionarEstudio_Click);
            ConfigurarBotonMenu(btnFacturarEstudio, "Facturar estudio", 620, btnFacturarEstudio_Click);
            ConfigurarBotonMenu(btnFinalizarEstudio, "Finalizar atención estudio", 655, btnFinalizarEstudio_Click);
            ConfigurarBotonMenu(btnGenerarInformeEstudio, "Generar informe estudio", 690, btnGenerarInformeEstudio_Click);
            ConfigurarBotonMenu(btnEntregarEstudio, "Entregar estudio", 725, btnEntregarEstudio_Click);
        }

        private void ConfigurarBotonMenu(Button btn, string texto, int posY, EventHandler clickHandler)
        {
            if (btn == null)
                throw new ArgumentNullException(nameof(btn), $"El botón para '{texto}' es null");

            btn.Location = new Point(10, posY);
            btn.Name = "btn" + texto.Replace(" ", "");
            btn.Size = new Size(250, 35);
            btn.Text = texto;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Click += clickHandler;
        }

        private void ConfigurarPanelContenido()
        {
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Controls.Add(lblSubtitulo);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(280, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(920, 700);
            panelContenido.TabIndex = 1;

            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Consultorios Externos y Estudios Clínicos";

            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(30, 75);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Seleccione una opción del menú para comenzar";
        }

        private void ConfigurarFormulario()
        {
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema PP2 - Consultorios y Estudios Clínicos";
        }

        #endregion

        private Panel panelMenu;
        private Button btnInicio;
        private Label lblComun;
        private Button btnPacientes;
        private Button btnSolicitudEstudio;
        private Label lblConsultorios;
        private Button btnGestionMedicos;
        private Button btnGestionAgenda;
        private Button btnGestionTurnos;
        private Button btnRecepcionarPaciente;
        private Button btnAtencionPaciente;
        private Label lblEstudios;
        private Button btnCrearAgendaEstudios;
        private Button btnConfirmarAgendaEstudios;
        private Button btnCancelarAgendaEstudios;
        private Button btnReservarTurnoEstudio;
        private Button btnCancelarReservaEstudio;
        private Button btnRecepcionarEstudio;
        private Button btnFacturarEstudio;
        private Button btnFinalizarEstudio;
        private Button btnGenerarInformeEstudio;
        private Button btnEntregarEstudio;
        private Panel panelContenido;
        private Label lblTitulo;
        private Label lblSubtitulo;
    }
}

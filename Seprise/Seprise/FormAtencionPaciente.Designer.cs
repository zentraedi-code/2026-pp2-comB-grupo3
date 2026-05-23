using System.Drawing;
using System.Windows.Forms;

namespace Seprise
{
    partial class FormAtencionPaciente
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnRevisarPacientesPendientes;
        private Button btnGenerarHistoriaClinica;
        private Button btnSolicitarEstudios;
        private Button btnSalir;

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
            panelBotones = new Panel();
            btnRevisarPacientesPendientes = new Button();
            btnGenerarHistoriaClinica = new Button();
            btnSolicitarEstudios = new Button();
            btnSalir = new Button();
            panelHeader.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(520, 60);
            panelHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = false;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(520, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Atención paciente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnRevisarPacientesPendientes);
            panelBotones.Controls.Add(btnGenerarHistoriaClinica);
            panelBotones.Controls.Add(btnSolicitarEstudios);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(520, 240);
            panelBotones.TabIndex = 1;

            // Configurar botones centrados en una fila
            int tamañoBoton = 140;
            int espaciado = 15;
            int totalAncho = (tamañoBoton * 3) + (espaciado * 2);
            int inicioX = (520 - totalAncho) / 2;
            int posY = 50;

            ConfigurarBotonConIcono(btnRevisarPacientesPendientes, "Revisar\nPacientes", "📋👥", 
                inicioX, posY, tamañoBoton, btnRevisarPacientesPendientes_Click);

            ConfigurarBotonConIcono(btnGenerarHistoriaClinica, "Generar\nHistoria", "📝🏥", 
                inicioX + tamañoBoton + espaciado, posY, tamañoBoton, btnGenerarHistoriaClinica_Click);

            ConfigurarBotonConIcono(btnSolicitarEstudios, "Solicitar\nEstudios", "🔬📋", 
                inicioX + (tamañoBoton + espaciado) * 2, posY, tamañoBoton, btnSolicitarEstudios_Click);

            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(400, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Click += btnSalir_Click;

            // Efecto hover para btnSalir
            btnSalir.MouseEnter += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(128, 203, 196);
            };
            btnSalir.MouseLeave += (s, e) => {
                btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            };

            // 
            // FormAtencionPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 300);
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAtencionPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atención paciente";
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ConfigurarBotonConIcono(Button btn, string texto, string icono, int x, int y, int tamaño, EventHandler clickHandler)
        {
            btn.Location = new Point(x, y);
            btn.Name = "btn" + texto.Replace(" ", "").Replace("\n", "");
            btn.Size = new Size(tamaño, tamaño);
            btn.TabIndex = 0;
            btn.BackColor = Color.FromArgb(178, 235, 242);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btn.FlatAppearance.BorderSize = 2;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Configurar texto con icono arriba y texto abajo
            btn.Text = $"{icono}\n\n{texto}";
            btn.TextAlign = ContentAlignment.MiddleCenter;

            btn.Click += clickHandler;

            // Efecto hover
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(128, 203, 196);
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.FromArgb(178, 235, 242);
            };
        }

        #endregion
    }
}

namespace Seprise
{
    partial class FormGestionTurnosEstudios
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
            panelBotones = new Panel();
            btnReservarTurno = new Button();
            btnCancelarReserva = new Button();
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
            panelHeader.Size = new Size(450, 60);
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
            lblTitulo.Size = new Size(450, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Turnos - Estudios Clínicos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnReservarTurno);
            panelBotones.Controls.Add(btnCancelarReserva);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(450, 240);
            panelBotones.TabIndex = 1;

            // 
            // btnReservarTurno
            // 
            btnReservarTurno.BackColor = Color.FromArgb(178, 235, 242);
            btnReservarTurno.Cursor = Cursors.Hand;
            btnReservarTurno.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnReservarTurno.FlatAppearance.BorderSize = 2;
            btnReservarTurno.FlatStyle = FlatStyle.Flat;
            btnReservarTurno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReservarTurno.Location = new Point(50, 50);
            btnReservarTurno.Name = "btnReservarTurno";
            btnReservarTurno.Size = new Size(160, 140);
            btnReservarTurno.TabIndex = 0;
            btnReservarTurno.Text = "🔬📅+\n\nReservar Turno";
            btnReservarTurno.TextAlign = ContentAlignment.MiddleCenter;
            btnReservarTurno.UseVisualStyleBackColor = false;
            btnReservarTurno.Click += btnReservarTurno_Click;

            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.BackColor = Color.FromArgb(178, 235, 242);
            btnCancelarReserva.Cursor = Cursors.Hand;
            btnCancelarReserva.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnCancelarReserva.FlatAppearance.BorderSize = 2;
            btnCancelarReserva.FlatStyle = FlatStyle.Flat;
            btnCancelarReserva.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelarReserva.Location = new Point(240, 50);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(160, 140);
            btnCancelarReserva.TabIndex = 1;
            btnCancelarReserva.Text = "✖📅\n\nCancelar Reserva";
            btnCancelarReserva.TextAlign = ContentAlignment.MiddleCenter;
            btnCancelarReserva.UseVisualStyleBackColor = false;
            btnCancelarReserva.Click += btnCancelarReserva_Click;

            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(330, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            // 
            // FormGestionTurnosEstudios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 300);
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGestionTurnosEstudios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Turnos - Estudios Clínicos";
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnReservarTurno;
        private Button btnCancelarReserva;
        private Button btnSalir;
    }
}

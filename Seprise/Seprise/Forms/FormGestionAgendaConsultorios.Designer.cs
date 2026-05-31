namespace Seprise
{
    partial class FormGestionAgendaConsultorios
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
            btnCrearAgenda = new Button();
            btnConfirmarAgenda = new Button();
            btnCancelarAgenda = new Button();
            btnSalir = new Button();
            panelHeader.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();

            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(550, 60);
            panelHeader.TabIndex = 0;

            lblTitulo.AutoSize = false;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Agenda - Consultorios Externos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            panelBotones.Controls.Add(btnCrearAgenda);
            panelBotones.Controls.Add(btnConfirmarAgenda);
            panelBotones.Controls.Add(btnCancelarAgenda);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(550, 240);
            panelBotones.TabIndex = 1;

            btnCrearAgenda.BackColor = Color.FromArgb(178, 235, 242);
            btnCrearAgenda.Cursor = Cursors.Hand;
            btnCrearAgenda.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnCrearAgenda.FlatAppearance.BorderSize = 2;
            btnCrearAgenda.FlatStyle = FlatStyle.Flat;
            btnCrearAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCrearAgenda.Location = new Point(50, 50);
            btnCrearAgenda.Name = "btnCrearAgenda";
            btnCrearAgenda.Size = new Size(140, 140);
            btnCrearAgenda.TabIndex = 0;
            btnCrearAgenda.Text = "📅\n\nCrear Agenda";
            btnCrearAgenda.TextAlign = ContentAlignment.MiddleCenter;
            btnCrearAgenda.UseVisualStyleBackColor = false;
            btnCrearAgenda.Click += btnCrearAgenda_Click;

            btnConfirmarAgenda.BackColor = Color.FromArgb(178, 235, 242);
            btnConfirmarAgenda.Cursor = Cursors.Hand;
            btnConfirmarAgenda.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnConfirmarAgenda.FlatAppearance.BorderSize = 2;
            btnConfirmarAgenda.FlatStyle = FlatStyle.Flat;
            btnConfirmarAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarAgenda.Location = new Point(205, 50);
            btnConfirmarAgenda.Name = "btnConfirmarAgenda";
            btnConfirmarAgenda.Size = new Size(140, 140);
            btnConfirmarAgenda.TabIndex = 1;
            btnConfirmarAgenda.Text = "✓📅\n\nConfirmar Agenda";
            btnConfirmarAgenda.TextAlign = ContentAlignment.MiddleCenter;
            btnConfirmarAgenda.UseVisualStyleBackColor = false;
            btnConfirmarAgenda.Click += btnConfirmarAgenda_Click;

            btnCancelarAgenda.BackColor = Color.FromArgb(178, 235, 242);
            btnCancelarAgenda.Cursor = Cursors.Hand;
            btnCancelarAgenda.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnCancelarAgenda.FlatAppearance.BorderSize = 2;
            btnCancelarAgenda.FlatStyle = FlatStyle.Flat;
            btnCancelarAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelarAgenda.Location = new Point(360, 50);
            btnCancelarAgenda.Name = "btnCancelarAgenda";
            btnCancelarAgenda.Size = new Size(140, 140);
            btnCancelarAgenda.TabIndex = 2;
            btnCancelarAgenda.Text = "✖📅\n\nCancelar Agenda";
            btnCancelarAgenda.TextAlign = ContentAlignment.MiddleCenter;
            btnCancelarAgenda.UseVisualStyleBackColor = false;
            btnCancelarAgenda.Click += btnCancelarAgenda_Click;

            btnSalir.BackColor = Color.FromArgb(178, 235, 242);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 150, 136);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(430, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(550, 300);
            ControlBox = false;
            Controls.Add(panelBotones);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGestionAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Agenda";
            panelHeader.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnCrearAgenda;
        private Button btnConfirmarAgenda;
        private Button btnCancelarAgenda;
        private Button btnSalir;
    }
}

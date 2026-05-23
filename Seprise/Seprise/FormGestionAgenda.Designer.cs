namespace Seprise
{
    partial class FormGestionAgenda
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

            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(550, 60);
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
            lblTitulo.Size = new Size(550, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Agenda";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnCrearAgenda);
            panelBotones.Controls.Add(btnConfirmarAgenda);
            panelBotones.Controls.Add(btnCancelarAgenda);
            panelBotones.Controls.Add(btnSalir);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 60);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(550, 240);
            panelBotones.TabIndex = 1;

            // Configurar botones centrados en una fila
            int margen = 40;
            int tamañoBoton = 140;
            int espaciado = 15;
            int totalAncho = (tamañoBoton * 3) + (espaciado * 2);
            int inicioX = (550 - totalAncho) / 2;
            int posY = 50;

            ConfigurarBotonConIcono(btnCrearAgenda, "Crear Agenda", "📅", 
                inicioX, posY, tamañoBoton, btnCrearAgenda_Click);

            ConfigurarBotonConIcono(btnConfirmarAgenda, "Confirmar Agenda", "✓📅", 
                inicioX + tamañoBoton + espaciado, posY, tamañoBoton, btnConfirmarAgenda_Click);

            ConfigurarBotonConIcono(btnCancelarAgenda, "Cancelar Agenda", "✖📅", 
                inicioX + (tamañoBoton + espaciado) * 2, posY, tamañoBoton, btnCancelarAgenda_Click);

            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(430, 205);
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
            // FormGestionAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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

        private void ConfigurarBotonConIcono(Button btn, string texto, string icono, int x, int y, int tamaño, EventHandler clickHandler)
        {
            btn.Location = new Point(x, y);
            btn.Name = "btn" + texto.Replace(" ", "");
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

        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelBotones;
        private Button btnCrearAgenda;
        private Button btnConfirmarAgenda;
        private Button btnCancelarAgenda;
        private Button btnSalir;
    }
}

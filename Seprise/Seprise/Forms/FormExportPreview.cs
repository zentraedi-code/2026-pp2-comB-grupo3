using System;
using System.Windows.Forms;

namespace Seprise
{
    public class FormExportPreview : Form
    {
        private TextBox txtPreview;
        private Button btnCerrar;

        public FormExportPreview(string contenido)
        {
            InitializeComponent();
            txtPreview.Text = contenido;
        }

        private void InitializeComponent()
        {
            this.txtPreview = new TextBox();
            this.btnCerrar = new Button();

            this.txtPreview.Multiline = true;
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = ScrollBars.Vertical;
            this.txtPreview.Dock = DockStyle.Top;
            this.txtPreview.Height = 420;
            this.txtPreview.Font = new System.Drawing.Font("Consolas", 10F);

            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Dock = DockStyle.Bottom;
            this.btnCerrar.Height = 36;
            this.btnCerrar.Click += (s, e) => this.Close();

            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.btnCerrar);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Vista de exportación";
        }
    }
}

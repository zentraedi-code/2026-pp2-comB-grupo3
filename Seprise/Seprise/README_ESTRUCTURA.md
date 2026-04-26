# Sistema de Consultorios Externos y Estudios Clínicos
## Proyecto PP2 - Seprise

### 📋 Descripción del Sistema

Este proyecto implementa un sistema de gestión de consultorios externos y estudios clínicos basado en el mockup HTML proporcionado en la carpeta `mockup/`.

### 🏗️ Estructura del Proyecto

#### Formularios Implementados

1. **Form1.cs** - Pantalla Principal (CU00 - Inicio)
   - Muestra 3 tarjetas principales:
     - Consultorios externos
     - Estudios clínicos
     - Pacientes
   - Navega a las pantallas correspondientes

2. **FormPacientes.cs** - ABM Pacientes (CU01)
   - Lista de pacientes en DataGridView
   - Botones: Crear, Consultar, Modificar, Desactivar
   - Abre FormPacienteABM para operaciones

3. **FormPacienteABM.cs** - Modal de Paciente
   - Modo: Crear / Consultar / Modificar
   - Campos: DNI, Nombre, Apellido, Teléfono, Email, Dirección, Fecha Nacimiento, Obra Social
   - Validaciones incluidas

4. **FormCrearAgendaMedica.cs** - Crear Agenda Médica (CU04)
   - Campos: Fecha, Día, Hora desde/hasta, Profesional, Consultorio, Duración
   - Panel de notas de validación
   - Botones: Crear agenda, Limpiar

### 🎨 Guía de Estilo (basada en el mockup)

#### Colores

```csharp
// Colores principales
Color.FromArgb(36, 52, 71)      // Azul oscuro - Títulos
Color.FromArgb(102, 102, 102)   // Gris - Subtítulos
Color.FromArgb(47, 111, 171)    // Azul - Botones primarios
Color.FromArgb(47, 143, 85)     // Verde - Botón success (crear)
Color.FromArgb(108, 117, 125)   // Gris - Botones secundarios
Color.FromArgb(178, 59, 59)     // Rojo - Botones danger (eliminar)
Color.FromArgb(250, 250, 250)   // Gris claro - Fondo de cards
Color.FromArgb(255, 248, 220)   // Amarillo claro - Notas/advertencias
Color.FromArgb(241, 241, 241)   // Gris claro - Campos readonly
```

#### Tipografía

```csharp
// Títulos principales
Font("Segoe UI", 18F, FontStyle.Bold)

// Títulos de sección
Font("Segoe UI", 14F, FontStyle.Bold)

// Labels de campos
Font("Segoe UI", 9F, FontStyle.Bold)

// Texto normal
Font("Segoe UI", 9F)
```

#### Componentes Estándar

**Botones:**
```csharp
BackColor = Color.FromArgb(47, 111, 171);
FlatStyle = FlatStyle.Flat;
FlatAppearance.BorderSize = 0;
Font = new Font("Segoe UI", 9F, FontStyle.Bold);
ForeColor = Color.White;
Size = new Size(150, 35);
```

**TextBox:**
```csharp
Size = new Size(350, 27);
```

**Labels:**
```csharp
Font = new Font("Segoe UI", 9F, FontStyle.Bold);
AutoSize = true;
```

### 📝 Casos de Uso del Mockup

#### Común
- ✅ **CU01** - ABM Pacientes
- ⬜ **CU02** - Crear solicitud de estudio

#### Consultorios Externos
- ⬜ **CU03** - ABM Médicos
- ✅ **CU04** - Crear agenda médica
- ⬜ **CU05** - Confirmar agenda médica
- ⬜ **CU06** - Reservar turno médico
- ⬜ **CU07** - Cancelar reserva
- ⬜ **CU08** - Recepcionar paciente
- ⬜ **CU09** - Facturar consulta
- ⬜ **CU10** - Cola de espera médico
- ⬜ **CU11** - Atención médica / Historia clínica
- ⬜ **CU12** - Liquidar honorarios

#### Estudios Clínicos
- ⬜ **CU13** - Crear agenda estudios
- ⬜ **CU14** - Cancelar agenda estudios
- ⬜ **CU15** - Confirmar agenda estudios
- ⬜ **CU16** - Reservar turno estudio
- ⬜ **CU17** - Recepcionar paciente estudio
- ⬜ **CU18** - Facturar estudio
- ⬜ **CU19** - Finalizar atención estudio
- ⬜ **CU20** - Generar informe estudio
- ⬜ **CU21** - Entregar estudio

### 🚀 Cómo Agregar Nuevos Formularios

#### 1. Analizar el mockup HTML

Primero, abre el archivo HTML correspondiente en `mockup/` para ver:
- Título y subtítulo
- Campos del formulario
- Botones y acciones
- Tablas si las hay
- Notas o validaciones

#### 2. Crear los archivos del formulario

```bash
# Crear FormNuevo.cs
# Crear FormNuevo.Designer.cs
```

#### 3. Plantilla básica del Designer

```csharp
namespace Seprise
{
    partial class FormNuevo
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            // ... más controles
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(36, 52, 71);
            lblTitulo.Location = new Point(30, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CU## - Título";

            // lblSubtitulo
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(102, 102, 102);
            lblSubtitulo.Location = new Point(30, 75);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Descripción de la funcionalidad.";

            // FormNuevo
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "FormNuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Título - Sistema PP2";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblSubtitulo;
        // ... más controles
    }
}
```

#### 4. Plantilla básica del Code-Behind

```csharp
namespace Seprise
{
    public partial class FormNuevo : Form
    {
        public FormNuevo()
        {
            InitializeComponent();
            CargarDatos(); // Si es necesario
        }

        private void CargarDatos()
        {
            // Cargar combos, listas, etc.
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Lógica de negocio
                MessageBox.Show("Operación exitosa", "Éxito", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCampos()
        {
            // Validaciones
            return true;
        }
    }
}
```

#### 5. Agregar navegación desde el menú principal

En `Form1.cs`, actualizar el evento del botón correspondiente:

```csharp
private void btnOpcion_Click(object sender, EventArgs e)
{
    var formNuevo = new FormNuevo();
    formNuevo.ShowDialog();
}
```

### 📐 Layout de Campos en Grilla (2 columnas)

```csharp
// Columna izquierda: X = 30
// Columna derecha: X = 420
// Ancho de campo: 350px
// Separación vertical: 70px

// Primera fila
lblCampo1.Location = new Point(30, 140);
txtCampo1.Location = new Point(30, 163);
lblCampo2.Location = new Point(420, 140);
txtCampo2.Location = new Point(420, 163);

// Segunda fila
lblCampo3.Location = new Point(30, 210);
txtCampo3.Location = new Point(30, 233);
lblCampo4.Location = new Point(420, 210);
txtCampo4.Location = new Point(420, 233);
```

### 🔄 DataGridView con Botones de Acción

```csharp
// Configuración del DataGridView
dgvDatos.AllowUserToAddRows = false;
dgvDatos.AllowUserToDeleteRows = false;
dgvDatos.BackgroundColor = Color.White;
dgvDatos.ReadOnly = true;
dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
dgvDatos.MultiSelect = false;

// Agregar columnas de botones
DataGridViewButtonColumn btnColumna = new DataGridViewButtonColumn();
btnColumna.HeaderText = "";
btnColumna.Name = "btnAccion";
btnColumna.Text = "Acción";
btnColumna.UseColumnTextForButtonValue = true;
btnColumna.Width = 110;
dgvDatos.Columns.Add(btnColumna);

// Manejar clicks en botones
dgvDatos.CellContentClick += (s, e) => {
    if (e.RowIndex < 0) return;
    if (e.ColumnIndex == btnAccion.Index)
    {
        // Acción del botón
    }
};
```

### 💡 Tips y Mejores Prácticas

1. **Nombres de controles:** Usar prefijos estándar (lbl, txt, btn, cbo, dtg, pnl, etc.)
2. **TabIndex:** Configurar en orden lógico para navegación con teclado
3. **Validaciones:** Siempre validar antes de procesar datos
4. **Mensajes:** Usar MessageBox con iconos apropiados (Information, Warning, Error)
5. **Centrado:** Usar `StartPosition = FormStartPosition.CenterScreen` o `CenterParent`
6. **Modales:** Usar `ShowDialog()` en lugar de `Show()` para formularios modales
7. **DialogResult:** Configurar en formularios modales para saber el resultado

### 🔍 Referencia Rápida de Mockup HTML

Para convertir elementos HTML a WinForms:

| HTML | WinForms |
|------|----------|
| `<input type="text">` | `TextBox` |
| `<input type="date">` | `DateTimePicker` |
| `<input type="number">` | `TextBox` o `NumericUpDown` |
| `<select>` | `ComboBox` |
| `<textarea>` | `TextBox` (Multiline = true) |
| `<button>` | `Button` |
| `<table>` | `DataGridView` |
| `<div class="note">` | `Panel` con color de fondo |
| `<label>` | `Label` |

### 📦 Archivos del Proyecto

```
Seprise/
├── Form1.cs                        # Pantalla principal
├── Form1.Designer.cs
├── FormPacientes.cs                # ABM Pacientes
├── FormPacientes.Designer.cs
├── FormPacienteABM.cs             # Modal de paciente
├── FormPacienteABM.Designer.cs
├── FormCrearAgendaMedica.cs       # Crear agenda médica
├── FormCrearAgendaMedica.Designer.cs
├── Program.cs                      # Entry point
└── mockup/                         # Mockups HTML de referencia
    ├── index.html
    ├── pacientes.html
    ├── crear-agenda-medica.html
    └── ... (otros mockups)
```

### 🎯 Próximos Pasos Sugeridos

1. Implementar **CU03 - ABM Médicos** (similar a Pacientes)
2. Crear formularios de **Reservar turno médico**
3. Agregar formulario de **Solicitud de estudio**
4. Implementar **Historia clínica / Atención médica**
5. Crear reportes e informes

### 📞 Soporte

Para agregar más formularios basados en el mockup, simplemente indica qué caso de uso (CU) necesitas y generaré el código correspondiente siguiendo esta estructura y estilo.

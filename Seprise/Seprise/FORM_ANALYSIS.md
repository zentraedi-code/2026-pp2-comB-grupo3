# Form Analysis - Redesign Planning

## Overview
Analysis of three medical application forms that will be redesigned with a vertical card-based layout similar to FormLiquidarHonorarios.

---

## 1. FormGenerarHistoriaClinica

### Purpose & Functionality
- **Use Case**: CU05 - Generate Clinical History
- **Flow**: Doctor attends a patient during a consultation, then records the clinical history and finalizes the appointment
- **Key Action**: Creates a medical history record tied to a consultation turn
- **Workflow State**: Moves appointment from "IN_PROGRESS" to "FINALIZADO" (FINISHED)

### Current UI Structure
**Controls Layout (Horizontal Grid):**
- **Header Section** (2 rows):
  - Title: "Generar historia clínica"
  - Subtitle: "El médico atiende al paciente, registra la historia clínica y finaliza la atención."

- **Patient/Doctor/Date Section** (4 columns):
  - `txtPaciente` (disabled) - Patient name [20,110] size 250x23
  - `txtMedico` (disabled) - Doctor name [290,110] size 250x23
  - `dtpFechaAtencion` - Appointment date/time [560,110] size 200x23
  - `txtEstadoTurno` (disabled) - Turn state [780,110] size 150x23

- **Medical Information Section** (3 large fields):
  - `txtMotivo` - Reason for visit (multiline, 70px height)
  - `txtDiagnostico` - Diagnosis/evolution (multiline, 70px height)
  - `txtIndicaciones` - Treatment/recommendations (multiline, 70px height)

- **Additional Elements**:
  - `lblNota` - Explanatory note (max width 910px)
  - `btnGuardar` "Guardar historia y finalizar atención" [20,480]
  - `btnSolicitarEstudio` "Solicitar estudio" [280,480]
  - `dgvEstudios` - DataGridView for requested studies [20,530] size 910x150
    - Columns: ID, Tipo, Origen, Estado

### Key Methods & Logic
```csharp
public void SetAtencion(int pacienteId, int medicoId, int turnoConsultaId, 
                        string pacienteNombre, string medicoNombre, string estadoTurno)
// Populates form with appointment data

private void btnGuardar_Click(object sender, EventArgs e)
// Validation → Create HistoriaClinica object → Save to DB → Update turn status to FINALIZADO

private bool ValidarCampos()
// Validates: Motivo de consulta (required), Diagnostico (required)

private void ConfigurarDataGridView()
// Sets up studies grid with readonly configuration
```

### Database Operations
- **DAO Used**: `HistoriaClinicaDao`
- **Entity**: `HistoriaClinica`
- **Operation**: `guardar()` - Inserts clinical history
- **Related Operations**: 
  - `TurnoConsultaDao.atenderTurno()` - Marks turn as FINALIZADO (indirectly via status change)
- **Tables Accessed**: 
  - `historia_clinica` (INSERT)
  - `turno_consulta` (UPDATE on estado)

---

## 2. FormConfirmarAsistencia

### Purpose & Functionality
- **Use Case**: CU03 - Confirm Patient Attendance
- **Flow**: Reception staff confirms when patient arrives at medical center
- **Key Action**: Searches for reserved appointments by patient and date, then confirms attendance
- **Workflow State**: Moves appointment from "RESERVADO" to "RECEPCIONADO" (RECEIVED)
- **Impact**: Turn becomes available for doctor's queue and billing

### Current UI Structure
**Controls Layout (Simple linear):**
- **Header Section**:
  - Title: "Confirmar asistencia"
  - Subtitle: "Confirmación de asistencia del paciente al llegar al centro médico."

- **Patient Search Section** (2 rows):
  - `txtDniPaciente` - Patient DNI input [20,110] size 200x23
  - `btnBuscarPaciente` "🔍 Buscar" [230,110] size 75x23
  - `txtPaciente` (disabled) - Patient name [320,110] size 300x23

- **Date Search Section**:
  - `dtpFecha` - Date picker [20,170] size 285x23
  - `btnBuscar` "Buscar turno reservado" [20,210] size 180x30

- **Results Section**:
  - `dgvTurnos` - DataGridView [20,260] size 800x250
    - Columns: Hora, Paciente, Médico, Consultorio, Estado, btnConfirmar (button column)
    - Clicking "Confirmar" button confirms attendance for that turn

- **Footer**:
  - `lblNota` - Explanatory note about what happens when confirmed
  - `btnSalir` - Exit button [745,520]

**Grid Configuration**:
- Read-only, full row selection, single select mode
- Button column for inline confirmation action

### Key Methods & Logic
```csharp
private void btnBuscarPaciente_Click(object sender, EventArgs e)
// Validates DNI input → Calls PacienteDao.buscar(dni) → Stores result in pacienteSeleccionado

private void btnBuscar_Click(object sender, EventArgs e)
// Validates patient selected → Gets date from dtpFecha → 
// Calls TurnoConsultaDao.buscarReservadosPorPaciente() → Populates grid

private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
// Intercepts button column click → Gets turnoId from row Tag → 
// Calls TurnoConsultaDao.confirmarAsistencia(turnoId) → Updates grid Estado to "RECEPCIONADO"
```

### Database Operations
- **DAOs Used**: 
  - `PacienteDao` - Search by DNI
  - `TurnoConsultaDao` - Query and update turns
- **Entities**: `Paciente`, `TurnoConsulta`
- **Operations**:
  - `PacienteDao.buscar(dni)` - Searches active patient by DNI
  - `TurnoConsultaDao.buscarReservadosPorPaciente(pacienteId, fecha)` - Returns DataTable with reserved turns
  - `TurnoConsultaDao.confirmarAsistencia(turnoId)` - Updates turn status to RECEPCIONADO
- **Tables Accessed**: 
  - `paciente` (SELECT)
  - `turno_consulta` (SELECT, UPDATE estado to RECEPCIONADO)

---

## 3. FormFacturarConsulta

### Purpose & Functionality
- **Use Case**: CU10 - Bill Consultation
- **Flow**: Administrative staff bills for consultations after patient reception
- **Key Action**: Creates invoice for RECEPCIONADO (received) appointments
- **Workflow State**: Moves appointment from "RECEPCIONADO" to "ATENDIDO" (ATTENDED)
- **Invoice State**: Created as "EMITIDA" (ISSUED)

### Current UI Structure
**Controls Layout (Form-based):**
- **Header Section**:
  - Title: "CU10 - Facturar consulta"
  - Subtitle: "Facturación de la consulta médica luego de recepcionar al paciente."

- **Patient Selection Section**:
  - `cmbPaciente` (DropDownList) - Populated with TurnoRecepcionadoItem objects [20,110] size 400x23
  - Display format: "DNI - Nombre - HH:mm - Médico"

- **Information Section** (horizontal layout):
  - Row 1: `txtMedico` (disabled) [20,170] + `txtConcepto` (disabled) [340,170]
  - Row 2: `txtImporte` [20,230] + `cmbMedioPago` [240,230] + `txtEstadoFactura` (disabled) [460,230]

- **Action Buttons** (horizontal):
  - `btnEmitir` "Emitir factura" [20,280] - Green button
  - `btnImprimir` "Imprimir comprobante" [150,280] - Green button
  - `btnSalir` "Salir" [565,280] - Green button

### Key Data Model
**TurnoRecepcionadoItem** (inner class):
```csharp
public int TurnoId { get; set; }
public int PacienteId { get; set; }
public string? PacienteNombre { get; set; }
public string? Dni { get; set; }
public string? MedicoNombre { get; set; }
public decimal ImporteConsulta { get; set; }
public DateTime TurnoFechaHora { get; set; }
```

### Key Methods & Logic
```csharp
private void CargarTurnosRecepcionados()
// Queries TurnoConsultaDao.buscarRecepcionados() → Creates TurnoRecepcionadoItem for each row →
// Populates cmbPaciente with items

private void cmbPaciente_SelectedIndexChanged(object? sender, EventArgs e)
// Extracts doctor name and import amount from selected TurnoRecepcionadoItem →
// Populates txtMedico and txtImporte

private void btnEmitir_Click(object sender, EventArgs e)
// Validates: patient selected, importe > 0, medio de pago selected →
// Creates Factura object with ImporteConsulta, tipo_cobertura (PARTICULAR or OBRA_SOCIAL) →
// Calls FacturaDao.agregar(factura) →
// Calls TurnoConsultaDao.atenderTurno(turnoId) →
// Removes item from combo and selects next turn →
// Updates txtEstadoFactura to "EMITIDA"

private bool ValidarCampos()
// Validates: cmbPaciente selected, txtImporte is valid decimal > 0, cmbMedioPago selected
```

### Database Operations
- **DAOs Used**:
  - `TurnoConsultaDao` - Query and update turns
  - `FacturaDao` - Insert new invoices
- **Entities**: `Factura` (constructor params: Id, pacienteId, turnoId, null, importe, tipo_cobertura, estado="EMITIDA", fechaEmision=NOW)
- **Operations**:
  - `TurnoConsultaDao.buscarRecepcionados()` - Returns DataTable of RECEPCIONADO turns with join info
  - `FacturaDao.agregar(factura)` - Inserts new invoice record
  - `TurnoConsultaDao.atenderTurno(turnoId)` - Updates turn status to ATENDIDO
- **Tables Accessed**: 
  - `turno_consulta` (SELECT with JOIN, UPDATE estado to ATENDIDO)
  - `factura` (INSERT)
  - Implied: `paciente`, `medico`, `consultorio` (via JOIN in query)

---

## Target Layout Pattern (FormLiquidarHonorarios)

FormLiquidarHonorarios demonstrates the **vertical card-based layout** to emulate:

### Structure:
- **Top Section**: Control bar with search/filter parameters (compact, inline)
  - ComboBox, DateTimePicker controls in a single row
  - Action buttons: "Buscar", "Exportar"

- **Content Area**: Scrollable panel (`pnlResultados`)
  - `AutoScroll = true`
  - `BackColor` = Light gray background (RGB 245,245,245)
  - `BorderStyle = FixedSingle`
  - Size: 770x400

- **Card/Tarjeta Design**:
  - Panel as container for each data item
  - Size: 730x80 per card
  - White background
  - Vertical positioning with 10px spacing between cards
  - Multiple labels with different font styles/sizes within each card
  - Example tarjeta contains: Médico name, Consultas count, Honorario amount, Total amount

### Key Implementation Details:
- Cards are dynamically created and added to `pnlResultados.Controls`
- Each card is a Panel with internal Labels for data display
- Y position incremented (yPos += 100) for stacked layout
- Bold titles, secondary info in smaller fonts
- Color accents for important values (e.g., green for totals)

---

## Redesign Recommendations

### FormGenerarHistoriaClinica (Card-Based)
**Layout Concept:**
- **Top Bar**: Title + Subtitle (styled header)
- **Patient Info Card**: 
  - Paciente name, Médico name, Appointment date, Estado turno
  - All fields in single card, read-only
- **Consultation Details Card**:
  - Motivo de consulta (text area)
  - Diagnóstico/evolución (text area)
  - Indicaciones (text area)
- **Studies Section**:
  - Either as another card or keep as DataGridView below
- **Action Buttons**: Bottom row (Guardar historia, Solicitar estudio)

### FormConfirmarAsistencia (Card-Based)
**Layout Concept:**
- **Top Bar**: Search filters (DNI, Patient name, Date picker, Search button)
- **Results Container** (scrollable panel with cards):
  - Each card represents one found appointment
  - Shows: Time, Patient, Doctor, Office, Estado
  - Include inline "Confirm" button on each card
- **Benefits**: Easier mobile-like interaction, better use of space, clearer data presentation

### FormFacturarConsulta (Card-Based)
**Layout Concept:**
- **Top Bar**: Patient selection (ComboBox) + search trigger
- **Patient Info Card**:
  - Selected patient details (Doctor, Appointment time, Patient name)
  - Read-only fields
- **Invoice Details Card**:
  - Concepto (Consulta médica)
  - Importe (editable)
  - Medio de pago (ComboBox)
  - Estado factura (read-only)
- **Action Buttons**: Bottom (Emitir factura, Imprimir, Salir)

---

## Summary Table

| Aspect | FormGenerarHistoriaClinica | FormConfirmarAsistencia | FormFacturarConsulta |
|--------|---------------------------|----------------------|-------------------|
| **Purpose** | Record patient medical history and close appointment | Confirm patient arrival and update turn state | Create invoice for attended consultation |
| **Primary DAO** | HistoriaClinicaDao | TurnoConsultaDao, PacienteDao | FacturaDao, TurnoConsultaDao |
| **Workflow State Change** | RECEPCIONADO → FINALIZADO | RESERVADO → RECEPCIONADO | RECEPCIONADO → ATENDIDO |
| **Key Table** | historia_clinica (INSERT) | turno_consulta (SELECT/UPDATE) | factura (INSERT), turno_consulta (UPDATE) |
| **Grid/Table Used** | dgvEstudios (studies list) | dgvTurnos (appointment results) | cmbPaciente (custom items) |
| **Main Validation** | Motivo, Diagnostico required | Patient searched first | Importe > 0, medio de pago |
| **Current Layout** | Horizontal grid (wide fields) | Linear form with results grid | Compact form layout |
| **Redesign Priority** | High - Many fields | High - Table with actions | Medium - Already compact |


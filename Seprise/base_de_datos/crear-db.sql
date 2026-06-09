-- Eliminar base si existe
DROP DATABASE IF EXISTS clinica_seprise;

-- Crear base nueva
CREATE DATABASE clinica_seprise;

use clinica_seprise;

-- ESPECIALIDAD
CREATE TABLE especialidad (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(255),
    duracion_minima_turno INT NOT NULL,
    activo BOOLEAN NOT NULL
);

-- MEDICO
CREATE TABLE medico (
    id INT AUTO_INCREMENT PRIMARY KEY,
    especialidad_id INT NOT NULL,
    matricula VARCHAR(50) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    importe_consulta DECIMAL(10,2) NOT NULL,
    activo BOOLEAN NOT NULL,
    FOREIGN KEY (especialidad_id) REFERENCES especialidad(id)
);

-- PACIENTE
CREATE TABLE paciente (
    id INT AUTO_INCREMENT PRIMARY KEY,
    dni VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    telefono VARCHAR(50),
    email VARCHAR(100),
    direccion VARCHAR(200),
    obra_social VARCHAR(100),
    activo BOOLEAN NOT NULL
);


-- CONSULTORIO

CREATE TABLE consultorio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    activo BOOLEAN NOT NULL
);


-- AGENDA_MEDICA

CREATE TABLE agenda_medica (
    id INT AUTO_INCREMENT PRIMARY KEY,
    medico_id INT NOT NULL,
    consultorio_id INT NOT NULL,
    fecha DATE NOT NULL,
    hora_desde TIME NOT NULL,
    hora_hasta TIME NOT NULL,
    duracion_turno_minutos INT NOT NULL,
    sobre_turnos_por_hora INT NOT NULL,
    estado VARCHAR(20) NOT NULL,
    FOREIGN KEY (medico_id) REFERENCES medico(id),
    FOREIGN KEY (consultorio_id) REFERENCES consultorio(id)
);


-- TURNO_CONSULTA

CREATE TABLE turno_consulta (
    id INT AUTO_INCREMENT PRIMARY KEY,
    agenda_medica_id INT NOT NULL,
    paciente_id INT,
    fecha_hora_turno DATETIME NOT NULL,
    es_sobreturno BOOLEAN NOT NULL,
    estado VARCHAR(20) NOT NULL,
    fecha_asignacion DATETIME,
    fecha_recepcion DATETIME,
    fecha_atencion DATETIME,
    FOREIGN KEY (agenda_medica_id) REFERENCES agenda_medica(id),
    FOREIGN KEY (paciente_id) REFERENCES paciente(id)
);


-- ESTUDIO

CREATE TABLE estudio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    requiere_turno BOOLEAN NOT NULL,
    requiere_ayuno BOOLEAN NOT NULL,
    activo BOOLEAN NOT NULL
);


-- AGENDA_ESTUDIO

CREATE TABLE agenda_estudio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    estudio_id INT NOT NULL,
    fecha DATE NOT NULL,
    hora_desde TIME NOT NULL,
    hora_hasta TIME NOT NULL,
    duracion_turno_minutos INT NOT NULL,
    estado VARCHAR(20) NOT NULL,
    FOREIGN KEY (estudio_id) REFERENCES estudio(id)
);


-- TURNO_ESTUDIO

CREATE TABLE turno_estudio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    agenda_estudio_id INT NOT NULL,
    paciente_id INT,
    fecha_hora_turno DATETIME NOT NULL,
    estado VARCHAR(20) NOT NULL,
    fecha_asignacion DATETIME,
    fecha_recepcion DATETIME,
    FOREIGN KEY (agenda_estudio_id) REFERENCES agenda_estudio(id),
    FOREIGN KEY (paciente_id) REFERENCES paciente(id)
);


-- ORIGEN_ATENCION

CREATE TABLE origen_atencion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);


-- SOLICITUD_ESTUDIO

CREATE TABLE solicitud_estudio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    paciente_id INT NOT NULL,
    estudio_id INT NOT NULL,
    medico_id INT,
    es_externo BOOLEAN NOT NULL,
    medico_solicitante_externo VARCHAR(255),
    turno_estudio_id INT,
    origen_atencion_id INT NOT NULL,
    fecha_solicitud DATETIME NOT NULL,
    fecha_realizacion DATETIME,
    fecha_resultado DATETIME,
    fecha_retiro DATETIME,
    resultado TEXT,
    estado VARCHAR(20) NOT NULL,
    FOREIGN KEY (paciente_id) REFERENCES paciente(id),
    FOREIGN KEY (estudio_id) REFERENCES estudio(id),
    FOREIGN KEY (medico_id) REFERENCES medico(id),
    FOREIGN KEY (turno_estudio_id) REFERENCES turno_estudio(id),
    FOREIGN KEY (origen_atencion_id) REFERENCES origen_atencion(id)
);


-- HISTORIA_CLINICA

CREATE TABLE historia_clinica (
    id INT AUTO_INCREMENT PRIMARY KEY,
    paciente_id INT NOT NULL,
    medico_id INT NOT NULL,
    turno_consulta_id INT NOT NULL,
    fecha_carga DATETIME NOT NULL,
    motivo_consulta TEXT NOT NULL,
    diagnostico TEXT NOT NULL,
    indicaciones TEXT NOT NULL,
    FOREIGN KEY (paciente_id) REFERENCES paciente(id),
    FOREIGN KEY (medico_id) REFERENCES medico(id),
    FOREIGN KEY (turno_consulta_id) REFERENCES turno_consulta(id)
);


-- FACTURA

CREATE TABLE factura (
    id INT AUTO_INCREMENT PRIMARY KEY,
    paciente_id INT NOT NULL,
    turno_consulta_id INT,
    solicitud_estudio_id INT,
    importe_total DECIMAL(10,2) NOT NULL,
    tipo_cobertura VARCHAR(20) NOT NULL,
    estado VARCHAR(20) NOT NULL,
    fecha_emision DATETIME NOT NULL,
    FOREIGN KEY (paciente_id) REFERENCES paciente(id),
    FOREIGN KEY (turno_consulta_id) REFERENCES turno_consulta(id),
    FOREIGN KEY (solicitud_estudio_id) REFERENCES solicitud_estudio(id)
);


-- INSUMO

CREATE TABLE insumo (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descripcion VARCHAR(255) NOT NULL,
    stock_actual INT NOT NULL,
    activo BOOLEAN NOT NULL
);


-- ESTUDIO_INSUMO

CREATE TABLE estudio_insumo (
    id INT AUTO_INCREMENT PRIMARY KEY,
    estudio_id INT NOT NULL,
    insumo_id INT NOT NULL,
    cantidad_requerida INT NOT NULL,
    FOREIGN KEY (estudio_id) REFERENCES estudio(id),
    FOREIGN KEY (insumo_id) REFERENCES insumo(id)
);


-- ESPECIALIDAD
INSERT INTO especialidad (id, nombre, descripcion, duracion_minima_turno, activo) VALUES
(1, 'Clínica Médica', NULL, 15, true),
(2, 'Pediatría', NULL, 15, true),
(3, 'Cardiología', NULL, 15, true),
(4, 'Traumatología', NULL, 15, true),
(5, 'Ginecología', NULL, 15, true),
(6, 'Fisio-kinesiología', NULL, 25, true),
(7, 'Salud mental', NULL, 30, true);
-- CONSULTORIO
INSERT INTO consultorio (id, nombre, activo) VALUES
(1, 'Consultorio 1', true),
(2, 'Consultorio 2', true),
(3, 'Consultorio 3', true),
(4, 'Consultorio 4', true);

-- ESTUDIO
INSERT INTO estudio (id, nombre, precio, requiere_turno, requiere_ayuno, activo) VALUES
(1, 'Análisis de sangre', 5000, false, true, true),
(2, 'Radiografía', 8000, true, false, true),
(3, 'Ecografía', 12000, true, false, true),
(4, 'Resonancia magnética', 25000, true, false, true),
(5, 'Tomografía', 20000, true, false, true);

-- ORIGEN_ATENCION
INSERT INTO origen_atencion (id, descripcion) VALUES
(1, 'CONSULTORIO_EXTERNO'),
(2, 'LABORATORIO'),
(3, 'GUARDIA'),
(4, 'INTERNACION'),
(5, 'EXTERNO');

-- INSUMO
INSERT INTO insumo (id, descripcion, stock_actual, activo) VALUES
(1, 'Gasa 10x10 caja x10', 100, true),
(2, 'Jeringa 5 ml', 200, true),
(3, 'Jeringa 20 ml', 150, true),
(4, 'Tubo de ensayo', 300, true),
(5, 'Guantes descartables', 500, true),
(6, 'Alcohol 70%', 50, true);

-- ESTUDIO_INSUMO
INSERT INTO estudio_insumo (estudio_id, insumo_id, cantidad_requerida) VALUES
-- Análisis de sangre
(1, 2, 1),
(1, 4, 1),
(1, 6, 1),

-- Radiografía
(2, 5, 1),

-- Ecografía
(3, 6, 1),
(3, 5, 1),

-- Resonancia
(4, 5, 1),

-- Tomografía
(5, 5, 1);


-- MEDICO
INSERT INTO medico (id, especialidad_id, matricula, nombre, apellido, importe_consulta, activo) VALUES
(1, 1, 'MP-10234', 'Laura',    'Gómez',      8500.00, true),
(2, 3, 'MP-20871', 'Carlos',   'Martínez',  12000.00, true),
(3, 2, 'MP-33456', 'Ana',      'Fernández',  7500.00, true),
(4, 4, 'MP-41122', 'Roberto',  'Díaz',       9000.00, true),
(5, 5, 'MP-55678', 'Valeria',  'López',      8000.00, true),
(6, 6, 'MP-60093', 'Marcelo',  'Pereyra',    6500.00, true),
(7, 7, 'MP-71845', 'Silvina',  'Torres',    10000.00, true);

INSERT INTO paciente (id, dni, nombre, apellido, fecha_nacimiento, telefono, obra_social, activo) VALUES
(1, '30111222', 'Juan Ignacio', 'Pérez', '1983-05-14', '1144556677', 'OSDE', true),
(2, '35444555', 'María Belén', 'Rodríguez', '1990-11-23', '1122334455', 'SWISS MEDICAL', true),
(3, '28777888', 'Diego Armando', 'Maradona', '1980-10-30', '1199887766', 'PARTICULAR', true),
(4, '40123456', 'Sofía Valentina', 'González', '1997-03-08', '261456789', 'GALENO', true),
(5, '42888999', 'Lucas Mateo', 'Silva', '2000-07-19', '341654321', 'OSECAC', true),
(6, '22333444', 'Patricia Noemí', 'Sánchez', '1972-01-15', '351987654', 'PAMI', true),
(7, '38555666', 'Facundo Ezequiel', 'Romero', '1994-09-02', '2215554433', 'IOMA', true),
(8, '45111222', 'Martina Paz', 'Álvarez', '2003-12-11', '2613334455', 'MEDIFE', true),
(9, '33666777', 'Gonzalo Javier', 'Benítez', '1988-04-25', '1133445566', 'SANCOR SALUD', true),
(10, '18444555', 'Jorge Alberto', 'García', '1967-06-30', '1177665544', 'PAMI', true),
(11, '95123789', 'Camila Inés', 'Herrera', '1999-08-14', '3512223344', 'PARTICULAR', true);

INSERT INTO agenda_medica (id, medico_id, consultorio_id, fecha, hora_desde, hora_hasta, duracion_turno_minutos, sobre_turnos_por_hora, estado) VALUES
(1, 1, 1, '2026-06-05', '08:00:00', '12:00:00', 15, 1, 'ACTIVA'), -- Dra. Gómez
(2, 2, 2, '2026-06-05', '09:00:00', '13:00:00', 15, 0, 'ACTIVA'), -- Dr. Martínez
(3, 3, 3, '2026-06-05', '14:00:00', '18:00:00', 15, 2, 'ACTIVA'), -- Dra. Fernández
(4, 4, 4, '2026-06-05', '08:00:00', '12:00:00', 15, 1, 'ACTIVA'), -- Dr. Díaz
(5, 5, 1, '2026-06-05', '14:00:00', '20:00:00', 15, 1, 'ACTIVA'), -- Dra. López
(6, 6, 2, '2026-06-06', '08:00:00', '12:00:00', 25, 0, 'ACTIVA'), -- Dr. Pereyra
(7, 7, 3, '2026-06-06', '09:00:00', '13:00:00', 30, 0, 'ACTIVA'), -- Dra. Torres
(8, 1, 4, '2026-06-06', '08:00:00', '12:00:00', 15, 1, 'ACTIVA'), -- Dra. Gómez
(9, 2, 1, '2026-06-06', '09:00:00', '13:00:00', 15, 0, 'ACTIVA'), -- Dr. Martínez
(10, 3, 2, '2026-06-06', '14:00:00', '18:00:00', 15, 2, 'ACTIVA'), -- Dra. Fernández
(11, 4, 3, '2026-06-06', '14:00:00', '18:00:00', 15, 1, 'ACTIVA'); -- Dr. Díaz

INSERT INTO turno_consulta (id, agenda_medica_id, paciente_id, fecha_hora_turno, es_sobreturno, estado, fecha_asignacion, fecha_recepcion, fecha_atencion) VALUES
(1, 1, 1, '2026-06-05 08:00:00', false, 'RESERVADO', '2026-06-01 10:00:00', '2026-06-05 07:50:00', NULL),
(2, 2, 2, '2026-06-05 09:15:00', false, 'RESERVADO', '2026-05-28 09:30:00', '2026-06-05 09:02:00', NULL),
(3, 3, 3, '2026-06-05 14:30:00', false, 'RESERVADO', '2026-06-02 11:15:00', '2026-06-05 14:15:00', NULL),
(4, 4, 4, '2026-06-05 10:45:00', false, 'RESERVADO', '2026-06-04 16:20:00', '2026-06-05 10:35:00', NULL),
(5, 5, 5, '2026-06-05 15:00:00', false, 'RESERVADO', '2026-05-30 08:10:00', '2026-06-05 14:55:00', NULL),
(6, 6, 6, '2026-06-06 08:30:00', false, 'RECEPCIONADO', '2026-06-03 09:00:00', '2026-06-06 08:15:00', NULL),
(7, 7, 7, '2026-06-06 10:00:00', false, 'RECEPCIONADO', '2026-06-01 14:00:00', '2026-06-06 09:45:00', NULL),
(8, 8, 8, '2026-06-06 11:15:00', false, 'RECEPCIONADO', '2026-06-02 15:30:00', '2026-06-06 11:00:00', NULL),
(9, 9, 9, '2026-06-06 09:45:00', false, 'RECEPCIONADO', '2026-05-29 17:00:00', '2026-06-06 09:30:00', NULL),
(10, 10, 10, '2026-06-06 16:15:00', false, 'RECEPCIONADO', '2026-06-04 11:00:00', '2026-06-06 16:00:00', NULL),
(11, 11, 11, '2026-06-06 15:00:00', true, 'RECEPCIONADO', '2026-06-06 12:00:00', '2026-06-06 14:45:00', NULL);

INSERT INTO factura (id, paciente_id, turno_consulta_id, solicitud_estudio_id, importe_total, tipo_cobertura, estado, fecha_emision) VALUES
(1, 1, 1, NULL, 8500.00, 'OBRA_SOCIAL', 'PAGADA', '2026-06-05 07:52:00'),   -- Turno 1 -> Medico 1 ($8500)
(2, 2, 2, NULL, 12000.00, 'OBRA_SOCIAL', 'PAGADA', '2026-06-05 09:03:00'),  -- Turno 2 -> Medico 2 ($12000)
(3, 3, 3, NULL, 7500.00, 'PARTICULAR', 'PAGADA', '2026-06-05 14:16:00'),   -- Turno 3 -> Medico 3 ($7500)
(4, 4, 4, NULL, 9000.00, 'OBRA_SOCIAL', 'EMITIDA', '2026-06-05 10:36:00'),  -- Turno 4 -> Medico 4 ($9000)
(5, 5, 5, NULL, 8000.00, 'OBRA_SOCIAL', 'PAGADA', '2026-06-05 14:56:00'),   -- Turno 5 -> Medico 5 ($8000)
(6, 6, 6, NULL, 6500.00, 'OBRA_SOCIAL', 'PAGADA', '2026-06-06 08:16:00'),   -- Turno 6 -> Medico 6 ($6500)
(7, 7, 7, NULL, 10000.00, 'OBRA_SOCIAL', 'EMITIDA', '2026-06-06 09:46:00'), -- Turno 7 -> Medico 7 ($10000)
(8, 8, 8, NULL, 8500.00, 'OBRA_SOCIAL', 'PAGADA', '2026-06-06 11:01:00'),   -- Turno 8 -> Medico 1 ($8500)
(9, 9, 9, NULL, 12000.00, 'OBRA_SOCIAL', 'PAGADA', '2026-06-06 09:31:00'),  -- Turno 9 -> Medico 2 ($12000)
(10, 10, 10, NULL, 7500.00, 'OBRA_SOCIAL', 'PAGADA', '2026-06-06 16:01:00'),-- Turno 10 -> Medico 3 ($7500)
(11, 11, 11, NULL, 9000.00, 'PARTICULAR', 'PAGADA', '2026-06-06 14:46:00'); -- Turno 11 -> Medico 4 ($9000)


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
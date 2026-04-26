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

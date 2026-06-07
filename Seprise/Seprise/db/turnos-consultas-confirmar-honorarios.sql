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
-- Migración: agregar campos email y direccion a la tabla paciente
-- Ejecutar sobre una base de datos clinica_seprise ya existente
-- (si se recrea la base con crear-db.sql, estos campos ya están incluidos).

use clinica_seprise;

ALTER TABLE paciente
    ADD COLUMN email VARCHAR(100) AFTER telefono,
    ADD COLUMN direccion VARCHAR(200) AFTER email;

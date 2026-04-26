function openPacienteModal(modo) {
      const esConsulta = modo === 'consultar';
      const titulo = modo === 'crear' ? 'Crear paciente' : modo === 'modificar' ? 'Modificar paciente' : 'Consultar paciente';
      const modalTitle = document.getElementById('modal-title');
      const modalContent = document.getElementById('modal-content');
      const modalSave = document.getElementById('modal-save');

      modalTitle.innerText = titulo;
      modalContent.className = esConsulta ? 'readonly' : '';
      modalContent.innerHTML = `
        <div class="grid">
          <div class="field"><label>DNI</label><input value="${modo === 'crear' ? '' : '30111222'}" placeholder="Ej: 30111222"></div>
          <div class="field"><label>Apellido y nombre</label><input value="${modo === 'crear' ? '' : 'Pérez Juan'}" placeholder="Ej: Pérez Juan"></div>
          <div class="field"><label>Fecha de nacimiento</label><input type="date" value="${modo === 'crear' ? '' : '1990-04-15'}"></div>
          <div class="field"><label>Teléfono</label><input value="${modo === 'crear' ? '' : '11-5555-5555'}" placeholder="Ej: 11-5555-5555"></div>
          <div class="field"><label>Email</label><input value="${modo === 'crear' ? '' : 'paciente@mail.com'}" placeholder="paciente@mail.com"></div>
          <div class="field"><label>Estado</label><select><option>Activo</option><option>Inactivo</option></select></div>
        </div>`;
      modalSave.innerText = 'Guardar';
      modalSave.style.display = esConsulta ? 'none' : 'inline-block';
      document.getElementById('abm-modal').classList.add('active');
    }

    function openMedicoModal(modo) {
      const esConsulta = modo === 'consultar';
      const titulo = modo === 'crear' ? 'Crear médico' : modo === 'modificar' ? 'Modificar médico' : 'Consultar médico';
      const modalTitle = document.getElementById('modal-title');
      const modalContent = document.getElementById('modal-content');
      const modalSave = document.getElementById('modal-save');

      modalTitle.innerText = titulo;
      modalContent.className = esConsulta ? 'readonly' : '';
      modalContent.innerHTML = `
        <div class="grid">
          <div class="field"><label>Matrícula</label><input value="${modo === 'crear' ? '' : 'MN12345'}" placeholder="Ej: MN12345"></div>
          <div class="field"><label>Apellido y nombre</label><input value="${modo === 'crear' ? '' : 'Gómez Laura'}" placeholder="Ej: Gómez Laura"></div>
          <div class="field"><label>Especialidad</label><select><option>Clínica médica</option><option>Fisio-kinesiología</option><option>Salud mental</option></select></div>
          <div class="field"><label>Honorario</label><input type="number" value="${modo === 'crear' ? '' : '15000'}" placeholder="Ej: 15000"></div>
          <div class="field"><label>Estado</label><select><option>Activo</option><option>Inactivo</option></select></div>
        </div>`;
      modalSave.innerText = 'Guardar';
      modalSave.style.display = esConsulta ? 'none' : 'inline-block';
      document.getElementById('abm-modal').classList.add('active');
    }

    function openReservaPacienteModal(titulo, mostrarSolicitud) {
      const solicitudHtml = mostrarSolicitud
        ? '<div class="field" style="grid-column: 1 / -1"><label>Solicitud de estudio</label><select><option>#105 - Radiografía - PENDIENTE</option></select></div>'
        : '';

      document.getElementById('modal-title').innerText = titulo;
      document.getElementById('modal-content').className = '';
      document.getElementById('modal-content').innerHTML = `
        <div class="grid">
          <div class="field">
            <label>DNI del paciente</label>
            <div class="inline-input"><input placeholder="Ej: 30111222"><button class="icon-btn" type="button">🔍</button></div>
          </div>
          <div class="field"><label>Paciente</label><input value="(auto) Pérez Juan" disabled></div>
          <div class="field"><label>Fecha de nacimiento</label><input value="1990-04-15" disabled></div>
          <div class="field"><label>Teléfono</label><input value="11-5555-5555" disabled></div>
          ${solicitudHtml}
        </div>
        <div class="note">Luego de buscar el DNI, el sistema muestra los datos del paciente para confirmar la reserva.</div>`;
      document.getElementById('modal-save').innerText = 'Confirmar reserva';
      document.getElementById('modal-save').style.display = 'inline-block';
      document.getElementById('abm-modal').classList.add('active');
    }

    function closeModal() {
      document.getElementById('modal-save').innerText = 'Guardar';
      document.getElementById('abm-modal').classList.remove('active');
    }

    
const pageMap = {
  "inicio": "index.html",
  "pacientes": "pacientes.html",
  "solicitud-estudio": "solicitud-estudio.html",
  "medicos": "medicos.html",
  "crear-agenda-medica": "crear-agenda-medica.html",
  "confirmar-agenda-medica": "confirmar-agenda-medica.html",
  "reservar-turno-medico": "reservar-turno-medico.html",
  "cancelar-reserva-medica": "cancelar-reserva-medica.html",
  "recepcionar-paciente": "recepcionar-paciente.html",
  "facturar-consulta": "facturar-consulta.html",
  "cola-espera-medico": "cola-espera-medico.html",
  "atencion-medica": "atencion-medica.html",
  "pacientes-pendientes": "pacientes-pendientes.html",
  "liquidar-honorarios": "liquidar-honorarios.html",
  "crear-agenda-estudios": "crear-agenda-estudios.html",
  "cancelar-agenda-estudios": "cancelar-agenda-estudios.html",
  "confirmar-agenda-estudios": "confirmar-agenda-estudios.html",
  "reservar-turno-estudio": "reservar-turno-estudio.html",
  "recepcionar-estudio": "recepcionar-estudio.html",
  "facturar-estudio": "facturar-estudio.html",
  "finalizar-estudio": "finalizar-estudio.html",
  "generar-informe-estudio": "generar-informe-estudio.html",
  "entregar-estudio": "entregar-estudio.html"
};
function go(id) { window.location.href = pageMap[id] || 'index.html'; }

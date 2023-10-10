// Variables
const loginURL = "https://localhost:7097/autenticacion/login";
const registroURL = "https://localhost:7097/autenticacion/registro";
const formLogin = document.querySelector(".form-login");
const formRegistro = document.querySelector(".form-register");

// Función para mostrar el formulario de inicio de sesión y ocultar el de registro
function redirigirAlInicio() {
  formRegistro.style.opacity = "0";
  setTimeout(() => {
    formRegistro.style.display = "none";
    formLogin.style.opacity = "1";
    formLogin.style.display = "block";
  }, 500);
}

// Funcion para manejar el inicio de sesion exitoso
function inicioSesionExitoso(nombreUsuario) {
  localStorage.setItem("nombreUsuario", nombreUsuario);
  alert("Inicio de sesión exitoso");
  window.location.href = "/vistas/inicio.html";
  document.getElementById("usuarioActivo").textContent = nombreUsuario;
}

// Función para manejar el registro exitoso
function registroExitoso() {
  document.getElementById("form-login").reset();
  redirigirAlInicio();
}

// Función para cargar el nombre de usuario si esta en localStorage
function cargarNombreUsuario() {
  const nombreUsuario = localStorage.getItem("nombreUsuario");
  if (nombreUsuario) {
    document.getElementById("usuarioActivo").textContent = nombreUsuario;
  }
}

// Funcion para cerrar sesion
function cerrarSesion() {
  localStorage.removeItem("nombreUsuario");
  window.location.href = "/index.html";
}

// Consumiendo API - parte login - boton iniciar sesion
document.getElementById("login").addEventListener("click", (e) => {
  e.preventDefault();
  const user = document.getElementById("user-login").value;
  const password = document.getElementById("password-login").value;

  // Verificar si los campos están llenos
  if (user.trim() === "" || password.trim() === "") {
    alert("Por favor, completa todos los campos.");
    return;
  }

  fetch(loginURL, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ User: user, Password: password }),
  })
    .then((response) => {
      if (response.status === 200) {
        inicioSesionExitoso(user);
      } else if (response.status === 401) {
        alert("Usuario o contraseña incorrecta");
      } else {
        alert("Error desconocido al iniciar sesión");
      }
    })
    .catch((error) => console.log(error));
});

// Consumiendo API - parte registro - boton registrarse
document.getElementById("registrarse").addEventListener("click", (e) => {
  e.preventDefault();
  const user = document.getElementById("user-registro").value;
  const nombre = document.getElementById("name-registro").value;
  const email = document.getElementById("email-registro").value;
  const password = document.getElementById("password-registro").value;

  // Verificar si los campos están llenos
  if (
    user.trim() === "" ||
    nombre.trim() === "" ||
    email.trim() === "" ||
    password.trim() === ""
  ) {
    alert("Por favor, completa todos los campos.");
    return;
  }

  const nuevoUsuario = {
    User: user,
    Nombre: nombre,
    Email: email,
    Password: password,
  };

  fetch(registroURL, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(nuevoUsuario),
  })
    .then((response) => {
      if (response.status === 201) {
        alert("Usuario registrado con éxito");
        registroExitoso();
      } else if (response.status === 409) {
        alert("El usuario ya existe");
      } else {
        alert("Error desconocido al registrar usuario");
      }
    })
    .catch((error) => console.log(error));
});

// Eventos para cambiar entre formularios
document.getElementById("btn-registro").addEventListener("click", (e) => {
  formRegistro.style.opacity = "1";
  formLogin.style.opacity = "0";
  setTimeout(() => {
    formLogin.style.display = "none";
    formRegistro.style.display = "block";
  }, 500);
});

document.getElementById("btn-login").addEventListener("click", (e) => {
  redirigirAlInicio();
});

// Cargar el nombre de usuario si está en localStorage
cargarNombreUsuario();

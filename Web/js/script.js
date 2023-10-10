// Definición de variables y funciones
const loginURL = "https://localhost:7097/autenticacion/login";
const registroURL = "https://localhost:7097/autenticacion/registro";
const formLogin = document.querySelector(".form-login");
const formRegistro = document.querySelector(".form-register");

function redirigirAlInicio() {
  formRegistro.style.opacity = "0";
  setTimeout(() => {
    formRegistro.style.display = "none";
    formLogin.style.opacity = "1";
    formLogin.style.display = "block";
  }, 500);
}

function inicioSesionExitoso(nombreUsuario) {
  localStorage.setItem("nombreUsuario", nombreUsuario);
  alert("Inicio de sesión exitoso");
  window.location.href = "/vistas/inicio.html";
  document.getElementById("usuarioActivo").textContent = nombreUsuario;
}

function registroExitoso() {
  formLogin.reset();
  redirigirAlInicio();
}

function cargarNombreUsuario() {
  const nombreUsuario = localStorage.getItem("nombreUsuario");
  if (nombreUsuario) {
    document.getElementById("usuarioActivo").textContent = nombreUsuario;
  }
}

function cerrarSesion() {
  localStorage.removeItem("nombreUsuario");
  window.location.href = "/index.html";
}

// Eventos
document.addEventListener("DOMContentLoaded", function () {
  cargarNombreUsuario();
});

document.getElementById("cerrar-sesion").addEventListener("click", (e) => {
  cerrarSesion();
});

// Api - parte login
document.getElementById("login").addEventListener("click", (e) => {
  e.preventDefault();
  const user = document.getElementById("user-login").value;
  const password = document.getElementById("password-login").value;

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

// Api - parte registro
document.getElementById("registrarse").addEventListener("click", (e) => {
  e.preventDefault();
  const user = document.getElementById("user-registro").value;
  const nombre = document.getElementById("name-registro").value;
  const email = document.getElementById("email-registro").value;
  const password = document.getElementById("password-registro").value;

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

// Api - parte calculadora
document.getElementById("sumar").addEventListener("click", () => {
  const num1 = parseFloat(document.getElementById("num1").value);
  const num2 = parseFloat(document.getElementById("num2").value);

  if (isNaN(num1) || isNaN(num2)) {
    alert("Por favor, ingrese números válidos.");
    return;
  }

  const url = `https://localhost:7097/operaciones/sumar?num1=${num1}&num2=${num2}`;

  fetch(url)
    .then((response) => {
      if (!response.ok) {
        throw new Error("Error en la solicitud.");
      }
      return response.json();
    })
    .then((result) => {
      document.getElementById("result").value = result.toString();
    })
    .catch((error) => {
      console.error("Error al realizar la suma: " + error);
      alert("Error al realizar la suma.");
    });
});

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

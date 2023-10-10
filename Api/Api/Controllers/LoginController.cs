using Api.Models.Login;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("autenticacion")]
    public class LoginController : ControllerBase
    {
        private readonly Autenticacion autenticacion;

        public LoginController (Autenticacion autenticacion)
        {
            this.autenticacion = autenticacion;
        }

        [HttpPost]
        [Route("login")]
        public dynamic Login([FromBody] Usuario usuario)
        {
            bool autenticado = autenticacion.IniciarSesion(usuario.User, usuario.Password);
            if (autenticado)
            {
                return Ok(new {mansaje = "Inicio de sesion exitoso"});
            } else
            {
                return Unauthorized(new {mensaje = "Usuario o contrasena incorrecta"});
            }
        }

        [HttpPost]
        [Route("registro")]
        public dynamic Registro([FromBody] Usuario usuario)
        {
            bool autenticado = autenticacion.Registrarse(usuario.User, usuario.Nombre, usuario.Email, usuario.Password);
            if (autenticado)
            {
                return CreatedAtAction(nameof(Login), new { message = "Usuario registrado con éxito" });
            }
            else
            {
                return Conflict(new { message = "El usuario ya existe" });
            }
        }


    }
}

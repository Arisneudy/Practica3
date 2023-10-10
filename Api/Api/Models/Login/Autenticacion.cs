
namespace Api.Models.Login
{
    public class Autenticacion
    {
        private readonly List<Usuario> usuarios;
        private readonly GuardarRegistro guardarRegistro;

        public Autenticacion(GuardarRegistro guardarRegistro)
        {
            usuarios = new List<Usuario>();
            this.guardarRegistro = guardarRegistro;
            usuarios.AddRange(guardarRegistro.CargarUsuarios());
        }

        // Metodo para verificar si el usuario existe
        public bool IniciarSesion(string nombreUsuario, string password)
        {

            var usuario = usuarios.FirstOrDefault(u => u.User == nombreUsuario && u.Password == password);
            return usuario != null;
        }

        // Metodo para registrar un usuario nuevo
        public bool Registrarse(string nombreUsuario, string nombreCompleto, string email, string password)
        {
            if (usuarios.Any(u => u.User == nombreUsuario && u.Password == password))
            {
                return false;
            }

            var nuevoUsuario = new Usuario
            {
                User = nombreUsuario,
                Nombre = nombreCompleto,
                Email = email,
                Password = password
            };

            usuarios.Add(nuevoUsuario);
            guardarRegistro.GuardarUsuarios(usuarios);

            return true;
        }

    }
}

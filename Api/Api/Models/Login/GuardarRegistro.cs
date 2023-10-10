
using System.Text.Json;

namespace Api.Models.Login
{
    public class GuardarRegistro
    {
        private readonly string jsonRuta;

        public GuardarRegistro(IWebHostEnvironment webHostEnvironment)
        {
            jsonRuta = Path.Combine(webHostEnvironment.WebRootPath, "Datos", "Usuarios.json");
        }

        // Método para guardar la lista de usuarios en el archivo JSON
        public void GuardarUsuarios(List<Usuario> usuarios)
        {
            try
            {
                string json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(jsonRuta, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado al guardar usuarios: " + ex.Message);
            }
        }

        // Método para cargar la lista de usuarios desde el archivo JSON
        public List<Usuario> CargarUsuarios()
        {
            try
            {
                if (File.Exists(jsonRuta))
                {
                    string json = File.ReadAllText(jsonRuta);
                    return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado al cargar usuarios: " + ex.Message);
            }
            return new List<Usuario>();
        }
    }
}

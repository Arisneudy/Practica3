using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Reporte
{
    public class Exportar
    {
        // Método para exportar el archivo de log al escritorio
        public static void ExportarLog()
        {
            string logRuta = Reporte.GetReporte().RutaLog;
            string escritorioRuta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logNombre = Path.GetFileName("Log - Practica1.txt");
            string rutaDestino = Path.Combine(escritorioRuta, logNombre);

            try
            {
                File.Copy(logRuta, rutaDestino, true); // copiar el archivo de log al escritorio
                File.SetAttributes(rutaDestino, File.GetAttributes(rutaDestino) | FileAttributes.ReadOnly); // archivo generado sera de solo lectura
                Console.Clear();
                Console.WriteLine("El archivo de log se ha exportado con éxito al escritorio.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error al exportar el archivo de log: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}

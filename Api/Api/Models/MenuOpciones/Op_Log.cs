using Practica1.Reporte;

namespace Practica1.MenuOpciones
{
    public class Op_Log
    {

        private static bool bucle = true;
        private static int opcion;

        // Metodo para mostrar el reporte de los usuarios
        public static void Reporte()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Que desea realizar? \n");
                Console.WriteLine("1) Exportar reporte o log");
                Console.WriteLine("2) Salir\n");
                Console.Write("Ingrese la opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    // Exportar el reporte en un archivo txt
                    case 1:
                        Exportar.ExportarLog();
                        break;

                    // Salir
                    case 2:
                        bucle = false;
                        break;

                    // Error!
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida....");
                        Console.ReadKey();
                        break;
                }
            } while (bucle);
        }
    }
}

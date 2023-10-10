
using System;

namespace Practica1.MenuOpciones
{
    public class Op_CalculadoraDiv
    {
        private static bool bucle = true;
        private static int opcion;
        private static double cantidad;
        //private static string usuarioActual = Autenticacion.UsuarioActual!;

        // Método para mostrar el menú de las operaciones para la calculadora de divisas
        public static void Divisas()
        {
            do
            {
                Console.Clear();
               // CalcDivisas divisas = new CalcDivisas(56.61, 60.32);
                Console.WriteLine("¿Qué desea realizar?\n");
                Console.WriteLine("1) Convertir de Peso Dominicano a Dolar");
                Console.WriteLine("2) Convertir de Dolar a Peso Dominicano");
                Console.WriteLine("3) Convertir de Euro a Dolar ");
                Console.WriteLine("4) Convertir de Dolar a Euro");
                Console.WriteLine("5) Convertir de Euro a Peso Dominicano");
                Console.WriteLine("6) Convertir de Peso Dominicano a Euro");
                Console.WriteLine("7) Salir\n");
                Console.Write("Ingrese la opción: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    // Convertir de Peso Dominicano a Dólar Estadounidense
                    case 1:
                     //   RealizarConversion("Convertir DOP a USD", divisas.DominicanoADolar, "DOP", "USD");
                        break;

                    // Convertir de Dólar Estadounidense a Peso Dominicano
                    case 2:
                      //  RealizarConversion("Convertir USD a DOP", divisas.DolarADominicano, "USD", "DOP");
                        break;

                    // Convertir de Euro a Dólar Estadounidense
                    case 3:
                     //   RealizarConversion("Convertir EUR a USD", divisas.EuroADolar, "EUR", "USD");
                        break;

                    // Convertir de Dólar Estadounidense a Euro
                    case 4:
                      //  RealizarConversion("Convertir USD a EUR", divisas.DolarAEuro, "USD", "EUR");
                        break;

                    // Convertir de Euro a Peso Dominicano
                    case 5:
                     //   RealizarConversion("Convertir EUR a DOP", divisas.EuroADominicano, "EUR", "DOP");
                        break;

                    // Convertir de Peso Dominicano a Euro
                    case 6:
                      //  RealizarConversion("Convertir DOP a EUR", divisas.DominicanoAEuro, "DOP", "EUR");
                        break;

                    // Salir
                    case 7:
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

        // Método para realizar una conversión y registrarla en el log
        private static void RealizarConversion(string nombreOperacion, Func<double, double> conversion, string unidadEntrada, string unidadSalida)
        {
            Console.Clear();
            Console.Write($"Ingrese la cantidad en {unidadEntrada}: ");
            double.TryParse(Console.ReadLine(), out cantidad);

            double resultado = conversion(cantidad);

            // Registra la operación en el log
            string valoresEntrada = $"{cantidad} {unidadEntrada}";
            string valoresSalida = $"{resultado} {unidadSalida}";
            //Reporte.Reporte.GetReporte().RegistrarOperacion(usuarioActual, nombreOperacion, valoresEntrada, valoresSalida);

            Console.WriteLine();
            Console.WriteLine($"La cantidad en {unidadSalida} es: {resultado} {unidadSalida}");
            Console.ReadKey();
        }
    }
}

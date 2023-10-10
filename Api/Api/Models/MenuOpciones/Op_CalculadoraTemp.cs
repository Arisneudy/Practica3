
using System;

namespace Practica1.MenuOpciones
{
    public class Op_CalculadoraTemp
    {
        private static bool bucle = true;
        private static int opcion;
        private static double temp;

        // Método para mostrar el menú de las operaciones para la calculadora de temperaturas
        public static void Temperaturas()
        {
            do
            {
                Console.Clear();
                //CalcTemperaturas temps = new CalcTemperaturas();
                Console.WriteLine("¿Qué desea realizar?\n");
                Console.WriteLine("1) Convertir Celsius a Fahrenheit");
                Console.WriteLine("2) Convertir Fahrenheit a Celsius");
                Console.WriteLine("3) Convertir Celsius a Kelvin");
                Console.WriteLine("4) Convertir Kelvin a Celsius");
                Console.WriteLine("5) Convertir Fahrenheit a Kelvin");
                Console.WriteLine("6) Convertir Kelvin a Fahrenheit");
                Console.WriteLine("7) Salir\n");
                Console.Write("Ingrese la opción: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    // Convertir Celsius a Fahrenheit
                    case 1:
                       // RealizarConversion("Convertir Celsius a Fahrenheit", temps.CelsiusAFahrenheit, "°C", "°F");
                        break;

                    // Convertir Fahrenheit a Celsius
                    case 2:
                      //  RealizarConversion("Convertir Fahrenheit a Celsius", temps.FahrenheitACelsius, "°F", "°C");
                        break;

                    // Convertir Celsius a Kelvin
                    case 3:
                       // RealizarConversion("Convertir Celsius a Kelvin", temps.CelsiusAKelvin, "°C", "K");
                        break;

                    // Convertir Kelvin a Celsius
                    case 4:
                       // RealizarConversion("Convertir Kelvin a Celsius", temps.KelvinACelsius, "K", "°C");
                        break;

                    // Convertir Fahrenheit a Kelvin
                    case 5:
                      //  RealizarConversion("Convertir Fahrenheit a Kelvin", temps.FahrenheitAKelvin, "°F", "K");
                        break;

                    // Convertir Kelvin a Fahrenheit
                    case 6:
                       // RealizarConversion("Convertir Kelvin a Fahrenheit", temps.KelvinAFahrenheit, "K", "°F");
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
            Console.Write($"Ingrese la temperatura en {unidadEntrada}: ");
            double.TryParse(Console.ReadLine(), out temp);

            double resultado = conversion(temp);

            // Registra la operación en el log
            string valoresEntrada = $"{temp} {unidadEntrada}";
            string valoresSalida = $"{resultado} {unidadSalida}";
            //Reporte.Reporte.GetReporte().RegistrarOperacion( nombreOperacion, valoresEntrada, valoresSalida);

            Console.WriteLine();
            Console.WriteLine($"La temperatura en {unidadSalida} es: {resultado} {unidadSalida}");
            Console.ReadKey();
        }
    }
}

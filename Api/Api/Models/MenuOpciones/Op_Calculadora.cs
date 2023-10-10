using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica1.MenuOpciones
{
    public class Op_Calculadora
    {
        private static bool bucle = true;
        private static int opcion;
        private static double num1, num2;
        //private static string usuarioActual = Autenticacion.UsuarioActual!;

        // Metodo para mostrar el menu de las operaciones para la calculadora
        public static void Sumadora()
        {
            do
            {
                Console.Clear();
                //Calculadora calculadora = new Calculadora();
                Console.WriteLine("Que desea realizar? \n");
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Salir\n");
                Console.Write("Ingrese la opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    // Sumar
                    case 1:
                      //  RealizarOperacion("Suma", calculadora.Sumar);
                        break;
                    
                    // Restar
                    case 2:
                       // RealizarOperacion("Resta", calculadora.Restar);
                        break;

                    // Multiplicar
                    case 3:
                        //RealizarOperacion("Multiplicación", calculadora.Multiplicar);
                        break;

                    // Dividir
                    case 4:
                      //  RealizarOperacion("División", calculadora.Dividir);
                        break;

                    // Salir
                    case 5:
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

        // Metodo para realizar las operaciones y a la vez registrar un log de estas
        private static void RealizarOperacion(string nombreOperacion, Func<double, double, double> operacion)
        {
            Console.Clear();
            Console.Write("Ingrese un número: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Ingrese otro número: ");
            double.TryParse(Console.ReadLine(), out num2);

            double resultado = operacion(num1, num2);

            // Registra la operación en el log
            string valoresEntrada = $"{num1} y {num2}";
            string valoresSalida = resultado.ToString();
            //Reporte.Reporte.GetReporte().RegistrarOperacion(usuarioActual, nombreOperacion, valoresEntrada, valoresSalida);

            Console.WriteLine();
            Console.WriteLine($"El resultado de la {nombreOperacion.ToLower()} es: {resultado}");
            Console.ReadKey();
        }
    }

}

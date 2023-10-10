using Api.Models.Operaciones.Divisas;
using Api.Models.Operaciones.Sumadora;
using Api.Models.Operaciones.Temperatura;

namespace Api.Models.Facade
{
    public class OperacionesFachada
    {
        private readonly Calculadora calculadora;
        private readonly CalcDivisas calculadoraDivisas;
        private readonly CalcTemperaturas calculadoraTemperaturas;

        public OperacionesFachada(Calculadora calculadora, CalcDivisas calculadoraDivisas, CalcTemperaturas calculadoraTemperaturas)
        {
            this.calculadora = calculadora;
            this.calculadoraDivisas = calculadoraDivisas;
            this.calculadoraTemperaturas = calculadoraTemperaturas;
        }

        // Metodo para obtener la suma de los dos numeros
        public double Sumar(double num1, double num2)
        {
            return calculadora.Sumar(num1, num2);
        }

        // Metodo para obtener la conversion de la moneda
        public double DolarADominicano(double dolar)
        {
            return calculadoraDivisas.DolarADominicano(dolar);
        }

        // Metodo para obtener la conversion de la temperatura
        public double FahrenheitACelsius(double fahrenheit)
        {
            return calculadoraTemperaturas.FahrenheitACelsius(fahrenheit);
        }

    }
}

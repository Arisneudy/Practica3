namespace Api.Models.Operaciones.Temperatura
{
    public class CalcTemperaturas : ITemperatura
    {

        // Metodo para calcular de Celsius a Farenheit
        public double CelsiusAFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        // Metodo para calcular de Farenheit a Celsius
        public double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Metodo para calcular de Celsius a Kelvin
        public double CelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        // Metodo para calcular de Kelvin a Celsius
        public double KelvinACelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        // Metodo para calcular de Farenheit a Kelvin
        public double FahrenheitAKelvin(double fahrenheit)
        {
            double celsius = FahrenheitACelsius(fahrenheit);
            return CelsiusAKelvin(celsius);
        }

        // Metodo para calcular de Farenheit a Celsius 
        public double KelvinAFahrenheit(double kelvin)
        {
            double celsius = KelvinACelsius(kelvin);
            return CelsiusAFahrenheit(celsius);
        }
    }
}

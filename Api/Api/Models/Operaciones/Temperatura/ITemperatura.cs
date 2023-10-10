namespace Api.Models.Operaciones.Temperatura
{
    public interface ITemperatura
    {
        double CelsiusAFahrenheit(double celsius);
        double FahrenheitACelsius(double fahrenheit);
        double CelsiusAKelvin(double celsius);
        double KelvinACelsius(double kelvin);
        double FahrenheitAKelvin(double fahrenheit);
        double KelvinAFahrenheit(double kelvin);
    }
}

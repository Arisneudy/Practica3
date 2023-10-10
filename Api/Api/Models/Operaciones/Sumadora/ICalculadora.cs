namespace Api.Models.Operaciones.Sumadora
{
    public interface ICalculadora
    {
        double Sumar(double num1, double num2);
        double Restar(double num1, double num2);
        double Multiplicar(double num1, double num2);
        double Dividir(double num1, double num2);
    }
}

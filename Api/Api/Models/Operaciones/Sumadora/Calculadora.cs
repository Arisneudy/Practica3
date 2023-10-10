namespace Api.Models.Operaciones.Sumadora
{
    public class Calculadora : ICalculadora
    {

        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

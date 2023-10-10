using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Models.Operaciones.Divisas
{
    public class CalcDivisas : IDivisas
    {
        public double ValorDolar { get; private set; } = 56.69;
        public double ValorEuro { get; private set; } = 59.89;

        // Método para convertir de Peso Dominicano a Dolar
        public double DominicanoADolar(double dominicano)
        {
            return dominicano / ValorDolar;
        }

        // Método para convertir de Dolar a Peso Dominicano
        public double DolarADominicano(double dolar)
        {
            return dolar * ValorDolar;
        }

        // Método para convertir de Euro a Dolar 
        public double EuroADolar(double euro)
        {
            return euro * ValorEuro / ValorDolar;
        }

        // Método para convertir de Dolar a Euro
        public double DolarAEuro(double dolar)
        {
            return dolar * ValorDolar / ValorEuro;
        }

        // Método para convertir de Euro a Peso Dominicano
        public double EuroADominicano(double euro)
        {
            return euro * ValorEuro;
        }

        // Método para convertir de Peso Dominicano a Euro
        public double DominicanoAEuro(double dominicano)
        {
            return dominicano / ValorEuro;
        }
    }
}

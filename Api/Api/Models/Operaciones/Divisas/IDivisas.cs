namespace Api.Models.Operaciones.Divisas
{
    public interface IDivisas
    {
        double DominicanoADolar(double dominicano);
        double DolarADominicano(double dolar);
        double EuroADolar(double euro);
        double DolarAEuro(double dolar);
        double EuroADominicano(double euro);
        double DominicanoAEuro(double dominicano);
    }
}

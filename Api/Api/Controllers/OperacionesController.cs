using Api.Models.Facade;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("operaciones")]
    public class OperacionesController : ControllerBase
    {
        private readonly OperacionesFachada operacionesFachada;

        public OperacionesController(OperacionesFachada operacionesFachada)
        {
            this.operacionesFachada = operacionesFachada;
        }

        [HttpGet]
        [Route("sumar")]
        public ActionResult<double> Sumar(double num1, double num2)
        {
            double resultado = operacionesFachada.Sumar(num1, num2);
            return resultado;
        }

        [HttpGet]
        [Route("dolar-a-dominicano")]
        public ActionResult<double> DolarADominicano(double cantidad)
        {
            double conversion = operacionesFachada.DolarADominicano(cantidad);
            return conversion;
        }

        [HttpGet]
        [Route("farenheit-a-celcius")]
        public ActionResult<double> FarenheitACelcius(double temp)
        {
            double conversion = operacionesFachada.FahrenheitACelsius(temp);
            return conversion;
        }
    }
}

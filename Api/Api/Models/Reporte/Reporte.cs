using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Reporte
{
    public class Reporte
    {
        private static Reporte? reporte;
        public string RutaLog { get; } = "Datos/Log.txt";

        private Reporte()
        {
        }

        public static Reporte GetReporte()
        {
            if (reporte == null)
            {
                reporte = new Reporte();
            }
            return reporte;
        }

        public void RegistrarOperacion(string usuario, string operacion, string valoresEntrada, string valoresSalida)
        {
            string log = $"Fecha y Hora: {DateTime.Now}: Usuario '{usuario}' realizó '{operacion}' con entrada '{valoresEntrada}' y salida '{valoresSalida}'";

            // Escribir el registro en un archivo de texto
            File.AppendAllText(RutaLog, log + Environment.NewLine);
        }
    }
}

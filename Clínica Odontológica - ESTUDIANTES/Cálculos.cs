using System;

namespace ClinicaOdontologica
{
    public static class Calculos
    {
        public static double CalcularCosto(string tratamiento)
        {
            double costo = 0;
            switch (tratamiento.ToLower())
            {
                case "limpieza":
                    costo = 30.0;
                    break;
                case "extraccion":
                    costo = 50.0;
                    break;
                case "ortodoncia":
                    costo = 200.0;
                    break;
                default:
                    Console.WriteLine("Tratamiento no reconocido.");
                    break;
            }
            return costo;
        }
    }
 }





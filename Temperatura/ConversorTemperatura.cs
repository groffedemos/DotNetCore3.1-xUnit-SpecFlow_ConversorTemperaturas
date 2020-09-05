using System;

namespace Temperatura
{
    public static class ConversorTemperatura
    {
        public static double FahrenheitParaCelsius(
            double temperatura)
        {
            return (temperatura - 32.0) / 1.8;
            //return Math.Round(
            //    (temperatura - 32.0) / 1.8, 2);
        }

        public static double FahrenheitParaKelvin(
             double temperatura)
        {
            return FahrenheitParaCelsius(temperatura) + 273.15;
            //return Math.Round(
            //    FahrenheitParaCelsius(temperatura) + 273.15, 2);
        }
    }
}

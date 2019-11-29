using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double CalcularCircunferencia(double r)
        {
            double cir = Math.Pow((r * Pi), 2.0);
            return cir;
        }

        public static double CalcularVolume(double v)
        {
            double vol = Math.Pow(v, 3.0);
            return vol;
        }


    }
}

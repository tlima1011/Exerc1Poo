using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exerc1Poo
{
    internal class Retangulo
    {
        public double Largura; 
        public double Altura; 

        public double Area()
        {
            return Largura * Altura; 
        }

        public double Perimetro()
        {
            return 2.0 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura,2.0) + (Math.Pow(Altura, 2.0)));
        }

        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nPERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

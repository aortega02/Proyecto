using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clMiLibreria
{
    public class Class1
    {
        public int autosuma { get; set; }
        public int cant { get; set; }
        public void sumar(int num1, int num2)
        {
            int result = num1 + num2;
            autosuma = result;
        }

        public void contar(string plbr)
        {
            char[] r;
            r = plbr.ToCharArray();
            cant = r.Length;
        }
    }
    public class Calculos
    {
        const double Pi = Math.PI;
        public double CalculoAreaCirculo(decimal dmt)
        {
            double area;
            area = Pi * (Convert.ToDouble(dmt)); ;
            return area;
        }
        public double CalculoAreaCirculo(double radio)
        {
            double area;
            area = Pi * (radio * radio); ;
            return area;
        }
        public double CalcularAreaCuadrado(double valorlados)
        {
            double area;
            area = (valorlados * valorlados);
            return area;
        }
    }
}

using System;
using System.Windows.Forms;
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

        public void cmbstatus(TextBox[] txt, bool Opc, string val = "",bool bt = false)
        {
            
            foreach (TextBox auxTxt in txt)
                {
                    if (bt == true)
                    {
                        auxTxt.ReadOnly = bt;
                    }
                     auxTxt.Visible = Opc;
                auxTxt.Text = val;
                }
            
            
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

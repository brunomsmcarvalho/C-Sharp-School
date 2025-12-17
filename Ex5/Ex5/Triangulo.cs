using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex5
{
    internal class Triangulo //definição da classe Triangulo
    {

        public double A;
        public double B;
        public double C;
    }

        class Program //classe principal do programa
        {
            static void Main(string[] args)
            { //ponto de entrada do programa

            Triangulo x = new Triangulo(); //primeira instância do objeto Triangulo
            Triangulo y = new Triangulo(); //segunda instância do objeto Triangulo
            //Cada triangulo possui suas próprias variáveis A, B e C
            //INstanciacao alocacao dinamica de memoria
            Console.WriteLine("Digite as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//leitura dos valores do triangulo X
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Digite as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;//calculo do semi-perimetro do triangulo X
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));//calculo da area do triangulo X
            
            p = (y.A + y.B + y.C) / 2.0;//calculo do semi-perimetro do triangulo Y
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));//calculo da area do triangulo Y
            
            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));//exibição da area do triangulo X
            Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");//comparação das áreas
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Maior área: Y");
            }
            else
            {
                Console.WriteLine("Introduziste valores errados ò burro!!!");
            }
        }
    }
}

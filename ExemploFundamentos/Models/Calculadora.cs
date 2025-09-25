using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_AVANADE___.Net___IA___2025.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y) // criando método somar. Esses métodos pertencem a minha classe calculadora.
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y) // criando método subtrair
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y) // criando método multiplicar
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }


        public void Dividir(int x, int y) // criando método dividir
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);//pow-potência. Essa classe abstrai pra  a gente.
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"seno de {angulo}o = {Math.Round(seno,4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"coseno de {angulo}o = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente =  Math.Tan(radiano);
            Console.WriteLine($"tangente de {angulo}o = {Math.Round(tangente, 4)}");
        }
    }
}
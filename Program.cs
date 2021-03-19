using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Math.PI constante;

            //2. Constante g = 9,80665 m/s²
            const double g = 9.80665;
            double anguloEmGraus;
            double velocidade;
            double anguloRadianos;
            double alcance;
            double altura;

            Console.Clear();

            Console.WriteLine("---------------");
             Console.WriteLine("-- Projetil --");
             Console.WriteLine("---------------");
             Console.WriteLine("Entre com a velocidade, em m/s ..: ");
             velocidade = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Entre com angulo, em graus ..: ");
             anguloEmGraus = Convert.ToDouble(Console.ReadLine());
           //3 converter o angulo graus para radiano
             anguloRadianos = anguloEmGraus * (Math.PI/180);

             //aplicar a equaçção de torricelli para o alcance
             alcance = (Math.Pow(velocidade, 2) * Math.Sin(2 * anguloRadianos)) / g;
             Console.WriteLine($"Alcance .......: {alcance:N2}m");
             //aplicar a equaçção de torricelli para o altura
             altura = Math.Pow((velocidade * Math.Sin(anguloRadianos)), 2) / (2 * g);
             Console.WriteLine($"Altura máxima .......: {altura:N2}m");



        }
    }
}

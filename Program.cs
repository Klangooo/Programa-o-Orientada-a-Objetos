using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static double produto_escalarVetor(double x1, double y1, double x2, double y2)
        {
            double resposta;
            resposta = x1 * x2 + y1 * y2;
            return resposta;
        }

        static double moduloVetor(double x1, double y1)
        {
            double resposta;
            resposta = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            return resposta;
        }

        static double anguloVetor(double escalar1_2, double mod1, double mod2)
        {
            double cosseno, resposta;
            cosseno = escalar1_2 / (mod1 * mod2);
            resposta = Math.Acos(cosseno);
            return resposta;
        }

        static void projecaoVetor(double x1, double y1, double x2, double y2)
        {
            double xfinal, yfinal;
            xfinal = (x1 * x2 * x2) / Math.Pow(moduloVetor(x2, y2), 2);
            yfinal = (y1 * y2 * y2) / Math.Pow(moduloVetor(x2, y2), 2);
            Console.WriteLine("Vetor projecao de 1 em 2: \n X: " + xfinal + "\n Y: " + yfinal);
        }

        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Digite x do primeiro vetor: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite y do primeiro vetor: ");
            y = int.Parse(Console.ReadLine());
            Vetor2D vet1 = new Vetor2D(x, y);
            Console.Write("Digite x do segundo vetor: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite y do segundo vetor: ");
            y = int.Parse(Console.ReadLine());
            Vetor2D vet2 = new Vetor2D(x, y);


            double resProdEscalar;
            resProdEscalar = produto_escalarVetor(vet1.X, vet1.Y, vet2.X, vet2.Y);

            double resModulo1;
            resModulo1 = moduloVetor(vet1.X, vet1.Y);

            double resModulo2;
            resModulo2 = moduloVetor(vet2.X, vet2.Y);

            double resAngulo;
            resAngulo = anguloVetor(resProdEscalar, resModulo1, resModulo2);

            Console.WriteLine("Produto escalar: " + resProdEscalar);
            Console.WriteLine("Modulo do vetor 1: " + resModulo1);
            Console.WriteLine("Modulo do veotr 2: " + resModulo2);
            Console.WriteLine("Angulo entre os vetores 1 e 2: " + resAngulo + " rad");
            projecaoVetor(vet1.X, vet1.Y, vet2.X, vet2.Y);
            Console.ReadLine();
        }
    }
}

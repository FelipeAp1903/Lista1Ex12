using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;
            double n4;
            double n5;
            double p;
            double total;

            Console.Write("coloque o valor do 1º produto: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("coloque o valor do 2º produto: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("coloque o valor do 3º produto: ");
            n3 = double.Parse(Console.ReadLine());

            Console.Write("coloque o valor do 4º produto: ");
            n4 = double.Parse(Console.ReadLine());

            Console.Write("coloque o valor do 5º produto: ");
            n5 = double.Parse(Console.ReadLine());

            Console.Write("coloque o valor do pagamento: ");
            p = double.Parse(Console.ReadLine());

            total = p - (n1+n2+n3+n4+n5);
            Console.WriteLine("O valor do troco é: {0}R$", total);

        }
    }
}

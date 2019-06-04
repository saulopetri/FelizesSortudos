using Bll.NumerosFelizeseSortudos;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                NumerosFelizeseSortudos Bll = new NumerosFelizeseSortudos();

                Console.Write("Digite um número inteiro:");

                Int32 num;
                bool isNum = Int32.TryParse(Console.ReadLine(), out num);

                if (isNum)
                {
                    Boolean isFeliz = Bll.isFeliz(num);
                    Boolean isSortudo = Bll.isSortudo(num);

                    String feliz = isFeliz ? "Feliz" : "Não-Feliz";
                    String sortudo = isSortudo ? "Sortudo" : "Não-Sortudo";

                    Console.WriteLine($"{num} - Número {sortudo} e {feliz}");
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("OPS! Número inválido...");
            } while (true);
        }
    }
}

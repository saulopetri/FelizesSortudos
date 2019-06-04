using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.NumerosFelizeseSortudos
{
    public class NumerosFelizeseSortudos
    {
        public Boolean isFeliz(Int32 numero)
        {
            for (int i = 0; i < 100; i++)
            {
                List<int> listOfInts = new List<int>();
                while (numero > 0)
                {
                    listOfInts.Add(numero % 10);
                    numero = numero / 10;
                }

                Int32 soma = listOfInts.Select(n => Convert.ToInt32(Math.Pow(n, 2))).Sum();

                if (soma == 1)
                    return true;
                else
                    numero = soma;
            }

            return false;
        }

        public bool isSortudo(int num)
        {
            //Gero a lista de números
            List<int> Numeros = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                Numeros.Add(i);
            }

            //Retiro multiplos de 2
            Numeros.RemoveAll(x => (x % 2 == 0));

            //Vou removendo os múltiplos de cada posição da lista
            for (int i = 1; i < Numeros.Count; i++)
            {
                long multiplode = Numeros[i];

                int elevado = 1;

                do
                {
                    int posicao = Convert.ToInt32(Math.Pow(multiplode, elevado));
                    if (posicao < Numeros.Count)
                    {
                        Numeros.RemoveAt(posicao - 1);
                        elevado++;
                    }
                    else
                    {
                        break;
                    }

                } while (true);
            }

            return Numeros.Contains(num);
        }
    }
}

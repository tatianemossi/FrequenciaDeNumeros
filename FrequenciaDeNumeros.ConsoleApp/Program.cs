using System;
using System.Linq;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números: ");
            int quantidadeDeNumeros = Convert.ToInt32(Console.ReadLine());

            int contador = 0;
            var listaNumeros = new int[quantidadeDeNumeros];

            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                Console.WriteLine("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                listaNumeros[i] = numero;
            }

            var collectionWithDistinctElements = listaNumeros.Distinct().ToArray();

            for (int i = 0; i < collectionWithDistinctElements.Length; i++)
            {
                var numeroAtual = collectionWithDistinctElements[i];

                for (int j = 0; j < quantidadeDeNumeros; j++)
                {
                    if (numeroAtual == listaNumeros[j])
                    {
                        contador++;
                    }
                }
                Console.WriteLine($"O número {numeroAtual} repete {contador} vezes");
                contador = 0;
            }

            Console.ReadLine();
        }
    }
}

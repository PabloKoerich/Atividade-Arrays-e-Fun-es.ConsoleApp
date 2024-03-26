using System.ComponentModel.DataAnnotations;

namespace Atividade_Arrays_e_Funções.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region instruções
            // Desenvolver um programa que receba 10 valores inteiros, -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6
                       //Permita:
            //Encontrar o Maior Valor da sequência OK
            //Encontrar o Menor Valor da sequência OK 
            //Encontrar o Valor Médio da sequência OK 
            //Encontrar os 3 maiores valores da sequência OK
            //Encontrar os valores negativos da sequência OK
            //Mostrar na Tela os valores da sequência OK
            //Remover um item da sequência OK 
            //Critérios de Aceite da Atividade:
            //    Deve utilizar arrays, Deve utilizar funções, Pode utilizar a classe “Array” do Framework.
            #endregion 
                    
                       
            int[] Lista = new int[16] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            MostrarValores(Lista);
            
            Console.WriteLine("Maior valor: " + EncontrarMaiorValor(Lista));
            Console.WriteLine("Menor valor: " + EncontrarMenorValor(Lista));
            Console.WriteLine("Valor médio: " + EncontrarValorMedio(Lista));
            Console.WriteLine("Três maiores valores: " + String.Join(", ", EncontrarTresMaioresValores(Lista)));
            Console.WriteLine("Valores negativos: " + String.Join(", ", EncontrarValoresNegativos(Lista)));
            Console.WriteLine();
            Console.WriteLine("Digite o valor que deseja remover:");
            int valorParaRemover = Convert.ToInt32(Console.ReadLine());
            Lista = RemoverItem(Lista, valorParaRemover);
            MostrarValores(Lista);

            Console.ReadLine();
        }

        static void MostrarValores(int[] array)
        {
            Console.WriteLine("Valores da sequência: " + String.Join(", ", array));
        }

        static int EncontrarMaiorValor(int[] array)
        {
            return array.Max();
        }

        static int EncontrarMenorValor(int[] array)
        {
            return array.Min();
        }

        static double EncontrarValorMedio(int[] array)
        {
            return array.Average();
        }

        static int[] EncontrarTresMaioresValores(int[] array)
        {
            return array.OrderByDescending(x => x).Take(3).ToArray();
        }

        static int[] EncontrarValoresNegativos(int[] array)
        {
            return array.Where(x => x < 0).ToArray();
        }

        static int[] RemoverItem(int[] array, int valorParaRemover)
        {
            return array.Where(val => val != valorParaRemover).ToArray();

        }



    }
}

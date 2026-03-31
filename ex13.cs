using System;

namespace ListadeExerciciosVariaveisEstruturadas{
    class ex13{
        static void Main(string[] args){
            int n;

            Console.WriteLine("Digite o Tamanho do Vetor: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[n];
            double soma = 0;

            for(int i = 0; i<n; i++){
                Console.WriteLine($"Digite a valor da casa {i} do Vetor: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                
                soma = soma + Math.Sqrt(vetor[i]);
            }

            double media = soma/n;

            Console.WriteLine($"\nAmedia da Raiz Quadrada é: {media}");
        }
    }
}
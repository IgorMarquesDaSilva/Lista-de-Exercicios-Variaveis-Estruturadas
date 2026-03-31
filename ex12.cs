// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex12{
//         static void Main(string[] args){
//             int n;
            
//             Console.WriteLine("Digite o Tamanho do Vetor: ");
//             n = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[n];
//             int[] quadrado = new int[n];
//             int soma = 0;

//             for(int i = 0; i<n; i++){
//                 Console.WriteLine($"Digite o Valor da Casa {i} do Vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());

//                 quadrado[i] = vetor[i] * vetor[i];
//                 soma = soma + quadrado[i];
//             }

//             for(int i = 0; i<n; i++){
//                 Console.WriteLine($"Vetor Quadrado: {quadrado[i]}");
//             }
//             Console.WriteLine($"Aqui esta soma dos Quadrados: {soma}");
//         }
//     }
// }
// using System;
// using System.Runtime.InteropServices;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex9{
//         static void Main(string[] args){
//             int num;

//             Console.WriteLine("Digite o Tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[num];

//             int soma = 0;
//             for(int i = 0;i<num;i++){
//                 Console.WriteLine($"Digite o Salario do funcionario {i}: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());

//                 soma = soma + vetor[i];
//             }
//             Console.WriteLine($"Aqui esta a soma de Todos os Salarios: {soma}");
//         }
//     }
// }
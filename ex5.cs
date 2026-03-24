// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex5{
//         static void Main(string[] args){
//             int num;

//             Console.WriteLine("Digite o tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[num];

//             for(int i = 0; i< num; i++){
//                 Console.WriteLine("Digite o valor do Vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }

//             for(int i = 0; i< num; i++){
//                 Console.WriteLine($"Vetor: {vetor[i]}");
//             }

//             int maior = vetor[0];
//             int menor = vetor[0];

//             for(int i = 0; i < num; i++){
//                 if(vetor[i] > maior){
//                     maior = vetor[i];
//                 }
//                 if(vetor[i] < menor ){
//                     menor = vetor[i];
//                 }
//             }

//             Console.WriteLine($"Maior Vetor: {maior}");
//             Console.WriteLine($"Menor Vetor: {menor}");
//         }
//     }
// }
// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex4{
//         static void Main(string[] args){
//             int num;

//             Console.WriteLine("Digite o tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[num];

//             for(int i = 0; i < num; i++){
//                 Console.WriteLine("Digite o valor do Vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }
//             for(int i = 0; i < num; i++){
//                 Console.WriteLine($"Vetor: {vetor[i]}");
//             }
//             int maior1 = -9999999;
//             int maior2 = -9999999;
//             int posicao1 = 0;
//             int posicao2 = 0;
//             for(int i = 0; i < num; i++){
//                 if(vetor[i] > maior1){
//                     maior2 = maior1;
//                     posicao2 = posicao1;
//                     maior1 = vetor[i];
//                     posicao1 = i;
//                 }else if(vetor[i] > maior2){
//                     maior2 = vetor[i];
//                     posicao2 = i;
//                 }
//             }

//             Console.WriteLine($"Maior 1: {maior1}, Posicao: {posicao1}");
//             Console.WriteLine($"Maior 2: {maior2}, Posicao: {posicao2}");
//         }
//     }
// }
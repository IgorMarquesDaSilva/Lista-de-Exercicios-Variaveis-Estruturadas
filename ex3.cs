// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex3{
//         static void Main(string[] args){
//             int num;

//             Console.WriteLine("Tamanho do Vetor");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[num];

//             for(int i = 0; i< num; i++){
//                 Console.WriteLine("Digite um Valor para o Vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }

//             int menor = vetor[0];
//             int posicao = 0;

//             for(int i = 0; i < num; i++){
//                 Console.WriteLine($"Vetor: {vetor[i]} Posicão: {posicao}");
//                 posicao++;
//             }
//             //resetando o posicao para verificaçao da posicao
//             posicao = 0;

//             for(int i = 1; i < num; i++){
//                 if(vetor[i] < menor){
//                     menor = vetor[i];
//                     posicao = i;
//                 }
//             }

//             Console.WriteLine($"Menor valor do Vetor: {menor}");
//             Console.WriteLine($"Posiçao do Maior Vetor: {posicao}");
//         }
//     }
// }
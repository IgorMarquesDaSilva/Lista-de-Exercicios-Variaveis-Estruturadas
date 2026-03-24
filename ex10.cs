// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex10{
//         static void Main(string[] args){
//             int num;

//             Console.WriteLine("Digite o Tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[num];
//             int somatemp = 0;
//             for(int i = 0;i<num;i++){
//                 Console.WriteLine($"Digite a Temperatua {i} no Vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());

//                 somatemp = somatemp + vetor[i];
//             }

//             int media = somatemp / num;

//             Console.WriteLine($"Aqui esta a media das Temperatura: {media}");

//         }
//     }
// }
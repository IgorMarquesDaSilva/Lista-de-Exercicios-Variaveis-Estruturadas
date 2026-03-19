// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class Program{
//         static void Main(string[] args){
//             int num;
            
//             Console.WriteLine("Digite o Tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[num];

//             for(int i = 0; i < num; i++){
//                 Console.WriteLine("Digite numero do Vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }
//             Console.WriteLine("Vetor Original: ");
//             for(int i = 0; i < num; i++){
//                 Console.WriteLine(vetor[i] + " ");
//             }
//             Console.WriteLine("Vetor Inverso: ");
//             for(int i = num - 1; i>= 0; i--){
//                 Console.WriteLine(vetor[i] + " ");
//             }
//         }
//     }
// }
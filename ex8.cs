// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex8{
//         static void Main(string[] args){
//             int num;

//             Console.WriteLine("Digite o tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());
            
//             int[] vetor = new int[num];
//             int multiUser;

//             Console.WriteLine("Digite um Numero para Multiplicar os Valores do Vetor: ");
//             multiUser = Convert.ToInt32(Console.ReadLine());

//             for(int i = 0;i<num;i++){
//                 Console.WriteLine($"Digite o Valor {i} do Vetor");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }
            
//             int multi;

//             for(int i = 0;i<num;i++){
//                 multi = multiUser * vetor[i];
//                 vetor[i] = multi;
//             }

//             for(int i = 0; i<num;i++){
//                 Console.WriteLine($"Vetor {i} multiplicado: {vetor[i]}");
//             }
//         }
//     }
// }
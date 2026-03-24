// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex7{
//         static void Main(string[] args){
//             int num;

//             Console.WriteLine("Digite o tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor = new int[num];

//             for(int i = 0; i<num;i++){
//                 Console.WriteLine($"Digite o Valor {i} do Vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }

//             int soma = 0;
//             int multi = 1;
//             for(int i = 0;i<num;i++){
//                 if(vetor[i]%2==0){
//                     soma = soma + vetor[i];
//                     multi = multi*vetor[i];
//                 }
//             }
//             Console.WriteLine($"Aqui esta a Soma dos numeros Pares: {soma}");
//             Console.WriteLine($"Aqui esta a Multiplicação dos numeros Pares: {multi}");
//         }
//     }
// }
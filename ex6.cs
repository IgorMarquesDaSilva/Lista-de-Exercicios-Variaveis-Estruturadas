// using System;

// namespace ListadeExerciciosVariaveisEstruturadas{
//     class ex6{
//         static void Main(string[] args){
//             int num;
            
//             Console.WriteLine("Digite o tamanho do Vetor: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             int[] vetor =  new int[num];

//             for(int i = 0; i < num; i++){
//                 Console.WriteLine("Digite a Idade para Preencher o vetor: ");
//                 vetor[i] = Convert.ToInt32(Console.ReadLine());
//             }

//             for(int i = 0; i < num; i++){
//                 if(vetor[i] >= 0 && vetor[i] <= 9){
//                     Console.WriteLine($"Idade: {vetor[i]}, Criança");
//                 }else if(vetor[i] >= 10 && vetor[i] <= 12){
//                     Console.WriteLine($"Idade: {vetor[i]}, Pré-Adolescente");
//                 }else if(vetor[i] >= 13 && vetor[i] <= 17){
//                     Console.WriteLine($"Idade: {vetor[i]}, Adolescente");
//                 }else if(vetor[i] >= 18 && vetor[i] <= 59){
//                     Console.WriteLine($"Idade: {vetor[i]}, Adulto");
//                 }else{
//                     Console.WriteLine($"Idade: {vetor[i]}, Idoso");
//                 }
//             }
//         }
//     }
// }
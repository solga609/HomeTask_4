// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] array = {3.5, 4.5, 7.1, 1.4, 6.5};
// //Random rand = new Random();
// int max = 0;
// for (int i = 0; i < array.Length; i++){
//     if (array[i] < array[max]){
//         max =i;
//     }
//     int min = 0;
//     for(int j = 0; j < array.Length; i++ ){
//         if (array[j] > array[min]){
//             min =j;
        
//         }
        
//     }
//     // for(int d = 0; d < array.Length; d++){
    
    // }
// }

// Console.WriteLine($"{max}");


// int n = 5;
// int num1 = 0, num2 = 0;
// double [] array = new double[n];
// Random rand = new Random();
// for (int i = 0; i < n; i++){
//     array[i] = rand.Next(-3, 2);
// }

// Console.WriteLine($"{array[i]}");





//  Random rand = new Random();
//  double [] a = new double[5];
//  for (int i = 0; i < 5; i++)
//  a[i] = rand.NextDouble();
//  for(int i = 0; i < 5; i++)
//  Console.Write($" {a[i]}");

double min = double.MaxValue;
double max = double.MinValue;
double k;
for(int i = 0; i < 6; i++){
    Console.Write("Введите {0}-е число: ", i + 1);
    k = double.Parse(Console.ReadLine());
    if (k > max)
    max = k;
    if(k < min)
    min = k;
}
Console.WriteLine("Разница между максимальным и минимальным значением: {0}", max - min);
Console.ReadKey();
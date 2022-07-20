
// int num1 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Ввести число: ");
// int num2 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Ввести число: ");
// int num3 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Ввести число: ");
// int num4 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Ввести число: ");
// int num5 = Convert.ToInt32(Console.ReadLine ());
// Console.Write("Ввести число: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < arr.Length; i++){
//     if (arr[i] > 0){
//         count++;
//     }
// }


int [] a = new int [5];
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Колличество элементов > 0: {count}");
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 




int [] array = new int [4];

     var rnd = new Random();
     int index = 0;
    while(index < array.Length){
         array[index] = rnd.Next(-30, 100);
         Console.Write($"{array[index]} ");
         index++;
     }
int i = 1;
int sum = 0;
foreach (int z in array){
    if ((i % 2)==1)
    sum +=z;
    i ++;

}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна = " + sum);
// Console.ReadLine();
 
    //  int [] array = new int[4];
    //  var rnd = new Random();
    //  int index = 0;
    // while(index < array.Length){
    //      array[index] = rnd.Next(-30, 100);
    //      Console.Write($"{array[index]} ");
    //      index++;
    //  }
    // int sum = 0;
    // for(int i = 0; i <array.Length; i++){
    //     if(array[i] % 2 != 0)
       
    //     sum++;
    // }
      
    //  //int sumPos = 0;

    // //  for(int i=0; i< array.Length; i++){
    // //    int sum1 = 0;
    // //     if(array[i] % 2 != 0)
        
    // //     sum1 += array[i];
    // //     // {
    // //     //     index= index + array[i];
    // //     //     index++;
    // //     // }
    // //     else
    // //     break;
    // //  }
    //   Console.WriteLine();
    //  Console.WriteLine($"Сумма элементов, стоящих на четных позициях равна = {sum} ");
     

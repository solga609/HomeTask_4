// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 

 
    int [] array = new int[4];
    var rnd = new Random();
    int index = 0;
    while(index < array.Length){
        array[index] = rnd.Next(-30, 100);
        Console.Write($"{array[index]} ");
        index++;
    }
      
     int sumPos = 0;
     for(int i=0; i< array.Length; i++){
        if(array[i] == 1)
        index = 0;
        {
            index= index + array[i];
            index++;
        }
     }
     Console.WriteLine();
     Console.WriteLine($"Сумма элементов, стоящих на четных позициях равна = {index} ");
     

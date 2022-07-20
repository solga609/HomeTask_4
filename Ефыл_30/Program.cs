// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] CreateArrayRndInt(int size){
int[] array = new int[4];
int index = 0;
var rnd = new Random();
while(index < array.Length){
    array[index] = rnd.Next(100, 1000);
     Console.Write(array[index] + "");
    index++;
 }
 return array;
}
int[] array1 = CreateArrayRndInt(1);
int FindPos(int[] arr){
    int i =0;
    int count = 0;
    while (i<arr.Length){
         count = 0;
        if(arr[i] % 2 == 0)
        //count = count + 1;
        count++;
    }
    return count;
}
int count1 = FindPos(array1);
Console.WriteLine();
Console.WriteLine(count1);
void PrintArray(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        if(i==0) Console.Write("[");
        if(i<arr.Length -1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
 
    
   
    
     

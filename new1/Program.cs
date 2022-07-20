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
for(int i = 0; i < array1.Length; i++){
    if(i==0) Console.Write("[");
    if(i<array1.Length -1) Console.Write(array1[i] + ",");
    else Console.Write(array1 [i] + "]");
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
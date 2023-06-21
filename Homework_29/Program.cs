/*
Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillAray(int[] collection){

    int length = collection.Length;
    int index = 0;
    int iMin = 0;
    int iMax = 10;
    while(index < length){
        collection[index] = new Random().Next(iMin, iMax);
        index ++;
    }
    Console.WriteLine($"[{string.Join(", ", collection)}]");
}
int i = 5;
int[] arr = new int[i];
FillAray(arr);

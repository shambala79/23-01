// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа через пробел: ");
string num = Console.ReadLine()!;
string[] numS = num.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] numI = Array.ConvertAll(numS, s => int.Parse(s));

int count = 0;
foreach (int el in numI)
 {
     if(el > 0){
       count ++;
            }
 }
Console.WriteLine($"[{String.Join(",", numS)}]");
Console.WriteLine(count);

// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)
// в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию
// (от меньшего числа к большему).

int[] array = GetArray(8);
Console.WriteLine($"[{String.Join("; ", array)}]");
Sort(array);
Console.WriteLine($"[{String.Join("; ", array)}]");

//---------------------
int[] GetArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(100);
    }
    return Array;
}
void Sort(int[] Array){
int indx;
for (int i = 0; i < Array.Length; i++)
{
    indx = i; 
        for (int j = i; j < Array.Length; j++)
    {
        if (Array[j] < Array[indx])  
        {
            indx = j; 
        }
    }
    if (Array[indx] == Array[i])
        continue;
       int temp = Array[i]; 
           Array[i] = Array[indx];
    Array[indx] = temp;
}}
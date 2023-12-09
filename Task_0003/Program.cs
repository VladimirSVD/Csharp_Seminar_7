// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size, int leftRange, int rigthRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rigthRange + 1);
    }
    return tempArray;
}
void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}
void PrintInversion(int[] array, int i) 
{ 
	if(i < 0) return;
     
	System.Console.Write(array[i] + " ");
    PrintInversion(array, i - 1);
}
//-----------------------------------------    

int size = ReadInt("Введите размер массива: ");
int[] myArray = GenerateArray(size, 1, 100);
PrintArray(myArray);
int i = myArray.Length - 1;
PrintInversion(myArray, i);
Console.WriteLine();

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string str) 
{ 
	System.Console.Write(str); 
	return Convert.ToInt32(Console.ReadLine()); 
} 
void PrintNumbers(int M, int N, int X, int Y) 
{ 
	if(X < Y)
    {
        if(N < M) return;
     	PrintNumbers(M, N - 1, X, Y); 
	    System.Console.Write(N + " ");
    } 
    else
    {
        if(M < N) return;
     	PrintNumbers(M - 1, N, X, Y); 
	    System.Console.Write(M + " ");
    }
}    
// ------------------ 
int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
int X = M;
int Y = N; 
PrintNumbers(M, N, X, Y);
Console.WriteLine();
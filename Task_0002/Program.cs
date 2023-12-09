// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int ReadInt(string str) 
{ 
	System.Console.Write(str); 
	return Convert.ToInt32(Console.ReadLine()); 
}
int FunAckerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunAckerman(m - 1, 1);
  else return FunAckerman(m - 1, FunAckerman(m, n - 1));
}
//------------------------------------

int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");
int numberAckerman = FunAckerman(m, n);
Console.WriteLine($"Функция Аккермана = {numberAckerman} ");


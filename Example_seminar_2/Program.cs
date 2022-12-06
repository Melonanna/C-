int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

//int n= -N;


for (int n=-N; n<=N; n++)
{
  Console.Write($" {n} ");
}
//while (n<=N)
// {
 // Console.Write($" {n} ");
 // n++;

 //}

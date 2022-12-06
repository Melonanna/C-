
/*int N;
Console.Write($"Введите число: ");

int.TryParse(Console.ReadLine()!, out N);
Console.Write($"Является ли число четным? ");

if (N%2==0)
{
  Console.Write($"Да");
}

else
{
  Console.Write($"Нет");
}*/

/*Трехзначные числа,программа показывает последнюю цифру этого числа*/

int a;
int b;
int c;

Console.WriteLine($"Введите число 1:");
int.TryParse(Console.ReadLine()!, out a);

Console.WriteLine($"Введите число 2:");
int.TryParse(Console.ReadLine()!, out b);

Console.WriteLine($"Введите число 3:");
int.TryParse(Console.ReadLine()!, out c);

int max=a;

if (b>max) {max = b;}
if (c>max) {max =c;}

Console.Write ("max = ");
Console.WriteLine (max);



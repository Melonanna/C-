// перевод из int в string
/* int a;
int.TryParse("123543", out a);
a.ToString(); 

int a;
string number = "990123"
int.TryParse(number, out a);
a.ToString(); 
*/

// Задайте двумерный массив размером m на n, заполненный случайными целыми числами

/*
int m,n;
Console.Write($"Введите m размерность массива:");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите n размерность массива:");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m,n];




// void PrintArray(int[,] arr)
{ for(int i=0; i<array.GetLength(0);i++)
{
for (int j=0; j<array.GetLength(1);j++)
{
  array[i,j] = new Random().Next(-9,10);
  Console.Write($" {array[i,j]} ");
}
 Console.WriteLine();
}
}

*/


//СОЗДАЕМ ТАБЛИЦУ УМНОЖЕНИЯ

int m,n;
Console.Write($"Введите m размерность массива:");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите n размерность массива:");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m+1,n+1];

//for (int i=0; i<array.GetLength(0);i++) //заполнение крайнего левого столбца
 // array[i,0] =i ;
//for (int i=0; i<array.GetLength(1);i++)// заполнение крайне верхней строки
//  array[0,i] = i;

for (int i=0; i<array.GetLength(0); i++)
{
 for (int j=0; j<array.GetLength(1); j++)
 {
  Console.Write($" {array[i,j]=i*j} ");
 }
Console.WriteLine();
}

PrintArray(array);

void PrintArray(int[,] arr)
{ for(int i=0; i<array.GetLength(0);i++)
{
for (int j=0; j<array.GetLength(1);j++)
{
  array[i,j] = new Random().Next(-9,10);
  Console.Write($" {array[i,j]} ");
}
 Console.WriteLine();
}
}

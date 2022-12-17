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
/*

//СОЗДАЕМ ТАБЛИЦУ УМНОЖЕНИЯ

int m,n;
Console.Write($"Введите m размерность массива:");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите n размерность массива:");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m+1, n+1];

for (int i=0; i<array.GetLength(0);i++) //заполнение крайнего левого столбца
 array[i,0] = i ;
for (int i=0; i<array.GetLength(1);i++)// заполнение крайне верхней строки
  array[0,i] = i;

for (int i=1; i<array.GetLength(0); i++)
{
 for (int j=1; j<array.GetLength(1); j++)
  array[i,j]=i*j;
 
} 
PrintArray(array);

void PrintArray(int[,] arr)
{ for(int i=0; i<arr.GetLength(0);i++)
 { 
  for (int j=0; j<arr.GetLength(1);j++)
{
  Console.Write("{0, 3}",arr[i,j]);
}
 Console.WriteLine();
}
}
*/



// поменять местами первую и последнюю строку массива
//1 4 7 2
//5 9 2 3
//8 4 2 4

//генерация первоначального массива
int [,]array = new int [3,4];
for (int i=0; i<array.GetLength(0);i++)
{
  for (int j=0; j<array.GetLength(1);j++)
  {
  array [i,j]=new Random().Next(10);
 Console.Write($"{array[i,j]} ");
  }
  Console.WriteLine();
}

for (int i=0; i<array.GetLength(1);i++)
{
  (array[0,i], array[array.GetLength(0) -1,i]) =
  (array[array.GetLength(0)-1,i], array[0,i]);
  
}

//вывод нового массива
for (int i=0; i<array.GetLength(0);i++)
{
  for (int j=0; j<array.GetLength(1);j++)
  {
  Console.Write($"{array[i,j]} ");
  }
  Console.WriteLine();
}















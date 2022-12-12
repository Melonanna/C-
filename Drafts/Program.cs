
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
/*
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


*/


 /*координаты точки x y причем x!=0, y!=0 и выдает номер плоскости где точка находится



int x,y;

Console.WriteLine($"Введите координату x:");
int.TryParse(Console.ReadLine()!, out x);

Console.WriteLine($"Введите координату y:");
int.TryParse(Console.ReadLine()!, out y);

if (x>0 && y>0)
{ Console.Write($"Точка находится в 1 плоскости ");
}

else if (x>0 && y<0)
{ Console.Write($"Точка находится в 4 плоскости ");
}

else if (x<0 && y>0)
{ Console.Write($"Точка находится в 2 плоскости ");
}

else if (x<0 && y<0)
{ Console.Write($"Точка находится в 3 плоскости ");
}

else 
{Console.Write($"неправильный ввод ");
}
 */


//СЕМИНАР ПО ФУНКЦИЯМ
/*
int [] array=new int [10]; /*в массиве 10 элементов*/
//int [] array=new int [] {1,2,3}
/*
for (int i=0;i<array.Length;i++)

{
 array[i] = new Random().Next(10);
 Console.Write($" {array[i]} ");
}
*/

 //поменять переменные друг с другом
/*
int [] array = new int [10];

for (int i=0;i<array.Length;i++)

{
 array[i] = new Random().Next(10);
 Console.Write($" {array[i]} ");
}
Console.WriteLine();

int index=1;
Console.WriteLine($"{array[index]} -- {array[array.Length - index - 1]}");

int temp = array[1];
array [1] = array [2];
array [2] = temp;

*/
/*
int [] array = new int [5];

for (int i=0;i<array.Length;i++)

{
 array[i] = new Random().Next(10);
 Console.Write($" {array[i]} ");
}
Console.WriteLine();

int temp = array[1];
array [1] = array [2];
array [2] = temp;

for( int i=0; i<array.Length; i++)
{
 Console.Write($" {array[i]} ");
}

Console.WriteLine();

 */

 //  Перевернуть массив полностью
/*
 int[]array = new int [5];
 for (int i=0; i< array.Length; i++)

 {
array [i] = new Random().Next(10);
 }
Print(array);

 for (int i=0; i<array.Length / 2; i++)
{
int temp = array[i];
array [i] = array [array.Length-i-1];
array [array.Length-i-1] = temp;

}
Print(array);
*/


// массив с неизвестным числом элемонтов. Пользователь вводит числа пока не наберет ноль
/*
int a=1;
/* array.length - счетчик */
/*int [] array=new int [0];
while (a !=0)
{

Console.Write($"Введите [{array.Length}}] элемент: ");
int.TryParse(Console.ReadLine()!,out a);
if (a!=0)
array[array.length]=a;

}

//Динамические массивы - нет ограничений по кол-ву элеемнтов



// 
//задайте значение N -  напишите прогу, кто выведет все натуральные числа от 1 до N

//option1
/*
int n;
Console.Write($"Введите N:");
int.TryParse(Console.ReadLine()!, out n);

PrintNums(1,n);

void PrintNums(int left,int right)
{
 if (left==right)
 Console.Write($"{left}");
 else 
 {
  Console.Write($"{left} ");
 PrintNums(left+1, right);
 }

}
*/

int n;
Console.Write($"Введите N:");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"{PrintNums(1,n)}");

string PrintNums(int left,int right)
{
string str = " ";
if (left>=right)
return str;

str+=left.ToString() + " ";
PrintNums(left+1, right);
return str;

}

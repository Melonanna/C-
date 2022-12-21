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
/*
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
*/ 
//прога принимает на вход число/ возвращает сумму его цифр
/*
int n;
Console.Write($"Введите N: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write($"{DigitSum(n)}");
int DigitSum(int num)
{
  if (num/10 ==0)
    return num;
  return num%10 + DigitSum(num /10);

*/


int a,b;
Console.Write($"Введите A: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите B: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($"{a}^{b} = {pow(a,b)}");

int pow(int a,int b)
{
  if (b==0)
  return 1;
  if (b==1)
  return a;
return a*pow(a,b-1);
}


//функция Аккермана


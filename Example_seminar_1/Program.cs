//double a=5;
//double b=7;
//int c2=5
//double d2=3.5;

//Console.Write("Ответ:");
//Console.WriteLine(a+b);
//Console.WriteLine("спасибо за внимание");


//int a=5;
//int b=2;
//int c=a/b;
//Console.Write ($"c={c}\n");
//only for this action a=double
//Console.Write($"ответ: {a}/{b} = {(double)a/b}\n end of program");

//FIRST OPTION
//int a=0;
//int b=a;
//string user1;
//string user2;

//Console.Write($"Введите первое число: ");
//user1=Console.ReadLine()!;

//Console.Write($"Введите второе число: ");
//user2=Console.ReadLine()!;

//int.TryParse(user1, out a);
//int.TryParse(user2, out b);

//Console.Write($"{a}+{b}={a+b}\n");
//Console.Write($"{a}-{b}={a-b}\n");
//Console.Write($"{a}*{b}={a*b}\n");
//Console.Write($"{a}/{b}={(double)a/b}\n");



//SECOND OPTION - BETTER ONE

//int a;
//int b;

//Console.Write($"Введите первое число: ");
//int.TryParse(Console.ReadLine()!, out a);
//Console.Write($"Введите второе число: ");
//int.TryParse(Console.ReadLine()!, out b);

//
//

//Console.Write($"{a}+{b}={a+b}\n");
//Console.Write($"{a}-{b}={a-b}\n");
//Console.Write($"{a}*{b}={a*b}\n");
//Console.Write($"{a}/{b}={(double)a/b}\n");

//CYCLES

//int a;
//int b;

//Console.Write($"Введите первое число: ");
//int.TryParse(Console.ReadLine()!, out a);
//Console.Write($"Введите второе число: ");
//int.TryParse(Console.ReadLine()!, out b);

//if (a==b) {
  //Console.Write($"Числа равны");
//}

//else{
//  Console.Write($"Числа не равны");
//}

//CYCLES with while

int a=0;
int b=a;

//Console.Write($"Введите первое число: ");
//int.TryParse(Console.ReadLine()!, out a);
//Console.Write($"Введите второе число: ");
//int.TryParse(Console.ReadLine()!, out b);

int index=0;

while(index<5) {
  Console.Write($"{index} ");
  index++;
}

Console.Write($"\n");
for (int index2=0; index2<5; index2++)

{
Console.Write($"{index2} ");

}
//НАЙТИ КОЛ-ВО ЦИФР В ЧИСЛЕ

 int a= new Random().Next(1000);

 int DigitsCount (int _a)
 {
  int i=0;
while (_a>0)
{
_a=_a/10;
i++;

}

return i;
 }

Console.Write($"digits in {a} = {DigitsCount(a)}");

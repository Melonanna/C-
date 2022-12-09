/*int []array ={1,12,18,4,15,16,17,18};

int n=array.Length;
int find=18;
int index=0;



while (index<n)
{
if (array[index]==find)
{Console.Write(index);
break;

}
index++;

} 

*/

/* LECTURE 2 ON METHODS*/
// 1 method

/*void Method1()
{
  Console.WriteLine("Автор - Анна С");
}

Method1(); таким образом вызываем метод*/

//2 method

/*void Method2(string msg)
{
  Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");
*/
//2.1 method

/*void Method21(string msg, int count)
{
int i=0;
  while (i<count)
{Console.WriteLine(msg);
i++;
}
}
//Method21("Текст сообщения",count:5);
Method21(count:5,msg:"новый текст сообщения");

*/

// 3 method
/*
int Method3()

{
return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

*/

// 4 method

string Method4(int count, string text)

{
int i =0;
string result = String.Empty;
 while (i<count)

 {
result=result+text;
i++;

 }
return result;
}
string res=Method4(10,"asdf ");
Console.WriteLine(res);










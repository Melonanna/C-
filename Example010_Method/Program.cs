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
/*
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
*/

// Method 4.1
/*
string Method4(int count, string text)
{
string result = String.Empty;

for (int i=0; i<count; i++)
{
result=result+text;
 }
return result;
}
string res=Method4(10,"asdf ");
Console.WriteLine(res);

*/
//таблица умножения
/*
for (int i=2; i<=10; i++)
{
  for (int j=2; j<=10; j++)
{
Console.WriteLine($"{i}*{j}={i*j}");

}
Console.WriteLine();
}

*/

//string s = "qwerty"
//            012
// s[3] // r
/*

string Replace(string.text, char oldValue, char newValue)

{
string result=String.Empty;
int length=text.length;
for (int i=0; i<length;i++)
{
  if(text[i]==oldValue)
   result == result+$"{newValue};
   else result== result + ${text[i]};
}
return result;
}

string newText=Replace(text,' ','|');
Console.WriteLine(newText);
newText =Replace(newText,'к','К');
Console.WriteLine(newText);

*/


//SORTING
/*
int [] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[]array)

{
int count = array.Length;

for (int i=0; i<count; i++)

{
  Console.Write($"{array[i]} ");
}

Console.WriteLine();
}

void SelectionSort(int[]array)
{
for (int i=0; i<array.Length-1; i++)
{
int minPosition=i;

//looking for max element
for (int j=i+1; j<array.length; j++)

{
  if(array[j]<array[minPosition]) 
  {minPosition=j;
  }
}

//making swap
int temporary = array[i];
array[i] = array [minPosition];
array [minPosition] = temporary;


}
}
//PrintArray(arr);
//SelectionSort(arr);

*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i+1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) minPosition = j;
{
minPosition = j;
}
}
int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);















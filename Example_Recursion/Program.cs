// ВВОД В 2-МЕРНЫЕ МАССИВЫ
/*
string [,] table = new string[2,5];
// String.Empty - инициализация строк
table[1,2] = "слово";
//table [0,0] table [0,1]  table[0,2] table [0,3] table [0,4]
//table [1,0] table [1,1] table [1,2] table [1,3],table [1,4]

for (int rows=0; rows<2; rows++)
{
for (int columns =0; columns <5; columns++)

{Console.Write($"-{table[rows, columns]}-");

}
Console.WriteLine();
}
*/

//int [,] matrix = new int [3,4];

/*
void PrintArray(int [,] matr)
{
for (int i=0; i<matr.GetLength(0) ; i++)
{
for (int j=0; j<matr.GetLength(1); j++)

{
  Console.Write($"{matr[i,j]} ");
}
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
for (int i=0; i < matr.GetLength(0); i++)
{
for (int j=0; j < matr.GetLength(1); j++)

{
matr[i,j] = new Random().Next(1,10);

}
}
}
int [,] matrix = new int [3,4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

*/

/*code not working!

void PrintImage(int [,] image)
{
  for (int i=0; i<image.GetLength(0); i++)
{
    for (int j=0; j<image.GetLength(1); j++)
{
      if (image[i,j]==0)
Console.Write($" ");
      else 
Console.Write($"+");
}
Console.WriteLine();
}
}

void FillImage(int row,int col);

{
if (pic[row, col] == 0)
{
pic[row,col]=1;
FillImage(row-1,col);
FillImage(row,col-1);
FillImage(row+1,col);
FillImage(row,col+1);

}

}

PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
 CODE NOT WORKING*/

//FACTORIAL SEARCH

double Factorial(int n)
{
if(n==1) 
return 1;
else 
return n*Factorial(n-1);

}
for (int i=1; i<40; i++ )

{Console.WriteLine($"{i}!= {Factorial(i)}");
}

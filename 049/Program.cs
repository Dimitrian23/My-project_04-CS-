// Задача_№49 В указанном массиве целых чисел найдите разницу между максимальным и минимальным элементом

int [] Array9;
Array9=new int[5];

Random random=new Random();
for(int i=0;i<Array9.Length;i++)
Array9[i]=random.Next(1,10);
System.Console.Write("Дан массив чисел : ");
for(int i=0;i<Array9.Length;i++)
System.Console.Write($"[ {Array9[i]} ]");
System.Console.WriteLine();

int max=Array9[0];
for(int i=1;i<Array9.Length;i++)
if (Array9[i]>max)
max=Array9[i];

System.Console.WriteLine($"Максимальное значение в массиве___ ({max})");

int min=Array9[0];
for(int i=1;i<Array9.Length;i++)
if (Array9[i]<min)
min=Array9[i];

System.Console.WriteLine($"Минимальное значение в массиве___ ({min})");

int sum=0;
sum=max-min;
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива___({sum})");


// Задача_№45 Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] Array5;
Array5=new int[10];
int count1=0;
int count2=0;

Random random=new Random();
for(int i=0;i<Array5.Length;i++)
Array5[i]=random.Next(100,999);

System.Console.Write("Дан массив случайных чисел:---> ");
for(int i=0;i<Array5.Length;i++)
System.Console.Write($" [ {Array5[i]} ] ");
System.Console.WriteLine();
  

for(int i=0;i<Array5.Length;i++)
if ((Array5[i] % 2) == 0)
count1++;
System.Console.WriteLine($"Колличество чётных чисел в массиве-------> ({count1})");


for(int i=0;i<Array5.Length;i++)
if ((Array5[i] % 2) != 0)
count2++;
System.Console.WriteLine($"Колличество нечётных чисел в массиве-----> ({count2})");



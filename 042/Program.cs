// Задача_№42 Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

int [] Array2;
Array2=new int[12]; 

Random random=new Random();
  for(int i=0;i<Array2.Length;i++)
    Array2[i]=random.Next(-9,10);

System.Console.Write("Дан массив случайных чисел:---> ");
   for(int i=0;i<Array2.Length;i++)
System.Console.Write($" [ {Array2[i]} ] ");
System.Console.WriteLine();

int sp=0;
for(int i=0;i<Array2.Length;i++)
  if(Array2[i]>0)
   sp=sp+Array2[i];

int sn=0;
  for(int i=0;i<Array2.Length;i++)
   if(Array2[i]<0)
   sn=sn+Array2[i];

System.Console.WriteLine($"Сумма положительных значений массива {sp}");
System.Console.WriteLine($"Сумма отрицательных значений массива {sn}");




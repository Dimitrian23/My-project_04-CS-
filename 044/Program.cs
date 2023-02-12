// Задача_№ Определить, присутствует ли в заданном массиве, некоторое число
 
 int N;
    System.Console.Write("Введите значение для переменной которую хотите найти в сгенирированном массиве:");
         N=Convert.ToInt32(Console.ReadLine());

int [] Array4;
Array4=new int[12]; 

Random random=new Random();
  for(int i=0;i<Array4.Length;i++)
    Array4[i]=random.Next(1,10);

    System.Console.Write("Дан массив случайных чисел:---> ");
   for(int i=0;i<Array4.Length;i++)
    System.Console.Write($" [ {Array4[i]} ] ");
    System.Console.WriteLine();

int j=0;
while(j<Array4.Length&&Array4[j]!=N)
j++;

if(j==Array4.Length)
    System.Console.WriteLine($"Введённое вами значение ({N}) не присутствует в массиве");
else
    System.Console.WriteLine($"Введённое вами значение ({N}) присутствует в массиве");   









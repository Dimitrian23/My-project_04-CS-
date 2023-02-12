// Задача_№46 Создать массив из 123 элементов. Заполнить случайными положительными числами от 0 до 1000. 
// Найти количество элементов которые принадлежат отрезку [10,99].

int [] Array6;
Array6=new int[123]; 
int count=0;


Random random=new Random();
for(int i=0;i<Array6.Length;i++)
Array6[i]=random.Next(1,1000);

System.Console.Write("Дан массив случайных чисел:---> ");
for(int i=0;i<Array6.Length;i++)
System.Console.Write($" [ {Array6[i]} ] ");
System.Console.WriteLine();
  

for(int i=0;i<Array6.Length;i++)
if ((Array6[i]>=10)&&(Array6[i]<=99))
count++;
System.Console.WriteLine($"Колличество элементов принадлежащих отрезку от [10] до [99] равно-------> ({count})");
















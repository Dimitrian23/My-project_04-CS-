// Задача_№47 Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] Array7;
Array7=new int[10];

Random random=new Random();
for(int i=0;i<Array7.Length;i++)
Array7[i]=random.Next(1,10);

System.Console.Write("Дан массив случайных чисел:---> ");
for(int i=0;i<Array7.Length;i++)
System.Console.Write($" [ {Array7[i]} ] ");
System.Console.WriteLine();
 System.Console.WriteLine(); 


int sum=0;
for(int i=0;i<Array7.Length;i=i+2) // в матиматике 0-чётное число
sum=sum+Array7[i];
System.Console.WriteLine($"Сумма чисел стоящих на чётных позициях равна ({sum})");

int sum1=0;
for(int i=1;i<Array7.Length;i=i+2)
sum1=sum1+Array7[i];
System.Console.WriteLine($"Сумма чисел стоящих на не чётных позициях равна ({sum1})");



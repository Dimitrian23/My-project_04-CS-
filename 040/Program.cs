// Задача_№40 Задать массив из 8 целых элементов и вывести их на экран

int [] Array1;
Array1=new int[8];

Random random=new Random();
for(int i=0;i<Array1.Length;i++)
Array1[i]=random.Next(1,10);

for(int i=0;i<Array1.Length;i++)
System.Console.Write($"[ {Array1[i]} ]");
System.Console.WriteLine();


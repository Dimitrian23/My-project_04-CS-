// Задача_№48 Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве a. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// а) вариант когда в массиве четное кол-во элементов
// б) * вариант когда в массиве и четное и не четное кол-во элементов


//_________Вариант когда в массиве чётное колличество элементов_______
// int [] Array8;
// Array8=new int[10];

// Random random=new Random();
// for(int i=0;i<Array8.Length;i++)
// Array8[i]=random.Next(1,10);



// System.Console.Write("Дан массив случайных чисел:---> ");
// for(int i=0;i<Array8.Length;i++)
// System.Console.Write($" [ {Array8[i]} ] ");
// System.Console.WriteLine();
//  System.Console.WriteLine(); 

// int [] Arr8;
// Arr8=new int[5];
// //  for(int i=0;i<Arr8.Length;i++)
// Arr8[0]=Array8[0]*Array8[9];
// Arr8[1]=Array8[1]*Array8[8];
// Arr8[2]=Array8[2]*Array8[7];
// Arr8[3]=Array8[3]*Array8[6];
// Arr8[4]=Array8[4]*Array8[5];

// System.Console.Write("Вывожу массив состоящий из произведений:---> ");
// for(int i=0;i<Arr8.Length;i++)
// System.Console.Write($" [ {Arr8[i]} ] ");
// System.Console.WriteLine();


//_____Вариант когда в массиве нечётное колличество элементов!
int [] A;
A=new int[9];

Random random=new Random();
for(int i=0;i<A.Length;i++)
A[i]=random.Next(1,10);



System.Console.Write("Дан массив [A] заполненый случайными числами:---> ");
for(int i=0;i<A.Length;i++)
System.Console.Write($" [ {A[i]} ] ");
System.Console.WriteLine();
 System.Console.WriteLine(); 

int [] B;
B=new int[5];
//  for(int i=0;i<Arr8.Length;i++)
B[0]=A[0]*A[8];
B[1]=A[1]*A[7];
B[2]=A[2]*A[6];
B[3]=A[3]*A[5];
B[4]=A[4]*A[4];

System.Console.Write("Вывожу массив [В] состоящий из произведений пар массива [A]:---> ");
for(int i=0;i<B.Length;i++)
System.Console.Write($" [ {B[i]} ] ");
System.Console.WriteLine();








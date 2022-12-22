// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
Console.Write("Введите число :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень :");
int b = Convert.ToInt32(Console.ReadLine());
int num = a;
for (int i = 1; i < b; i++)
{
    num = num * a;
}

Console.WriteLine (" " + num);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int SumNum (int num)
{int result = 0;
    while (num > 0)
    {
                result = result + num % 10; 
        num = num/10;    
    }
return result;
}
Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(num);
Console.WriteLine ("Сумма чисел: " + sum);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
int[] CreateRandomArray() //МЕТОД, ФОРМИРУЮЩИЙ СЛУЧАЙНЫЙ МАССИВ
{
int[] array = new int[8];

for(int i = 0; i < 8; i ++)
        array[i] = new Random().Next(0, 100);
    
    return array;//просто имя массива
}

void ShowArray(int[] array) //МЕТОД, ОРГАНИЗУЮЩИЙ ВЫВОД МАССИВА
{
    Console.Write("[");  
    {   
    for(int i = 0; i < array.Length; i++)  
        Console.Write(array[i] + ", ");       
    }
    Console.Write("]");
}

int [] myArray = CreateRandomArray();
ShowArray(myArray);
*/





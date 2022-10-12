// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число:"); 
int N = int.Parse(Console.ReadLine()!);
int resalt = 1;
int cub;

if(N < 1)
{
    Console.WriteLine("Ввели некорректное число. Введите число равное или больше 1.");
}

else
{
     while (resalt < N)
    {
        cub = resalt * resalt * resalt;
        Console.Write($"{cub},");
        resalt++;
    }
    Console.Write($"{Math.Pow(N, 3)}");
}


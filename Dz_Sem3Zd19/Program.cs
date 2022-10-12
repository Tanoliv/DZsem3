// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

/*Console.WriteLine("Введите пятизначное число:"); 
int num = int.Parse(Console.ReadLine()!);


int resalt = 0;
int resalt1 = 0;

if(num < 10000 || num > 99999){
    Console.WriteLine("Ввели некорректное число. Введите пятизначное."); 
    }


else{
    int nu = num /1000;
    int n1 = nu / 10;
    int n2 = num / 1000 - n1 * 10;
   
    int ntu = num % 100;
    int n4 = ntu / 10;
    int n5 = ntu % 10;  
    resalt = n1 % n5;
    resalt1 = n2 % n4;


       if(resalt == resalt1){
        Console.WriteLine($"Число {num} => палиандром.");
        }
        else{
        Console.WriteLine($"Число {num} => не палиандром.");
        }
}*/


Console.WriteLine("Введите пятизначное число:"); 
string num = Console.ReadLine()!;

if((num.Length == 5)){
    int resalt = Convert.ToInt32(num[0] % num[4]);
    int resalt1 = Convert.ToInt32(num[1] % num[3]);
    if(resalt == resalt1){
         Console.WriteLine("Число -> ПАЛИАНДРОМ!!!");
    }
    else{
        Console.WriteLine("Палиандром? -> НЕТ");
    }
}
else{
  Console.WriteLine("Ввели некорректное число. Введите пятизначное.");   
}

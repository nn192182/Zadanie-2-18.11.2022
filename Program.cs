
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int  Digits (int number)
{
   int cot = number % 100;
   int dec = number % 10;
   int ed = number / 10;

   int result;
   if (cot > ed){
    result = ed;
   }
   else result = ed;

   return result;
}
Console.WriteLine("Imput your 3digit number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int res = Digits(user_num);

Console.Write($"Вторая цифра числа {res} ");
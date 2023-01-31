using System.Security.Principal;
using System.Threading.Tasks.Dataflow;
using static System.Console;

// Task 1
/* 
Write("Введите число в диапозоне от 1 до 100: ");
int num = Convert.ToInt32(ReadLine());

for(int i=1;i<100;i++)
{
if (num > 100 || num < 1)
    {
        WriteLine("Вы вышли за приделы диапозона,поробуйте снова");
        break;
    }
else if (num % 3 == 0 && num % 5 == 0) 
    {
        WriteLine("Fizz Buzz");
        break;
    }
else if (num % 3 == 0)
    {
        WriteLine("Fizz");
        break;
    }
else if (num % 5 == 0)
    {
        WriteLine("Buzz");
        break;
    }
else
    {
        WriteLine(num);
        break;
    }
}
*/

// Task 2
/*
WriteLine("Введите два числа ");
Write("Введите значение: ");
double num1=Convert.ToDouble(ReadLine());
Write("Введите процент: ");
double num2=Convert.ToDouble(ReadLine());

double result;
result = num1 * num2 / 100;
WriteLine($"Результат: {result}");
*/

// Task 3
//Пользователь вводит с клавиатуры четыре цифры.
//Необходимо создать число, содержащее эти цифры.  
/*
Write("Введите первую цифру:");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите вторую цифру:");
int num2 = Convert.ToInt32(ReadLine());
Write("Введите третью цифру:");
int num3 = Convert.ToInt32(ReadLine());
Write("Введите четвертую цифру: ");
int num4 = Convert.ToInt32(ReadLine());
WriteLine($"Созданное число: {num1}{num2}{num3}{num4}");
*/

// Task 4
//Пользователь вводит шестизначное число. После чего
//пользователь вводит номера разрядов для обмена цифр.
Write("Введите шестизначное число: ");
int num1=Convert.ToInt32(ReadLine());
WriteLine("Введите номера разрядов для обмена цифр: ");
Write("Первый разряд: ");
int num2=Convert.ToInt32(ReadLine());
Write("Второй разряд: ");
int num3=Convert.ToInt32(ReadLine());
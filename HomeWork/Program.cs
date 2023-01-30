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


WriteLine("Ввудите два числа ");
Write("Введите значение: ");
double num1=Convert.ToDouble(ReadLine());
Write("Введите процент: ");
double num2=Convert.ToDouble(ReadLine());

double result;
result = num1 * num2 / 100;
WriteLine($"Результат: {result}");
//Завдання 1

int a;
Console.WriteLine("Введіть число : ");
a = int.Parse(Console.ReadLine());
if (a > 0)
{ Console.WriteLine("Число додатнє"); }
else if (a < 0)
{ Console.WriteLine("Число від'ємне"); }
else
{ Console.WriteLine("Число = 0"); }

//Завдання 2
using System.Diagnostics.CodeAnalysis;

int a1;
Console.WriteLine("Введіть рік : ");
a1 = int.Parse(Console.ReadLine());
if (((a1%4==0) & (a1%100!=0)) | (a1%400==0))
        { Console.WriteLine($"{a1} рік  є високосним"); }
else
{ Console.WriteLine($"{a1} рік не є високосним"); }


//Завдання 3
int a;
double tax;
Console.WriteLine("Введіть дохід : ");
a = int.Parse(Console.ReadLine());
if (a <= 10000)
{ Console.WriteLine("Податок = 0"); }
else if (a <= 50000)
{
    tax = (a - 10000) * 0.1;
    Console.WriteLine($"Податок = {tax:F2} грн");
}
else if (a <= 100000)
{
    tax = (50000 - 10000) * 0.1 + (a - 50000) * 0.2;
    Console.WriteLine($"Податок = {tax:F2} грн");
}
else
{
    tax = (50000 - 10000) * 0.1 + (a - 50000) * 0.2 + (a - 100000) * 0.3;
    Console.WriteLine($"Податок = {tax:F2} грн");
}

//Завдання 4
char sym;
Console.WriteLine("Введіть символ:");
sym = char.Parse(Console.ReadLine());

if ((sym == 'A') | (sym == 'E') | (sym == 'I') | (sym == 'O') | (sym == 'U'))
{
    Console.WriteLine("Введений символ є голосною");
        }
else
{
    Console.WriteLine("Введений символ є приголосною");
}

//Завдання 5
int a, b, c;
Console.WriteLine("Введіть 1 число:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть 2 число:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть 3 число:");
c = int.Parse(Console.ReadLine());
if ((a>b) & (a>c))
{
    Console.WriteLine($"Найбільше число {a:F0} ");
}
else if (b>c)
{
    Console.WriteLine($"Найбільше число {b:F0} ");
}
else
{
    Console.WriteLine($"Найбільше число {c:F0} ");
}

//Завдання 6
int age;
Console.WriteLine("Введіть вік:");
age = int.Parse(Console.ReadLine());
if ((age >=12 ) & (age <= 18))
{
    Console.WriteLine($"Задана к-сть років : {age:F0} є підліковим");
}
else
{
    Console.WriteLine($"Задана к-сть років : {age:F0} не є підліковим");
}

//Завдання 7
int num;
Console.WriteLine("Введіть число:");
num= int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"Число {num:F0} є парним");
}
else
{
    Console.WriteLine($"Число {num:F0} не є парним");
}
if (num % 3 == 0)
{
    Console.WriteLine("Число ділиться на 3 ");
}
else
{
    Console.WriteLine("Число не ділиться на 3 ");
}

//Завдання 8
int a, b, c;
Console.WriteLine("Введіть сторону a :");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть сторону b:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть сторону c");
c = int.Parse(Console.ReadLine());
if (a <= 0 | b <= 0  |c <= 0)
{
    Console.WriteLine("Помилка");
    return;
}
if ((a > b) & (a > c))
{
    Console.WriteLine($"Найдовша сторона {a:F0} ");
}
else if (b > c)
{
    Console.WriteLine($"Найдовша сторона {b:F0} ");
}
else
{
    Console.WriteLine($"Найдовша сторона {c:F0} ");
}

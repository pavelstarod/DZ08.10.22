//Подсчитать сумму цифр в числе



Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

while (n / 10 != 0 || n % 10 != 0)
{
    sum = sum + (n % 10);
    n = n / 10;
}

Console.WriteLine("Вывод суммы цифр числа: " + sum);


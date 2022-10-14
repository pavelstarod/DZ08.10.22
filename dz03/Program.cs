//Написать программу вычисления произведения чисел от 1 до N


Console.WriteLine("Введите N2: ");
int N2 = int.Parse(Console.ReadLine() ?? "0");
int N1 = 1;
int result = 1;

while (N1 <= N2)
{
    result = result * N1;
    N1++;
}
Console.WriteLine("Вывод произведения цифр числа: " + result);

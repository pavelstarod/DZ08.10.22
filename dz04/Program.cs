//Показать кубы чисел, заканчивающихся на четную цифру


Console.WriteLine("ведите N2: ");
int N2 = int.Parse(Console.ReadLine() ?? "0");
int N1 = 1;
Console.WriteLine("Вывод кубов чисел, заканчивающихся на четную цифру: ");

while (N1 <= N2)
{
    int result = N1 * N1 * N1;
    N1++;
       if (result % 2 == 0)
    { 
           Console.WriteLine(result);
    }
}



// Console.WriteLine("Введите N2: ");
// int N2 = int.Parse(Console.ReadLine() ?? "0");
// int N1 = 2;
// Console.WriteLine("Вывод кубов чисел, заканчивающихся на четную цифру: ");

// while (N1 <= N2)
// {
//    Console.WriteLine(N1*N1*N1);
//    N1 = N1 + 2;
// }

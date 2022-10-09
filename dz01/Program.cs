Console.WriteLine("Введите N2: ");
int N = 1;
int N2 = int.Parse(Console.ReadLine());
Console.WriteLine("Вывод кубов числа из отрезка: ");

while (N <= N2)
{ 
    Console.WriteLine(N*N*N);
    N++;
}
    

Console.WriteLine("Введите неотрицательное число m: ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите неоткрицательное n: ");
int n = Int32.Parse(Console.ReadLine());

int Ackerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return Ackerman(m-1, 1);
    }
    else
    {
        return Ackerman(m-1, Ackerman(m, n-1));
    }    
}
Console.WriteLine(Ackerman(m,n));


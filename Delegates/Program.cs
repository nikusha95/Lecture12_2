// See https://aka.ms/new-console-template for more information

namespace Delegates;

internal class Program
{
    public delegate int MyDelegate(int a, int b);

    public static int Sum(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static void Main(string[] args)
    {
        MyDelegate d = Sum;

        Console.WriteLine(Sum(5, 4));
        Console.WriteLine(d(5, 4));
        d.Invoke(1, 2); //d(1,2)

        foreach (var invoc in d.GetInvocationList())
        {
            Console.WriteLine($"{invoc.Method.Name} {invoc.Method.Module}");
        }

        PrintMethod(1, 2, d);
        d += Subtract;

        foreach (var invoc in d.GetInvocationList())
        {
            Console.WriteLine($"{invoc.Method.Name} {invoc.Method.Module}");
        }

        d -= Subtract;
        PrintMethod(1, 2, d);

        MyDelegate anonym = (x, y) => x * y;
        Console.WriteLine(anonym(3, 5));

        Func<int, double, double> f = (i, i1) => i * i1;
        
        Console.WriteLine(f(10, 2));
    }

    public static void PrintMethod(int a, int b, MyDelegate del)
    {
        Console.WriteLine(del(a, b));
    }
}
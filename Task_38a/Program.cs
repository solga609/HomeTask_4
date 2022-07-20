//  double [] array = {3.5, 4.5, 7.1, 1.4, 6.5};
//  double min = double.MaxValue;
// double max = double.MinValue;
// double k;
// for(int i = 0; i < 6; i++){
//     // Console.Write("Введите {0}-е число: ", i + 1);
//     Console.Write
//     k = double.Parse(Console.ReadLine());
//     if (k > max)
//     max = k;
//     if(k < min)
//     min = k;
// }
// Console.WriteLine("Разница между максимальным и минимальным значением: {0}", max - min);
// Console.ReadKey();

// double a, b, c, d;
// Console.Write("Введите первое число: ");
// a = Double.Parse(Console.ReadLine());
// Console.Write("Введите первое число: ");
// b = Double.Parse(Console.ReadLine());
// Console.Write("Введите первое число: ");
// c = Double.Parse(Console.ReadLine());
// Console.Write("Введите первое число: ");
// d = Double.Parse(Console.ReadLine());
// if (a>b && b>c && c>d)
// double Ras = a-b;
// Console.Write("Максимальное значение - минимальное", Ras);

internal class Program
{
    private static void Main(string[] args)
    {
        double[] mass = { 5.4, 3.6, 7.1, 8.5 };
        int m = 0;

        for (int i = 0; i < mass.Length; i++)
        {
            if ( mass[i] <  mass[m])
            {
                m = i;
            }
        }
        for (int j = 0; j < mass.Length; j++)
        {
            mass[j] = mass[j] - m;
        
            Console.Write(mass[j]);
            Console.Write(' ');
        }
        Console.WriteLine();
    }
}
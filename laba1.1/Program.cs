try
{

    Console.Write("Введите значение y: ");
    double y = double.Parse(Console.ReadLine());


    Console.Write("Введите значение p: ");
    double p = double.Parse(Console.ReadLine());


    Console.Write("Введите значение n: ");
    double n = double.Parse(Console.ReadLine());


    double N = 3 * Math.Pow(y, 2) + Math.Sqrt(y + 1) / Math.Log(p + n) + Math.Exp(p);

    Console.WriteLine($"Результат N = {N}");

}
catch
{
    Console.WriteLine("Введите правильно");
}
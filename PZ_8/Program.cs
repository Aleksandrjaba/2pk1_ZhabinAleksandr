namespace PZ_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //пользователь вводит значения и присваиваются переменным a, b, c

            Console.WriteLine("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("c = ");
            double c = double.Parse(Console.ReadLine());

            double num1;
            double num2;   //ввожу переменные чтобы потом использовать их в промежуточном варианте

            num1 = (a - c) * Math.Pow(a, 2) + Math.Pow(b, 2);

            num2 = Math.Cbrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2.2 * c);
            
            double Result = (Math.Pow(10, -3) * Math.Tan(-8)) - (num1 / num2) - (Math.Cos(2 * a) / Math.Sin(5));

            Console.WriteLine(Result);
        }
    }
}

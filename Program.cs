namespace Circle_Ex4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Circle circle = new Circle();
            Console.Write("輸入圓形半徑:");
            r = double.Parse(Console.ReadLine());
            circle.radius = r;
            if (r < 10)
            {
                circle.radius = 10;
            }
            else if (r > 20)
            {
                circle.radius = 20;
            }
            Console.WriteLine("使用半徑 = {0}", circle.radius);
            Console.WriteLine("圓周長 = {0}", circle.CalCircumference());
            Console.WriteLine("圓面積 = {0}", circle.CalArea());
            Console.Read();
        }
    }
}
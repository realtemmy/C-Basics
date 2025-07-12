using System;



namespace Test
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //int i = 42;
            //int j = (int)5.7;
            //double dl = i;

            //Console.WriteLine(i / 5);
            //Console.WriteLine(dl / 5);
            //Console.WriteLine(i / 5.0);
            //Console.WriteLine(j);

            // ============ String Interpolation ================== //

            //String message = $"It's been about {i} years since it happened last.";

            //double width = 3, height = 4;
            //string info = $"Hypotenuse: {Math.Sqrt(width * width + height * height)}";

            //Console.WriteLine(info);
            //Console.WriteLine(message);

            // Tuples
            (int x, int y) point = (10, 5); // or var point = (x:10,y:5)

            Console.WriteLine($"X: {point.x}, Y: {point.y}");

            Console.Beep();
        }
    }

}


namespace Task5
{
    public class Triangle
    {
        double a, b, c;

        public double A
        {
            set
            {
                if (value > 0) a = value;
                else Console.WriteLine("1 сторона не може бути від'ємною");
            }
        }

        public double B
        {
            set
            {
                if (value > 0) b = value;
                else Console.WriteLine("2 сторона не може бути від'ємною");
            }
        }
        public double C
        {
            set
            {
                if (value > 0) c = value;
                else Console.WriteLine("3 сторона не може бути від'ємною");
            }
        }

        public bool Correct()
        {
            bool p = false;
            if (a < b + c && b < a + c && c < a + b) p = true;
            return p;
        }

        public void Print()
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }
        public double Perimetr()
        {
            double p = a + b + c;
            return p;
        }

        public double Sqr()
        {
            double p = this.Perimetr() / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            try
            {
                Console.Write("x="); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y="); y = Convert.ToDouble(Console.ReadLine());
                Console.Write("z="); z = Convert.ToDouble(Console.ReadLine());

                Triangle t = new Triangle();

                t.A = x; t.B = y; t.C = z;

                t.Print();

                if (t.Correct())
                {
                    double p = t.Perimetr();
                    double s = t.Sqr();

                    Console.WriteLine("P = {0}, S = {1:F3}", p, s);

                }
                else Console.WriteLine("Такого трикутника не існує ");
            }
            catch
            {
                Console.WriteLine("Error!!!");
            }
        }
    }
}

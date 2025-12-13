namespace _6dars
{
    internal class Program
    {
        static int Calculate(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Calculate(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }


        static float Add(float a, float b)
        {
            return a + b;
        }

        static float Add(float a, float b, float c)
        {
            return a + b + c;
        }

        static string Add(string a, string b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(2.5f, 3.5f));
            Console.WriteLine(Add(2.1f, 3f, 7.7f));
            Console.WriteLine(Add("Salom", "Dunyo"));
            Console.WriteLine(Calculate(4,5));
            Console.WriteLine(Calculate(2,5,6));
        }
    }
}

namespace OperatorExercise

{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;

            int difference = a - b;

            int product = a * b;

            int quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine();
            Console.WriteLine("What is the radius of a cirle that you would like to use?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));



        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}

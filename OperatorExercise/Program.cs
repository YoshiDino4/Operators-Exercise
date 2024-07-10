namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        static void Main(string[] args)
        {
            // For division, create 2 int variables called a and b
            int a = 17;
            int b = 4;

            int sum = a + b;
            int sub = a - b;
            int mult = a * b;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {sub}");
            Console.WriteLine($"{a} * {b} = {mult}");
            Console.WriteLine($"{a} / {b} = {quotient} remainder {remainder}");

            Console.WriteLine("Enter a number to be the radius of a circle: ");
            var radius = double.Parse(Console.ReadLine());
            var area  = AreaOfCircle(radius);
            Console.WriteLine($"The area of this circle is: {area}");
        }
    }
}

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int diff = a - b;
            int product = a * b;

            int quotient = a / b;

            int remainder = a % b;

            


            Console.WriteLine($"a + b = {sum}");
            Console.WriteLine($"a - b = {diff}");
            Console.WriteLine($"a * b = {product}");

            if(a == 17 && b == 4)
            {
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


                
            Console.WriteLine($"What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
            static double AreaOfCircle(double radius)
                {
                   double area = Math.PI * Math.Pow(radius, 2);
                   return area;
                }


            }



        }
    }
}

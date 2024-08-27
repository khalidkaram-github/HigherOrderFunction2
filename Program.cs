namespace HigherOrderFunction2
{
    internal class Program
    {

        //Example 2:Returning Functions from Functions
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;

        static void Main()
        {
            Func<int, int, int> add = GetMathOperation("add");
            Console.WriteLine("Addition: " + add(5, 3)); // Output: 8
            Console.WriteLine($"Addition: {GetMathOperation("add")(5, 3)}");// Output: 8




            Func<int, int, int> subtract = GetMathOperation("subtract");
            Console.WriteLine("Subtraction: " + subtract(5, 3)); // Output: 2
            Console.WriteLine($"Subtraction: {GetMathOperation("subtract")(5, 3)}");// Output: 2
        }
        static Func<int, int, int> GetMathOperation(string operation)
        {
            switch (operation.ToLower())
            {
                case "add": return Add;
                case "subtract": return Subtract;
                default: throw new ArgumentException("Invalid operation");
            }
        }

    }
}

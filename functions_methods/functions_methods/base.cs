namespace functions_methods
{
    internal class @base
    {
        static void ExampleMethod()
        {
            Console.WriteLine("This is an example method!");
        }

        static void ExampleMethod2() => Console.WriteLine("hello");

        static string echo(string message)
        {
            return message;
        }

        static string echo2(string message) => message;

        static void Main(string[] args)
        {
            ExampleMethod();
            ExampleMethod2();
        }
    }
}

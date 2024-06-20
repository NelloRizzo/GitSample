namespace GitSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[1] == "it")
                Console.WriteLine("Ciao, Mondo!");
            else
                Console.WriteLine("Hello, World!");
        }
    }
}

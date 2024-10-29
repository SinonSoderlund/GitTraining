namespace GitTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej");
            Console.WriteLine("daniel");
            Console.WriteLine("yes");
            Console.WriteLine(new Bunnyficator(args, 12).ToString());
            var bunny = new Bunnyficator(Program.Main, 12);
            Console.WriteLine(bunny);
            Console.WriteLine("Update from dansaa8 branch");

            
            Console.WriteLine("Hello from mohammad's branch");
        }
    }
}

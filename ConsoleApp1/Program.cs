namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            GenClass<int> l = new GenClass<int>();
            l.Add(1);
            l.Add(5);   
            l.Add(2);   
        l.Add(3);
            l.Add(7);   

             


            foreach (int i in l.GetSortedList())
            {
                Console.WriteLine($"{i}");  

            }

        }
    }
}

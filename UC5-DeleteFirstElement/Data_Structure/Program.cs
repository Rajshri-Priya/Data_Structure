namespace Data_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Data Structure Program");

            LinkedList ln = new LinkedList();
            ln.Add(56);
            ln.Add(30);
            ln.Add(70);
            ln.RemoveFirstNode();
            Console.WriteLine("After removing is : ");
            ln.Display();
            
        }
    }
}
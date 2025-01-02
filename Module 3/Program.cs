namespace Module_3;

class Program
{
    static void Main(string[] args)
    {
        const string myName = "Jane";
        Console.WriteLine(myName);

        Console.WriteLine("\t Привет, мир");
        Console.WriteLine("\t Мне 41 год");
        Console.WriteLine("\t My name is \n {0}", myName);
        Console.WriteLine("\u0040");
        
        Console.ReadKey();
    }
}
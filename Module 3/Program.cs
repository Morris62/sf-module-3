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
        Console.WriteLine("\x0040");
        Console.WriteLine("\x23");
        
        Console.WriteLine(true);
        Console.WriteLine(false);

        Console.WriteLine(5);
        
        Console.WriteLine(0x0A);
        Console.WriteLine(0b11);
        Console.WriteLine(5.5);
        
        Console.ReadKey();
    }
}
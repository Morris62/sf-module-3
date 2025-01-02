namespace Module_3;

class Program
{
    static void Main(string[] args)
    {
        string MyName = "Jane";
        byte MyAge = 27;
        bool HaveIPet = true;
        double MyShoeSize = 37.5;
        
        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("My age is " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIPet);
        Console.WriteLine("My shoe size is " + MyShoeSize);

        Console.WriteLine("Int.MaxValue {0}", int.MaxValue);
        Console.WriteLine("Int.MinValue {0}", int.MinValue);
        Console.WriteLine("Double.MaxValue {0}", double.MaxValue);
        Console.WriteLine("Double.MinValue {0}", double.MinValue);
        
        Console.ReadKey();
    }
}
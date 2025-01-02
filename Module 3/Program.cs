namespace Module_3;

class Program
{
    static void Main(string[] args)
    {
        Semaphore MyFavouriteSemaphoreColor = Semaphore.Green;

        Console.WriteLine(MyFavouriteSemaphoreColor);
        
        Console.ReadKey();
    }

    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}
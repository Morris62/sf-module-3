namespace Module_3;

class Program
{
    static void Main(string[] args)
    {
        DaysOfWeek MyFavouriteDay = DaysOfWeek.Friday;

        Console.WriteLine(MyFavouriteDay);
        
        Console.ReadKey();
    }

    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
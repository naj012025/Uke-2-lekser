namespace Uke_2_lekser;

class Program
{
    static void Main(string[] args)
    {
        
        
        DateTime Now = DateTime.Now;
        int time = Now.Hour;
        Console.WriteLine("Hello user please enter your name: ");
        string? username =  Console.ReadLine();// runs men får warning og spør ikke brukere om navn. fikk beskjet at man kan bruke var 
        // får og få vekk warning.
        Console.Clear();
        Console.WriteLine($"Hello {username}\n The Date and time is {Now}");
            // husk at <= betyr mindre eller equal for exempel 10. 
        switch(time)
        {
           case int T when  T <= 10:
           Console.WriteLine("Good morning!");
            break;
            case int T when T <= 12:
            Console.WriteLine("Lunchtime");
            break;
           case int T when T <= 14:
           Console.WriteLine("Good afternoon");
           break;
           case int T when T <= 20:
           Console.WriteLine("good evening");
           break;
           default:
           Console.WriteLine("you should be sleeping.");
           break;
        
        }
    }
}

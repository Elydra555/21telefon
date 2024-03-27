using ClassLibrary.Data;
using ClassLibrary.Models;

namespace alapDolgok
{
    public class Program
    {
        static void Kiir(IEnumerable<object> szemelyek)
        {
            foreach (var item in szemelyek)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            EmberekContext db = new EmberekContext();

            if (!db.Emberkek.Any())
            {
                var sorok = File.ReadAllLines(@"C:\Users\Diak\dev\kb\asztali\oop\21telefon\21csv\21.csv").Skip(1);
                foreach (var line in sorok)
                {
                    db.Emberkek.Add(new Emberek(line));
                }
                db.SaveChanges();
            }
            Kiir(db.Emberkek);
        }
    }
}

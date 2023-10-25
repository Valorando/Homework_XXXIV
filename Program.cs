using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableModel;
using TableContext;


namespace Homework_25_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Таблица команд";


            using (StandingsContext sc = new StandingsContext())
            {
                Standings standings = new Standings { Name = "Barcelona", Place = 1, Win = 18, Loss = 0, Draw = 2 };
                Standings standings2 = new Standings { Name = "Real Madrid", Place = 2, Win = 17, Loss = 1, Draw = 1 };

                sc.Standings.Add(standings);
                sc.Standings.Add(standings2);

                sc.SaveChanges();

                using (StandingsContext scc = new StandingsContext())
                {
                    var st = scc.Standings.ToList();
                    Console.WriteLine("ID\tНазвание команды\tМесто\tПобеды\tПроиграши\tНичьи");
                    foreach (var b in st)
                    {
                        Console.WriteLine($"{b.Id}\t{b.Name}\t{b.Place}\t{b.Win}\t{b.Loss}\t{b.Draw}");
                    }
                }
                
            }
        }
    }
}

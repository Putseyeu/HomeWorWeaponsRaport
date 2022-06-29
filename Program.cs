using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWeaponsReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            database.ShowRankAndName();
            Console.ReadLine();
        }
    }

    class Database
    {
        private List<Solder> _solders = new List<Solder>()
        {
            new Solder("Петров В.Ф", "автомат","рядовой", 24),
            new Solder("Иванов С.С", "пулемёт","рядовой", 14),
            new Solder("Cетров B.К", "винтовка","ефрейтор", 15),
            new Solder("Бетров К.А", "автомат","сержант", 24),
            new Solder("Ершов В.Ф", "пистолет","лейтенант", 58)
        };

        public void ShowRankAndName()
        {
            var newSquadSolder = _solders.Select(solder => new
            {
                Name = solder.Name,
                Rank = solder.Rank,
            });
            
            foreach (var solder in newSquadSolder)
            {
                Console.WriteLine($"Фамилия И.О  - {solder.Name}, звание -  {solder.Rank} ");
            }
        }
    }

    class Solder
    {
        public string Name { get; private set; }
        public string PersonalWeapon { get; private set; }
        public string Rank { get; private set; }
        public int ServingInTheArmy { get; private set; }

        public Solder(string name, string personalWeapon, string rank, int servingInTheArmy)
        {
            Name = name;
            PersonalWeapon = personalWeapon;
            Rank = rank;
            ServingInTheArmy = servingInTheArmy;
        }
    }
}

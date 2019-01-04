using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
    public static class ForEachDeconstruction
    {
        public static void Example1()
        {
            Console.WriteLine();
            Console.WriteLine();

            List<Musician> results = GetMusicianList();

            // Group the list by Instrument 
            var groupedList = results.GroupBy(f => f.Instrument)
                                     .ToDictionary(grp => grp.Key, grp => grp.ToList());

            // Loop over the groups and display the names
            foreach (var (instrument, musicians) in groupedList)
            {
                Console.WriteLine($"Instrument: {instrument}");
                foreach (var person in musicians)
                {
                    Console.WriteLine($"   : {person.Name}");
                }
            }

            Console.Write("\nPress Enter to exit: ");
            Console.ReadLine();
        }

        private static List<Musician> GetMusicianList()
        {
            return new List<Musician>() {
                new Musician() { Name = "Miles Davis", Instrument = "Trumpet" },
                new Musician() { Name = "Marcus Miller", Instrument = "Bass" },
                new Musician() { Name = "Tony Williams", Instrument = "Drums" },
                new Musician() { Name = "John Coltrane", Instrument = "Sax" },
                new Musician() { Name = "Lee Morgan", Instrument = "Trumpet" },
                new Musician() { Name = "Paul Chambers", Instrument = "Bass" },
                new Musician() { Name = "Philly Joe Jones", Instrument = "Drums" },
                new Musician() { Name = "Sonny Rollins", Instrument = "Sax" },
                new Musician() { Name = "Randy Brecker", Instrument = "Trumpet" },
                new Musician() { Name = "Ron Carter", Instrument = "Bass" },
                new Musician() { Name = "Kenny Clark", Instrument = "Drums" },
                new Musician() { Name = "Wayne Shorter", Instrument = "Sax" }
            };
        }
    }

    internal class Musician
    {
        public string Name { get; set; }
        public string Instrument { get; set; }
    }
}

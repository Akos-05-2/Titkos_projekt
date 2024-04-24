using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Titkos_Projekt
{
    internal class Cargo
    {
        private static int nextId = -1;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Good { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Cargo: {Id};{Date.ToShortDateString()};{Source}{Destination};{Good};{Quantity}";
        }

        public string ToCSV()
        {
            return $"Cargo: {Id};{Date.ToShortDateString()};{Source}{Destination};{Good};{Quantity}";
        }

        public static Cargo CreteFromLine(string line, char separator = ';')
        {
            string[] split = line.Split(separator);
            nextId++;
            return new Cargo()
            {
                Id = nextId,
                Date = DateTime.Parse(split[0]),
                Source = split[1],
                Destination = split[2],
                Good = split[3],
                Quantity = int.Parse(split[4])
            };
        }
    }
}

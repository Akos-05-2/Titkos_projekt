using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OA_Titkos_Projekt
{
    internal class CargoRepository
    {
        public static string Path { get; set; } = "cargo.csv";
        public static bool SkipHeader { get; set; } = false;
        public static char Separator { get; set; } = ';';

        public static List<Cargo> FindAll()
        {
            using (StreamReader r = new StreamReader(Path))
            {
                if (SkipHeader)
                {
                    r.ReadLine();
                }
                List<Cargo> cargos = new List<Cargo>();
                while (!r.EndOfStream)
                {
                    string line = r.ReadLine();
                    Cargo cargo = Cargo.CreteFromLine(line, Separator);
                    cargos.Add(cargo);
                }
                return cargos;
            }
            
        }
        public static Cargo FindById(int id)
        {
            foreach (Cargo cargo in FindAll())
            {
                if (cargo.Id == id)
                {
                    return cargo;
                }
            }
            return null;
        }
        public static void Save(Cargo cargo)
        {
            List<Cargo> cargos = FindAll();
            cargos.Add(cargo);
            Cargo.nextId = 0;
            using (StreamWriter w = new StreamWriter(Path))
            {
                w.WriteLine(cargo.ToCSV());
            } 
        }
    }
}

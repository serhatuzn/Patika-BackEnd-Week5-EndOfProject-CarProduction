using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosingProject
{
    public class Cars
    {
        public DateTime UretimTarih { get; set; }
        public string SeriNumarası { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; } 
        public int KapıSayısı { get; set; }

        public Cars (DateTime UretimTarih)
        {
            UretimTarih = DateTime.Now;
        }

        public Cars()
        {
        }

        internal static void Add(Cars newCar)
        {
            throw new NotImplementedException();
        }
    }

}
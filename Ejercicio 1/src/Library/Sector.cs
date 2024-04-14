using System.Collections.Generic;

namespace Ucu.Poo.Expert
{

    public class Sector
    {
        public string LibrarySector { get ; set; }
        private List<ShelveBook> Shelve;
        
        public Sector(string sector)
        {
            this.LibrarySector = sector;
            this.Shelve = new List<ShelveBook>();
        }

        public void AddShelve(ShelveBook Shelve)
        {
            this.Shelve.Add(Shelve);
        }

    }
}
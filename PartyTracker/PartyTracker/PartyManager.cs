using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyTracker
{
    public class PartyManager
    {
        public string PartyNotes { get; set; }
        public List<Player> Players { get; }

        public PartyManager()
        {
            PartyNotes = "";
            Players = new List<Player>();
        }
    }
}

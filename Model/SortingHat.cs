using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordelingsHatten.Model
{
    /// <summary>
    /// This class is responsible for giving out the faction the student belongs to.
    /// </summary>
    internal class SortingHat
    {
        public enum Factions
        {
            Gryffindor = 1,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        }
        public Factions GetFaction(byte factionId)
        {
            return (Factions)factionId;
        }
    }
}

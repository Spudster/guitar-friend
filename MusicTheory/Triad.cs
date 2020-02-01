using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Triad
    { 
        public List<PositionDefinition> Major { get; set; }
        public List<PositionDefinition> Minor { get; set; }
        public List<PositionDefinition> Diminished { get; set; }
        public Triad(Scale scale)
        {

            Major = new List<PositionDefinition>
            {
                new PositionDefinition(1),
                new PositionDefinition(3),
                new PositionDefinition(5),
            };
            Minor = new List<PositionDefinition>
            {
                new PositionDefinition(1),
                new PositionDefinition(3, "b"),
                new PositionDefinition(5),
            };
            Diminished = new List<PositionDefinition>
            {
                new PositionDefinition(1),
                new PositionDefinition(3,"b"),
                new PositionDefinition(5,"b"),
            };
        }
    }

    public class PositionDefinition
    {
        public int PositionValue { get; set; }
        public string Modifier { get; set; }

        public PositionDefinition(int positionValue, string mod = null)
        {
            PositionValue = positionValue;
            Modifier = mod;
        }
    }
}

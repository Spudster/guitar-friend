using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Note
    {
        public List<string> LetterName { get; set; }
        public int PositionIndex { get; set; }

        public Note()
        {

            LetterName = new List<string>();

        }
    }
}

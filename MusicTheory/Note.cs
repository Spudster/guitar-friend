using System.Collections.Generic;

namespace MusicTheory
{
    public class Note
    {
        public List<string> LetterName { get; set; }
        public List<Note> ScaleNotes { get; set; }
        public int PositionIndex { get; set; }
        public int ScalePosition { get; set; }

        public Note()
        {
            ScaleNotes = new List<Note>();
            LetterName = new List<string>();
        }

        public Note(Note input)
        {
            LetterName = new List<string>();
            LetterName = input.LetterName;
            PositionIndex = input.PositionIndex;

        }
    }
}

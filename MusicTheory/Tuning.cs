using System.Collections.Generic;

namespace MusicTheory
{
    public class Tuning
    {
        public List<GuitarString> GuitarTuning { get; set; }
        public NoteMap MainNoteMap { get; set; }
        public string TuningName { get; set; }
        public Tuning(int fretboardSize, string tuningName = "Standard")
        {
            TuningName = tuningName;
            GuitarTuning = new List<GuitarString>();
            MainNoteMap = new NoteMap();
            MainNoteMap.GenerateMainNoteMap();
            DefaultStandardTuning(fretboardSize);
        }

        public void DefaultStandardTuning(int fretboardSize)
        {
            GuitarTuning.Add(new GuitarString
            ("E", 1,fretboardSize));

            GuitarTuning.Add(new GuitarString
            ("B", 2, fretboardSize));

            GuitarTuning.Add(new GuitarString
            ("G", 3, fretboardSize));

            GuitarTuning.Add(new GuitarString
            ("D", 4, fretboardSize));

            GuitarTuning.Add(new GuitarString
            ("A", 5, fretboardSize));

            GuitarTuning.Add(new GuitarString
            ("E", 6, fretboardSize));
        }
    }

}

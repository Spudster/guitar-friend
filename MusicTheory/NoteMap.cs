using System.Collections.Generic;

namespace MusicTheory
{
    public class NoteMap
    {
        public  List<Note> MainNoteMap { get; set; }

        public NoteMap()
        {
            MainNoteMap = new List<Note>();
        }
        public void GenerateMainNoteMap()
        {

            MainNoteMap.Add(new Note()
            {
                LetterName = new List<string> { "A" },
                PositionIndex = 1         
            });

            MainNoteMap.Add(new Note()
            {
                LetterName = new List<string> { "A#", "Bb" },
                PositionIndex = 2
            });

            MainNoteMap.Add(new Note()
            {
                LetterName = new List<string> { "B" },
                PositionIndex = 3
            });

            MainNoteMap.Add(new Note()
            {
                LetterName = new List<string> { "C" },
                PositionIndex = 4
            });

            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "C#", "Db" },
                PositionIndex = 5
            });

            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "D" },
                PositionIndex = 6
            });

            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "D#", "Eb" },
                PositionIndex = 7

            });

            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "E" },
                PositionIndex = 8
            });


            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "F" },
                PositionIndex = 9

            });

            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "F#", "Gb" },
                PositionIndex = 10

            });

            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "G" },
                PositionIndex = 11

            });

            MainNoteMap.Add(new Note()
            {

                LetterName = new List<string> { "G#", "Ab" },
                PositionIndex = 12

            });
        }
    }
}

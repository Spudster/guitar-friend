using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicTheory
{
    public class GuitarString
    {
        public int StringNumber { get; set; }
        public string RootNote { get; set; }
        public List<Note> NotesInString { get; set; }
        public NoteMap MainNoteMap { get; set; }
        public int FretBoardSize { get; set; }


        public GuitarString(string rootNote, int stringNumber, int fretBoardSize)
        {
            NotesInString = new List<Note>();
            RootNote = rootNote;
            FretBoardSize = fretBoardSize;
            StringNumber = stringNumber;
            MainNoteMap = new NoteMap();
            MainNoteMap.GenerateMainNoteMap();
            CreateNotesInString();
        }

        private void CreateNotesInString()
        {
            var rootIndex = -1;
            var rootNote = MainNoteMap.MainNoteMap.FirstOrDefault(_ => _.LetterName.Contains(RootNote));
            if (rootNote == null) throw new Exception("Root Note Not Found");
            rootIndex = rootNote.PositionIndex - 1;
            if (rootIndex == -1) throw new Exception("Invalid Root Note");
            NotesInString.Add(MainNoteMap.MainNoteMap[rootIndex]); //open note

            for (var i = 0; i < FretBoardSize; i++)
            {
                var scaleNoteIndex = (rootIndex + 1) % MainNoteMap.MainNoteMap.Count;
                rootIndex = scaleNoteIndex;
                NotesInString.Add(MainNoteMap.MainNoteMap[scaleNoteIndex]);
            }
        }

    }
}

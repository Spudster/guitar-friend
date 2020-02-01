using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace MusicTheory
{
    public class Scale
    {
        public string ScaleName { get; set; }
        public ScaleNames ScaleNameEnum { get; set; }
        public string RootNote { get; set; }
        public List<Step> Formula { get; set; }
        public List<Note> ScaleNotes { get; set; }
        public List<List<Note>> TuningScales { get; set; }
        private NoteMap MainNoteMap { get; set; }


        public Scale(string rootNote, ScaleNames scaleName)
        {
            MainNoteMap = new NoteMap();
            MainNoteMap.GenerateMainNoteMap();
            Formula = new List<Step>();
            ScaleNotes = new List<Note>();
            TuningScales = new List<List<Note>>();
            RootNote = rootNote;
            ScaleNameEnum = scaleName;
            ScaleName = scaleName.ToString();
            GenerateDefaultFormulaFromList();
            RootNote = rootNote;
            GenerateScaleNotes();
            GenerateScaleForEachScaleNote();
        }

        public Scale(List<Step> formula, string rootNote)
        {
            MainNoteMap = new NoteMap();
            MainNoteMap.GenerateMainNoteMap();
            ScaleNotes = new List<Note>();
            TuningScales = new List<List<Note>>();
            Formula = formula;
            RootNote = rootNote;
            GenerateDefaultFormula();
            RootNote = rootNote;
            GenerateScaleNotes();
            GenerateScaleForEachScaleNote();
        }

        private void GenerateDefaultFormula()
        {
        }

        private void GenerateDefaultFormulaFromList()
        {
            switch (ScaleNameEnum)
            {
                case  ScaleNames.Major:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    break;
                case ScaleNames.Blues:
                   
                    Formula.Add(new Step("wh"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("wh"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.NaturalMinor:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.MinorPentatonic:
                   
                    Formula.Add(new Step("wh"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("wh"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.MajorPentatonic:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("wh"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("wh"));
                    break;
                case ScaleNames.HarmonicMinor:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("wh"));
                    Formula.Add(new Step("h"));
                    break;
                case ScaleNames.MelodicMinor:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    break;
                case ScaleNames.Ionian:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    break;
                case ScaleNames.Dorian:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.Phrygian:
                   
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.Lydian:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    break;
                case ScaleNames.Mixolydian:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.Aeolian:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.Locrian:
                   
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.WholeTone:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("w"));
                    break;
                case ScaleNames.WholeHalfDiminished:
                   
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    break;
                case ScaleNames.HalfWholeDiminished:
                   
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    Formula.Add(new Step("h"));
                    Formula.Add(new Step("w"));
                    break;
            }
        }

        private void GenerateScaleNotes()
        {
            var rootNote = MainNoteMap.MainNoteMap.FirstOrDefault(_ => _.LetterName.Contains(RootNote));
            if (rootNote == null) throw new Exception("Root Note Not Found");
            var rootIndex = rootNote.PositionIndex - 1;
            if (rootIndex == -1) throw new Exception("Invalid Root Note");
            var rootNoteToAdd = new Note(MainNoteMap.MainNoteMap[rootIndex]) {ScalePosition = 1};
            ScaleNotes.Add(rootNoteToAdd);
            var startPositionForLoop = 2;

            for (var i = 0; i < Formula.Count; i++)
            {
                var step = Formula[i];
                var scaleNoteIndex = (rootIndex + step.GetValueFromStepLetter()) % MainNoteMap.MainNoteMap.Count;
                rootIndex = scaleNoteIndex;
                var noteToAdd = MainNoteMap.MainNoteMap[scaleNoteIndex];
                noteToAdd.ScalePosition = (startPositionForLoop);
                ScaleNotes.Add(noteToAdd);
                startPositionForLoop++;
            }
            PrintScale();
        }
        private void GenerateScaleForEachScaleNote()
        {
            foreach (var scaleNote in ScaleNotes)
            {
                scaleNote.ScaleNotes = new List<Note>();
                var rootNote = MainNoteMap.MainNoteMap.FirstOrDefault(_ => _.LetterName.Contains(scaleNote.LetterName.FirstOrDefault()));
                if (rootNote == null) throw new Exception("Root Note Not Found");
                var rootIndex = rootNote.PositionIndex - 1;
                if (rootIndex == -1) throw new Exception("Invalid Root Note");
                var rootNoteToAdd = new Note(MainNoteMap.MainNoteMap[rootIndex]) {ScalePosition = 1};
                scaleNote.ScaleNotes.Add(rootNoteToAdd);
                var startPositionForLoop = 2;

                for (var i = 0; i < Formula.Count; i++)
                {
                    var step = Formula[i];
                    var scaleNoteIndex = (rootIndex + step.GetValueFromStepLetter()) % MainNoteMap.MainNoteMap.Count;
                    rootIndex = scaleNoteIndex;
                    var noteToAdd = MainNoteMap.MainNoteMap[scaleNoteIndex];
                    noteToAdd.ScalePosition = (startPositionForLoop);
                    scaleNote.ScaleNotes.Add(noteToAdd);
                    startPositionForLoop++;
                }
            }
        }

        private void GenerateScaleForEachString(Tuning selectedTuning)
        {
            foreach (var guitarString in selectedTuning.GuitarTuning)
            {
                var stringScale = new List<Note>();
                var rootNote = MainNoteMap.MainNoteMap.FirstOrDefault(_ => _.LetterName.Contains(guitarString.RootNote));
                if (rootNote == null) throw new Exception("Root Note Not Found");
                var rootIndex = rootNote.PositionIndex - 1;
                if (rootIndex == -1) throw new Exception("Invalid Root Note");
                var rootNoteToAdd = new Note(MainNoteMap.MainNoteMap[rootIndex]) { ScalePosition = 1 };
                stringScale.Add(rootNoteToAdd);
                var startPositionForLoop = 2;

                for (var i = 0; i < Formula.Count; i++) //fretboard gotta repeat
                {
                    var step = Formula[i];
                    var scaleNoteIndex = (rootIndex + step.GetValueFromStepLetter()) % MainNoteMap.MainNoteMap.Count;
                    rootIndex = scaleNoteIndex;
                    var noteToAdd = MainNoteMap.MainNoteMap[scaleNoteIndex];
                    noteToAdd.ScalePosition = (startPositionForLoop);
                    stringScale.Add(noteToAdd);
                    startPositionForLoop++;
                }
            }
        }
        public void PrintScale()
        {
            Console.WriteLine($"######### {ScaleName}  ##########");

            foreach (var note in ScaleNotes)
            {
                Console.Write(note.ScalePosition + " ");
                foreach (var letterName in note.LetterName)
                {
                    Console.Write(letterName + " ");
                }
                Console.WriteLine();

            }
        }
        public void PrintMainMap()
        {
            var p = 1;
            Console.WriteLine("######################################");
            foreach (var note in MainNoteMap.MainNoteMap)
            {
                Console.Write(p + " ");
                foreach (var letterName in note.LetterName)
                {
                    Console.Write(letterName + " ");
                }

                p++;
                Console.WriteLine();

            }
        }
    }
}

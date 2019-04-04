using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Scale
    {
        public string ScaleName { get; set; }
        public string RootNote { get; set; }
        public List<Step> Formula { get; set; }
        public List<Note> ScaleNotes { get; set; }
        private List<Note> MainNoteMap { get; set; }
        private int _rootIndex = -1;

        public Scale(string rootNote)
        {
            MainNoteMap = new List<Note>();
            Formula = new List<Step>();
            ScaleNotes = new List<Note>();

            GenerateMainNoteMap();
            RootNote = rootNote;
            GenerateDefaultFormula();
            RootNote = rootNote;
            GenerateScaleNotes();
        }

        public Scale(List<Step> formula, string rootNote)
        {
            MainNoteMap = new List<Note>();
            ScaleNotes = new List<Note>();
            Formula = formula;

            GenerateMainNoteMap();
            RootNote = rootNote;
            GenerateDefaultFormula();
            RootNote = rootNote;
            GenerateScaleNotes();
        }

        private void GenerateDefaultFormula()
        {
            //ScaleName = "Major Scale";
            //Formula.Add(new Step("w"));
            //Formula.Add(new Step("w"));
            //Formula.Add(new Step("h"));
            //Formula.Add(new Step("w"));
            //Formula.Add(new Step("w"));
            //Formula.Add(new Step("w"));
            //Formula.Add(new Step("h"));

            ScaleName = "Blues Scale";
            Formula.Add(new Step("wh"));
            Formula.Add(new Step("w"));
            Formula.Add(new Step("h"));
            Formula.Add(new Step("h"));
            Formula.Add(new Step("wh"));
            Formula.Add(new Step("w"));
        }

        private void GenerateScaleNotes()
        {
            var rootNote = MainNoteMap.FirstOrDefault(_ => _.LetterName.Contains(RootNote));
            if (rootNote == null) throw new Exception("Root Note Not Found");
            _rootIndex = rootNote.PositionIndex - 1;
            if (_rootIndex == -1) throw new Exception("Invalid Root Note");
            ScaleNotes.Add(MainNoteMap[_rootIndex]);

            for (var i = 0; i < Formula.Count; i++)
            {
                var step = Formula[i];
                var scaleNoteIndex = (_rootIndex + step.GetValueFromStepLetter()) % MainNoteMap.Count;
                _rootIndex = scaleNoteIndex;
            
                ScaleNotes.Add(MainNoteMap[scaleNoteIndex]);
            }

            PrintScale();
        }

        public void PrintScale()
        {
            Console.WriteLine($"######### {ScaleName}  ##########");

            foreach (var note in ScaleNotes)
            {
                Console.Write(note.PositionIndex + " ");
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
            foreach (var note in MainNoteMap)
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

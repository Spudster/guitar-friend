using System;
using System.Linq;

namespace MusicTheory
{
    public class VirtualGuitarFretBoard
    {
        public Tuning GuitarTuning { get; set; }
        public int FretBoardSize { get; set; }
        public Scale SelectedScale { get; set; }

    public VirtualGuitarFretBoard(Scale selectedScale, int fretBoardSize = 24)
        {
            FretBoardSize = fretBoardSize;
            SelectedScale = selectedScale;
            GuitarTuning = new Tuning(FretBoardSize);
        }
        public VirtualGuitarFretBoard(Tuning guitarTuning, Scale selectedScale, int fretBoardSize = 24)
        {
            FretBoardSize = fretBoardSize;
            SelectedScale = selectedScale;
            GuitarTuning = guitarTuning;
        }
        public void  PrintFretBoard()
        {
            Console.WriteLine($"Tuning: {GuitarTuning.TuningName}");
            for (var i = 0; i < GuitarTuning.GuitarTuning.Count; i++)
            {
                var guitarString = GuitarTuning.GuitarTuning[i];
                if (i == 0)
                {
                    Console.Write(" ");
                    for (var n = 0; n < FretBoardSize; n++)
                    {
                        if (n > 10)
                        {
                            Console.Write($"{n}   ");
                        }
                        else
                        {
                            Console.Write($" {n}   ");
                        }

                    }
                    Console.WriteLine();
                }

                Console.Write($"{guitarString.StringNumber} ");
                for (var j = 0; j < guitarString.FretBoardSize; j++)
                {
                    if (guitarString.NotesInString[j].LetterName.FirstOrDefault().Length > 1)
                    {
                        Console.Write($"{guitarString.NotesInString[j].LetterName.FirstOrDefault()} | ");
                    }
                    else
                    {
                        Console.Write($"{guitarString.NotesInString[j].LetterName.FirstOrDefault()}  | ");
                    }
                }
                Console.WriteLine();
            }   
        }
    }
}

using System;

namespace MusicTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            var scale = new Scale("C", ScaleNames.Blues);
            var vFb = new VirtualGuitarFretBoard(scale);
            vFb.PrintFretBoard();
            Console.ReadLine();
        }
    }
}

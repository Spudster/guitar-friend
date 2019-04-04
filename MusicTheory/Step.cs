using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Step
    {
        private int Half = 1;
        private int Whole = 2;
        private int WholeHalf = 3;

        public string StepLetter { get; set; }

        public Step(string stepLetter)
        {
            if (stepLetter.ToLower() == "h" || stepLetter.ToLower() == "w" || stepLetter.ToLower() == "wh")
            StepLetter = stepLetter;
        }
        public int GetValueFromStepLetter()
        {
            switch (StepLetter.ToLower())
            {
                case "h":
                    return Half;
                case "w":
                    return Whole;
                case "wh":
                    return WholeHalf;
                default:
                    return -1 ;
            }
        }
    }

}

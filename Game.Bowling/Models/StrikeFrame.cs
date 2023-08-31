using Game.Bowling.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Bowling.Models
{
    internal class StrikeFrame : IFrame
    {
        public List<Roll> Rolls { get; set; }

        public int CalculateBonus(List<IFrame> frames, int[] rolls)
        {
            throw new NotImplementedException();
        }

        public int CalculateScore(List<IFrame> frames, int[] rolls)
        {
            throw new NotImplementedException();
        }

        public bool GetFrameType(List<int> rolls)
        {
            if (rolls.First() == ApplicationConstants.NUMBER_OF_PINS)
                return true;
            else return false;
        }
    }
}

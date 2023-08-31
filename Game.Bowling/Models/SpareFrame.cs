using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Bowling.Models
{
    internal class SpareFrame : IFrame
    {
        public List<Roll> Rolls { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            throw new NotImplementedException();
        }
    }
}

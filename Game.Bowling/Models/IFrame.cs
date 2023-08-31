using Game.Bowling.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Bowling.Models
{
    public interface IFrame
    {
        List<Roll> Rolls { get; set; }
       
        int CalculateScore(List<IFrame> frames, int[] rolls);
        bool GetFrameType(List<int> rolls);

        int CalculateBonus(List<IFrame> frames, int[] rolls);
    }
}

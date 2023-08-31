using Game.Bowling.Constants;
using Game.Bowling.Factory;
using Game.Bowling.Models;
using Game.Bowling.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Bowling
{
    public interface IBowlingGame
    {
        int CalculateTotalScore(int[] rolls);
    }
    public class BowlingGame : IBowlingGame
    {
        private List<IFrame> frames;

        public int CalculateTotalScore(int[] rolls)
        {
            frames = new FrameFactory().CreateFrames(rolls);
            int totalScore = 0;
            foreach (IFrame frame in frames)
            {
                totalScore += frame.CalculateScore(frames, rolls);
            }
            return totalScore;
               
        }
        
    }
}

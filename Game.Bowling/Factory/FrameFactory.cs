using Game.Bowling.Constants;
using Game.Bowling.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Bowling.Factory
{
    internal class FrameFactory
    {
        //This will create frames for game
        public List<IFrame> CreateFrames(int[] rolls)
        {
            List<IFrame> frames = new List<IFrame>();

            for(int i = 0; i < ApplicationConstants.NUMBER_OF_FRAMES; i = i+2)
            {
                var firstRollScrore = rolls[i];
                var secondRollScore = rolls[i + 1];

                if (firstRollScrore == ApplicationConstants.NUMBER_OF_PINS)
                    frames.Add(new StrikeFrame() { Rolls = new List<Roll>() { new Roll() { Score = firstRollScrore } } });
                else
                {
                    if (firstRollScrore + secondRollScore == ApplicationConstants.NUMBER_OF_PINS)
                        frames.Add(new StrikeFrame() { });
                }
                
            }
            return frames;
        }
    }
}

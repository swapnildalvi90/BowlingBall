using Game.Bowling.Constants;
using Game.Bowling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Bowling.Services
{
    public interface IScoreCalculationService
    {
        int CalculateTotalScore(List<IFrame> frames);

    }
    public class ScoreCalculationService : IScoreCalculationService
    {
        private int _totalScore;

        public int CalculateTotalScore(List<IFrame> frames)
        {
            //Need to change this logic and move it to frame specific class
            
            
            /*for (int i = 0; i < frames.Count; i++)
            {
                var currentFrame = frames[i];
                //check current frame is not last frame
                if (i < frames.Count - 1)
                {
                    var bonusScore = 0;
                    if (currentFrame.HasStriked)
                    {
                        _totalScore = _totalScore + ApplicationConstants.NUMBER_OF_PINS;
                        _totalScore = _totalScore + GetBonus(i, frames, bonusScore, 2); ;
                    }
                    else if (currentFrame.HasSpare)
                    {
                        _totalScore = _totalScore + ApplicationConstants.NUMBER_OF_PINS;
                        _totalScore = _totalScore + GetBonus(i, frames, bonusScore, 1);
                    }
                    else
                    {
                        _totalScore = _totalScore + currentFrame.Rolls.Sum(r => r.Score);
                    }
                }
                else // if current frame is last frame
                {
                    //in last frame just take sum of all rolls.
                    _totalScore = _totalScore + currentFrame.Rolls.Sum(r => r.Score);
                }
            }
            return _totalScore;*/

            return _totalScore;
        }

        private int GetBonus(int currentIndex, List<IFrame> frames, int bonusScore, int noOfRollsConsiderForBonus)
        {
            //Need to change this logic and move it to frame specific class


            //if (noOfRollsConsiderForBonus > 0)
            //{
            //    currentIndex++;
            //    var frame = frames[currentIndex];
            //    if (frame.HasStriked)
            //    {
            //        bonusScore = bonusScore + ApplicationConstants.NUMBER_OF_PINS;
            //        noOfRollsConsiderForBonus--;
            //        if (noOfRollsConsiderForBonus != 0)
            //        {
            //            //check if current frame is second last one and has striked then iterate to next frame only once, as next frame is last frame.and use can upto 3 rolls in last frame.
            //            if (currentIndex < frames.Count - 1)
            //                return GetBonus(currentIndex, frames, bonusScore, noOfRollsConsiderForBonus);
            //            else
            //                return bonusScore + frame.Rolls.Skip(1).Take(1).FirstOrDefault().Score;
            //        }
            //        else
            //            return bonusScore;
            //    }
            //    else
            //    {
            //        return bonusScore = bonusScore + frame.Rolls.Skip(0).Take(noOfRollsConsiderForBonus).Sum(s => s.Score);
            //    }
            //}
            return bonusScore;
        }
    }
}

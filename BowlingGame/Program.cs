using Game.Bowling;
using Game.Bowling.Models;
using Game.Bowling.Services;
using System;
using System.Collections.Generic;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreCalculationService scoreCalculationService = new ScoreCalculationService();

            //var data = new List<Frame>
            //{
            //    new Frame{Rolls= new List<Roll>{ new Roll { Score =10} } },
            //     new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //     new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //     new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //    new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //    new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //    new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //     new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //    new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
            //    new Frame{Rolls= new List<Roll>{ new Roll { Score =10},new Roll { Score =6},new Roll { Score =4} }},
            //};
            //var result = scoreCalculationService.CalculateTotalScore(data);
            //Console.WriteLine($"Total score - {result}");
            //
            int[] rolls = new int[21] { 10, 0, 9, 1, 5, 5, 7, 2, 10, 0, 10, 0, 10, 0, 9, 0, 8, 2, 9, 1, 10 };
            Game.Bowling.IBowlingGame game = new Game.Bowling.BowlingGame();
            var finalScore = game.CalculateTotalScore(rolls);

        }
    }
}

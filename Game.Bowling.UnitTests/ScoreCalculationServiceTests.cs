using Game.Bowling.Models;
using Game.Bowling.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace Game.Bowling.UnitTests
{
    public class ScoreCalculationServiceTests
    {
       
        public static IEnumerable<object[]> GetData()
        {
            var allData = new List<object[]>
        {
            new object[] { ScoreCalculationServiceTestData.GetAllStrikedFrames() , 300 },
            new object[] {  ScoreCalculationServiceTestData.GetAllFailedFrames() , 0 },
            new object[] {  ScoreCalculationServiceTestData.GetAllSpareFrames() , 150 },
            new object[] {  ScoreCalculationServiceTestData.GetFramesWithSomeStrikedAndSomeSpared() , 187 },
            new object[] {  ScoreCalculationServiceTestData.GetFramesWithoutStrikedAndSPare() , 83 }

        };

            return allData;
        }
        [Theory]
        [MemberData(nameof(GetData))]
        public void ShouldReturnCorrectScore_ForGivenFrames(List<IFrame> frames, int expected)
        {
            //var frames = testFixture.GetAllStrikedFrames();
            //int expected = 300;

            var scoreService = new ScoreCalculationService();
            var actual = scoreService.CalculateTotalScore(frames);

            Assert.Equal(expected, actual);
        }
       
    }

    

    public class ScoreCalculationServiceTestData
    {
        public static List<IFrame> GetAllFailedFrames()
        {
            var frames = new List<IFrame>();
            var failedRoll = new Roll { Score = 0 };
            for (int i = 0; i < 10; i++)
            {
                frames.Add(new Frame
                {
                    Rolls = new List<Roll> { failedRoll, failedRoll }

                });
            }
            return frames;
        }

        public static List<Frame> GetAllStrikedFrames()
        {
            var frames = new List<Frame>();
            var strikedRoll = new Roll { Score = 10 };

            for (int i = 0; i < 9; i++)
            {
                frames.Add(new Frame
                {
                    Rolls = new List<Roll> { strikedRoll, strikedRoll }

                });
            }
            //last frame
            frames.Add(new Frame
            {
                Rolls = new List<Roll> { strikedRoll, strikedRoll, strikedRoll }
            });
            return frames;
        }

        public static List<Frame> GetAllSpareFrames()
        {
            var frames = new List<Frame>();
            var strikedRoll = new Roll { Score = 5 };

            for (int i = 0; i < 9; i++)
            {
                frames.Add(new Frame
                {
                    Rolls = new List<Roll> { strikedRoll, strikedRoll }

                });
            }
            //last frame
            frames.Add(new Frame
            {
                Rolls = new List<Roll> { strikedRoll, strikedRoll, strikedRoll }
            });
            return frames;
        }

        public static List<Frame> GetFramesWithSomeStrikedAndSomeSpared()
        {
            var frames = new List<Frame>
            {
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} } },
                new Frame{Rolls= new List<Roll>{ new Roll { Score =9}, new Roll { Score = 1 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =5}, new Roll { Score = 5 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =7}, new Roll { Score = 2 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =10} }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =9}, new Roll { Score = 0 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =8}, new Roll { Score = 2 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =9},new Roll { Score =1},new Roll { Score = 10 } }}
            };

            return frames;
        }

        public static List<Frame> GetFramesWithoutStrikedAndSPare()
        {
            var frames = new List<Frame>
            {
                new Frame{Rolls= new List<Roll>{ new Roll { Score =4}, new Roll { Score = 2 } } },
                new Frame{Rolls= new List<Roll>{ new Roll { Score =8}, new Roll { Score = 1 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =4}, new Roll { Score = 5 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =7}, new Roll { Score = 2 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =7}, new Roll { Score = 2 }  }},
                new Frame{Rolls= new List<Roll>{new Roll { Score =7}, new Roll { Score = 2 }  }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =7}, new Roll { Score = 2 }  }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =9}, new Roll { Score = 0 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =6}, new Roll { Score = 2 } }},
                new Frame{Rolls= new List<Roll>{ new Roll { Score =5},new Roll { Score =1} }}
            };

            return frames;
        }

    }
}

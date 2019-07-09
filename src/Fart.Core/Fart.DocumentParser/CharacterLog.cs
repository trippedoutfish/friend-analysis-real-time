using System;
using System.Collections.Generic;
using System.Text;

namespace Fart.DocumentParser
{
    class CharacterLog
    {
        public int MapId { get; set; }
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public int EpochTime { get; set; }
        public int Level { get; set; }
        public int XpLeft { get; set; }
        public int XpMax { get; set; }
        public bool IsRested { get; set; }
        public int RestExpLeft { get; set; }
        public int MoneyInCopper { get; set; }
        public CharacterLog(int mapId, double xCoordinate, double yCoordinate, int epochTime, int level, int xpLeft, int xpMax, bool isRested, int restExpLeft, int moneyInCopper)
        {
            MapId = mapId;
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            EpochTime = epochTime;
            Level = level;
            XpLeft = xpLeft;
            XpMax = xpMax;
            IsRested = isRested;
            RestExpLeft = restExpLeft;
            MoneyInCopper = moneyInCopper;
        }
    }
}

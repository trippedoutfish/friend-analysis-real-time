using Fart.Common.Models.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fart.Common.Models.Player
{
    class CharacterPointInTime
    {
        public DateTime Time { get; private set; }
        public Zone Zone { get; private set; }
        public Tuple<int,int> Coordinates { get; private set; }
        public float Health { get; private set; }
        public float MaxHealth { get; private set; }
        public float Resource { get; private set; }
        public float MaxResource { get; private set; }
        public int Level { get; private set; }
        public long TimeThisLevel { get; private set; }
        public List<string> PartyMembers { get; private set; }
    }
}

using System;

namespace Fart.Web.Data
{
    public class PlayerCharacter
    {
        public string Name { get; set; }

        public string Race { get; set; }

        public string Class { get; set; }

        public int Level { get; set; }

        public int Experience { get; set; }

        public LocationData[] Locations { get; set; }

        public class LocationData
        {
            public string Zone { get; private set; }

            public int X { get; private set; }

            public int Y { get; private set; }
        }
    }
}

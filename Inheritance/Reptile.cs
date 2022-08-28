using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            LegCount = 0;
            LandSeaAir = "Land";
            Age = 1;
        }

        public string LiveBirth { get; set; }
        public int Weight { get; set; }

        public string Habitat { get; set; }
        public bool Venomous { get; set; }
    }
}

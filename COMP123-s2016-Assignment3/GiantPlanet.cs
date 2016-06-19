using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Assignment3
{
    public class GiantPlanet : Planets, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(string name, double diameter, double mass, string type)
        {
            throw new System.NotImplementedException();
        }
    }
}
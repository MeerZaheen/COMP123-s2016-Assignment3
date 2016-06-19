using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Assignment3
{
    public class TerrestrialPlanet : Planets, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
        {
            throw new System.NotImplementedException();
        }

        public void Habitable()
        {
            throw new System.NotImplementedException();
        }

        public void HasMoons()
        {
            throw new System.NotImplementedException();
        }
    }
}
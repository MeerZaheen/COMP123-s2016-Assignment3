using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Assignment3
{
    /**
    * <summary>
    * This class TerrestrialPlanet is a subclass of the Planets Abstract class. This class will also implement
    * both the IHasMoons and IHabitable interfaces 
    * </summary>
    *
    * @class TerrestrialPlanet
    * @extends Planet
    */
    public class TerrestrialPlanet : Planets, IHasMoons, IHabitable
    {

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++

        private bool _oxygen;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++

        /**<summary>
        * This is a property for our _oxygen field.
        * </summary>
        *
        * @property Type
        */
        public bool Oxygen
        {
            get
            {
                return this._oxygen;
            }
            set
            {
                this._oxygen = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This constructor method takes all parameters of the Planets base class as well as Oxygen
        * as a local variable and sets the related instance variable (_oxygen) to its value
        * </summary>
        *
        * @constructor TerrestrialPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {bool} oxygen
        */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
        : base(name, diameter, mass)
        {
            this.Oxygen = oxygen;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
         * This public method Habitable() will return true if the oxygen instance variable is set to true
         * </summary>
         *
         * @method oxygen
         * @returns {bool}
         */
        public bool Habitable()
        {
            if(Oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /** <summary>
         * This public method HasMoons() will return true if the MoonCount property is greater than zero
         * </summary>
         *
         * @method MoonCount
         * @returns {bool}
         */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
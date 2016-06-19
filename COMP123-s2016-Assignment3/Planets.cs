using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_s2016_Assignment3
{
    /** <summary>
     * This abstract class defines planets.
     * </summary>
     * 
     * @class Planets
     */
    public abstract class Planets
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++

        /**<summary>
        * This is a property for our _diameter field.
        * </summary>
        *
        * @property Diameters
        */
        public double Diameter
        {
            get
            {
                return this._diameter;
            }

        }

        /**<summary>
        * This is a property for our _mass field.
        * </summary>
        *
        * @property Mass
        */
        public double Mass
        {
            get
            {
                return this._mass;
            }

        }

        /**<summary>
        * This is a property for our _moonCount field.
        * </summary>
        *
        * @property MoonCount
        */
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }

        }

        /**<summary>
        * This is a property for our _name field.
        * </summary>
        *
        * @property Name
        */
        public string Name
        {
            get
            {
                return this._name;
            }

        }

        /**<summary>
        * This is a property for our _orbitalPeriod field.
        * </summary>
        *
        * @property Orbital Period
        */
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        /**<summary>
        * This is a property for our _ringCount field.
        * </summary>
        *
        * @property RingCount
        */
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        /**<summary>
        * This is a property for our _rotationPeriod field.
        * </summary>
        *
        * @property RotationalPeriod
        */
        public double RotationalPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++

        /** <summary>
        * This constructor takes name, diameter, and mass as parameters and passes them to the PRIVATE INSTANCE VARIABLES.
        * </summary>
        *
        * @constructor Planets
        * @params {string} name
        * @params {double} diameter
        * @params {double} mass
        */
        public Planets(string name, double diameter, double mass)
        {
            throw new System.NotImplementedException();
        }

        // PUBLIC METHODS

        /** <summary>
        * This method ToString outputs Name, Diameter, and Mass to the console
        * </summary>
        *
        * @method ToString
        * returns {string}
        */
        public override string ToString()
        {
            return String.Format("Name of Planet is: {0}\nDiameter of Planet is: {1}\nMass of Planet is: {2}", this.Name, this.Diameter, this.Mass);
        }

    }
}
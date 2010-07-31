using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public class Unit
    {
        public static Unit AddName(Unit unit, string name, string symbol,
                                   params string[] quantityNames)
        {
            unit._names.Add(new UnitName(name, symbol, quantityNames));
            return unit;
        }
            
        public static Unit operator /(int one, Unit unit)
        {
            if (one != 1)
            {
                throw new ArgumentException("Argument must be 1.", "one");
            }
            
            //TODO:
            return new Unit();
        }
        
        public static Unit operator *(Unit unitA, Unit unitB)
        {   
            //TODO: 
            return new Unit();
        }
        
        public static Unit operator /(Unit unitA, Unit unitB)
        {           
            //TODO:
            return new Unit();
        }
        
        public Unit Squared
        {
            get
            {
                //TODO:
                return new Unit();
            }
        }
        
        private readonly List<UnitName> _names = new List<UnitName>();            
        
        public ReadOnlyCollection<UnitName> Names
        {
            get { return _names.AsReadOnly(); }
        }
    }
}

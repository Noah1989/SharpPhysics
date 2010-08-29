using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public class Unit
    {
        private static readonly List<Unit> __cachedUnits = new List<Unit>();
    
        private static Unit GetCached(
            IEnumerable<KeyValuePair<BaseUnit,int>> exponents)
        {
            var found = __cachedUnits.FirstOrDefault(
                            unit =>
                            unit._baseUnitExponents.All(
                            exponent => exponents.Any(
                                        exponent1 => 
                                        exponent.Key == exponent1.Key)
                                        || exponent.Value == 0)
                            &&
                            exponents.All(
                            exponent => unit[exponent.Key] == exponent.Value));
            
            if (found != null)
                return found;
            
            var newUnit = new Unit();
            foreach (var exponent in exponents)
                newUnit[exponent.Key] = exponent.Value;
            
            return newUnit;
        }
    
        public static readonly Unit Dimensionless = new Unit();
        
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
            
            return Dimensionless / unit;
        }
        
        public static Unit operator *(Unit unitA, Unit unitB)
        {   
            return GetCached(unitA._baseUnitExponents.Keys.Concat(
                             unitB._baseUnitExponents.Keys)
                             .Distinct()
                             .Select(baseUnit => 
                                 new KeyValuePair<BaseUnit, int>(baseUnit,
                                 unitA[baseUnit] + unitB[baseUnit])));
        }
        
        public static Unit operator /(Unit unitA, Unit unitB)
        {           
            return GetCached(unitA._baseUnitExponents.Keys.Concat(
                             unitB._baseUnitExponents.Keys)
                             .Distinct()
                             .Select(baseUnit =>
                                 new KeyValuePair<BaseUnit, int>(baseUnit,
                                 unitA[baseUnit] - unitB[baseUnit])));
        }
        
        public Unit Squared
        {
            get
            {
                return GetCached(_baseUnitExponents.Keys.Select(baseUnit =>
                                     new KeyValuePair<BaseUnit, int>(baseUnit,
                                     _baseUnitExponents[baseUnit] * 2)));
            }
        }
        
        private readonly Dictionary<BaseUnit, int> _baseUnitExponents = 
            new Dictionary<BaseUnit, int>();
        
        private readonly List<UnitName> _names = new List<UnitName>(); 
                        
        protected Unit()
        {            
            __cachedUnits.Add(this);
        }
               
        public int this[BaseUnit baseUnit]
        {
            get
            {
                if (!_baseUnitExponents.ContainsKey(baseUnit))
                    return 0;
                    
                return _baseUnitExponents[baseUnit];
            }
            protected set
            {
                 if (!_baseUnitExponents.ContainsKey(baseUnit))
                    _baseUnitExponents.Add(baseUnit, value);
                    
                _baseUnitExponents[baseUnit] = value;
            }
        }                   
        
        public ReadOnlyCollection<UnitName> Names
        {
            get { return _names.AsReadOnly(); }
        }
        
        public override string ToString()
        {
            if (Names.Any())
                return Names.First().Symbol;
                
            return _baseUnitExponents
                   .Where(e => e.Value != 0)
                   .Aggregate("", 
                              (str, e) => 
                                  e.Value == 1
                                      ? string.Format("{0} * {1}",
                                                      str, e.Key)
                                      : string.Format("{0} * {1}^{2}",
                                                      str, e.Key, e.Value))
                                      
                   .Trim(new [] {' ', '*'});                                                        
        }
    }
}

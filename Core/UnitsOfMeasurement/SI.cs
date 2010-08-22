using System;
using System.Linq;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public static partial class SI
    {   
        public static bool TryParse(string unitName, out Unit result)
        {
            unitName = unitName.ToLower(); 
                   
            result = __allUnits.SingleOrDefault(
                         unit => unit.Names.Any(
                             name => unitName.Equals(name.Name,
                                                     StringComparison.Ordinal)
                                     ||
                                     unitName.Equals(name.Name + "s", 
                                                     StringComparison.Ordinal)
                                     ||
                                     unitName.Equals(name.Symbol, 
                                                     StringComparison.Ordinal)
                                     ));

            if (result == null)
                return false;
            
            return true;
        }
    
        public static Unit Parse(string unitName)
        {          
            Unit result;
            
            if (TryParse(unitName, out result))
                return result;

            throw new ArgumentException(
                String.Format("Could not parse unit name '{0}'.", unitName),
                              "unitName");
        }
    
        public static MeasuredValue Parse(double value, string unitName)
        {
            unitName = unitName.ToLower();
            
            Unit resultUnit;            
            if (TryParse(unitName, out resultUnit))
                return new MeasuredValue(value, resultUnit);
            
            var foundPrefix = __prefixes.Keys.SingleOrDefault(
                                  prefix => unitName.StartsWith(prefix));
                                  
            if (foundPrefix != null)          
            {
                var prefixValue = __prefixes[foundPrefix];            
                unitName = unitName.Substring(foundPrefix.Length);
            
                return new MeasuredValue(value * prefixValue, Parse(unitName));
            }
            
            throw new ArgumentException(
                String.Format("Could not parse unit name '{0}'.", unitName),
                              "unitName");
        }
    }
}

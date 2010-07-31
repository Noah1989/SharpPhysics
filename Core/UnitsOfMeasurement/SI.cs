using System;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public static partial class SI
    {        
        public static Unit Parse(string name)
        {
            
            
            throw new ArgumentException(
                String.Format("Could not parse unit name '{0}'.", name),
                "unitName");            
        }
    
        public static MeasuredValue Parse(double value, string unitName)
        {
            return new MeasuredValue(value, Parse(unitName));
        }
    }
}

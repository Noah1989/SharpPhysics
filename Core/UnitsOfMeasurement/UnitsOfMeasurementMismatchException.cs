using System;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public class UnitsOfMeasurementMismatchException 
        : InvalidOperationException
    {
        public UnitsOfMeasurementMismatchException(Unit unitA, Unit unitB)
            :base(string.Format("Units of measurement mismatch: {0} and {1}.",
                                unitA, unitB))
        {
        }        
    }
}

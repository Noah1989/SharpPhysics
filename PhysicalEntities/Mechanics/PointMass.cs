using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public class PointMass
    {
        public readonly MeasuredValue Mass;
        
        public PointMass(MeasuredValue mass)
        {
            Mass = mass.In(SI.Kilogram);
        }
    }
}

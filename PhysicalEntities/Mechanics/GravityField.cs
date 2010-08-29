using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public class GravityField
    {
        public readonly MeasuredVector3 Acceleration;
        
        public GravityField(MeasuredVector3 acceleration)
        {
            Acceleration = acceleration.In(SI.Metre / SI.Second.Squared);
        }
    }
}

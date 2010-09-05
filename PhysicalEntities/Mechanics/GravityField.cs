using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public class GravityField : IForceSource<IMass, IFrame>
    {
        private readonly MeasuredVector3 _acceleration;
        
        public MeasuredVector3 Acceleration
        {   
            get { return _acceleration; }
        }
        
        public GravityField(MeasuredVector3 acceleration)
        {
            _acceleration = acceleration.In(SI.Metre / SI.Second.Squared);
        }
        
        public MeasuredVector3 GetForce(IMass mass, IFrame frame)
        {
            return _acceleration * mass.Mass;
        }
    }
}

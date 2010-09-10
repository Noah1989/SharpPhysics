using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public class SimpleBodyFrame : EmptyFrame
    {
        private readonly MeasuredVector3 _location;
        private readonly MeasuredVector3 _velocity;
    
        public SimpleBodyFrame(MeasuredValue time, 
                               MeasuredVector3 location,
                               MeasuredVector3 velocity) : base(time)
        {
            _location = location.In(SI.Metre);
            _velocity = velocity.In(SI.Metre / SI.Second);       
        }
        
        public MeasuredVector3 Location
        {
            get { return _location; }
        }
        
        public MeasuredVector3 Velocity
        {
            get { return _velocity; }
        }        
    }
}

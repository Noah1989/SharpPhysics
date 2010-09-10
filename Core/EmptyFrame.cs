using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.Core
{
    public class EmptyFrame : IFrame
    {
        private readonly MeasuredValue _time;
    
        public EmptyFrame(MeasuredValue time)
        {
            _time = time.In(SI.Second);
        }
    
        public MeasuredValue Time
        {
            get { return _time; }
        }
    }
}

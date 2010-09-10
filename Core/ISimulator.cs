using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.Core
{
    public interface ISimulator<TFrame>
    {                       
        void Simulate(TFrame initialFrame, MeasuredValue time);
        TFrame GetFrame(MeasuredValue time);
    }
}

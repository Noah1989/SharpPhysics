using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.Core
{
    public abstract class SimulatedPhysical<TFrame> : IPhysical 
        where TFrame : IFrame
    {        
        public TFrame InitialFrame { get; set; }
        
        protected abstract ISimulator<TFrame> Simulator { get; }
           
        public void Simulate(MeasuredValue time)
        {
            Simulator.Simulate(InitialFrame, time);
        }
        
        public TFrame GetFrame(MeasuredValue time)
        {
            return Simulator.GetFrame(time);
        }
    }
}

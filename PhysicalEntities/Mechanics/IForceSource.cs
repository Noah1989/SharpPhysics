using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public interface IForceSource<in TTarget, in TFrame> 
        where TTarget : IPhysical<TFrame>
        where TFrame : IFrame
    {
        MeasuredVector3 GetForce(TTarget target, TFrame frame);        
    }
}

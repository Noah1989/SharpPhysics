using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public interface IMass : IPhysical<IFrame>
    {
        MeasuredValue Mass { get; }
    }
}

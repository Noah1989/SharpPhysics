using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public interface IMass : IPhysical
    {
        MeasuredValue Mass { get; }
    }
}

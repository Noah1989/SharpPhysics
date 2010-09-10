using System.Collections.Generic;
using System.Linq;
using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public class ForceAnchor<TOwner, TFrame> 
        where TOwner : IPhysical
        where TFrame : IFrame
    {
        private TOwner _owner;
        private List<IForceSource<TOwner, TFrame>> _sources;
    
        public ForceAnchor(TOwner owner)
        {
            _owner = owner;
            _sources = new List<IForceSource<TOwner, TFrame>>();
        }
    
        public MeasuredVector3 GetForce(TFrame frame)
        {
            return (from source in _sources
                    select source.GetForce(_owner, frame))
                   .Aggregate(Vector3.Zero .SI().Newton, (a, b) => a + b);
        }
        
        public void Connect(IForceSource<TOwner, TFrame> source)
        {
            _sources.Add(source);
        }
    }
}

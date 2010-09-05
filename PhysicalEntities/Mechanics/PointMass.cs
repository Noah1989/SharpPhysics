using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public class PointMass : PhysicalEntity<SimpleBodyFrame>, IMass
    {
        private MeasuredValue _mass;
        private ForceAnchor<PointMass, SimpleBodyFrame> _anchor;
        
        public MeasuredValue Mass
        {
            get { return _mass; }
        }
        
        public ForceAnchor<PointMass, SimpleBodyFrame> ForceAnchor
        {
            get { return _anchor; }
        }
        
        public PointMass(MeasuredValue mass)
        {
            _mass = mass.In(SI.Kilogram);
            _anchor = new ForceAnchor<PointMass, SimpleBodyFrame>(this);
        }
    }
}

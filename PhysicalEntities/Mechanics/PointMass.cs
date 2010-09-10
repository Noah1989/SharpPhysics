using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.PhysicalEntities.Mechanics
{
    public class PointMass : SimulatedPhysical<SimpleBodyFrame>, IMass
    {
        private MeasuredValue _mass;
        private ForceAnchor<PointMass, SimpleBodyFrame> _anchor;
        
        protected override ISimulator<SimpleBodyFrame> Simulator
        {
            get { throw new System.NotImplementedException(); }
        }
        
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

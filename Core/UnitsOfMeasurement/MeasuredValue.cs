using System;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public struct MeasuredValue : IComparable, IComparable<MeasuredValue>
    {
        private readonly double _value;
        private readonly Unit _unit;
        
        public double Value { get { return _value; } }
        public Unit Unit { get { return _unit; } }
        
        public MeasuredValue(double value, Unit unit)
        {
            _value = value;
            _unit = unit;
        }
    
        public static MeasuredValue operator *(MeasuredValue valueA, 
                                               MeasuredValue valueB)
        {
            return new MeasuredValue(valueA._value * valueB._value,
                                     valueA._unit  * valueB._unit);
        }
        
        public static MeasuredValue operator *(MeasuredValue value, 
                                               Unit unit)
        {
            return value * new MeasuredValue(1, unit);
        }
        
        public static MeasuredValue operator /(MeasuredValue valueA, 
                                               MeasuredValue valueB)
        {
            return new MeasuredValue(valueA._value / valueB._value,
                                     valueA._unit  / valueB._unit);
        }
        
        public static MeasuredValue operator /(MeasuredValue value, 
                                               Unit unit)
        {
            return value / new MeasuredValue(1, unit);
        }
                        
        public static MeasuredValue operator +(MeasuredValue valueA, 
                                               MeasuredValue valueB)
        {
            CheckUnitsMatch(valueA._unit, valueB._unit);        
            return new MeasuredValue(valueA._value + valueB._value,
                                     valueA._unit);
        }
        
        public static MeasuredValue operator -(MeasuredValue valueA, 
                                               MeasuredValue valueB)
        {
            CheckUnitsMatch(valueA._unit, valueB._unit);     
            return new MeasuredValue(valueA._value - valueB._value,
                                     valueA._unit);
        }
        
        private static void CheckUnitsMatch(Unit unitA, Unit unitB)
        {
            if(unitA != unitB)
                throw new UnitsOfMeasurementMismatchException(unitA, unitB);
        }
        
        public MeasuredValue In(Unit unit)
        {
            CheckUnitsMatch(_unit, unit);
            return this;
        }
               
        public int CompareTo(MeasuredValue other)
        {
            throw new NotImplementedException();
        }
        
        public int CompareTo(object other)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            return String.Format("{0} {1}", _value, _unit);
        }
    }
}

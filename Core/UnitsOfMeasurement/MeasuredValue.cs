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
            throw new NotImplementedException();
        }
        
        public static MeasuredValue operator /(MeasuredValue valueA, 
                                               MeasuredValue valueB)
        {
            throw new NotImplementedException();
        }
        
        public static MeasuredValue operator +(MeasuredValue valueA, 
                                               MeasuredValue valueB)
        {
            throw new NotImplementedException();
        }
        
        public static MeasuredValue operator -(MeasuredValue valueA, 
                                               MeasuredValue valueB)
        {
            throw new NotImplementedException();
        }
        
        public static implicit operator double(MeasuredValue value)
        {
            throw new NotImplementedException();
        }
        
        public int CompareTo(MeasuredValue other)
        {
            throw new NotImplementedException();
        }
        
        public int CompareTo(object other)
        {
            throw new NotImplementedException();
        }
    }
}

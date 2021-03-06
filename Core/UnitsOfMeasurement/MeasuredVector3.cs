﻿using System;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public struct MeasuredVector3
    {
        private readonly Vector3 _value;
        private readonly Unit _unit;
        
        public Vector3 Value { get { return _value; } }
        public Unit Unit { get { return _unit; } }
        
        public MeasuredVector3(Vector3 vector, Unit unit)
        {
            _value = vector;
            _unit = unit;
        }
    
        public static MeasuredVector3 operator *(MeasuredVector3 vectorA, 
                                                 MeasuredVector3 vectorB)
        {
            return new MeasuredVector3(vectorA._value * vectorB._value,
                                       vectorA._unit  * vectorB._unit);
        }

        public static MeasuredVector3 operator *(MeasuredVector3 vector, 
                                                 MeasuredValue value)
        {
            return new MeasuredVector3(vector._value * value.Value,
                                       vector._unit  * value.Unit);
        }
        
        public static MeasuredVector3 operator *(MeasuredVector3 vector, 
                                                 Unit unit)
        {
            return vector * new MeasuredValue(1, unit);
        }

        public static MeasuredVector3 operator /(MeasuredVector3 vector, 
                                                 MeasuredValue value)
        {
            return new MeasuredVector3(vector._value / value.Value,
                                       vector._unit  / value.Unit);
        }
               
        public static MeasuredVector3 operator /(MeasuredVector3 vector, 
                                                 Unit unit)
        {
            return vector / new MeasuredValue(1, unit);
        }
                        
        public static MeasuredVector3 operator +(MeasuredVector3 vectorA, 
                                                 MeasuredVector3 vectorB)
        {
            CheckUnitsMatch(vectorA._unit, vectorB._unit);        
            return new MeasuredVector3(vectorA._value + vectorB._value,
                                       vectorA._unit);
        }
        
        public static MeasuredVector3 operator -(MeasuredVector3 vectorA, 
                                                 MeasuredVector3 vectorB)
        {
            CheckUnitsMatch(vectorA._unit, vectorB._unit);     
            return new MeasuredVector3(vectorA._value - vectorB._value,
                                       vectorA._unit);
        }
        
        private static void CheckUnitsMatch(Unit unitA, Unit unitB)
        {
            if(unitA != unitB)
                throw new UnitsOfMeasurementMismatchException(unitA, unitB);
        }
        
        public MeasuredVector3 In(Unit unit)
        {
            CheckUnitsMatch(_unit, unit);
            return this;
        }
        
        public MeasuredValue X
        {
            get { return new MeasuredValue(_value.X, _unit); }
        }
        
        public MeasuredValue Y
        {
            get { return new MeasuredValue(_value.Y, _unit); }
        }
        
        public MeasuredValue Z
        {
            get { return new MeasuredValue(_value.Z, _unit); }
        }
        
        public MeasuredValue Norm
        {
            get {  return new MeasuredValue(_value.Norm, _unit); }
        }
        
        public override string ToString()
        {
            return String.Format("{0} {1}", _value, _unit);
        }
    }
}

using System;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public static class SiUnitExtensions
    {
        public static SiUnitDoubleExpression SI(this double value)
        {
            return new SiUnitDoubleExpression(value);
        }
        
        public sealed class SiUnitDoubleExpression
        {
            private readonly double _value;
        
            internal SiUnitDoubleExpression(double value)
            {
                _value = value;
            }            
            
            public MeasuredValue Metre
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Metre); }
            }

            public MeasuredValue Kilogram
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Kilogram); }
            }

            public MeasuredValue Second
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Second); }
            }

            public MeasuredValue Ampere
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Ampere); }
            }

            public MeasuredValue Kelvin
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Kelvin); }
            }

            public MeasuredValue Mole
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Mole); }
            }

            public MeasuredValue Candela
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Candela); }
            }

            public MeasuredValue Hertz
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Hertz); }
            }

            public MeasuredValue Newton
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Newton); }
            }

            public MeasuredValue Pascal
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Pascal); }
            }

            public MeasuredValue Joule
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Joule); }
            }

            public MeasuredValue Watt
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Watt); }
            }

            public MeasuredValue Coulomb
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Coulomb); }
            }

            public MeasuredValue Volt
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Volt); }
            }

            public MeasuredValue Farad
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Farad); }
            }
        
            public MeasuredValue Ohm
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Ohm); }
            }

            public MeasuredValue Siemens
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Siemens); }
            }

            public MeasuredValue Weber
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Weber); }
            }

            public MeasuredValue Tesla
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Tesla); }
            }
                         
            public MeasuredValue Henry
            {
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Henry); }
            }
                         
            public MeasuredValue Katal
            {   
                get { return new MeasuredValue(
                        _value, UnitsOfMeasurement.SI.Katal); }
            }
        }
    }
}

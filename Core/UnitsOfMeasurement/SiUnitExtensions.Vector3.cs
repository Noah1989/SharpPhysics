using System;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public static partial class SiUnitExtensions
    {
        public static SiUnitVector3Expression SI(this Vector3 value)
        {
            return new SiUnitVector3Expression(value);
        }
        
        public sealed class SiUnitVector3Expression
        {
            private readonly Vector3 _value;
        
            internal SiUnitVector3Expression(Vector3 value)
            {
                _value = value;
            }            
            
            public MeasuredVector3 Metre
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Metre); }
            }

            public MeasuredVector3 Kilogram
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Kilogram); }
            }

            public MeasuredVector3 Second
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Second); }
            }

            public MeasuredVector3 Ampere
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Ampere); }
            }

            public MeasuredVector3 Kelvin
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Kelvin); }
            }

            public MeasuredVector3 Mole
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Mole); }
            }

            public MeasuredVector3 Candela
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Candela); }
            }

            public MeasuredVector3 Hertz
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Hertz); }
            }

            public MeasuredVector3 Newton
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Newton); }
            }

            public MeasuredVector3 Pascal
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Pascal); }
            }

            public MeasuredVector3 Joule
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Joule); }
            }

            public MeasuredVector3 Watt
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Watt); }
            }

            public MeasuredVector3 Coulomb
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Coulomb); }
            }

            public MeasuredVector3 Volt
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Volt); }
            }

            public MeasuredVector3 Farad
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Farad); }
            }
        
            public MeasuredVector3 Ohm
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Ohm); }
            }

            public MeasuredVector3 Siemens
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Siemens); }
            }

            public MeasuredVector3 Weber
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Weber); }
            }

            public MeasuredVector3 Tesla
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Tesla); }
            }
                         
            public MeasuredVector3 Henry
            {
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Henry); }
            }
                         
            public MeasuredVector3 Katal
            {   
                get { return new MeasuredVector3(
                        _value, UnitsOfMeasurement.SI.Katal); }
            }
        }
    }
}

using System;
using System.Linq;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public static partial class SI
    {
        public static readonly BaseUnit Metre =
            BaseUnit.Define("metre", "m", "length");

        public static readonly BaseUnit Kilogram =
            BaseUnit.Define("kilogram", "kg", "mass");

        public static readonly BaseUnit Second =
            BaseUnit.Define("second", "s", "time");

        public static readonly BaseUnit Ampere =
            BaseUnit.Define("ampere", "A", "electric current");

        public static readonly BaseUnit Kelvin =
            BaseUnit.Define("kelvin", "K", "thermodynamic temperature");

        public static readonly BaseUnit Mole =
            BaseUnit.Define("mole", "mol", "amount of substance");

        public static readonly BaseUnit Candela =
            BaseUnit.Define("candela", "cd", "luminous intensity");

        public static readonly Unit Hertz =
            Unit.AddName(1 / Second,
                         "hertz", "Hz", "frequency");

        public static readonly Unit Newton =
            Unit.AddName(Kilogram * Metre / Second.Squared,
                         "newton", "N", "force", "weight");

        public static readonly Unit Pascal =
            Unit.AddName(Newton / Metre.Squared,
                         "pascal", "Pa", "pressure", "stress");

        public static readonly Unit Joule =
            Unit.AddName(Newton * Metre,
                         "joule", "J", "energy", "work", "heat");

        public static readonly Unit Watt =
            Unit.AddName(Joule / Second,
                         "watt", "W", "power", "radiant flux");

        public static readonly Unit Coulomb =
            Unit.AddName(Ampere * Second,
                         "coulomb", "C", "electric charge", "electric flux");

        public static readonly Unit Volt =
            Unit.AddName(Joule / Coulomb,
                         "volt", "V", "voltage",
                         "electrical potential difference",
                         "electromotive force");

        public static readonly Unit Farad =
            Unit.AddName(Coulomb / Volt,
                         "farad", "F", "electric capacitance");

        public static readonly Unit Ohm =
            Unit.AddName(Volt / Ampere,
                         "ohm", "Ω",
                         "electric resistance", "impedance", "reactance");

        public static readonly Unit Siemens =
            Unit.AddName(1 / Ohm,
                         "siemens", "S", "electrical conductance");

        public static readonly Unit Weber =
            Unit.AddName(Joule / Ampere,
                         "weber", "Wb", "magnetic flux");

        public static readonly Unit Tesla = 
            Unit.AddName(Weber / Metre.Squared,
                         "tesla", "T", 
                         "magnetic field strength", "magnetic flux density");
                         
        public static readonly Unit Henry = 
            Unit.AddName(Weber / Ampere,
                         "henry", "H", "inductance");
                         
        public static readonly Unit Katal =
            Unit.AddName(Mole / Second,
                         "katal", "kat", "catalytic activity");

        private static readonly BaseUnit[] __baseUnits = new []
                                                         {
                                                             Metre,
                                                             Kilogram,
                                                             Second,
                                                             Ampere,
                                                             Kelvin,
                                                             Mole,
                                                             Candela
                                                         };

        private static readonly Unit[] __derivedUnits = new []
                                                        {
                                                            Hertz,
                                                            Newton,
                                                            Pascal,
                                                            Joule,
                                                            Watt,
                                                            Coulomb,
                                                            Volt,
                                                            Farad,
                                                            Ohm,
                                                            Siemens,
                                                            Weber,
                                                            Tesla,
                                                            Henry,
                                                            Katal
                                                        };
                                                        
        private static readonly Unit[] __allUnits = __baseUnits
                                                      .Cast<Unit>()
                                                      .Concat(__derivedUnits)
                                                      .ToArray();
    }
}

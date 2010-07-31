using System;
using System.Linq;
using System.Collections.Generic;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public sealed class BaseUnit : Unit
    {
        private static readonly List<BaseUnit> __definedUnits = 
            new List<BaseUnit>();    
      
        public static BaseUnit Define(string name, 
                                      string symbol, 
                                      string measure)
        {
            if (__definedUnits.Exists(unit => unit.Names.Any(
                                      unitName => unitName.Name == name)))
            {
                throw new ArgumentException(
                    String.Format("A base unit with the name '{0}'" + 
                                  "has already been defined", name),
                    "name");
            }
            
            if (__definedUnits.Exists(unit => unit.Names.Any(
                                      unitName => unitName.Symbol == symbol)))
            {
                throw new ArgumentException(
                    String.Format("A base unit with the symbol '{0}'" + 
                                  "has already been defined", symbol),
                    "symbol");
            }
            
            var newUnit = new BaseUnit(name, symbol, measure);
            __definedUnits.Add(newUnit);
            return newUnit;
        }
        
        private BaseUnit(string name, string symbol, string quantityName)
        {
           Unit.AddName(this, name, symbol, quantityName);
        }       
      
    }
}

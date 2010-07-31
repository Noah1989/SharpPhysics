using System;
using System.Linq;
using System.Collections.ObjectModel;

namespace SharpPhysics.Core.UnitsOfMeasurement
{
    public class UnitName
    {
        private readonly string _name;
        private readonly string _symbol;
        private readonly ReadOnlyCollection<string> _quantityNames; 
    
        public UnitName(string name, string symbol,
                        params string[] quantityNames)
        {
            _name = name;
            _symbol = symbol;
            _quantityNames = quantityNames.ToList().AsReadOnly();
        }        
    
        public string Name { get { return _name; } }
        public string Symbol { get { return _symbol; } }
        public ReadOnlyCollection<string> QuantityNames
        { 
            get { return _quantityNames; } 
        }
    }
}

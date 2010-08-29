using System;
using System.Collections.Generic;
using SharpTestsEx;
using TechTalk.SpecFlow;
using SharpPhysics.Core.UnitsOfMeasurement;

namespace SharpPhysics.Specifications
{
    [Binding]
    public class UnitsOfMeasurementSteps
    {
        List<MeasuredValue> _values = new List<MeasuredValue>();
        MeasuredValue _result;
        Exception _exception;

        [Given(@"a value of ([-+]?[0-9]*\.?[0-9]+) (\w+)")]
        public void GivenAValueOf(double value, string unitName)
        {
            _values.Add(SI.Parse(value, unitName));
	    }
	    
        [Given(@"a value of 1 metre per second squared")]
        public void GivenAValueOf1MetrePerSecondSquared()
        {
            _values.Add(1 .SI().Metre / SI.Second.Squared);
        }

        [When(@"I multiply the two values")]
        public void WhenIMultiplyTheTwoValues()
        {
	        _result = _values[0] * _values[1];
        }

        [When(@"I divide the two values")]
        public void WhenIDivideTheTwoValues()
        {
            _result = _values[0] / _values[1];
        }
        
        [When(@"I add the two values")]
        public void WhenIAddTheTwoValues()
        {
            try
            {        
                _result = _values[0] + _values[1];
            }
            catch (UnitsOfMeasurementMismatchException ex)
            {
                _exception = ex;
            }
        }
        
        [When(@"I substract the two values")]
        public void WhenISubstractTheTwoValues()
        {
            try
            {
                _result = _values[0] - _values[1];
            }
            catch (UnitsOfMeasurementMismatchException ex)
            {
                _exception = ex;
            }
        }

        [Then(@"the result should be ([-+]?[0-9]*\.?[0-9]+) (\w+)")]
        public void ThenTheResultShouldBe(double value, string unitName)
        {
            _result.Should().Be.EqualTo(SI.Parse(value, unitName));
            _result.Value.Should().Be.EqualTo(value);
        }
        
        [Then(@"an UnitsOfMeasurementMismatchException should be thrown")]
        public void ThenAnUnitsOfMeasurementMismatchExceptionShouldBeThrown()
        {
            _exception.Should()
                .Be.OfType<UnitsOfMeasurementMismatchException>();
        }        
    }
}

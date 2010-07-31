﻿using System;
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

        [Given(@"a value of ([-+]?[0-9]*\.?[0-9]+) (\w+)")]
        public void GivenAValueOf(double value, string unitName)
        {
            _values.Add(SI.Parse(value, unitName));
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
            _result = _values[0] + _values[1];
        }
        
        [When(@"I substract the two values")]
        public void WhenISubstractTheTwoValues()
        {
            _result = _values[0] - _values[1];
        }


        [Then(@"the result should be ([-+]?[0-9]*\.?[0-9]+) (\w+)")]
        public void ThenTheResultShouldBe(double value, string unitName)
        {
            _result.Should().Be.EqualTo(SI.Parse(value, unitName));
            ((double) _result).Should().Be.EqualTo(value);
        }
    }
}

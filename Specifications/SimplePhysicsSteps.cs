using System;
using SharpPhysics.Core;
using SharpPhysics.Core.UnitsOfMeasurement;
using SharpPhysics.PhysicalEntities.Mechanics;
using TechTalk.SpecFlow;

namespace SharpPhysics.Specifications
{
    [Binding]
    public class SimplePhysicsSteps
    {
        private PointMass _pointMass;
        private GravityField _gravityField;
    
        [Given(@"a point mass")]
        public void GivenAPointMass()
        {
            _pointMass = new PointMass(1 .SI().Kilogram);
        }

        [Given(@"earth's gravity field")]
        public void GivenEarthsGravityField()
        {
            _gravityField = new GravityField(
                                new Vector3(0, 0, -9.81)
                                    .SI().Metre / SI.Second.Squared);
                                    
            ScenarioContext.Current.Pending();
            //_gravityField.Connect(_pointMass);
        }

        [When(@"I simulate ten seconds of time")]
        public void WhenISimulateTenSecondsOfTime()
        {
            ScenarioContext.Current.Pending();
            //_pointMass.Simulate(10 .SI().Second);
        }

        [Then(@"the point mass should have a speed of 98\.1 m/s")]
        public void ThenTheMassPointShouldHaveASpeedOf98Point1MetresPerSecond()
        {
            ScenarioContext.Current.Pending();
            //_pointMass.GetFrame(10 .SI().Second)
            //    .Velocity.Abs()
            //    .Should().Be.EqualTo(98.1 .SI().Metre / SI.Second);
        }

        [Then(@"the point mass should have fallen 490\.5 m")]
        public void ThenTheMassPointShouldHaveFallen490Point5Metres()
        {
            ScenarioContext.Current.Pending();
            //_pointMass.GetFrame(10 .SI().Second)
            //    .Location.Z
            //    .Should.Be.EqualTo(-490.5 .SI().Metre);
        }
    }
}

using System;
using SharpPhysics.PhysicalEntities.Mechanics;
using SharpPhysics.Core.UnitsOfMeasurement;
using TechTalk.SpecFlow;

namespace SharpPhysics.Specifications
{
    [Binding]
    public class SimplePhysicsSteps
    {
        private PointMass _pointMass;
        //private GravityField _gravityField;
    
        [Given(@"a point mass")]
        public void GivenAPointMass()
        {
            _pointMass = new PointMass(1 .SI().Kilogram);
        }

        [Given(@"earth's gravity field")]
        public void GivenEarthsGravityField()
        {
            /*_gravityField = new GravityField 
                                {
                                    Acceleration = 
                                        new Vector3(0, 0, -9.81)
                                            .SI().Metre / SI.Second.Squared
                                };*/
        }

        [When(@"I simulate ten seconds of time")]
        public void WhenISimulateTenSecondsOfTime()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the point mass should have a speed of 98\.1 m/s")]
        public void ThenTheMassPointShouldHaveASpeedOf98Point1MetresPerSecond()
        {
            var test = 98.1 .SI().Metre / SI.Second;
            
            ScenarioContext.Current.Pending();
        }

        [Then(@"the point mass should have fallen 490\.5 m")]
        public void ThenTheMassPointShouldHaveFallen490Point5Metres()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

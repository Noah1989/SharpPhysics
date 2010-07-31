using System;
using TechTalk.SpecFlow;

namespace SharpPhysics.Specifications
{
    [Binding]
    public class SimplePhysicsSteps
    {
        [Given(@"a point mass")]
        public void GivenAPointMass()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"earth's gravity field")]
        public void GivenEarthsGravityField()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I simulate ten seconds of time")]
        public void WhenISimulateTenSecondsOfTime()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the point mass should have a speed of 98\.1 m/s")]
        public void ThenTheMassPointShouldHaveASpeedOf98Point1MetersPerSecond()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the point mass should have fallen 490\.5 m")]
        public void ThenTheMassPointShouldHaveFallen490Point5Meters()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

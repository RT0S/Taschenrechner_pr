using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Taschenrechner_pr
{
    [Binding]
    public class TrigonomischeFunktionenSteps
    {
        private double number;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(Decimal p0)
        {
            number = (double) p0;
        }
        
        [When(@"we calculate the sinus from it")]
        public void WhenWeCalculateTheSinusFromIt()
        {
            number = Math.Sin(number);
        }
        
        [When(@"we calculate the cosinus from it")]
        public void WhenWeCalculateTheCosinusFromIt()
        {
            number = Math.Cos(number);
        }
        
        [When(@"we calculate the tangens from it")]
        public void WhenWeCalculateTheTangensFromIt()
        {
            number = Math.Tan(number);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = number;
            Assert.Equal(expected, actual, 5);
        }
    }
}

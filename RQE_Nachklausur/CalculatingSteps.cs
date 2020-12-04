using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQE_Nachklausur
{
    [Binding]
    public class CalculatingSteps
    {
        private double x, y, result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            x = 10;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            y = 5;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = x + y;
        }
        
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = x - y;
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = x / y;
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = x * y;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = result;
            Assert.Equal(expected, actual, 5);
        }
    }
}

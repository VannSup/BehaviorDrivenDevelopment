using BehaviorDrivenDevelopment;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();

        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When(@"the two numbers are multiply")]
        public void WhenTheTwoNumbersAreMultiply()
        {
            _result = _calculator.Multiply();
        }

        [When(@"the two numbers are divide")]
        public void WhenTheTwoNumbersAreDivide()
        {
            try
            {
                _result = _calculator.Divide();
            }catch(Exception e)
            {
                _scenarioContext.Add("Exception_CalculatorDivide", e);
            }
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Then(@"the user is presented with an error message")]
        public void ThenTheUserIsPresentedWithAnErrorMessage()
        {
            var exception = _scenarioContext["Exception_CalculatorDivide"];
            exception.Should().BeOfType<InvalidOperationException>().Which.Message.Should().Be("Cannot divide by 0");
        }

    }
}

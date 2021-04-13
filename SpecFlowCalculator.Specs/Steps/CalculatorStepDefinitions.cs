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

        #region Given
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.InputsNumbers.Add(number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.InputsNumbers.Add(number);
        }

        [Given(@"the following numbers")]
        public void GivenTheFollowingNumbers(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                _calculator.InputsNumbers.Add(int.Parse(row["Numbers"]));
            }

        }
        #endregion

        #region When
        [When("numbers are added")]
        public void WhenNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("numbers are subtracted")]
        public void WhenNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When("numbers are multiply")]
        public void WhenNumbersAreMultiply()
        {
            _result = _calculator.Multiply();
        }

        [When("numbers are divide")]
        public void WhenNumbersAreDivide()
        {
            try
            {
                _result = _calculator.Divide();
            }
            catch (Exception e)
            {
                _scenarioContext.Add("Exception_CalculatorDivide", e);
            }

        }
        #endregion

        #region Then
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Then("the user is presented with an error message")]
        public void ThenTheUserIsPresentedWithAnErrorMessage()
        {
            var exception = _scenarioContext["Exception_CalculatorDivide"];
            exception.Should().BeOfType<InvalidOperationException>().Which.Message.Should().Be("Cannot divide by 0");
        }
        #endregion
    }
}

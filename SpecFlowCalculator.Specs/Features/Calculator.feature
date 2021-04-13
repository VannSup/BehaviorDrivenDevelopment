Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract two numbers
    Given the first number is 120
    And the second number is 70
    When the two numbers are subtracted
    Then the result should be 50

Scenario: Multiply two numbers
    Given the first number is 6
    And the second number is 7
    When the two numbers are multiply
    Then the result should be 42

Scenario: Divide two numbers
    Given the first number is 30
    And the second number is 2
    When the two numbers are divide
    Then the result should be 15

Scenario: Divide two numbers with invalid second number
    Given the first number is 30
    And the second number is 0
    When the two numbers are divide
    Then the user is presented with an error message
Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When numbers are added
	Then the result should be 120

Scenario: Add N numbers
    Given the following numbers
    | Numbers |
    |   25    |
    |   2     |
    |   10    |
    When numbers are added
    Then the result should be 37

Scenario: Subtract two numbers
    Given the first number is 120
    And the second number is 70
    When numbers are subtracted
    Then the result should be 50

#first value of Tab is add
Scenario: Subtract N numbers
    Given the following numbers
    | Numbers |
    |   25    |
    |   2     |
    |   10    |
    When numbers are subtracted
    Then the result should be 13

Scenario: Multiply two numbers
    Given the first number is 6
    And the second number is 7
    When numbers are multiply
    Then the result should be 42

Scenario: Multiply N numbers
    Given the following numbers
    | Numbers |
    |   25    |
    |   2     |
    |   10    |
    When numbers are multiply
    Then the result should be 500

Scenario: Divide two numbers
    Given the first number is 30
    And the second number is 2
    When numbers are divide
    Then the result should be 15

# Is not float
Scenario: Divide N numbers
    Given the following numbers
    | Numbers |
    |   25    |
    |   2     |
    |   10    |
    When numbers are divide
    Then the result should be 1

Scenario: Divide by 0
    Given the first number is 30
    And the second number is 0
    When numbers are divide
    Then the user is presented with an error message

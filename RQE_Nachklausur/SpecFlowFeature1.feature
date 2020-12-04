Feature: Calculating
	In order to be able to make basic calculation
	As a arithmetic beginner
	I want to be told the result of additions, subtractions, divisions and multiplications

Scenario: Add two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are added
	Then the result should be 15

Scenario: Subtract two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are subtracted
	Then the result should be 5

Scenario: Divide two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are divided
	Then the result should be 2
	
Scenario: Multiply two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are multiplied
	Then the result should be 50
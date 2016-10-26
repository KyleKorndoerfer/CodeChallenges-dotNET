Feature: FizzBuzz
	In order to test my logic skills
	As a developer
	I want to be told if a positive natural number is divisible by 3 (Fizz), 5 (Buzz), or both (FizzBuzz)

@FizzBuzz
Scenario Outline: Determine divisibility
	Given I have entered <number> into the fizzbuzz machine
	When I ask for the answer
	Then the result should be <response>

Examples:
| number | response |
| 1      | 1        |
| 2      | 2        |
| 3      | Fizz     |
| 4      | 4        |
| 5      | Buzz     |
| 6      | Fizz     |
| 7      | 7        |
| 8      | 8        |
| 9      | Fizz     |
| 10     | Buzz     |
| 11     | 11       |
| 12     | Fizz     |
| 13     | 13       |
| 14     | 14       |
| 15     | FizzBuzz |
| 16     | 16       |
| 17     | 17       |
| 18     | Fizz     |
| 19     | 19       |
| 20     | Buzz     |
Feature: DataDrivenWithExample
As a user to benefit
from the website,
User have to register to the websire

@tag1
Scenario Outline: Data Driven With Example
	Given I navigate to the website
	And I click on Sign Up
	And I enter Username text "<Username>"
	And I enter Email text "<Email>"
	And I enter Password text "<Password>"
	When I click on Sign up 
	Then I should be able to register successfully 


	Examples: 

	
	| Username | Email            | Password  |
	| Remo     | okeremo@demo.com | Okearegba |
	| Oluyole  | olu@demo.com     | Shade12   |
	| Ganiyat  | ogawife@demo.com | Number1   |

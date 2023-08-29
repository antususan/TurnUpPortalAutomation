Feature: TMFeature

As a TurnUp portal admin
I would like to create,edit and delete time and material records
So that I can manage employees time and materials sucessfully 

@regression
Scenario: create time record with valid details
	Given I logged in to TurnUp portal Successfully
	And I navigate to Time and Material page
	When I create a new time record 
	Then the record should be created sucessfully 

Scenario Outline: edit time record with valid data 
	Given I logged in to TurnUp portal Successfully
	And I navigate to Time and Material page
	When I update '<Code>' on an existing Time record 
	Then the record should have an  updated '<Code>'

Examples: 
| Code     |
| Pen      |
| Keyboard |
| Bottle   |

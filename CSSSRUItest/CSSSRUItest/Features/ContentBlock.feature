Feature: ContentBlock
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Click on link two times and verify that content in block still displayed
	Given I am on quest page
	And ProjectDetails block displayed 
	When I click on InfoErrors link 
	Then InfoErrors block displayed
	When I click on InfoErrors link
	Then InfoErrors block displayed
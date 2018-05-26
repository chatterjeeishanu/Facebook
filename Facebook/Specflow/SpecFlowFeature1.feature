Feature: Facebook Login
	In order to login facebook home page
	As an user
	

@Login
Scenario: Open Facebook homepage
	Given I have navigated to facebook.com
	And I have entered my username and password
	When I click on login
	Then I can see my homepage

Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@automationscenario1
Scenario: User should be able to create a new account for the application, signin and signout.
	Given Matt, a new customer navigates to application sign-in page
	And Matt registers as a new user of the application
	And Matt should get logged into the application
	And Matt should be able to view his account page
	And view the sign out option

Feature: Login
	Login to Demo application

@smoke
Scenario: Perform Login of Application site
	#steps
	Given I launch the application
	And I click login link
	And I enter the following details
	| UserName | Password |
	| admin | password |
	And I click login button
	Then I should see Employee details link


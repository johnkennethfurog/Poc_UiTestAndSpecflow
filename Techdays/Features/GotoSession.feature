Feature: GotoSession
	From homescreen user will move to session page

Scenario: Go to Session
	Given I am at the Home page
	When I Tap menu
	And Tap Session
	Then I must go to session page


	Scenario: Inspect
	Given I will inspect elements
Feature: Demo
		As a User,
		I can find information about libraries this demo uses

@C001 @smokeTest
Scenario: Validate Star gazers on a repository
    Given I am on "https://github.com/jukafah/csharp-specflow-selenium/"
    When I click on Star Count
    Then List of all stargazers are displayed on page


Feature: SDSignIn
In order to purchase items from the saucedemo website 
As a registered user 
I want to be able to sign in to my account

@login
Scenario: Invalid password - wrong password
	Given I am on the sign in page
	And I have entered the username <username>
	And I have entered the password <password>
	When I click the login button
	Then I should get the error message "Epic sadface: Username and password do not match any user in this service"
	Examples:
	| username        | password       |
	| standard_user   | wrongpassword1 |
	| locked_out_user | Eng71easteregg |

	@login
Scenario: Blank username and password
	Given I am on the sign in page
	When I click the login button
	Then I should get the error message "Epic sadface: Username is required"

@login
Scenario: Blank username
	Given I am on the sign in page
	And I have entered the password 'secret_sauce'
	When I click the login button
	Then I should get the error message "Epic sadface: Username is required"

@login
Scenario: Blank password
	Given I am on the sign in page
	And I have entered the username 'locked_out_user'
	When I click the login button
	Then I should get the error message "Epic sadface: Password is required"

	@login
Scenario: Invalid username - username doesn't exist
	Given I am on the sign in page
	And I have entered the username 'leshki'
	And I have entered the password 'secret_sauce'
	When I click the login button
	Then I should get the error message "Epic sadface: Username and password do not match any user in this service"

	@login
Scenario: Valid username and password
	Given I am on the sign in page
	And I have entered the username <username>
	And I have entered the password 'secret_sauce'
	When I click the login button
	Then I should end up on the inventory page with the url "https://www.saucedemo.com/inventory.html"
	Examples:
| username                 |
| standard_user            |
| locked_out_user          |
| problem_user             |
| performance_ glitch_user |

@login
Scenario: Error message disappears when I click it
	Given I am on the sign in page
	And I have entered the username 'problem_user'
	And I have entered the password 'wrongpasswordagain'
	And I click the login button
	When I click error message button
	Then I should get the error message should disappear

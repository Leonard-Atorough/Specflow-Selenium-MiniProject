Feature: SDProduct
	Simple calculator for adding two numbers

@mytag
Scenario: Sort By Name A-Z
	Given I am on the product page
	When I select sort by name A-Z
	Then the products are listed alphabetically
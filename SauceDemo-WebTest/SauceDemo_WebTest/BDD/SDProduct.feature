Feature: SDProduct
	Simple calculator for adding two numbers

@mytag
Scenario: Sort By Name A-Z
	Given I am on the product page
	When I select sort by name A-Z
	Then the products are listed alphabetically

@mytag
Scenario: Sort By Name Z-A
	Given I am on the product page
	When I select sort by name Z-A
	Then the products are listed reverse alphabetically

@mytag
Scenario: Sort By Price Low-High
	Given I am on the product page
	When I select sort by price low-high
	Then the products are listed cheapest first

@mytag
Scenario: Sort By Price High-Low
	Given I am on the product page
	When I select sort by price high-low
	Then the products are listed priciest first
Feature: SDCart
	As a signed in shopper on the saucedemo website
	I want to be able to add items to my cart
	So I can buy lots of items at once

@mytag
Scenario: Add item to cart
	Given I am on the products page
	And I add the first item to my cart
	When I click on the cart Icon to go to my cart
	Then the first item should be in my cart

Scenario: : Add multiple items to cart
	Given I am on the products page
	When I add multiple <number> of Items to my cart
	Then the cart counter should display the correct <number> of items
	Examples: 
	| number |
	| 2      |
	| 1      |
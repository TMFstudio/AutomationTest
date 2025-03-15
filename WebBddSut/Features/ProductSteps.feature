Feature: Product
	Test the product page functionalities

@mytag
Scenario: Create New product 
	Given I click the Product menu
	And I click the "Create" link
	And I create product with this details
		 | Name      | Description | Price | ProductType |
	     | Nokia1100 | Nothing     | 100   | 1           |
	Then I see all the product details are created as expected

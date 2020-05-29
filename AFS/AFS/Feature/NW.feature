Feature: Add product
		As a user
		I want to open the application
		So I can add new product 


		Scenario: New Product

		Given I open "http://localhost:5000" url
		When I enter "user" login
		And I enter "user" password
		And I click on login button
		And I create new product
		And I type product name "Kungaloosh"
		And I set category "Beverages"
		And I set supplier "Exotic Liquids"
		And I type unit price "25,000"
		And I type quantity per unit "5"
		And I type units in stock "20" 
		And I type units on order "100"
		And I type reorder level "75"
		And I click on send button
		Then "Kungaloosh" should be added
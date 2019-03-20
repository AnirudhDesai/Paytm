Feature: SpecFlowFeature1
	
@mytag
Scenario: mobile recharge using Paytm
	Given I have entered Paytm website
	And I validate 'Mobile','Electricity','DTH','Metro' optios are available.
	And I click on 'Mobile' option and validate 
    When I Enter Mobile number,select Operator,state and enter the Amount and Click on Proceed to Recharge then validate
	Then result should be dipalyed which will navigate to proceed to pay


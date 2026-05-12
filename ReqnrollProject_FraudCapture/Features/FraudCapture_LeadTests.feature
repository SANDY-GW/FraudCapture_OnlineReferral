Feature: FraudCapture_LeadTests

A short summary of the feature

@tag1
Scenario: [Enter usedetails in the first page]
	Given when I open the FraudCapture application
	And I enter the "UserFirstName" on the Initial User Data Page
	And I enter the "UserLastName" on the Initial User Data Page
	And I enter the "Email address" on the Initial User Data Page
	And I enter the "Phone number" on the Initial User Data Page
	When I click on the Next button on the Initial User Data Page
	Then I should be navigated to the Next Page


Scenario: [Enter usedetails in the first page with invalid data]
	Given when I open the Online referral application
	And I enter the "Sandeep" on the Initial User Data Page for this demo
	And I enter the "UserLastName" on the Initial User Data Page
	And I enter the "qwqw" on the Initial User Data Page 
	And I enter the "Phone number" on the Initial User Data Page
	When I click on the Next button on the Initial User Data Page
	Then I should be navigated to the Next Page

Scenario: [Enter usedetails in the entire application]
	Given when I open the Online referral application
	And I enter the "UserFName","UserLastName","Test Source 1","sandeep.krishnan@gainwelltechnologies.com"  filled on the Initial User Data Page
	And I enter the "Email address" on the Initial User Data Page
	And I enter the "Phone number" on the Initial User Data Page
	When I click on the Next button on the Initial User Data Page
	Then I should be navigated to the Next Page


Scenario Outline: [Enter usedetails in the first page with different data sets]
	Given when I open the Online referral application
	And I enter the "<UserFirstName>" on the Initial User Data Page
	And I enter the "<UserLastName>" on the Initial User Data Page
	And I enter the "<Email address>" on the Initial User Data Page
	And I enter the "<Phone number>" on the Initial User Data Page
	And I enter the "<Phone number1>" on the Initial User Data Page
	When I click on the Next button on the Initial User Data Page
	Then I should be navigated to the Next Page
Examples: 
| UserFirstName | UserLastName | Email address | Phone number | Phone number1 |
| san           | sAN2         | t.t@tcom      |       999999 |          8888 |
| san           | sAN3         | t.t@tcom      |       999999 |          8888 |
| san           | sAN4         | t.t@tcom      |       999999 |          Null |
| san           | sAN5         | t.t@tcom      |       999999 |               |
| san           | sAN6         | t.t@tcom      |       999999 |               |

Scenario: [Enter usedetails in the entire application part2]
	Given when I open the Online referral application
	And I enter the "UserFName","UserLastName","Test Source 1","sandeep.krishnan@gainwelltechnologies.com" filled on the Initial User Data Page
	| UserFName | USerLName    | TestSource    | Email                                     |  |
	| UserFName | UserLastName | Test Source 1 | sandeep.krishnan@gainwelltechnologies.com |  |
	And I enter the "Email address" on the Initial User Data Page
	And I enter the "Phone number" on the Initial User Data Page
	When I click on the Next button on the Initial User Data Page
	Then I should be navigated to the Next Page
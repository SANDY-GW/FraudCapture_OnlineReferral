Feature: New UI Changes for Online Referral

Online referral End to End Scenarios

#Background: Given when I open the Online referral application


@online_referral @SmokeTest @regression
Scenario Outline: [Verify that the user is able to see the new UI changes for online referral as a Provider]
	Given when I open the Online referral application
	When I enter the email as "<Email address>" on the Initial User Data Page

	Then I enter the userFN as "<UserFirstName>",User lastname as "<UserLastName>",Org name as "<Org name>",title as "<title>"  filled on the Initial User Data Page
	And I enter the Phone number as "<Phone number>" on the Initial User Data Page
	And I enter the "<Address1>","<Address2>","<City>","<State>","<Zipcode>", filled in the Address section yon the Initial User Data Page
	And #verify the Captcha Email notification
	#Then I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page


	And Referral Type is selected as "<referralType>" on the second User Data Page
	And Suspect or Subject or Involved Party Type as "<involvedPartyType>"
	Then enter case or reference number as "<caseOrReferenceNumber>" on the second User Data Page
	And How was this detected as"<detectedAs>" ,please provide  a Summary of this referral as "<summary>" on the second User Data Page
	And enter Amount "<amount>",detectiondate "<detectionDate>", incidentStartDate "<incidentStartDate>", incidentEndDate "<incidentEndDate>" on the second User Data Page
	And get the Original detection date
	And enter state as "<state2>" and city as "<city2>" on the second User Data Page
	And I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page

	And Is thisInvolved Party dropdown is selected as "<witnessDropdown>" on the third User Data Page
	And enter InvolvedParty orgname as "<orgname>", name prefix as "<name prefix>", associated party first name as "<first name>",associated party middle name as "<middle name>", associated party last name as "<last name>" and name suffix as "<name suffix>" on the fourth User Data Page
	And enter InvolvedParty Designation as "<designation>",DOB as "<DOB>", SSN as "<SSN>", licenseNumber as "<licenseNumber>", How witness or external party reported this as "<involvedPartyType>",any additional info as "<detectedAs>" ID Test as "<ID Test>"
	And enter InvolvedParty NPI as "<NPI>", TIN as "<TIN>",medicaid ID as "<medicaid ID>",Medicare ID as "<Medicare ID>", otherID as "<otherID>" on the fourth User Data Page
	And enter InvolvedParty provider type as "<provider type>", provider specialty as "<provider specialty >",Taxonomy as "<Taxonomy>" and other as "<other>" on the fourth User Data Page
	And InvolvedParty street_Address_lineone as "<Address1>", street_Address_linetwo as "<Address2>", city as ,"<City>", state as "<associatedstate>" , county as "<city2>" and zip code as "<Zipcode>"
	And InvolvedParty country as "<country>",  phone number as "<Phone number>", fax as "<fax>" and email address as "<Email address>"
	And I click on the Next button on the third User Data Page
	And I should be navigated to the Next Page

	And is there anotherinvolved party dropdown is selected as "<Is there any Involved Party Dropdown>" on the fourth User Data Page

	
	And Questionone Is this a resubmission as "<Question1>"
	And Questiontwo as "Question2", QuestionThree as "<Question3>"
	And then uploading a file using file path as "<TestFile>"
	Then click on proceed to next session button

	Given when I open the fraud capture  application
	When I enter the "<UserEmailID>" on the welcome fraude capture page
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor as "DEMO"
	And I click on CaseTracking and select the "Leads" option on the fraud capture home page
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	#And I click on the Activities and selected lead activity name as "<ActivityName>" on the fraud capture Lead detials Page
	And click on Activities tab and serach for the activity "<ActivityName>" created through onlinereferral
	Then the searched activity should be displayed in the activity list "<ActivityName>"
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity "<ActivityName>"
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed


	

Examples:
	| UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                           | ActivityName                                                  | InvalidDOB | InvalidDOBErrorMessage        |
	| UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | jayapradha.d@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | 06/26/2026 | Date cannot be in the future. |



	
	




Scenario Outline: [Verify that the user is able to see the new UI changes for online referral as a Member]
	Given when I open the Online referral application
	Then I enter the email as "<Email address>" on the Initial User Data Page
	Given I enter the userFN as "<UserFirstName>",User lastname as "<UserLastName>",Org name as "<Org name>",title as "<title>"  filled on the Initial User Data Page
	And I enter the Phone number as "<Phone number>" on the Initial User Data Page
	And I enter the "<Address1>","<Address2>","<City>","<State>","<Zipcode>", filled in the Address section yon the Initial User Data Page
	#Then verify the Captcha Email notification
	Then I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page

	And Referral Type is selected as "<referralType>" on the second User Data Page
	And Suspect or Subject or Involved Party Type as "<involvedPartyType>"
	Then enter case or reference number as "<caseOrReferenceNumber>" on the second User Data Page
	And How was this detected as"<detectedAs>" ,please provide  a Summary of this referral as "<summary>" on the second User Data Page
	And enter Amount "<amount>",detectiondate "<detectionDate>", incidentStartDate "<incidentStartDate>", incidentEndDate "<incidentEndDate>" on the second User Data Page
	And enter state as "<state2>" and city as "<city2>" on the second User Data Page
	And I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page

	And Is thisInvolved Party dropdown is selected as "<witnessDropdown>" on the third User Data Page
	And enter InvolvedParty  name prefix as "<name prefix>", associated party first name as "<first name>",associated party middle name as "<middle name>", associated party last name as "<last name>" and name suffix as "<name suffix>"
	And enter InvolvedParty DOB as "<DOB>", Gender as "<Gender>", other as "<other>", How witness or external party reported this as "<involvedPartyType>",any additional info as "<detectedAs>"
	And enter InvolvedParty ID as "<medicaid ID>",ssn as "<SSN>" medicaid ID as "<medicaid ID>",Medicare ID as "<Medicare ID>", otherID as "<otherID>"
	And enter InvolvedParty plan as "Test", Program  as "Program",LOB as "LOB1" and Group as "Group1"
	And InvolvedParty member street_Address_lineone as "<Address1>", street_Address_linetwo as "<Address2>", city as ,"<City>", state as "<associatedstate>" , county as "<city2>" and zip code as "<Zipcode>"
	And InvolvedParty Primary phoneNo as "<Phone number>",  Secondary phone number as "<Phone number>" and email address as "jayapradha.d@gainwelltechnologies.com"
	And I click on the Next button on the third User Data Page
	And I should be navigated to the Next Page

	And is there anotherinvolved party dropdown is selected as "<Is there any Involved Party Dropdown>" on the fourth User Data Page

	
	And Questionone Is this a resubmission as "<Question1>"
	And Questiontwo as "Question2", QuestionThree as "<Question3>"
	And then uploading a file using file path as "<TestFile>"
	Then click on proceed to next session button

	Given when I open the fraud capture  application
	When I enter the "<UserEmailID>" on the welcome fraude capture page
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor as "DEMO"
	And I click on CaseTracking and select the "Leads" option on the fraud capture home page
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	#And I click on the Activities and selected lead activity name as "<ActivityName>" on the fraud capture Lead detials Page
	And click on Activities tab and serach for the activity "<ActivityName>" created through onlinereferral
	Then the searched activity should be displayed in the activity list "<ActivityName>"
	When user clicks on Edit button for an existing activity "<ActivityName>"
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

Examples:
	| UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN     | LN     | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                           | ActivityName                                                  |
	| UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | UserFN | UserLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | jayapradha.d@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) |




Scenario Outline: [Verify that the user is able to see the new UI changes for online referral as a Non Enumerated Provider]
	Given when I open the Online referral application
	Then I enter the email as "<Email address>" on the Initial User Data Page
	And I enter the userFN as "<UserFirstName>",User lastname as "<UserLastName>",Org name as "<Org name>",title as "<title>"  filled on the Initial User Data Page
	And I enter the Phone number as "<Phone number>" on the Initial User Data Page
	And I enter the "<Address1>","<Address2>","<City>","<State>","<Zipcode>", filled in the Address section yon the Initial User Data Page
	When I click on the Next button on the Initial User Data Page
	And I should be navigated to the Next Page

	And Referral Type is selected as "<referralType>" on the second User Data Page
	And Suspect or Subject or Involved Party Type as "<involvedPartyType>"
	Then enter case or reference number as "<caseOrReferenceNumber>" on the second User Data Page
	And How was this detected as"<detectedAs>" ,please provide  a Summary of this referral as "<summary>" on the second User Data Page
	And enter Amount "<amount>",detectiondate "<detectionDate>", incidentStartDate "<incidentStartDate>", incidentEndDate "<incidentEndDate>" on the second User Data Page
	And enter state as "<state2>" and city as "<city2>" on the second User Data Page
	When I click on the Next button on the Initial User Data Page
	And I should be navigated to the Next Page

	And Is thisInvolved Party dropdown is selected as "<witnessDropdown>" on the third User Data Page
	And enter InvolvedParty Non-Enumertaed Provider orgname as "<associated orgname>", name prefix as "<name prefix>", associated party first name as "<associated party first name>",associated party middle name as "<associated party middle name>", associated party last name as "<associated party last name>" and name suffix as "<name suffix>" on the fourth User Data Page
	And enter InvolvedParty Designation as "<designation>" ,DOB as "<DOB>", SSN as "<SSN>", How witness or external party reported this as "<involvedPartyType>",any additional info as "<detectedAs>" licenseNumber as "<licenseNumber>",other ID as "<otherID>",other as "<other>"
	And enter primary phone number as "<Phone number>",secondary phone number as "<Phone number>", fax as "<fax>" and email address as "<Email address>" for the involved party
	And street address line one as "<Address1>", street address line two as "<Address2>", city as "<City>", state as "<associatedstate>", county as "<city2>" , zip code as "<Zipcode>" and country as "<country>" for the involved party
	And I click on the Next button on the third User Data Page
	And I should be navigated to the Next Page

	And is there anotherinvolved party dropdown is selected as "<Is there any Involved Party Dropdown>" on the fourth User Data Page

	
	And Questionone Is this a resubmission as "<Question1>"
	And Questiontwo as "Question2", QuestionThree as "<Question3>"
	And then uploading a file using file path as "<TestFile>"
	Then click on proceed to next session button

	

Examples:
	| UserFirstName | UserLastName | Email address                         | Phone number | Org name           | title   | Address1           | Address2    | City   | State | Zipcode | referralType                            | involvedPartyType       | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile                                                                                                    | Is there any Involved Party Dropdown |
	| UserFName     | UserLastName | jayapradha.d@gainwelltechnologies.com |   9999999999 | Referring Source 1 | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | TX    |   75035 | Referral Type 1 - w/ Distribution Email | Non-Enumerated Provider |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | TX     | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | FN         | MN          | LN        | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | C:/Users/jd/SourceQaDevelopment/Repos/FraudCapture_OnlineReferral/ReqnrollProject1/Attachments/TestFile.txt | No                                   |



Scenario Outline: [TestMyCode]
	Given when I open the Online referral application
	And Verify color on all Required Field in the Initial User Data Page
	And I enter the "<Address1>","<Address2>","<City>","<State>","<Zipcode>", filled in the Address section yon the Initial User Data Page
	
	And when I open the fraud capture  application
	When I enter the "<UserEmailID>" on the welcome fraude capture page
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor as "DEMO"
	And I click on CaseTracking and select the "Leads" option on the fraud capture home page
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And I click on the Activities and selected lead activity name as "<ActivityName>" on the fraud capture Lead detials Page
	Then I should be navigated to Lead Activities  Page
	

Examples:
	| UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                    |
	| UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | TX    |   75035 | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | TX     | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | 02242026-Lead Activity 1-Auto Close on Creation |


Scenario Outline: [Verify that the error messages are displayed when Incident end date is prior to start date for online referral as a Provider]
	Given when I open the Online referral application
	And I enter the email as "<Email address>" on the Initial User Data Page
	And I enter the userFN as "<UserFirstName>",User lastname as "<UserLastName>",Org name as "<Org name>",title as "<title>"  filled on the Initial User Data Page
	And I enter the Phone number as "<Phone number>" on the Initial User Data Page
	And I enter the "<Address1>","<Address2>","<City>","<State>","<Zipcode>", filled in the Address section yon the Initial User Data Page
	Then the Captcha Email notification appears
	When I should be navigated to the Next Page


	And Referral Type is selected as "<referralType>" on the second User Data Page
	And Suspect or Subject or Involved Party Type as "<involvedPartyType>"
	Then enter case or reference number as "<caseOrReferenceNumber>" on the second User Data Page
	And How was this detected as"<detectedAs>" ,please provide  a Summary of this referral as "<summary>" on the second User Data Page
	

	When User enters Incident Start Date as "<Incident Start Date>"
	And User enters Incident End Date as "<Incident End>"
	Then validate "<Error message>" should be displayed
		| error message   |
		| <Error message> |


Examples:
	| UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | Incident Start Date | Incident End | Error message                                                                                |
	| UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 04/10/2026          | 04/05/2026   | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date |
	| UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 04/10/2028          | 04/05/2029   | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date |

Scenario Outline: [Verify that the error messages are displayed when Incident start date is prior to end date for online referral as a Provider]
	Given when I open the Online referral application
	And I enter the email as "<Email address>" on the Initial User Data Page
	And I enter the userFN as "<UserFirstName>",User lastname as "<UserLastName>",Org name as "<Org name>",title as "<title>"  filled on the Initial User Data Page
	And I enter the Phone number as "<Phone number>" on the Initial User Data Page
	And I enter the "<Address1>","<Address2>","<City>","<State>","<Zipcode>", filled in the Address section yon the Initial User Data Page
	Then verify the Captcha Email notification
	#Then I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page


	And Referral Type is selected as "<referralType>" on the second User Data Page
	And Suspect or Subject or Involved Party Type as "<involvedPartyType>"
	Then enter case or reference number as "<caseOrReferenceNumber>" on the second User Data Page
	And How was this detected as"<detectedAs>" ,please provide  a Summary of this referral as "<summary>" on the second User Data Page
	

	When User enters Incident Start Date as "04/10/2028"
	Then Error message "Date cannot be in the future" should be displayed


Examples:
	| UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | Incident Start Date |
	| UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2028    | 04/10/2028          |
	

	
Scenario Outline: 01_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party selected as "No" along with Validation of all the required fields ]

# Submitting Party Information page:
	Given when I open the Online referral application
	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	And i check the required fields current page
	Then verify Dropdown lists are in alphabetical order
	When I enter the email  on the Initial User Data Page
		| Email address   |
		| <Email address> |

	And I enter the invalid email id
		| Invalid email   |
		| <Invalid email> |

	Then I validate the error messgae
		| Email validation error message   |
		| <Email validation error message> |

	When I enter the valid email id
		| Email address   |
		| <Email address> |
		
	Then I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |

	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |

	When I enter the invalid zipcode
		| Invalid zipcode   |
		| <Invalid zipcode> |

	Then I validate the zip code error messgae
		| Zipcode validation error message   |
		| <Zipcode validation error message> |

	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the Next Page

	# Referral page:
	And i check the required fields current page
	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	Then verify Dropdown lists are in alphabetical order




	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And Suspect or Subject or Involved Party Type
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the second User Data Page
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the second User Data Page
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
	And User enters Incident Start Date
		| Incident Start Date   |
		| <Incident Start Date> |

	And User enters Incident End Date
		| Incident End Date |
		| <Incident End>    |

	Then validate error message should be displayed
		| error message   |
		| <Error message> |
	When enter incidentStartDate , incidentEndDate  on the second User Data Page
		| incidentStartDate   | incidentEndDate   |
		| <incidentStartDate> | <incidentEndDate> |
	And enter state  and city  on the second User Data Page
		| State    | City    |
		| <state2> | <city2> |
	Then validate the  symbol is displayed in the amount field
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	And I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page

	#Primary Involved Party Information Page:
	
	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	#When Required CSS glow appears with correct configured color controlled in Admin.
	When i check the required fields current page
	When Is thisInvolved Party dropdown is selected  on the third User Data Page
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the fourth User Data Page
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |

	And enter InvolvedParty Designation
		| designation   |
		| <designation> |

	And i enter invalid date of birth
		| InvalidDOB   |
		| <InvalidDOB> |
	Then error message should be displayed
		| DOB validation error message   |
		| <DOB validation error message> |
	
	When SSN , licenseNumber , How witness or external party reported this ,any additional info ID Test
		| SSN   | licenseNumber   | involvedPartyType   | detectedAs   | ID Test   |
		| <SSN> | <licenseNumber> | <involvedPartyType> | <detectedAs> | <ID Test> |
	
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the fourth User Data Page
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the fourth User Data Page
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	And I enter the invalid zipcode for InvolvedParty
		| Invalid zipcode   |
		| <Invalid zipcode> |

	Then I validate the zip code error messgae
		| Zipcode validation error message   |
		| <Zipcode validation error message> |
	And verify Dropdown lists are in alphabetical order in Involved Party as provider
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | state2   | city2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <state2> | <city2> | <Zipcode> |
	And I enter the invalid email id for involvedparty as provider
		| Invalid email   |
		| <Invalid email> |

	Then I validate the error message is displayed for involvedparty as provider
		| Email validation error message   |
		| <Email validation error message> |
	When i enter invalid date of birth
		| InvalidDOB   |
		| <InvalidDOB> |
	
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And enter DOB
		| DOB   |
		| <DOB> |
	And I click on the Next button on the third User Data Page
	And I should be navigated to the Next Page

	# Additional Involved Party Information Page:

	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	And i check the required fields current page

	And is there anotherinvolved party dropdown is selected on the fourth User Data Page
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |


	#Questions Page:

	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	And i check the required fields current page

	And Questionone Is this a resubmission
		| Question1  |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button

	




Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | Incident Start Date | Incident End | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                           | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026          | 04/05/2026   | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | jayapradha.d@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2026 | Date cannot be in the future. |





	Scenario Outline: 02_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party as "Non-Enumerated Provider" along with Validation of all the required fields ]

# Submitting Party Information page:
	Given when I open the Online referral application
	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	And i check the required fields current page
	Then verify Dropdown lists are in alphabetical order
	When I enter the email  on the Initial User Data Page
		| Email address   |
		| <Email address> |

	And I enter the invalid email id
		| Invalid email   |
		| <Invalid email> |

	Then I validate the error messgae
		| Email validation error message   |
		| <Email validation error message> |

	When I enter the valid email id
		| Email address   |
		| <Email address> |
		
	Then I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |

	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |

	When I enter the invalid zipcode
		| Invalid zipcode   |
		| <Invalid zipcode> |

	Then I validate the zip code error messgae
		| Zipcode validation error message   |
		| <Zipcode validation error message> |

	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the Next Page

	# Referral page:
	And i check the required fields current page
	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	Then verify Dropdown lists are in alphabetical order




	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And Suspect or Subject or Involved Party Type
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the second User Data Page
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the second User Data Page
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
	And User enters Incident Start Date
		| Incident Start Date   |
		| <Incident Start Date> |

	And User enters Incident End Date
		| Incident End Date |
		| <Incident End>    |

	Then validate error message should be displayed
		| error message   |
		| <Error message> |
	When enter incidentStartDate , incidentEndDate  on the second User Data Page
		| incidentStartDate   | incidentEndDate   |
		| <incidentStartDate> | <incidentEndDate> |
	And enter state  and city  on the second User Data Page
		| State    | City    |
		| <state2> | <city2> |
	Then validate the  symbol is displayed in the amount field
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	And I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page

	#Primary Involved Party Information Page:
	
	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	#When Required CSS glow appears with correct configured color controlled in Admin.
	When i check the required fields current page
	When Is thisInvolved Party dropdown is selected  on the third User Data Page
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the fourth User Data Page
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |

	And enter InvolvedParty Designation
		| designation   |
		| <designation> |

	And i enter invalid date of birth
		| InvalidDOB   |
		| <InvalidDOB> |
	Then error message should be displayed
		| DOB validation error message   |
		| <DOB validation error message> |
	
	When SSN , licenseNumber , How witness or external party reported this ,any additional info ID Test
		| SSN   | licenseNumber   | involvedPartyType   | detectedAs   | ID Test   |
		| <SSN> | <licenseNumber> | <involvedPartyType> | <detectedAs> | <ID Test> |
	
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the fourth User Data Page
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the fourth User Data Page
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	And I enter the invalid zipcode for InvolvedParty
		| Invalid zipcode   |
		| <Invalid zipcode> |

	Then I validate the zip code error messgae
		| Zipcode validation error message   |
		| <Zipcode validation error message> |
	And verify Dropdown lists are in alphabetical order in Involved Party as provider
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | state2   | city2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <state2> | <city2> | <Zipcode> |
	And I enter the invalid email id for involvedparty as provider
		| Invalid email   |
		| <Invalid email> |

	Then I validate the error message is displayed for involvedparty as provider
		| Email validation error message   |
		| <Email validation error message> |
	When i enter invalid date of birth
		| InvalidDOB   |
		| <InvalidDOB> |
	
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And enter DOB
		| DOB   |
		| <DOB> |
	And I click on the Next button on the third User Data Page
	And I should be navigated to the Next Page

	# Additional Involved Party Information Page:

	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	And i check the required fields current page

	Then I select the another involved Party from the drop down menu
	| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
	| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	Then the following fields should be displayed:
	| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | StreetAddress3   | StreetAddress4   | City   | Zip   | Designation1   | Country   | PrimaryPhone   | SecondaryPhone   | Ssn   | OtherId   | Email1   | Other   |
	| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> | <StreetAddress3> | <StreetAddress4> | <City> | <Zip> | <Designation1> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <Ssn> | <OtherId> | <Email1> | <Other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
	| report1   | additionalInfo1 |
	| <report1> | <additionalInfo1> |
	And I continue with Involved Party Selection and proceed to the next page
	Then I Select the  another involved Party from the drop down menu as NO
	| isAnotherInvolvedPartyAvailable1   |
	| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	Then Logo should be visible
	And Logo should be aligned at the top center of the page
	When Required CSS glow appears with correct configured color controlled in Admin.
	And i check the required fields current page

	And Questionone Is this a resubmission
		| <Question1  |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button

	




Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | Incident Start Date | Incident End | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                           | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026          | 04/05/2026   | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | jayapradha.d@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2026 | Date cannot be in the future. |

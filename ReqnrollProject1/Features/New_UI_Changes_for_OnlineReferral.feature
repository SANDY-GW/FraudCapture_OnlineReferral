Feature: New UI Changes for Online Referral

Online referral End to End Scenarios


	
Scenario Outline: 01_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party selected as "No" along with Validation of all the required fields ]

  #Submitting Party Information page:
	Given when I open the Online referral application
	Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	When i check the required fields current page on the "<Sub Party Info >"
	And I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	And I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	And I enter the invalid zipcode and validate
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "<state dropdown>" on the page "<Sub Party Info>"
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	And i check the required fields current page on the "<Referral>"
	Then Validate header appears aligned and not distorted on the "<Referral>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
		| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
		| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |
	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
	Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	When I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	Then i enter invalid date of birth and validate for "<Involved Party>"
		| InvalidDOB   | DOB validation error message   |
		| <InvalidDOB> | <DOB validation error message> |
	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	Then I enter the invalid zipcode and validate for provider
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	And I enter the invalid email id  and validate for "<Involved Party>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
	Then I enter the invalid  fax  and validate for "<Involved Party>"
		| Invalidfax   | FaxValidationErrorMessage   |
		| <Invalidfax> | <FaxValidationErrorMessage> |
	When InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	When i check the required fields current page on the "<Add Inv Party>"
	And is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |
	
	#Questions Page:

	Then Validate header appears aligned and not distorted on the "<Questions>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	When i check the required fields current page on the "<Questions>"
	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |
	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | Invalidfax | FaxValidationErrorMessage                                    | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com |       1234 | Not valid, enter 10-digit number or use format 999-999-9999. | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




	# Primary Subject as "Provider" with different additional subject Types

Scenario Outline: 02_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party as "Non-Enumerated Member" along with Validation of all the required fields ]

 #Submitting Party Information page:
	Given when I open the Online referral application
	Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	When i check the required fields current page on the "<Sub Party Info >"
	And I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	And I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	And I enter the invalid zipcode and validate
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "<state dropdown>" on the page "<Sub Party Info>"
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	And i check the required fields current page on the "<Referral>"
	Then Validate header appears aligned and not distorted on the "<Referral>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
		| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
		| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |
	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
	Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	When I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	Then i enter invalid date of birth and validate for "<Involved Party>"
		| InvalidDOB   | DOB validation error message   |
		| <InvalidDOB> | <DOB validation error message> |
	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	Then I enter the invalid zipcode and validate for provider
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	And I enter the invalid email id  and validate for "<Involved Party>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
	Then I enter the invalid  fax  and validate for "<Involved Party>"
		| Invalidfax   | FaxValidationErrorMessage   |
		| <Invalidfax> | <FaxValidationErrorMessage> |
	When InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	And Validate header appears aligned and not distorted on the "<Questions>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | Invalidfax | FaxValidationErrorMessage                                    | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com |       1234 | Not valid, enter 10-digit number or use format 999-999-9999. | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | 12.1.25 Non enumerated Individual | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




	
Scenario Outline: 03_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party as "Member" along with Validation of all the required fields ]


 #Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |
	
	And enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	#	
	
	And InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |

	#And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	#And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	And enter DOB
		| DOB   |
		| <DOB> |
						
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |

	
	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page




Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Recipient w/ req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |






Scenario Outline: 04_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party as "Provider" along with Validation of all the required fields ]

 #Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType |
	#	| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	#
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation |
	#	| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |
	
	And enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
		
	
	And InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
#And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
#	And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	And enter DOB
		| DOB   |
		| <DOB> |
						
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |

	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Add Inv Party>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |

	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	
	And enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Add Inv Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Add Inv Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	
	And InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And enter DOB
		| DOB   |
		| <DOB> |

	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

	




Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                     | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Provider w Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



Scenario Outline: 05_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party as "Non-Enumerated Provider" along with Validation of all the required fields ]

 #Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |
	
	And enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
		
	
	And InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
#And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	#And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	And enter DOB
		| DOB   |
		| <DOB> |
						
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |


	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	
	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other
	
		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |
		
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <country> |

	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                        | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Caregiver w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 06_ [Online Referral End To End Scenario with Primary Subject Type as Provider and additional involved party as "Non-Enumerated Organization" along with Validation of all the required fields ]

 #Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
		| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
		| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |
	
	And enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
		
	
	And InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |

	#And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	#And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	And enter DOB
		| DOB   |
		| <DOB> |
						
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |

	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |



	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    | involvedPartyType | detectedAs   |
		| <NamePrefix> | <FirstName1> | <middle name> | <LastName1> | <Designation1> | <detectedAs>      | <detectedAs> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	When street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <FirstName1> | <middle name> | <LastName1> | <Designation1> |

	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



	###Subject Type as "Member with all possible additional involved parties" and validation of all the required fields

Scenario Outline: 07_[Online Referral End To End Scenario with Primary Subject Type as Member and additional involved party as "Provider" along with Validation of all the required fields ]

#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |

		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |


	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter  how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |

	And enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	When enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	
	
	And InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1 | Address2 | City | State2 | City2 | Zipcode |
#		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
#		And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
#	And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
#
#	Then I enter the invalid email id  and validate for "<Involved Party>"
#		| Invalid email   | Email validation error message   |
#		| <Invalid email> | <Email validation error message> |
	And enter DOB
		| DOB   |
		| <DOB> |
					
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	
	And I continue with Involved Party Selection and proceed to the next page
	
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button



	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

	



Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                     | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Provider w Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |







Scenario Outline: 08_[Online Referral End To End Scenario with Primary Subject Type as Member and additional involved party as "Non-Enumerated Member" along with Validation of all the required fields ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	#
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |


	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter  how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button

	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page



Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                   | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject-Lawyer w/ Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |

	




Scenario Outline: 09_[Online Referral End To End Scenario with Primary Subject Type as Member and additional involved party as "Member" along with Validation of all the required fields ]

#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |


	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter  how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |

	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	



	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page





Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Recipient w/ req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |


	
Scenario Outline: 10_[Online Referral End To End Scenario with Primary Subject Type as Member and additional involved party as "Non-Enumerated Provider" along with Validation of all the required fields ]
#Submitting Party Information page:
	
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |


	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter  how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |


	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	
	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other
	
		| designation   | DOB   | SSN   | involvedPartyType   | detectedAs   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <involvedPartyType> | <detectedAs> | <licenseNumber> | <otherID> | <other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |


	When enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <country> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page



Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                        | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Caregiver w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |





Scenario Outline: 11_[Online Referral End To End Scenario with Primary Subject Type as Member and additional involved party as "Non-Enumerated Organization" along with Validation of all the required fields ]

#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	And Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	And enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |


	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter  how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |


	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <FirstName1> | <middle name> | <LastName1> | <Designation1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |


	# Selecting the dropdown option as "No for Is this involved party an external referring party or witness? 

Scenario Outline: 12_[Online Referral End To End Scenario with Primary Subject Type as Member, involved party an external referring party or witness? as "No" and additional involved party as "No" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	When i check the required fields current page on the "<Sub Party Info >"
	And I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	And I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	And I enter the invalid zipcode and validate
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	 #Referral page:
	And i check the required fields current page on the "<Referral>"
	Then Validate header appears aligned and not distorted on the "<Referral>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
		| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
		| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	When I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter  how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |


	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	 #Additional Involved Party Information Page:

	Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	When i check the required fields current page on the "<Add Inv Party>"


	And is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |


	#Questions Page:

	Then Validate header appears aligned and not distorted on the "<Questions>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	#Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | No              | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 13_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Member, involved party an external referring party or witness? as "No" and additional involved party as "No" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	When i check the required fields current page on the "<Sub Party Info >"
	And I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	And I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	And I enter the invalid zipcode and validate
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	 #Referral page:
	And i check the required fields current page on the "<Referral>"
	Then Validate header appears aligned and not distorted on the "<Referral>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
		| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
		| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	When I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"


	 #Additional Involved Party Information Page:

	Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	When i check the required fields current page on the "<Add Inv Party>"


	And is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |


	#Questions Page:

	Then Validate header appears aligned and not distorted on the "<Questions>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	#Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page
	




Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | 12.1.25 Non enumerated Individual |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | No              | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  |



Scenario Outline: 14_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Provider, involved party an external referring party or witness? as "No" and additional involved party as "No" ]

Submitting Party Information page:
	Given when I open the Online referral application
	Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	When i check the required fields current page on the "<Sub Party Info >"
	And I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	And I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	And I enter the invalid zipcode and validate
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	 #Referral page:
	And i check the required fields current page on the "<Referral>"
	Then Validate header appears aligned and not distorted on the "<Referral>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
		| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
		| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	When I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	
	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other
	
		| designation   | DOB   | SSN   | involvedPartyType   | detectedAs   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <involvedPartyType> | <detectedAs> | <licenseNumber> | <otherID> | <other> |
	And enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	 #Additional Involved Party Information Page:

	Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	When is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |


	#Questions Page:

	Then Validate header appears aligned and not distorted on the "<Questions>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	#Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page
	




Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                  | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Caregiver w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | No              | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |






Scenario Outline: 15_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization, involved party an external referring party or witness? as "No" and additional involved party as "No" ]
Submitting Party Information page:
	Given when I open the Online referral application
	Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	When i check the required fields current page on the "<Sub Party Info >"
	And I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	And I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	And I enter the invalid zipcode and validate
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	When I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	 #Referral page:
	And i check the required fields current page on the "<Referral>"
	Then Validate header appears aligned and not distorted on the "<Referral>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
		| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
		| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
		| Dollar symbol in amount field validation message   |
		| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	When I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	Then Validate header appears aligned and not distorted on the "<Involved Party>"
	
	When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation

		| NamePrefix   | FirstName1   | middle name   | LastName1   | Designation1   |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <Designation1> |
	And enter  how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
		

	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	 #Additional Involved Party Information Page:

	Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	When i check the required fields current page on the "<Add Inv Party>"


	And is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |


	#Questions Page:

	Then Validate header appears aligned and not distorted on the "<Questions>"
	And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	#Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

	
Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Law Firm w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | No              | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 16_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Member" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <Designation1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |


	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	When enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Law Firm w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Recipient w/ req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 17_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Provider" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |
	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <Designation1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |
	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	
	
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	#	And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	#And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                     | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Law Firm w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Provider w Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 18_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Non-Enumertaed Provider" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <Designation1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |
	
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |

	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page



Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                        | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Law Firm w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Caregiver w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 19_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Non-Enumertaed Member" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <Designation1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button

	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                   | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Law Firm w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject-Lawyer w/ Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 20_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Non-Enumertaed Organization" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <Designation1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation

		| NamePrefix   | FirstName1   | middle name   | LastName1   | Designation1   |
		| <NamePrefix> | <FirstName1> | <middle name> | <LastName1> | <Designation1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	

	When street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Law Firm w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



	### Primary Subject Type as Non-Enumerated Provider
	
Scenario Outline: 21_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated provider with additional party type as "Member" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <first name> | <MiddleName1> | <last name> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |

	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |


	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page
	


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                  | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Caregiver w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Recipient w/ req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |





Scenario Outline: 22_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Provider" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |

	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "<Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>""
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |

	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	When enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	
	
		
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	#Then verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	#And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
	#Then I enter the invalid  fax  and validate for "<Involved Party>"
	#	| Invalidfax   | FaxValidationErrorMessage   |
	#	| <Invalidfax> | <FaxValidationErrorMessage> |
	When InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                  | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                     | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Caregiver w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Provider w Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 23_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Non-Enumertaed Provider" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |

	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |
	
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |


	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:

	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                  | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                        | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Caregiver w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Caregiver w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 24_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Non-Enumertaed Member" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"

	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |

	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                  | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                   | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Caregiver w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject-Lawyer w/ Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



Scenario Outline: 25_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization with additional party type as "Non-Enumertaed Organization" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"

	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |

	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation

		| NamePrefix   | FirstName1   | middle name   | LastName1   | Designation1   |
		| <NamePrefix> | <FirstName1> | <middle name> | <LastName1> | <Designation1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                  | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Caregiver w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |

	## Primary Subject Type as Non-Enumerated Member 

Scenario Outline: 26_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Member with additional party type as "Member" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
	#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"

	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	And InvolvedParty Primary phoneNo ,  Secondary phone number  and email address
		| PrimaryPhone   | SecondaryPhone   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <Email address> |

	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page
	




Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                             | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject-Lawyer w/ Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Recipient w/ req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |





Scenario Outline: 27_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Member with additional party type as "Provider" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |

	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	When enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	#	And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	#And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
					
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                             | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                     | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject-Lawyer w/ Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Provider w Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



Scenario Outline: 28_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Member with additional party type as "Non-Enumertaed Provider" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other
		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:

	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                             | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                        | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject-Lawyer w/ Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Caregiver w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 29_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Member with additional party type as "Non-Enumertaed Member" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                             | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                   | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject-Lawyer w/ Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject-Lawyer w/ Req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



Scenario Outline: 30_[Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Member with additional party type as "Non-Enumertaed Organization" ]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |
	And enter how witness or external party reported this, any additional info
		| InvolvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| NamePrefix   | FirstName1   | middle name   | LastName1   | Designation1   |
		| <NamePrefix> | <FirstName1> | <middle name> | <LastName1> | <Designation1> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	When street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zip> | <Country> | <fax> | <Email address> |
	And I continue with Involved Party Selection and proceed to the next page
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                             | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject-Lawyer w/ Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |

	#Adding the Primary SubjectType as a  "Provider" and Editing the Primary Subject Type 


Scenario Outline: 31_ [Online Referral End To End Scenario with Primary Subject Type as Provider and Editing the Primary Subject Type]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Party>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |

	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |

	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	
	
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
#And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
#	And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
#
#	Then I enter the invalid email id  and validate for "<Involved Party>"
#		| Invalid email   | Email validation error message   |
#		| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
					
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"


	# Additional Involved Party Information Page:
	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"


	And Edit Primary InvovePartyType,Change the data and save the changes
		| updatedOrgname   |
		| <updatedOrgname> |

	Then Validate the updated data of the Primary Subject type
		| updatedOrgname   |
		| <updatedOrgname> |

	When is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |


	#Questions Page:

	#Then Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | updatedOrgname        | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Gainwell Technologies | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



Scenario Outline: 32_ [Online Referral End To End Scenario with Primary Subject Type as Member and Editing the Primary Subject Type]
#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix
		| name prefix  | first name   | middle name   | last name   | name suffix  |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |
	And enter InvolvedParty DOB , Gender , other
		| DOB   | Gender   | other   |
		| <DOB> | <Gender> | <other> |
	And enter how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID
		| other   | SSN   | medicaid ID   | Medicare ID   | otherID   |
		| <other> | <SSN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty plan , Program  ,LOB  and Group
		| planType   | Program   | LOB   | Group   |
		| <planType> | <Program> | <LOB> | <Group> |

	And InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code
		| Address1   | Address2   | City   | state2   | city2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <state2> | <city2> | <Zipcode> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"


	# Additional Involved Party Information Page:
	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And Edit Primary InvovePartyType,Change the data and save the changes
		| updatedOrgname   |
		| <updatedOrgname> |
	Then Validate the updated data of the Primary Subject type
		| updatedOrgname   |
		| <updatedOrgname> |
	When is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |

	#Questions Page:

	#Then Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | updatedOrgname        | updatedFirstName | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Recipient w/ req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Gainwell Technologies | FN101            | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |





Scenario Outline: 33_ [Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Provider and Editing the Primary Subject Type]

#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> |

	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other

		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |
	And enter how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | state2   | city2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <state2> | <city2> | <Zipcode> | <country> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"


	# Additional Involved Party Information Page:
	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And Edit Primary InvovePartyType,Change the data and save the changes
		| updatedOrgname   |
		| <updatedOrgname> |
	Then Validate the updated data of the Primary Subject type
		| updatedOrgname   |
		| <updatedOrgname> |
	When is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |

	#Questions Page:

	#Then Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed
	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page

Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                  | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | updatedOrgname        | updatedFirstName | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Caregiver w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Gainwell Technologies | FN101            | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |




Scenario Outline: 34_ [Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Member and Editing the Primary Subject Type]

#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	#
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |

	And the following fields should be displayed:
		| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | Designation1   | DOB   | Ssn   | OtherId   | Other   | StreetAddress3   | StreetAddress4   | City   | State2   | City2   | Zip   | Country   | PrimaryPhone   | SecondaryPhone   | OtherId   | Email1   |
		| <Organization1> | <NamePrefix> | <first name> | <middle name> | <last name> | <NameSuffix> | <Designation1> | <DOB> | <Ssn> | <OtherId> | <Other> | <StreetAddress3> | <StreetAddress4> | <City> | <State2> | <City2> | <Zip> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <OtherId> | <Email1> |

	And enter  how witness or external party reported this, any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"


	# Additional Involved Party Information Page:
	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And Edit Primary InvovePartyType,Change the data and save the changes
		| updatedOrgname   |
		| <updatedOrgname> |
	Then Validate the updated data of the Primary Subject type
		| updatedOrgname   |
		| <updatedOrgname> |
	When is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |

	#Questions Page:

	#Then Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page
	
Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | updatedOrgname        | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | 12.1.25 Non enumerated Individual |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2026 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Gainwell organization | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |





Scenario Outline: 35_ [Online Referral End To End Scenario with Primary Subject Type as Non-Enumerated Organization and Editing the Primary Subject Type]

	#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |
	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID
		| orgname   | TIN   | licenseNumber   | other   | otherID   |
		| <orgname> | <TIN> | <licenseNumber> | <other> | <otherID> |

	And enter nameprefix,firstname, middlename, lastname, designation
		| name prefix  | first name   | middle name   | last name   | designation    |
		| <NamePrefix> | <first name> | <middle name> | <last name> | <Designation1> |

	And street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party
		| Address1   | Address2   | City   | state2   | city2   | Zip   | Country   | fax   | Email address   |
		| <Address1> | <Address2> | <City> | <state2> | <city2> | <Zip> | <Country> | <fax> | <Email address> |

	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"


	# Additional Involved Party Information Page:
	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And Edit Primary InvovePartyType,Change the data and save the changes
		| updatedOrgname   |
		| <updatedOrgname> |
	Then Validate the updated data of the Primary Subject type
		| updatedOrgname   |
		| <updatedOrgname> |
	When is there anotherinvolved party dropdown is selected on the "<Add Inv Party>"
		| Is there any Involved Party Dropdown   |
		| <Is there any Involved Party Dropdown> |

	#Questions Page:

	#Then Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	And Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page
	
Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                                 | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | updatedOrgname        | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Law Firm w/o req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | No              | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | No                              | Involved Party Type - Associated Subject- Law Firm w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Gainwell Organization | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |






	# Editing Additional Subject Type



Scenario Outline: 36_ [Online Referral End To End Scenario with editing additional involved party Primary Subject Type as Provider and additional involved party as "Non-Enumerated Provider" along with Validation of all the required fields ]

#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
		#And verify county Dropdown lists are in alphabetical order for referral page "<CountyDrodown>" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	#Then i enter invalid date of birth and validate for "<Involved Party>"
	#	| InvalidDOB   | DOB validation error message   |
	#	| <InvalidDOB> | <DOB validation error message> |
	
	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	#Then I enter the invalid zipcode and validate for provider
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
		
	
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	#	And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	#And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	#Then I enter the invalid email id  and validate for "<Involved Party>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other
		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |
	And I continue with Involved Party Selection and proceed to the next page
	And Edit additionalInvolvedPartyType for non-Enumerated provider,Change the data and save the changes
		| updatedOrgname   |
		| <updatedOrgname> |
	Then Validate the updated data of the additional involved party Subject type as non-enumerated provider
		| updatedOrgname   |
		| <updatedOrgname> |
	When I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed



Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                        | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | updatedOrgname        | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Caregiver w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Gainwell Organization | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |



	# Deleting Additional Subject Type



Scenario Outline: 37_ [Online Referral End To End Scenario with deleting additional involved party Primary Subject Type as Provider and additional involved party as "Non-Enumerated Provider" along with Validation of all the required fields ]

#Submitting Party Information page:
	Given when I open the Online referral application
	#Then Validate header appears aligned and not distorted on the "<Sub Party Info>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Sub Party Info>"
	#When i check the required fields current page on the "<Sub Party Info >"
	#When I enter the invalid email id and validate for "Email validation error message under <Sub Party Info>"
	#	| Invalid email   | Email validation error message   |
	#	| <Invalid email> | <Email validation error message> |
	When I enter the email  on the "<Sub Party Info>"
		| Email address   |
		| <Email address> |
	And I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page
		| UserFirstName   | UserLastName   | Org name   | title   |
		| <UserFirstName> | <UserLastName> | <Org name> | <title> |
	And I enter the Phone number on the Initial User Data Page
		| Phone number   |
		| <Phone number> |
	#And I enter the invalid zipcode and validate
	#	| Invalid zipcode   | Zipcode validation error message   |
	#	| <Invalid zipcode> | <Zipcode validation error message> |
	And I enter Address section yon the Initial User Data Page
		| Address1   | Address2   | City   | State   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State> | <Zipcode> |
		#Then verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Sub Party Info>"
	And I click on the emailverification button on the Initial User Data Page
	And I should be navigated to the "Referral Details page"

	# Referral page:
	#And i check the required fields current page on the "<Referral>"
	#Then Validate header appears aligned and not distorted on the "<Referral>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Referral>"
	#And verify  referral Dropdown lists are in alphabetical order "<referralDropdown>" on the page "<Referral>"
	When Referral Type is selected  on the second User Data Page
		| referralType   |
		| <referralType> |
	#And enter invalid incidentStartDate , incidentEndDate and validate the error message  on the "<Referral>"
	#	| InvalidIncidentStartDate   | InvalidIncidentEndDate   |
	#	| <InvalidIncidentStartDate> | <InvalidIncidentEndDate> |

	And Suspect or Subject or Involved Party Type dropdown is selected  on the "<Referral>"
		| involvedPartyType   |
		| <involvedPartyType> |
	And enter case or reference number  on the "<Referral>"
		| caseOrReferenceNumber   |
		| <caseOrReferenceNumber> |
	And How was this detected  ,please provide  a Summary of this referral  on the "<Referral>"
		| detectedAs   | summary   |
		| <detectedAs> | <summary> |
	And enter Amount ,detectiondate
		| amount   | detectionDate   |
		| <amount> | <detectionDate> |
			
	#Then validate the  dollar symbol is displayed in the amount field on the "<Referral>"
	#	| Dollar symbol in amount field validation message   |
	#	| <Dollar symbol in amount field validation message> |
	When enter valid incidentStartDate , incidentEndDate  on the "<Referral>"
		| incidentValidStartDate   | incidentValidEndDate   |
		| <incidentValidStartDate> | <incidentValidEndDate> |
	And enter state  and city  on the "<Referral>"
		| State2   | City2   |
		| <State2> | <City2> |
		#And verify Dropdown lists are in alphabetical order "state dropdown" on the page "<Referral>"
	And I click on the Next button on the "<Referral>"
	And I should be navigated to the "<Involved Party>"
	#Primary Involved Party Information Page:
	
	#Then Validate header appears aligned and not distorted on the "<Involved Party>"
	#When i check the required fields current page on the "<Involved Party>"
	And Is thisInvolved Party dropdown is selected  on the "<Involved Party>"
		| witnessDropdown   |
		| <witnessDropdown> |
	And enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the "<Involved Parties page>"
		| orgname   | name prefix   | first name   | middle name   | last name   | name suffix   |
		| <orgname> | <name prefix> | <first name> | <middle name> | <last name> | <name suffix> |
	And enter InvolvedParty Designation
		| designation   |
		| <designation> |
	Then i enter invalid date of birth and validate for "<Involved Party>"
		| InvalidDOB   | DOB validation error message   |
		| <InvalidDOB> | <DOB validation error message> |
	
	When enter SSN , licenseNumber ,ID Test
		| SSN   | licenseNumber   | ID Test   |
		| <SSN> | <licenseNumber> | <ID Test> |
	And enter How witness or external party reported this ,any additional info
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	And enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the "<Involved Party>"
		| NPI   | TIN   | medicaid ID   | Medicare ID   | otherID   |
		| <NPI> | <TIN> | <medicaid ID> | <Medicare ID> | <otherID> |
	And enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the "<Involved Party>"
		| provider type   | provider specialty   | Taxonomy   | other   |
		| <provider type> | <provider specialty> | <Taxonomy> | <other> |
	Then I enter the invalid zipcode and validate for provider
		| Invalid zipcode   | Zipcode validation error message   |
		| <Invalid zipcode> | <Zipcode validation error message> |
		
	And verify Dropdown lists are in alphabetical order "<stateDropdown>" on the "<Involved Party>" in involved party page
	And verify county Dropdown lists are in alphabetical order "<CountyDropdown>" on the page "<Involved Party>"
	When InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> |
	Then I enter the invalid email id  and validate for "<Involved Party>"
		| Invalid email   | Email validation error message   |
		| <Invalid email> | <Email validation error message> |
	When enter DOB
		| DOB   |
		| <DOB> |
	And InvolvedParty country,  phone number , fax  and email address
		| country   | Phone number   | fax   | Email address   |
		| <country> | <Phone number> | <fax> | <Email address> |
	And I click on the continue button on the "<Involved Party>"
	And I should be navigated to the "< Add Inv Party>"

	# Additional Involved Party Information Page:

	#Then Validate header appears aligned and not distorted on the "<Add Inv Party>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Add Inv Party>"
	#When i check the required fields current page on the "<Add Inv Party>"
	And I select the another involved Party from the drop down menu
		| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
		| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	And enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix
		| orgname         | name prefix  | first name   | middle name   | last name   | name suffix  |
		| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> |
	And enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other
		| designation   | DOB   | SSN   | licenseNumber   | otherID   | other   |
		| <designation> | <DOB> | <SSN> | <licenseNumber> | <otherID> | <other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
		| involvedPartyType   | detectedAs   |
		| <involvedPartyType> | <detectedAs> |
	When enter primary phone number ,secondary phone number , fax aand email address  for the involved party
		| PrimaryPhone   | SecondaryPhone   | fax   | Email address   |
		| <PrimaryPhone> | <SecondaryPhone> | <fax> | <Email address> |
	And street address line one , street address line two, city , state , county , zip code and country for the involved party
		| Address1   | Address2   | City   | State2   | City2   | Zipcode   | Country   |
		| <Address1> | <Address2> | <City> | <State2> | <City2> | <Zipcode> | <Country> |
	And I continue with Involved Party Selection and proceed to the next page
	And Delete additionalInvolvedPartyType
	And I Select the  another involved Party from the drop down menu as NO
		| isAnotherInvolvedPartyAvailable1   |
		| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button


	#Questions Page:

	#And Validate header appears aligned and not distorted on the "<Questions>"
	#And Required CSS glow appears with correct configured color controlled in Admin "<Questions>"
	#When i check the required fields current page on the "<Questions>"

	When Questionone Is this a resubmission
		| Question1   |
		| <Question1> |

	And Questiontwo, QuestionThree
		| Question2   | Question3   |
		| <Question2> | <Question3> |
	And then uploading a file using file path
		| TestFile   |
		| <TestFile> |
	Then click on proceed to next session button
	When Click on Submit Button
	Then validate Enter New Referral is displayed


	##Lead is created 
	Given when I open the fraud capture  application
	When I enter the user email id  on the welcome fraude capture page
		| UserEmailID   |
		| <UserEmailID> |
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I select the payor
		| Payor   |
		| <Payor> |
	And I click on CaseTracking and select the leads tab option on the fraud capture home page
		| Leads   |
		| <Leads> |
	And I Verify first and Last Name and click on the Latest created lead
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And get the lead creation date
	And click on Activities tab and serach for the activity created through onlinereferral
		| ActivityName   |
		| <ActivityName> |
	Then the searched activity should be displayed in the activity list
		| ActivityName   |
		| <ActivityName> |
	And get the Activitydate created through online
	And verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity
	When user clicks on Edit button for an existing activity
		| ActivityName   |
		| <ActivityName> |
	Then Edit Activity page should be displayed
	And click on Attachment tab
	And verify summary, confirmation and test files are displayed

	When I click Logout Option to close the Fraud Capture Application
	Then I should ne navigated to FC Logout confirmation Page


Examples:
	| Invalid zipcode | Zipcode validation error message                                   | Invalid email | Email validation error message                  | UserFirstName | UserLastName | Email address                             | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | InvalidIncidentStartDate | InvalidIncidentEndDate | Error message                                                                                | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentValidStartDate | incidentValidEndDate | State2 | City2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | orgname | name prefix | first name | middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate | TestFile     | Is there any Involved Party Dropdown | UserEmailID                               | ActivityName                                                  | DollarsymbolinAmountFieldValidationMessage | InvalidDOB | DOB validation error message  | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                        | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City1 | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | Gender | Program | LOB  | Group  | County | updatedOrgname        | Sub Party Info                    | Referral              | Involved Party        | Add Inv Party                    | Questions      | Payor | Leads |
	|            1234 | Not valid, use 5 or 9 digits or numbers in this format 12345-1234. | abc           | Enter a valid email. Example: email@address.com | UserFName     | UserLastName | Sandeep.Krishnan@gainwelltechnologies.com |   9999999999 | MCO Example 1- Mapped to Enrollment Department | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | Texas |   75035 | 04/10/2026               | 04/05/2026             | Date cannot be in the future or Incident End Date cannot be prior to the Incident Start Date | Referral Type 1- Mapped to Dbl billing w/ distribution | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026             | 02/13/2026           | Texas  | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS     | Mr          | UserFN     | MN          | UserLN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        | Test      | No        | Test      | Texas           | TestFile.txt | No                                   | Sandeep.Krishnan@gainwelltechnologies.com | Test Lead Testing - Automated Only Activity 1 (Lead Creation) | $                                          | 06/26/2028 | Date cannot be in the future. | Yes                             | Involved Party Type - Associated Subject- Caregiver w/o req fields | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | female | Program | LOB1 | Group1 | Texas  | Gainwell Organization | Submitting Party Information Page | Referral Details page | Involved Parties page | Additional Involved Parties page | Questions page | DEMO  | Leads |


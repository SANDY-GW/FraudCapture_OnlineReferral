Feature: InitialUserDataPage

Online referral End to End Scenarios




	



Scenario Outline: [Enter entire online referral scenario]
	Given when I open the Online referral application
	And I enter the email as "<Email address>" on the Initial User Data Page
	And I enter the userFN as "<UserFirstName>",User lastname as "<UserLastName>",Org name as "<Org name>",title as "<title>"  filled on the Initial User Data Page
	And I enter the Phone number as "<Phone number>" on the Initial User Data Page
	And I enter the "<Address1>","<Address2>","<City>","<State>","<Zipcode>", filled in the Address section yon the Initial User Data Page
	When I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page
	
	When Referral Type is selected as "<referralType>" on the second User Data Page
	And Suspect or Subject or Involved Party Type as "<involvedPartyType>"
	Then enter case or reference number as "<caseOrReferenceNumber>" on the second User Data Page
	And How was this detected as"<detectedAs>" ,please provide  a Summary of this referral as "<summary>" on the second User Data Page
	And enter Amount "<amount>",detectiondate "<detectionDate>", incidentStartDate "<incidentStartDate>", incidentEndDate "<incidentEndDate>" on the second User Data Page
	And enter state as "<state2>" and city as "<city2>" on the second User Data Page
	When I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page

	When was there a witness or external referring party dropdown is selected as "<witnessDropdown>" on the third User Data Page
	Then enter ReferralFN,ReferralLN, Orgname as "<referralFN>","<referralLN>","Gainwell" on the third User Data Page
	And referral party relationship to the involved party is selected as "<referralRelationship>" on the third User Data Page
	And enter Referral party email and phone number as "<Email address >","< Phone number>" on the third User Data Page
	And street_Address_lineone as "<Address1 >", street_Address_linetwo as "<Address2 >", city as ,"<City >", state as "<State>" and zip code as "<Zipcode>" on the third User Data Page
	When I click on the Next button on the fouth User Data Page
	When I should be navigated to the Next Page

	And enter associated orgname as "<associated orgname>", name prefix as "<name prefix>", associated party first name as "<associated party first name>",associated party middle name as "<associated party middle name>", associated party last name as "<associated party last name>" and name suffix as "<name suffix>" on the fourth User Data Page
	And enter designation as "<designation>",DOB as "<DOB>", SSN as "<SSN>", licenseNumber as "<licenseNumber>", ID Test as "<ID Test>"
	And enter NPI as "<NPI>", TIN as "<TIN>",medicaid ID as "<medicaid ID>",Medicare ID as "<Medicare ID>", otherID as "<otherID>" on the fourth User Data Page
	And enter provider type as "<provider type>", provider specialty as "<provider specialty >",Taxonomy as "<Taxonomy>" and other as "<other>" on the fourth User Data Page
	And street_Address_lineone as "<Address1>", street_Address_linetwo as "<Address2>", city as ,"<City>", state as "<associatedstate>" , county as "<city2>" and zip code as "<Zipcode>"
	And country as "<country>",  phone number as "<Phone number>", fax as "<fax>" and email address as "<Email address>"
	When I click on the Next button on the Initial User Data Page
	When I should be navigated to the Next Page

	When Does this rederral involve a specific member is selected as "<rederral involve a specific member dropdown >"
	And Is the member the same person as the witness or external referring party? is selected as "<Is the member the same person as the witness or external referring party?>"
	And I click on the Next button on the Initial User Data Page
	And Enter FN,LN,memberID and DOB as "<FN>","<LN>","<memberID>","<Phone number>","<DOB>"
	And Enter planType as "<planType>", Phone number as "<Phone number>", email as "<Email address >"
	And street_Address_lineone as "<Address1>", street_Address_linetwo as "<Address2>", city as ,"<City>", state as "<State>" , county as "<city2>" , zip code as "<Zipcode>" and country as "United States"
	And I click on the Next button on the fifth User Data Page
	When I should be navigated to the Next Page

	
	When Questionone Is this a resubmission as "<Question1>"
	And Questiontwo as "Question2", QuestionThree as "<Question3>", Questionfour as "<Question4>", Questionfive as "<Question5>", Questionsix as "<Question6>"
	Then submitting a referral

	Given when I open the fraud capture  application
	When I enter the "<UserEmailID>" on the welcome fraude capture page
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I Verify first and Last Name and click on the Latest created lead
	#And I click on the Lead tab on the fraud capture Page
	#And  I Filter the created date on the fraud capture Page
	#And  I verify  FirstAndLastName  on the fraud capture Page
	#And I click on the leadid link on the fraud capture Lead table Page
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And I click on the Activities and selected lead activity name as "<ActivityName>" on the fraud capture Lead detials Page
	Then I should be navigated to Lead Activities  Page



Examples:
	| UserFirstName | UserLastName | Email address                         | Phone number | Org name                                       | title   | Address1           | Address2    | City   | State | Zipcode | referralType                                           | involvedPartyType                                               | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      | associated orgname | name prefix | associated party first name | associated party middle name | associated party last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate |UserEmailID                               | ActivityName                                    |
	| UserFName     | UserLastName | jayapradha.d@gainwelltechnologies.com |   9999999999 |MCO Example 1- Mapped to Enrollment Department  | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | TX    |   75035 |Referral Type 1- Mapped to Dbl billing w/ distribution  | Involved Party Type - Associated Subject- Provider w Req fields |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | TX     | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS                | Mr          | TestAssociatedPartyFN       | TestAssociatedPartyMN        | TestAssociatedPartyLN      | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        |  Test     | No        | Test      | Texas           |Sandeep.krishnan@gainwelltechnologies.com | 02242026-Lead Activity 1-Auto Close on Creation |


	


Scenario Outline: [Enter fraudcapture user data]
	Given when I open the fraud capture  application
	When I enter the "<UserEmailID>" on the welcome fraude capture page
	And I click on the Procced to login button on the welcome fraude capture page
	And I click on the I Agree button on the fraud capture Page
	And I Verify first and Last Name on the Latest created lead
	#And I click on the Lead tab on the fraud capture Page
	#And  I Filter the created date on the fraud capture Page
	#And  I verify  FirstAndLastName  on the fraud capture Page
	And I click on the leadid link on the fraud capture Lead table Page
	And I click on the Begin Editing on the fraud capture Lead detials Page
	And I click on the Activities and selected lead activity name as "<ActivityName>" on the fraud capture Lead detials Page
	Then I should be navigated to Lead Activities  Page
	
	Examples: 
| UserEmailID                               | ActivityName                                    |
| Sandeep.krishnan@gainwelltechnologies.com | 02242026-Lead Activity 1-Auto Close on Creation |

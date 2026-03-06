Feature: New UI Changes for Online Referral

Online referral End to End Scenarios




	
Scenario Outline: [Verify that the user is able to see the new UI changes for online referral]
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

	When Is thisInvolved Party dropdown is selected as "<witnessDropdown>" on the third User Data Page
	And enter InvolvedParty orgname as "<associated orgname>", name prefix as "<name prefix>", associated party first name as "<associated party first name>",associated party middle name as "<associated party middle name>", associated party last name as "<associated party last name>" and name suffix as "<name suffix>" on the fourth User Data Page
	And enter InvolvedParty Designation as "<designation>",DOB as "<DOB>", SSN as "<SSN>", licenseNumber as "<licenseNumber>", How witness or external party reported this as "<involvedPartyType>",any additional info as "<detectedAs>" ID Test as "<ID Test>"
	And enter InvolvedParty NPI as "<NPI>", TIN as "<TIN>",medicaid ID as "<medicaid ID>",Medicare ID as "<Medicare ID>", otherID as "<otherID>" on the fourth User Data Page
	And enter InvolvedParty provider type as "<provider type>", provider specialty as "<provider specialty >",Taxonomy as "<Taxonomy>" and other as "<other>" on the fourth User Data Page
	And InvolvedParty street_Address_lineone as "<Address1>", street_Address_linetwo as "<Address2>", city as ,"<City>", state as "<associatedstate>" , county as "<city2>" and zip code as "<Zipcode>"
	And InvolvedParty country as "United States",  phone number as " 9999999999", fax as "8888888888" and email address as "jayapradha.d@gainwelltechnologies.com"
	When I click on the Next button on the third User Data Page
	When I should be navigated to the Next Page

	And is there anotherinvolved party dropdown is selected as "No" on the fourth User Data Page	

	
	When Questionone Is this a resubmission as "<Question1>"
	And Questiontwo as "Question2", QuestionThree as "<Question3>", Questionfour as "<Question4>", Questionfive as "<Question5>", Questionsix as "<Question6>"
	And then uploading a file using file path as "C:/Users/jd/SourceQaDevelopment/Repos/FraudCapture_OnlineReferral/ReqnrollProject1/Attachments/TestFile.txt"
	Then click on proceed to next session button

	#Then submitting a referral

	Examples:
	| UserFirstName | UserLastName | Email address                         | Phone number | Org name                    | title   | Address1           | Address2    | City   | State | Zipcode | referralType                               | involvedPartyType       | caseOrReferenceNumber | detectedAs   | summary        | amount       | detectionDate | incidentStartDate | incidentEndDate | state2 | city2      | witnessDropdown | referralFN     | referralLN     | referralOrgname | referralRelationship                                                                      |  orgname           | name prefix | first name |  middle name | last name | name suffix | designation     | SSN         | licenseNumber | ID Test    | NPI        | TIN        | medicaid ID | Medicare ID | otherID    | provider type                                         | provider specialty                                         | Taxonomy | other | country       | fax        | rederral involve a specific member dropdown | Is the member the same person as the witness or external referring party? | FN       | LN       | memberID | DOB        | planType | Question1 | Question2 | Question3 | Question4 | Question5 | Question6 | associatedstate |
	| UserFName     | UserLastName | jayapradha.d@gainwelltechnologies.com |   9999999999 |  Referring Source 1         | QA_Test | 5615 High Point Dr | Unit 151029 | Irving | TX    |   75035 | Referral Type 1 - w/ Distribution Email    |  Enumerated Provider    |             123456789 | Tested by QA | TestAutomation | 999999999.99 | 02/13/2026    | 02/13/2026        | 02/13/2026      | TX     | Washington | Yes             | TestReferralFN | TestReferralLN | Gainwell        | Referral party relationship to the involved party - Mapped to Dbl billing w/ distribution | HMS                | Mr          | FN         | MN           |     LN    | Jr          | TestDesignation | 123-45-6789 |    1234567890 | 1234567890 | 1234567890 | 12-3456789 |  1234567890 |  1234567890 | 1234567890 | Provider Type - Mapped to Dbl billing w/ distribution | Provider Specialty - Mapped to Dbl billing w/ distribution | Tester   | Test  | United States | 8888888888 | Yes                                         | No                                                                        | MemberFN | MemberLN |  1234567 | 02/13/1990 | Test     | No        | Test      | No        |  Test     | No        | Test      | Texas           |
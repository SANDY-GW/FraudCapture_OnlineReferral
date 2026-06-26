Feature: Online Referral New UI Changes 

Scenario Outline: Online Referral with IP-Involved Party Type-Associated Subject-Caregiver w/o req fields and AIP-12.1.25 Non enumerated Individual
	Given when I open the Online referral application
	When i check the required fields in the "Submitting Party Information"
	When Required CSS glow appears with correct configured color controlled in Admin
	And I filling the mandatory fileds details on the Initial User Data Page
	| FirstName   | LastName   | Email   | Organization   | StreetAddress1   |
	| <FirstName> | <LastName> | <Email> | <Organization> | <StreetAddress1> |
	Then verify Dropdown lists are in alphabetical order
	Then select the StateName from the dropdown
	| StateName   |
	| <StateName> |
	Then Proceed to Email Address Verification
	And I validate the Captcha for the email address verification page
	And I select the referralType and InvolvedPartyType from the dropdown
	| RefType   | InvolvedPartyType   |
	| <RefType> | <InvolvedPartyType> |
	Then I Enter the Text for How was this detected? 
	| Detected   |
	| <Detected> |
	Then I Enter the Text for Please Provide a Summary of this Referral for the referral details page
	| ReferralSummary   |
	| <ReferralSummary> |
	And I click Next step to Proceed to the next page
	Then I select involved party an external referring party or witness?
	| witness_Or_ExternalReferringParty   |
	| <witness_Or_ExternalReferringParty> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field
	| report   | additionalInfo |
	| <report> | <additionalInfo> |
	And I click "Next" Continue with Involved Party Selection button to proceed
	Then I select the another involved Party from the drop down menu
	| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
	| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	Then the following fields should be displayed:
	| Organization1   | NamePrefix   | FirstName1   | MiddleName1   | LastName1   | NameSuffix   | StreetAddress3   | StreetAddress4   | City   | State   | County   | Zip   | Designation1   | Country   | PrimaryPhone   | SecondaryPhone   | Ssn   | OtherId   | Email1   | Other   |
	| <Organization1> | <NamePrefix> | <FirstName1> | <MiddleName1> | <LastName1> | <NameSuffix> | <StreetAddress3> | <StreetAddress4> | <City> | <State> | <County> | <Zip> | <Designation1> | <Country> | <PrimaryPhone> | <SecondaryPhone> | <Ssn> | <OtherId> | <Email1> | <Other> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
	| report1   | additionalInfo1 |
	| <report1> | <additionalInfo1> |
	And I continue with Involved Party Selection and proceed to the next page
	Then I Select the  another involved Party from the drop down menu as NO
	| isAnotherInvolvedPartyAvailable1   |
	| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	And I Select the Entering into the Questions and Attachments Section and answer the questions
	| question1   | question2   | question3   | question4   | question5   | question6   |
	| <question1> | <question2> | <question3> | <question4> | <question5> | <question6> |
	Then I add the Attachments with the help of Uploading the files and providing the detail
	| filePath   |
	| <filePath> |
	And I Click Proceed to Next Section and Submit the Refreral button to proceed to Finish the Referral Submission

	Examples:
	| FirstName | LastName | Email                             | Organization                                   | StreetAddress1 | StateName | RefType                  | InvolvedPartyType                                                  | Detected | ReferralSummary | witness_Or_ExternalReferringParty | report | additionalInfo | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType       | isAnotherExternalInvolvedPartyAvailable | Organization1 | NamePrefix | FirstName1 | MiddleName1 | LastName1 | NameSuffix | StreetAddress3 | StreetAddress4     | City  | State   | County | Zip   | Designation1 | Country | PrimaryPhone | SecondaryPhone | Ssn       | OtherId | Email1         | Other | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | question1 | question2 | question3 | question4 | question5 | question6 | filePath     |
	| Henry     | Welson   | yamuna.c@gainwelltechnologies.com | MCO Example 1- Mapped to Enrollment Department | 123 Main St    | Florida   | Potential Fraud Referral | Involved Party Type - Associated Subject- Caregiver w/o req fields | test1    | test2           | Yes                               | test1  | test2          | Yes                             | 12.1.25 Non enumerated Individual | Yes                                     | asv           | Mr.        | Tommy      | Josh        | S         | Jr.        | Car Street     | 456 StreetAddress4 | Texas | Florida | Baker  | 11223 | Tester       | USA     |   8974512631 |     8974512645 | 789065432 |  234516 | josh@gmail.com | test  | Test3   | Test4           | No                               | Yes       | Test5     | Yes       | Test6     | Yes       | Test7     | TestFile.txt |

	

	Scenario Outline: Online Referral with IP-Involved Party Type - Associated Subject-Lawyer w/ Req fields and AIP- Involved Party Type - Associated Subject- Provider w Req fields 
	Given when I open the Online referral application
	When i check the required fields in the "Submitting Party Information"
	When Required CSS glow appears with correct configured color controlled in Admin
	And I filling the mandatory fileds details on the Initial User Data Page
	| FirstName   | LastName   | Email   | Organization   | StreetAddress1   |
	| <FirstName> | <LastName> | <Email> | <Organization> | <StreetAddress1> |
	Then verify Dropdown lists are in alphabetical order
	Then select the StateName from the dropdown
	| StateName   |
	| <StateName> |
	Then Proceed to Email Address Verification
	And I validate the Captcha for the email address verification page
	And I select the referralType and InvolvedPartyType from the dropdown
	| RefType   | InvolvedPartyType   |
	| <RefType> | <InvolvedPartyType> |
	Then I Enter the Text for How was this detected? 
	| Detected   |
	| <Detected> |
	Then I Enter the Text for Please Provide a Summary of this Referral for the referral details page
	| ReferralSummary   |
	| <ReferralSummary> |
	And I click Next step to Proceed to the next page
	Then I select involved party an external referring party or witness?
	| witness_Or_ExternalReferringParty   |
	| <witness_Or_ExternalReferringParty> |
	Then the following fields should be displayed for Witness:
	| Organization1Lawer   | NamePrefixLawer   | FirstName1Lawer   | MiddleName1Lawer   | LastName1Lawer   | NameSuffixLawer   | StreetAddress3Lawer   | StreetAddress4Lawer   | CityLawer   | StateLawer   | CountyLawer   | ZipLawer   | Designation1Lawer   | CountryLawer   | dobLawer   | PrimaryPhoneLawer   | SecondaryPhoneLawer   | SsnLawer   | OtherIdLawer   | Email1Lawer   | OtherLawer   |
	| <Organization1Lawer> | <NamePrefixLawer> | <FirstName1Lawer> | <MiddleName1Lawer> | <LastName1Lawer> | <NameSuffixLawer> | <StreetAddress3Lawer> | <StreetAddress4Lawer> | <CityLawer> | <StateLawer> | <CountyLawer> | <ZipLawer> | <Designation1Lawer> | <CountryLawer> | <dobLawer> | <PrimaryPhoneLawer> | <SecondaryPhoneLawer> | <SsnLawer> | <OtherIdLawer> | <Email1Lawer> | <OtherLawer> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field
	| report   | additionalInfo |
	| <report> | <additionalInfo> |
	And I click "Next" Continue with Involved Party Selection button to proceed
	Then I select the another involved Party from the drop down menu as YES option
	| isAnotherInvolvedPartyAvailable   | additionalInvolvedPartyType   | isAnotherExternalInvolvedPartyAvailable   |
	| <isAnotherInvolvedPartyAvailable> | <additionalInvolvedPartyType> | <isAnotherExternalInvolvedPartyAvailable> |
	Then the following fields should be displayed for Provider
	| OrganizationProvider   | namePrefixProvider   | firstNameProvider   | middleNameProvider   | lastNameProvider   | nameSuffixProvider   | DesignationProvider   | DOBProvider   | SSNProvider   | LicenseNumberProvider   | IDProvider   | NPIProvider   | TIN_EINProvider   | medicaidIDProvider   | medicareIDProvider   | OtherIDProvider   | ProviderTypeProvider                       | ProviderSpecialtyProvider   | TaxonomyProvider   | otherProvider   |  | address1Provider   | address2Provider   | cityProvider   | stateProvider   | countyProvider   | zipCodeProvider   | countryProvider   | phoneNumberProvider   | faxProvider   | emailProvider   |
	| <OrganizationProvider> | <namePrefixProvider> | <firstNameProvider> | <middleNameProvider> | <lastNameProvider> | <nameSuffixProvider> | <DesignationProvider> | <DOBProvider> | <SSNProvider> | <LicenseNumberProvider> | <IDProvider> | <NPIProvider> | <TIN_EINProvider> | <medicaidIDProvider> | <medicareIDProvider> | <OtherIDProvider> | <ProviderTypeProvider> | <ProviderSpecialtyProvider> | <TaxonomyProvider> | <otherProvider> |  | <address1Provider> | <address2Provider> | <cityProvider> | <stateProvider> | <countyProvider> | <zipCodeProvider> | <countryProvider> | <phoneNumberProvider> | <faxProvider> | <emailProvider> |
	Then I enter the Text for How did this witness/external referring party report this? (Required) and Any Additonal Information regarding the witness or external referring party? (Optional)field on Second Time
	| report1   | additionalInfo1   |
	| <report1> | <additionalInfo1> |
	And I continue with Involved Party Selection and proceed to the next page
	Then I Select the  another involved Party from the drop down menu as NO
	| isAnotherInvolvedPartyAvailable1   |
	| <isAnotherInvolvedPartyAvailable1> |
	Then I Click Finish Involved Party Selection and Proceed to Next Section button
	And I Select the Entering into the Questions and Attachments Section and answer the questions
	| question1   | question2   | question3   | question4   | question5   | question6   |
	| <question1> | <question2> | <question3> | <question4> | <question5> | <question6> |
	Then I add the Attachments with the help of Uploading the files and providing the detail
	| filePath   |
	| <filePath> |
	And I Click Proceed to Next Section and Submit the Refreral button to proceed to Finish the Referral Submission
	

	Examples:
	| FirstName | LastName | Email                             | Organization                                   | StreetAddress1 | StateName | RefType                  | InvolvedPartyType                                             | Detected | ReferralSummary | witness_Or_ExternalReferringParty | Organization1Lawer | NamePrefixLawer | FirstName1Lawer | MiddleName1Lawer | LastName1Lawer | NameSuffixLawer | StreetAddress3Lawer | StreetAddress4Lawer | CityLawer | StateLawer | CountyLawer | ZipLawer | Designation1Lawer | CountryLawer | dobLawer   | PrimaryPhoneLawer | SecondaryPhoneLawer | SsnLawer  | OtherIdLawer | Email1Lawer    | OtherLawer | report | additionalInfo | isAnotherInvolvedPartyAvailable | additionalInvolvedPartyType                                     | isAnotherExternalInvolvedPartyAvailable | OrganizationProvider | namePrefixProvider | firstNameProvider | middleNameProvider | lastNameProvider | nameSuffixProvider | DesignationProvider | DOBProvider | SSNProvider | LicenseNumberProvider | IDProvider | NPIProvider | TIN_EINProvider | medicaidIDProvider | medicareIDProvider | OtherIDProvider | ProviderTypeProvider | ProviderSpecialtyProvider | TaxonomyProvider | otherProvider | address1Provider | address2Provider | cityProvider | stateProvider | countyProvider | zipCodeProvider | countryProvider | phoneNumberProvider | faxProvider | emailProvider  | report1 | additionalInfo1 | isAnotherInvolvedPartyAvailable1 | question1 | question2 | question3 | question4 | question5 | question6 | filePath     |
	| John      | Welson   | yamuna.c@gainwelltechnologies.com | MCO Example 1- Mapped to Enrollment Department | 123 Main St    | Florida   | Potential Fraud Referral | Involved Party Type - Associated Subject-Lawyer w/ Req fields | test1    | test2           | Yes                               | Tata               | Mrs.            | Rosy            | Jam              | S              | Jr.             | Car Street          | 456 StreetAddress4  | Cali      | Florida    | Baker       |    11223 | Tester            | USA          | 01/02/1995 |        8974512631 |          8974512645 | 789065432 |       234516 | rosy@gmail.com | test       | test1  | test2          | Yes                             | Involved Party Type - Associated Subject- Provider w Req fields | Yes                                     | abc corp             | Mr.                | Mark              | L                  | Antony           | Smith              | Developer           | 02/07/1987  |   345213678 |                234567 |       1234 |   234523456 |          234516 |               5467 |               2324 |             890 | adfc                 | bb                        | szx              | es            | texas            | cx               | montek       | Florida       | Baker          |           12345 | US              |          2345678980 |  1234567890 | john@gmail.com | test3   | test4           | No                               | Yes       | test5     | Yes       | test6     | Yes       | test7     | TestFile.txt |


	
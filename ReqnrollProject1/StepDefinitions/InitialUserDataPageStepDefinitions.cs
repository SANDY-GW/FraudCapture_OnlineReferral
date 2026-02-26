using System;
using FC_OnlineReferral.OnlineReferral_Pages;
using NUnit.Framework;
using OpenQA.Selenium;

using Reqnroll;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class InitialUserDataPageStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public InitialUserDataPageStepDefinitions(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given("when I open the Online referral application")]
        public void GivenWhenIOpenTheOnlineReferralApplication()
        {
            var Ol = new OnlineReferral(Driver);
            Ol.Login();
        }


        [Given("I enter the userFN as {string},User lastname as {string},Org name as {string},title as {string}  filled on the Initial User Data Page")]
        public void GivenIEnterTheUserFNAsUserLastnameAsOrgNameAsTitleAsFilledOnTheInitialUserDataPage(string userFName, string userLastName, string value, string title)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterUserFName(userFName);
            PG1.EnterUserLastName(userLastName);
            PG1.SelectOrgAgency(value);
            PG1.EnterUserTitle(title);
        }
        [Given("I enter the email as {string} on the Initial User Data Page")]
        public void GivenIEnterTheEmailAsOnTheInitialUserDataPage(string username)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterUserEmailName(username);
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.localStorage.setItem('useTestData', 'true');localStorage.setItem('validatedEmail', '" + username + "');localStorage.setItem('emailValidated', 'true')");

        }

        [Given("I enter the Phone number as {string} on the Initial User Data Page")]
        public void GivenIEnterThePhoneNumberAsOnTheInitialUserDataPage(string phoneno)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterPhoneNumberAndExtension(phoneno);
        }

        [Then("verify the Captcha Email notification")]
        public void ThenVerifyTheCaptchaEmailNotification()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.waitForEmailNotification();
        }




        [When("I click on the Next button on the Initial User Data Page")]
        public void WhenIClickOnTheNextButtonOnTheInitialUserDataPage()
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.ClickProceedToNextSectionButton();

        }
        [When("I click on the Next button on the fouth User Data Page")]
        public void WhenIClickOnTheNextButtonOnTheFouthUserDataPage()
        {
            var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3.ClickProceedToNextSectionButton();

        }


        [When("I should be navigated to the Next Page")]
        public void WhenIShouldBeNavigatedToTheNextPage()
        {

        }
        [Given("I enter the {string},{string},{string},{string},{string}, filled in the Address section yon the Initial User Data Page")]
        public void GivenIEnterTheFilledInTheAddressSectionOnTheInitialUserDataPage(string Mailing_Street_Address1, string Mailing_Street_Address2, string Mailing_Address_City, string Mailing_Address_State, string Mailing_Address_Zip)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterMailingStreetAddress1(Mailing_Street_Address1);
            PG1.EnterMailingStreetAddress2(Mailing_Street_Address2);
            PG1.EnterMailingAddressCity(Mailing_Address_City);
            PG1.SelectState_Or_Territory(Mailing_Address_State);
            PG1.EnterMailingAddressZipCode(Mailing_Address_Zip);
        }

        [When("I click on the emailverification button on the Initial User Data Page")]
        public void WhenIClickOnTheEmailverificationButtonOnTheInitialUserDataPage()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.clickEmailAddressVerificationButton();
        }

        [When("Referral Type is selected as {string} on the second User Data Page")]
        public void WhenReferralTypeIsSelectedAsOnTheSecondUserDataPage(string referralType)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.SelectRefType(referralType);
        }
        [When("Suspect or Subject or Involved Party Type as {string}")]
        public void WhenSuspectOrSubjectOrInvolvedPartyTypeAs(string involvedpartytype)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.SelectInvolvedPartyType(involvedpartytype);
        }
        [Then("enter case or reference number as {string} on the second User Data Page")]
        public void ThenEnterCaseOrReferenceNumberAsOnTheSecondUserDataPage(string referenceno)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.EnterCase_Or_Reference_Or_TrackingNumber(referenceno);
        }

        [Then("How was this detected as{string} ,please provide  a Summary of this referral as {string} on the second User Data Page")]
        public void ThenHowWasThisDetectedAsPleaseProvideASummaryOfThisReferralAsOnTheSecondUserDataPage(string detected, string summary)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.EnterHowWasThisDetected(detected);
            PG2.EnterReferralSummary(summary);
        }
        [Then("enter Amount {string},detectiondate {string}, incidentStartDate {string}, incidentEndDate {string} on the second User Data Page")]
        public void ThenEnterAmountDetectiondateIncidentStartDateIncidentEndDateOnTheSecondUserDataPage(string amount, string detectiondate, string startdate, string enddate)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.EnterEstimatedAmount(amount);
            PG2.EnterOriginalDetectionDate(detectiondate);
            PG2.EnterIncidentStartDate(startdate);
            PG2.EnterIncidentEndDate(enddate);
        }

        [Then("enter state as {string} and city as {string} on the second User Data Page")]
        public void ThenEnterStateAsAndCityAsOnTheSecondUserDataPage(string state, string country)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.SelectState_Or_Territory(state);
            PG2.SelectCounty_Or_District(country);
        }

        [When("was there a witness or external referring party dropdown is selected as {string} on the third User Data Page")]
        public void WhenWasThereAWitnessOrExternalReferringPartyDropdownIsSelectedAsOnTheThirdUserDataPage(string option)
        {
            var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3.SelectisExtRefType(option);
        }

        [Then("enter ReferralFN,ReferralLN, Orgname as {string},{string},{string} on the third User Data Page")]
        public void ThenEnterReferralFNReferralLNOrgnameAsOnTheThirdUserDataPage(string firstname, string lastname, string orgname)
        {
            var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3.EnterWitnessFirstName(firstname);
            PG3.EnterWitnessLastName(lastname);
            PG3.EnterWitnessOrgAgencyName(orgname);
        }

        [Then("referral party relationship to the involved party is selected as {string} on the third User Data Page")]
        public void ThenReferralPartyRelationshipToTheInvolvedPartyIsSelectedAsOnTheThirdUserDataPage(string relation)
        {
            var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3.EnterWitnessRelationship(relation);
        }

        [Then("enter Referral party email and phone number as {string},{string} on the third User Data Page")]
        public void ThenEnterReferralPartyEmailAndPhoneNumberAsOnTheThirdUserDataPage(string email, string phoneno)
        {
            var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3.EnterWitnessEmail(email);
            PG3.EnterWitnessPhoneNumber(phoneno);
        }
        [Then("street_Address_lineone as {string}, street_Address_linetwo as {string}, city as ,{string}, state as {string} and zip code as {string} on the third User Data Page")]
        public void ThenStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsAndZipCodeAsOnTheThirdUserDataPage(string address1, string address2, string city, string state, string zipcode)
        {
            var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3.EnterWitnessAddress1(address1);
            PG3.EnterWitnessAddress2(address2);
            PG3.EnterWitnessCity(city);
            PG3.SelectWitnessState(state);
            PG3.EnterWitnessZipCode(zipcode);
        }


        [Given("enter associated orgname as {string}, name prefix as {string}, associated party first name as {string},associated party middle name as {string}, associated party last name as {string} and name suffix as {string} on the fourth User Data Page")]
        public void GivenEnterAssociatedOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(string orgname, string nameprefix, string FN, string MN, string LN, string namesuffix)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterOrgName(orgname);
            PG4.EnterNamePrefix(nameprefix);
            PG4.EnterFirstName(FN);
            PG4.EnterMiddleName(MN);
            PG4.EnterLastName(LN);
            PG4.EnterNameSuffix(namesuffix);

        }

        [When("enter associated orgname as {string}, name prefix as {string}, associated party first name as {string},associated party middle name as {string}, associated party last name as {string} and name suffix as {string} on the fourth User Data Page")]
        public void WhenEnterAssociatedOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(string orgname, string nameprefix, string FN, string MN, string LN, string namesuffix)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterOrgName(orgname);
            PG4.EnterNamePrefix(nameprefix);
            PG4.EnterFirstName(FN);
            PG4.EnterMiddleName(MN);
            PG4.EnterLastName(LN);
            PG4.EnterNameSuffix(namesuffix);

        }
        [When("enter designation as {string},DOB as {string}, SSN as {string}, licenseNumber as {string}, ID Test as {string}")]
        public void WhenEnterDesignationAsDOBAsSSNAsLicenseNumberAsIDTestAs(string testDesignation, string dob, string ssn, string licenseno, string IDtest)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterDesignation_or_Title(testDesignation);
            PG4.EnterDOB(dob);
            PG4.EnterSSN(ssn);
            PG4.EnterLicenseNo(licenseno);
            PG4.EnterIDTest(IDtest);
        }

        [When("enter NPI as {string}, TIN as {string},medicaid ID as {string},Medicare ID as {string}, otherID as {string} on the fourth User Data Page")]
        public void WhenEnterNPIAsTINAsMedicaidIDAsMedicareIDAsOtherIDAsOnTheFourthUserDataPage(string Npi, string Tin, string Medicaid, string Medicare, string OtherID)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterNPI(Npi);
            PG4.EnterTIN(Tin);
            PG4.EnterMedicaidID(Medicaid);
            PG4.EnterMedicareID(Medicare);
            PG4.EnterOtherID(OtherID);


        }

        [When("enter provider type as {string}, provider specialty as {string},Taxonomy as {string} and other as {string} on the fourth User Data Page")]
        public void WhenEnterProviderTypeAsProviderSpecialtyAsTaxonomyAsAndOtherAsOnTheFourthUserDataPage(string ProType, string ProSpec, string Taxonomy, string Other)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterProviderType(ProType);
            PG4.EnterProviderSpecialty(ProSpec);
            PG4.EnterTaxonomy(Taxonomy);
            PG4.EnterOther(Other);

        }

        [When("country as {string},  phone number as {string}, fax as {string} and email address as {string}")]
        public void WhenCountryAsPhoneNumberAsFaxAsAndEmailAddressAs(string country, string phoneno, string fax, string email)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterCountry(country);
            PG4.EnterPhoneNumber(phoneno);
            PG4.EnterFax(fax);
            PG4.EnterEmail(email);
        }




        [When("street_Address_lineone as {string}, street_Address_linetwo as {string}, city as ,{string}, state as {string} , county as {string} and zip code as {string}")]
        public void WhenStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsCountyAsAndZipCodeAs(string address1, string address2, string city, string state, string county, string zipcode)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterAddress1(address1);
            PG4.EnterAddress2(address2);
            PG4.EnterCity(city);
            PG4.SelectState(state);
            PG4.SelectCounty(county);
            PG4.EnterZipCode(zipcode);

        }

        [When("country as {string}, primary phone number as {string}, secondary phone number as {string} and email address as {string}")]
        public void WhenCountryAsPrimaryPhoneNumberAsSecondaryPhoneNumberAsAndEmailAddressAs(string country, string primaryPhNo, string secondayPhNo, string email)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterCountry(country);
            PG4.EnterPhoneNumber(primaryPhNo);
            PG4.EnterFax(secondayPhNo);
            PG4.EnterEmail(email);

        }

        [When("Does this rederral involve a specific member is selected as {string}")]
        public void WhenDoesThisRederralInvolveASpecificMemberIsSelectedAs(string dropdownOption)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.SelectDoesThisReferralInvolveSpecificPatient(dropdownOption);
        }

        [When("Is the member the same person as the witness or external referring party? is selected as {string}")]
        public void WhenIsTheMemberTheSamePersonAsTheWitnessOrExternalReferringPartyIsSelectedAs(string dropdownOption)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.SelectIsThisPersonSameASWitness_Or_ExternalParty(dropdownOption);

        }
        [When("Enter FN,LN,memberID and DOB as {string},{string},{string},{string},{string}")]
        public void WhenEnterFNLNMemberIDAndDOBAs(string memberFN, string memberLN, string memberID, string Phno, string DOB)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.EnterPatientFirstName(memberLN);
            PG5.EnterPatientLastName(memberLN);
            PG5.EnterMemberID(memberID);
            PG5.EnterPhoneNumber(Phno);
            PG5.EnterDateOfBirth(DOB);
        }



        [When("Enter planType as {string}, Phone number as {string}, email as {string}")]
        public void WhenEnterPlanTypeAsPhoneNumberAsEmailAs(string plantype, string phoneno, string email)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.EnterProgram_Or_Plan_Type(plantype);
            PG5.EnterPhoneNumber(phoneno);
            PG5.EnterEmail(email);
        }

        [When("street_Address_lineone as {string}, street_Address_linetwo as {string}, city as ,{string}, state as {string} , county as {string} , zip code as {string} and country as {string}")]
        public void WhenStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsCountyAsZipCodeAsAndCountryAs(string address1, string address2, string city, string state, string county, string zipcode, string country)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.EnterAddress1(address1);
            PG5.EnterAddress2(address2);
            PG5.EnterCity(city);
            PG5.SelectState(state);
            PG5.SelectCounty(county);
            PG5.EnterZipCode(zipcode);
            PG5.EnterCountry(country);


        }
        [When("I click on the Next button on the fifth User Data Page")]
        public void WhenIClickOnTheNextButtonOnTheFifthUserDataPage()
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.ClickProceedToNextSectionButton();
        }


        [When("Questionone Is this a resubmission as {string}")]
        public void WhenQuestiononeIsThisAResubmissionAs(string no)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.SelectQuestion1Dropdown(no);
        }
        [When("Questionone as {string}")]
        public void WhenQuestiononeAs(string test)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.SelectQuestion1Test(test);
        }


        [When("Questiontwo as {string}, QuestionThree as {string}, Questionfour as {string}, Questionfive as {string}, Questionsix as {string}")]
        public void WhenQuestiontwoAsQuestionThreeAsQuestionfourAsQuestionfiveAsQuestionsixAs(string test, string no, string test2, string no3, string test4)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.EnterQuestion2(test);
            PG5.SelectQuestion3dropdown(no);
            PG5.EnterQuestion4(test2);
            PG5.SelectQuestion5(no3);
            PG5.EnterQuestion6(test4);
        }

        [Then("submitting a referral")]
        public void ThenSubmittingAReferral()
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.ClickSubmitReferralButton();

        }




    }


    
}

using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab;
using FC_OnlineReferral.OnlineReferral_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using Assert = NUnit.Framework.Assert;
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



        [When("i check the required fields in the {string}")]
        public void WhenICheckTheRequiredFieldsInThe(string p0)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.verifyrequiredfieldsinpage1();
            Assert.That(PG1.IsLogoDisplayed(), Is.True, "Logo is not displayed on the page");
            Assert.That(PG1.verifyrequiredfieldsinpage1(), Is.True, "Required fields are not highlighted with expected color");
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
        [When("I click on the Next button on the Initial User Data Page")]
        public void WhenIClickOnTheNextButtonOnTheInitialUserDataPage()
        {
            var PG3 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG3.ClickProceedToNextSection();
        }


        [Given("I enter the email as {string} on the Initial User Data Page")]
        public void GivenIEnterTheEmailAsOnTheInitialUserDataPage(string username)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterUserEmailName(username);
            Assert.That(CommonHelpers.ValidationerrorExists(Driver), Is.False, $"Invalid email ID '{username}' entered");
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.localStorage.setItem('useTestData', 'true');localStorage.setItem('validatedEmail', '" + username + "');localStorage.setItem('emailValidated', 'true')");

        }
        [Given("Verify color on all Required Field in the Initial User Data Page")]
        public void GivenVerifyColorOnAllRequiredFieldInTheInitialUserDataPage()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.VerifyBGColorOnRequiredFields();

        }


        [Given("I enter the Phone number as {string} on the Initial User Data Page")]
        public void GivenIEnterThePhoneNumberAsOnTheInitialUserDataPage(string phoneno)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterPhoneNumberAndExtension(phoneno);
        }

        [Then("the Captcha Email notification appears")]
        public void TheCaptchaEmailNotificationAppears()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.clickEmailAddressVerificationButton();
            PG1.waitForEmailNotification();
        }


        [Then("I click Next button to proceed")]
        public void ThenIClickNextButtonToProceed()
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
            Assert.That(CommonHelpers.ValidationerrorExists(Driver), Is.False, $"Invalid email ID '{Mailing_Address_Zip}' entered");
        }

        [Then("verify Dropdown lists are in alphabetical order")]
        public void ThenVerifyDropdownListsAreInAlphabeticalOrder()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);

            Assert.That(PG1.VerifyIfStateOrTerritoryDropdownIsInAlphabeticalOrder(), Is.True, "State/territory dropdown list is not in alphabetic order");

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


        [When("User enters Incident Start Date as {string}")]
        public void WhenUserEntersIncidentStartDateAs(string startDate)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.EnterIncidentStartDate(startDate);

        }

        [When("User enters Incident End Date as {string}")]
        public void WhenUserEntersIncidentEndDateAs(string p0)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.EnterIncidentEndDate(p0);
        }


        [Then("validate {string} should be displayed")]
        public void ThenValidateShouldBeDisplayed(string p0, DataTable dataTable)
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);


            var data = dataTable.CreateInstance<OnlineReferralData>();
            string actualEndError = PG2.GetErrorMessage();

            string actualstartError = PG2.GetErrorMessageStartDate();




            Assert.That(actualEndError.Contains(data.errormessage) || actualstartError.Contains(data.errormessage)
                        , "No valid date error message displayed");


        }

        [Then("get the Original detection date")]
        public void ThenGetTheOriginalDetectionDate()
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var referraldate = PG2.GetOriginalDetectionDate();
            Console.WriteLine(referraldate);
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


        // Page3 new UI online referral changes

        [When("Is thisInvolved Party dropdown is selected as {string} on the third User Data Page")]
        public void WhenIsThisInvolvedPartyDropdownIsSelectedAsOnTheThirdUserDataPage(string option)
        {

            var PG3 = new InvolvedParties_Page3(Driver);

            PG3.SelectIsExternalReferringPartyFromDropdown(option);
        }

        [When("enter InvolvedParty orgname as {string}, name prefix as {string}, associated party first name as {string},associated party middle name as {string}, associated party last name as {string} and name suffix as {string} on the fourth User Data Page")]
        public void WhenEnterInvolvedPartyOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(string orgname, string prefix, string fn, string mn, string ln, string suffix)
        {

            var PG3 = new InvolvedParties_Page3(Driver);
            DateTime dateTime = DateTime.Now;
            fn = fn + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            ln = ln + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            _scenarioContext["UserFN"] = fn;
            _scenarioContext["UserLN"] = ln;

            PG3.FillOrganizationField(orgname);
            PG3.FillNamePrefixField(prefix);
            PG3.FillFirstNameField(fn);
            PG3.FillMiddleNameField(mn);
            PG3.FillLastNameField(ln);
            PG3.FillNameSuffixField(suffix);
        }
        [When("enter InvolvedParty Designation as {string},DOB as {string}, SSN as {string}, licenseNumber as {string}, How witness or external party reported this as {string},any additional info as {string} ID Test as {string}")]
        public void WhenEnterInvolvedPartyDesignationAsDOBAsSSNAsLicenseNumberAsHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAsIDTestAs(string Designation, string dob, string ssn, string licenseno, string text, string text1, string idTest)
        {
            var PG3 = new InvolvedParties_Page3(Driver);
            PG3.FillDesignationField(Designation);
            PG3.FillDOBField(dob);
            PG3.FillSSNField(ssn);
            PG3.FillLicenseNumberField(licenseno);
            PG3.FillHowDidThisExternalReferringPartyreportThisTextarea(text);
            PG3.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(text);
            PG3.FillIDTestField(idTest);
        }


        [When("enter InvolvedParty NPI as {string}, TIN as {string},medicaid ID as {string},Medicare ID as {string}, otherID as {string} on the fourth User Data Page")]
        public void WhenEnterInvolvedPartyNPIAsTINAsMedicaidIDAsMedicareIDAsOtherIDAsOnTheFourthUserDataPage(string npi, string Tin, string medicaidID, string medicareID, string OtherID)
        {
            var PG3 = new InvolvedParties_Page3(Driver);
            PG3.FillNPIField(npi);
            PG3.FillTIN_EINField(Tin);
            PG3.FillMedicaidIDField(medicaidID);
            PG3.FillMedicareIDField(medicareID);
            PG3.FillOtherIDField(OtherID);
        }

        [When("enter InvolvedParty provider type as {string}, provider specialty as {string},Taxonomy as {string} and other as {string} on the fourth User Data Page")]
        public void WhenEnterInvolvedPartyProviderTypeAsProviderSpecialtyAsTaxonomyAsAndOtherAsOnTheFourthUserDataPage(string p0, string p1, string tester, string test)
        {
            var PG3 = new InvolvedParties_Page3(Driver);
            PG3.FillProviderTypeField(p0);
            PG3.FillProviderSpecialtyField(p1);
            PG3.FillTaxonomyField(tester);
            PG3.FillOtherField(test);
        }

        [When("InvolvedParty street_Address_lineone as {string}, street_Address_linetwo as {string}, city as ,{string}, state as {string} , county as {string} and zip code as {string}")]
        public void WhenInvolvedPartyStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsCountyAsAndZipCodeAs(string p0, string p1, string irving, string texas, string washington, string p5)
        {
            var PG3 = new InvolvedParties_Page3(Driver);
            PG3.FillAddress1Field(p0);
            PG3.FillAddress2Field(p1);
            PG3.FillCityField(irving);
            PG3.SelectStateFromDropdown(texas);
            PG3.SelectCountyFromDropdown(washington);
            PG3.FillZipCodeField(p5);
        }

        [When("InvolvedParty country as {string},  phone number as {string}, fax as {string} and email address as {string}")]
        public void WhenInvolvedPartyCountryAsPhoneNumberAsFaxAsAndEmailAddressAs(string p0, string p1, string p2, string p3)
        {
            var PG3 = new InvolvedParties_Page3(Driver);
            PG3.FillCountryField(p0);
            PG3.FillPhoneNumberField(p1);
            PG3.FillFaxField(p2);
            PG3.FillEmailField(p3);
        }

        [When("I click on the Next button on the third User Data Page")]
        public void WhenIClickOnTheNextButtonOnTheThirdUserDataPage()
        {

            var PG3 = new InvolvedParties_Page3(Driver);
            PG3.ClickProceedToNextSectionButton();
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
            DateTime dateTime = DateTime.Now;
            FN = FN + dateTime.ToString("HH:mm ") + dateTime.ToString("MM dd yyyy");
            _scenarioContext.Set(FN, "FirstName");
            PG4.EnterFirstName(FN);
            PG4.EnterMiddleName(MN);
            LN = LN + dateTime.ToString("HH:mm ") + dateTime.ToString("MM dd yyyy");
            _scenarioContext.Set(LN, "LastName");
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


        [When("is there anotherinvolved party dropdown is selected as {string} on the fourth User Data Page")]
        public void WhenIsThereAnotherinvolvedPartyDropdownIsSelectedAsOnTheFourthUserDataPage(string no)
        {
            var PG4 = new additionalInvolvedParty_page4(Driver);
            PG4.SelectisThereAnotherInvolvedParty(no);

            PG4.ClickContinueWithInvolvedPartySelectionButton();


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


        [When("Questiontwo as {string}, QuestionThree as {string}")]
        public void WhenQuestiontwoAsQuestionThreeAsQuestionfourAsQuestionfiveAsQuestionsixAs(string test, string no)
        {
            var PG5 = new New_UI_Questions_Page5(Driver);
            PG5.EnterAllQuestionAnswers();
            //PG5.EnterQuestion2Answer(test);
            //PG5.EnterQuestion3Answer(no);
            //PG5.EnterQuestion4(test2);
            //PG5.SelectQuestion5(no3);
            //PG5.EnterQuestion6(test4);
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


        [When("then uploading a file using file path as {string}")]
        public void WhenThenUploadingAFileUsingFilePathAs(string fileName)
        {
            var PG5 = new New_UI_Questions_Page5(Driver);
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Attachments\";
            PG5.ClickUploadFileArrow(filePath + fileName);
        }

        [Then("click on proceed to next session button")]
        public void ThenClickOnProceedToNextSessionButton()
        {


            var PG5 = new New_UI_Questions_Page5(Driver);
            PG5.ClickProceedToNextSessionButton();
        }


        [Then("submitting a referral")]
        public void ThenSubmittingAReferral()
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.ClickSubmitReferralButton();

        }

        // member page

        [When("enter InvolvedParty  name prefix as {string}, associated party first name as {string},associated party middle name as {string}, associated party last name as {string} and name suffix as {string}")]
        public void WhenEnterInvolvedPartyNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAs(string nameprefix, string Fn, string Mn, string Ln, string namesuffix)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);


            DateTime dateTime = DateTime.Now;
            Fn = Fn + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            Ln = Ln + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            _scenarioContext["UserFN"] = Fn;
            _scenarioContext["UserLN"] = Ln;

            PG3.FillNamePrefixField(nameprefix);
            PG3.FillFirstNameField(Fn);
            PG3.FillMiddleNameField(Mn);
            PG3.FillLastNameField(Ln);
            PG3.FillNameSuffixField(namesuffix);
        }


        [When("enter InvolvedParty DOB as {string}, Gender as {string}, other as {string}, How witness or external party reported this as {string},any additional info as {string}")]
        public void WhenEnterInvolvedPartyDOBAsGenderAsOtherAsHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAs(string p0, string male, string test, string member, string p4)
        {

            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3.FillDOBField(p0);
            PG3.FillGenderField(male);
            PG3.FillOtherField(test);
            PG3.FillHowDidThisExternalReferringPartyreportThisTextarea(member);
            PG3.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(p4);
        }



        [When("enter InvolvedParty ID as {string},ssn as {string} medicaid ID as {string},Medicare ID as {string}, otherID as {string}")]
        public void WhenEnterInvolvedPartyIDAsSsnAsMedicaidIDAsMedicareIDAsOtherIDAs(string Id, string ssn, string medicaid, string medicare, string otherID)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3.FillIDField(Id);
            PG3.FillSSNField(ssn);
            PG3.FillMedicaidIDField(medicaid);
            PG3.FillMedicareIDField(medicare);
            PG3.FillOtherIDField(otherID);

        }

        [When("enter InvolvedParty plan as {string}, Program  as {string},LOB as {string} and Group as {string}")]
        public void WhenEnterInvolvedPartyPlanAsProgramAsLOBAsAndGroupAs(string plan, string program, string lob, string group)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3.FillPlanField(plan);
            PG3.FillProgramField(program);
            PG3.FillLOBField(lob);
            PG3.FillGroupField(group);
        }
        [When("InvolvedParty member street_Address_lineone as {string}, street_Address_linetwo as {string}, city as ,{string}, state as {string} , county as {string} and zip code as {string}")]
        public void WhenInvolvedPartyMemberStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsCountyAsAndZipCodeAs(string p0, string p1, string irving, string texas, string washington, string p5)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3.FillAddress1Field(p0);
            PG3.FillAddress2Field(p1);
            PG3.FillCityField(irving);
            PG3.SelectStateFromDropdown(texas);
            PG3.SelectCountyFromDropdown(washington);
            PG3.FillZipCodeField(p5);
        }

        [When("InvolvedParty Primary phoneNo as {string},  Secondary phone number as {string} and email address as {string}")]
        public void WhenInvolvedPartyPrimaryPhoneNoAsSecondaryPhoneNumberAsAndEmailAddressAs(string primaryphNo, string SeconadryPhno, string email)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3.FillPrimaryPhoneNumberField(primaryphNo);
            PG3.FillSecondaryPhoneNumberField(SeconadryPhno);
            PG3.FillEmailField(email);
        }


        // Non-Enumerated provider
        [When("enter InvolvedParty Non-Enumertaed Provider orgname as {string}, name prefix as {string}, associated party first name as {string},associated party middle name as {string}, associated party last name as {string} and name suffix as {string} on the fourth User Data Page")]
        public void WhenEnterInvolvedPartyNon_EnumertaedProviderOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(string p0, string mr, string p2, string p3, string p4, string jr)
        {
            var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            PG3.EnterOrganization(p0);
            PG3.EnterNamePrefix(mr);
            PG3.EnterFirstName(p2);
            PG3.EnterMiddleName(p3);
            PG3.EnterLastName(p3);
            PG3.EnterNameSuffix(jr);

        }


        [When("enter InvolvedParty Designation as {string} ,DOB as {string}, SSN as {string}, How witness or external party reported this as {string},any additional info as {string} licenseNumber as {string},other ID as {string},other as {string}")]
        public void WhenEnterInvolvedPartyDesignationAsDOBAsSSNAsHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAsLicenseNumberAsOtherIDAsOtherAs(string testDesignation, string dob, string ssn, string referringPartyReport, string additionalwitness, string licenseno, string otherid, string other)
        {
            var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            PG3.EnterDesignation(testDesignation);
            PG3.EnterDOB(dob);
            PG3.EnterSSN(ssn);
            PG3.FillHowDidThisExternalReferringPartyreportThisTextarea(referringPartyReport);
            PG3.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(additionalwitness);
            PG3.EnterLicenseNumber(licenseno);
            PG3.EnterOtherID(otherid);
            PG3.EnterOther(other);
        }


        [When("enter primary phone number as {string},secondary phone number as {string}, fax as {string} and email address as {string} for the involved party")]
        public void WhenEnterPrimaryPhoneNumberAsSecondaryPhoneNumberAsFaxAsAndEmailAddressAsForTheInvolvedParty(string p0, string p1, string p2, string p3)
        {
            var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            PG3.EnterPrimaryPhoneNumber(p0);
            PG3.EnterSecondaryPhoneNumber(p1);
            PG3.EnterFax(p2);
            PG3.EnterEmail(p3);
        }

        [When("street address line one as {string}, street address line two as {string}, city as {string}, state as {string}, county as {string} , zip code as {string} and country as {string} for the involved party")]
        public void WhenStreetAddressLineOneAsStreetAddressLineTwoAsCityAsStateAsCountyAsZipCodeAsAndCountryAsForTheInvolvedParty(string p0, string p1, string irving, string texas, string washington, string p5, string p6)
        {
            var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            PG3.EnterAddress1(p0);
            PG3.EnterAddress2(p1);
            PG3.EnterCity(irving);
            PG3.SelectState(texas);
            PG3.SelectCounty(washington);
            PG3.EnterZipCode(p5);
            PG3.EnterCountry(p6);


        }

        //Header logo Validation

        [Then(@"Logo should be visible")]
        public void ThenLogoShouldBeVisible()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            Assert.That(PG1.IsLogoDisplayed(), Is.True, "Logo is not visible");
        }

        [Then(@"Logo should be aligned at the top center of the page")]
        public void ThenLogoTopCenter()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);

            Assert.That(PG1.IsLogoAtTopCenter(), Is.True, "Logo is not at top center");
        }

        [Then(@"Logo should be aligned to the left of the header")]
        public void ThenLogoLeftAligned()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            Assert.That(PG1.IsLogoLeftAligned(), Is.True, "Logo is not left aligned");
        }


        [When("Required CSS glow appears with correct configured color controlled in Admin")]
        public void WhenRequiredCSSGlowAppearsWithCorrectConfiguredColorControlledInAdmin()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);

            Assert.That(PG1.VerifyBGColorOnRequiredFieldsPage1(), Is.True, "Required field glow color is not correct");
        }


        [When("I filling the mandatory fileds details on the Initial User Data Page")]
        public void WhenIFillingTheMandatoryFiledsDetailsOnTheInitialUserDataPage(DataTable dataTable)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterUserFName(data.FirstName);
            PG1.EnterUserLastName(data.LastName);
            PG1.EnterUserEmailName(data.Email);
            PG1.SelectOrgAgency(data.Organization);
            PG1.EnterMailingStreetAddress1(data.StreetAddress1);
        }
        [Then("select the StateName from the dropdown")]
        public void ThenSelectTheStateNameFromTheDropdown(DataTable dataTable)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.SelectState_Or_Territory(data.StateName);
        }



        [Then("Proceed to Email Address Verification")]
        public void ThenProceedToEmailAddressVerification()
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.clickEmailAddressVerificationButton();
        }
        [Then("I validate the Captcha for the email address verification page")]
        public void ThenIValidateTheCaptchaForTheEmailAddressVerificationPage()
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            //PG1.waitForEmailNotification();

        }


        [Then("I Click NextButtonToProceed button to proceed")]
        public void ThenIClickNextButtonToProceedButtonToProceed()
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.ClickProceedToNextSectionButton();
        }


        [Then("I select the referralType and InvolvedPartyType from the dropdown")]
        public void ThenISelectTheReferralTypeAndInvolvedPartyTypeFromTheDropdown(DataTable dataTable)
        {
            var PG1 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.SelectRefType(data.RefType);
            PG1.SelectInvolvedPartyType(data.InvolvedPartyType);
        }
        [Then("I Enter the Text for How was this detected?")]
        public void ThenIEnterTheTextForHowWasThisDetected(DataTable dataTable)
        {
            var PG1 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterHowWasThisDetected(data.Detected);
        }

        [Then("I Enter the Text for Please Provide a Summary of this Referral for the referral details page")]
        public void ThenIEnterTheTextForPleaseProvideASummaryOfThisReferralForTheReferralDetailsPage(DataTable dataTable)
        {
            var PG1 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterReferralSummary(data.ReferralSummary);
        }

        [Then("I click Next step to Proceed to the next page")]
        public void ThenIClickNextStepToProceedToTheNextPage()
        {
            var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.ClickProceedToNextSectionButton();
        }

        [Then("I select involved party an external referring party or witness?")]
        public void ThenISelectInvolvedPartyAnExternalReferringPartyOrWitness(DataTable dataTable)
        {
            var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG4.SelectWitness_Or_ExternalReferringParty(data.witness_Or_ExternalReferringParty);
        }

        [When("I enter initial user details:")]
        public void WhenIEnterInitialUserDetails(DataTable dataTable)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);


            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterUserFName(data.FirstName);
            PG1.EnterUserLastName(data.LastName);
            PG1.EnterUserEmailName(data.Email);
            PG1.SelectOrgAgency(data.Organization);
            PG1.EnterUserTitle(data.Title);
            PG1.EnterPhoneNumberAndExtension(data.Phone);

        }



        [When("I enter the address:")]
        public void WhenIEnterTheAddress(DataTable dataTable)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);


            var data = dataTable.CreateInstance<OnlineReferralData>();
            

        }

        [Then("I select the another involved Party from the drop down menu")]
        public void ThenISelectTheAnotherInvolvedPartyFromTheDropDownMenu(DataTable dataTable)
        {
            var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.SelectisThereAnotherInvolvedParty(data.isAnotherInvolvedPartyAvailable);
            PG3.SelectPleaseSelectTheAdditionalInvolvedPartyType(data.additionalInvolvedPartyType);
            PG3.SelectIsThisInvolvedPartyAnExternalReferringParty(data.isAnotherExternalInvolvedPartyAvailable);
        }
        [Then("the following fields should be displayed:")]
        public void ThenTheFollowingFieldsShouldBeDisplayed(DataTable dataTable)
        {
            var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.FillOrganizationField(data.Organization1);
            PG3.FillNamePrefixField(data.NamePrefix);
            PG3.FillFirstNameField(data.FirstName1);
            PG3.FillMiddleNameField(data.MiddleName1);
            PG3.FillLastNameField(data.LastName1);
            PG3.FillNameSuffixField(data.NameSuffix);
            PG3.FillStreetAddress1Field(data.StreetAddress3);
            PG3.FillStreetAddress2Field(data.StreetAddress4);
            PG3.FillCityField(data.City);
            //PG3.FillStateField(data.State);
            //PG3.SelectCountyField(data.County);
            PG3.FillZipField(data.Zip);
            PG3.FillDesignationField1(data.Designation1);
            PG3.FillCountryField(data.Country);
            PG3.FillPrimaryPhoneField(data.PrimaryPhone);
            PG3.FillSecondaryPhoneField(data.SecondaryPhone);
            PG3.FillSsnField(data.Ssn);
            PG3.FillOtherIdField(data.OtherId);
            PG3.FillEmailField(data.Email1);
            PG3.FillOtherField(data.Other);
            





        }

        
        [Then("I enter the Text for How did this witness\\/external referring party report this? \\(Required) and Any Additonal Information regarding the witness or external referring party? \\(Optional)field")]
        public void ThenIEnterTheTextForHowDidThisWitnessExternalReferringPartyReportThisRequiredAndAnyAdditonalInformationRegardingTheWitnessOrExternalReferringPartyOptionalField(DataTable dataTable)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.FillHowDidThisExternalReferringPartyreportThisTextarea(data.report);
            PG3.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.additionalInfo);
        }
        [Then("I enter the Text for How did this witness\\/external referring party report this? \\(Required) and Any Additonal Information regarding the witness or external referring party? \\(Optional)field on Second Time")]
        public void ThenIEnterTheTextForHowDidThisWitnessExternalReferringPartyReportThisRequiredAndAnyAdditonalInformationRegardingTheWitnessOrExternalReferringPartyOptionalFieldOnSecondTime(DataTable dataTable)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.SelectHowDidThisExternalReferringPartyreportThisTextarea(data.report1);
            PG3.SelectAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.additionalInfo1);
        }
        [Then("I continue with Involved Party Selection and proceed to the next page")]
        public void ThenIContinueWithInvolvedPartySelectionAndProceedToTheNextPage()
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3.ClickProceedToNextSectionButton();
            
        }

        [Then("I Select the  another involved Party from the drop down menu as NO")]
        public void ThenISelectTheAnotherInvolvedPartyFromTheDropDownMenuAsNO(DataTable dataTable)
        {
            var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.FillisThereAnotherInvolvedParty(data.isAnotherInvolvedPartyAvailable1);
        }
        [Then("I Click Finish Involved Party Selection and Proceed to Next Section button")]
        public void ThenIClickFinishInvolvedPartySelectionAndProceedToNextSectionButton()
        {
            var PG3 = new additionalInvolvedParty_page4(Driver);
            PG3.ClickfinishInvolvedPartySelectionAndProceedToNectSectionButton();
        }
        [Then("I select the Involved party an external referring Party or Witness dropdown as {string}")]
        public void ThenISelectTheInvolvedPartyAnExternalReferringPartyOrWitnessDropdownAs(DataTable dataTable)
        {
            var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.SelectIsThisInvolvedPartyAnExternalReferringParty(data.isAnotherExternalInvolvedPartyAvailable);
        }
        [Then("I Select the Entering into the Questions and Attachments Section and answer the questions")]
        public void ThenISelectTheEnteringIntoTheQuestionsAndAttachmentsSectionAndAnswerTheQuestions(DataTable dataTable)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG5.SelectQuestion1Dropdown(data.question1);
            PG5.EnterQuestion2(data.question2);
            PG5.SelectQuestion3dropdown(data.question3);
            PG5.EnterQuestion4(data.question4);
            PG5.SelectQuestion5(data.question5);
            PG5.EnterQuestion6(data.question6);
        }

        [Then("I Click Proceed to Next Section and Submit the Refreral button to proceed to Finish the Referral Submission")]
        public void ThenIClickProceedToNextSectionAndSubmitTheRefreralButtonToProceedToFinishTheReferralSubmission()
        {
            var PG5 = new New_UI_Questions_Page5(Driver);
            PG5.ClickProceedToNextSessionButton();
        }
        
        [Then("I add the Attachments with the help of Uploading the files and providing the detail")]
        public void ThenIAddTheAttachmentsWithTheHelpOfUploadingTheFilesAndProvidingTheDetail(DataTable dataTable)
        {
            var PG5 = new New_UI_Questions_Page5(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            //PG5.ClickUploadFileArrow(data.filePath);
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Attachments\";
            PG5.ClickUploadFileArrow(filePath + data.filePath);
        }
       
        [Then("I click {string} Continue with Invloved Party Selection button to proceed")]
        public void ThenIClickContinueWithInvlovedPartySelectionButtonToProceed(string next)
        {
            var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3.ClickProceedToNextSectionButton();
        }

    }
}






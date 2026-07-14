using FC_OnlineReferral.OnlineReferral_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using ReqnrollProject1.Hooks;
using System;
using Assert = NUnit.Framework.Assert;
namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class InitialUserDataPageStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _driver;
        LoginOnlineRef_Page1 PG1;
        OnlineReferral_Referral_Page2 PG2;
        InvolvedParties_Page3 PG3_InvParty;
        WitnessOrExternalRefParty_Page3 PG3Witness;
        InvolvedPartyTypeasMember_page3 PG3_Member;
        InvolvedPartyasNonEnumeratedProvider_Page3 PG3InvPrtyNONEnum;
        InvolvedPartyTypeInfo_Page4 PG4;
        additionalInvolvedParty_page4 PG4_AddtnlInvldParty;
        New_UI_Questions_Page5 PG5;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        //public InitialUserDataPageStepDefinitions(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;
        public InitialUserDataPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = Hooks_FC.loc_driver;
            PG1 = new LoginOnlineRef_Page1(Driver);
            PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG3_InvParty = new InvolvedParties_Page3(Driver);
            PG3Witness = new WitnessOrExternalRefParty_Page3(Driver);
            PG3_Member = new InvolvedPartyTypeasMember_page3(Driver);
            PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4_AddtnlInvldParty = new additionalInvolvedParty_page4(Driver);
            PG5 = new New_UI_Questions_Page5(Driver);
            

        }
        //PG3 = new InvolvedParties_Page3(Driver);

        [Given("when I open the Online referral application")]
        public void GivenWhenIOpenTheOnlineReferralApplication()
        {
            var Ol = new OnlineReferral(_driver);
            Ol.Login();
        }


        //new changes for online referral

        [When("I enter the email  on the {string}")]
        public void WhenIEnterTheEmailAsOnTheInitialUserDataPage(string pageName, DataTable dataTable)
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForPageLoading(Driver);
            PG1.EnterUserEmailName(data.EmailAddress);
            Assert.That(CommonHelpers.ValidationerrorExists(Driver), Is.False, $"Invalid email ID '{data.EmailAddress}' entered");
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.localStorage.setItem('useTestData', 'true');localStorage.setItem('validatedEmail', '" + data.EmailAddress + "');localStorage.setItem('emailValidated', 'true')");

        }


        [When("I enter the userFN ,User lastname ,Org name ,title   filled on the Initial User Data Page")]
        public void WhenEnterTheUserFNAsUserLastnameAsOrgNameAsTitleAsFilledOnTheInitialUserDataPage(DataTable dataTable)

        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterUserFName(data.UserFirstName);
            PG1.EnterUserLastName(data.UserLastName);
            PG1.SelectOrgAgency(data.orgname);
            PG1.EnterUserTitle(data.title);
        }

        [When("I enter the Phone number on the Initial User Data Page")]
        public void WhenIEnterThePhoneNumberOnTheInitialUserDataPage(DataTable dataTable)
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterPhoneNumberAndExtension(data.Phonenumber);

        }

        [When("I enter Address section yon the Initial User Data Page")]
        public void ThenIEnterTheFilledInTheAddressSectionYonTheInitialUserDataPage(DataTable dataTable)
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterMailingStreetAddress1(data.Address1);
            PG1.EnterMailingStreetAddress2(data.Address2);
            PG1.EnterMailingAddressCity(data.City);
            PG1.SelectState_Or_Territory(data.State);
            PG1.EnterMailingAddressZipCode(data.Zipcode);
        }



        [When("i check the required fields current page on the {string}")]
        public void WhenICheckTheRequiredFieldsInThe(string requiredfields)
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);

            PG1.verifyrequiredfieldsinpage1();
            Assert.That(PG1.verifyrequiredfieldsinpage1(), Is.True, $"Required fields are not highlighted with expected color for the page: '{requiredfields}'");
        }





        [Then("validate email field {string} and zip code field {string} require specific value formats")]
        public void ThenValidateEmailFieldAndZipCodeFieldRequireSpecificValueFormats(string username, string Mailing_Address_Zip, DataTable dataTable)
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG1.EnterUserEmailName(username);
            Assert.That(CommonHelpers.ValidationerrorExists(Driver), Is.False, $"Invalid email ID '{username}' entered");

            PG1.EnterMailingAddressZipCode(Mailing_Address_Zip);
            Assert.That(CommonHelpers.ValidationerrorExists(Driver), Is.False, $"Invalid Zip Code '{Mailing_Address_Zip}' entered");
        }




        [Given("Verify color on all Required Field in the Initial User Data Page")]
        public void GivenVerifyColorOnAllRequiredFieldInTheInitialUserDataPage()
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.VerifyBGColorOnRequiredFields();

        }




        [Then("the Captcha Email notification appears")]
        public void TheCaptchaEmailNotificationAppears()
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.clickEmailAddressVerificationButton();
            //PG1.waitForEmailNotification();
        }


        [When("I enter the invalid email id and validate for {string}")]
        public void WhenEnterTheInvalidEmailIdAs(string pageName, DataTable dataTable)
        {
            ////var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForPageLoading(Driver);
            CommonHelpers.ScrollDown(Driver);
            CommonHelpers.WaitForPageLoading(Driver);

            PG1.EnterUserEmailName(data.Invalidemail);
            Assert.That(PG1.IsValidationErrorDisplayed(), Is.True, $"Email validation error message is not displayed for Page '{pageName}'");

            string actualErrorMessage = PG1.GetValidationErrorMessage();
            Console.WriteLine(actualErrorMessage);
            Assert.That(actualErrorMessage, Is.EqualTo(data.Emailvalidationerrormessage),
                $"Expected error message: '{data.Emailvalidationerrormessage}', but got: '{actualErrorMessage}'");
        

        }


        [When("I enter the valid email id")]
        public void WhenEnterThevalidEmailIdAs(DataTable dataTable)
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForPageLoading(Driver);
            PG1.EnterUserEmailName(data.EmailAddress);
        }




        [Then("I validate the error messgae")]
        public void ThenValidateTheErrorMessgaeAs(DataTable dataTable)
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();

            Assert.That(PG1.IsValidationErrorDisplayed(), Is.True, "Email validation error message is not displayed");

            string actualErrorMessage = PG1.GetValidationErrorMessage();
            Console.WriteLine(actualErrorMessage);
            Assert.That(actualErrorMessage, Is.EqualTo(data.Emailvalidationerrormessage),
                $"Expected error message: '{data.Emailvalidationerrormessage}', but got: '{actualErrorMessage}'");
        }


        [When("I enter the invalid zipcode and validate")]
        public void WhenEnterTheInvalidZipcodeAs(DataTable dataTable)
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForPageLoading(Driver);

            PG1.EnterMailingAddressZipCode(data.Invalidzipcode);

            string actualErrorMessage = PG1.GetValidationErrorMessage();

            Assert.That(PG1.IsValidationErrorDisplayed(), Is.True, "Zip codevalidation error message is not displayed");


            Assert.That(actualErrorMessage, Is.EqualTo(data.Zipcodevalidationerrormessage),
                $"Expected error message: '{data.Zipcodevalidationerrormessage}', but got: '{actualErrorMessage}'");

        }

        [Then("I enter the invalid zipcode and validate for provider")]
        public void ThenIEnterTheInvalidZipcodeAndValidateForProvider(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForPageLoading(Driver);

            PG3_InvParty.FillZipCodeField(data.Invalidzipcode);

            string actualErrorMessage = PG3_InvParty.GetValidationErrorMessage();

            Assert.That(PG3_InvParty.IsValidationErrorDisplayed(), Is.True, "Zip codevalidation error message is not displayed");

            Assert.That(actualErrorMessage, Is.EqualTo(data.Zipcodevalidationerrormessage),
                $"Expected error message: '{data.Zipcodevalidationerrormessage}', but got: '{actualErrorMessage}'");

        }





        [When("I click on the Next button on the {string}")]
        public void WhenIClickOnTheNextButtonOnThePage(string pageName)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.ClickProceedToNextSectionButton();

        }
        [When("I click on the Next button on the fouth User Data Page")]
        public void WhenIClickOnTheNextButtonOnTheFouthUserDataPage()
        {
            // var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3Witness.ClickProceedToNextSectionButton();

        }


        
        [Given("I enter the {string},{string},{string},{string},{string}, filled in the Address section yon the Initial User Data Page")]
        public void GivenIEnterTheFilledInTheAddressSectionOnTheInitialUserDataPage(string Mailing_Street_Address1, string Mailing_Street_Address2, string Mailing_Address_City, string Mailing_Address_State, string Mailing_Address_Zip)
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterMailingStreetAddress1(Mailing_Street_Address1);
            PG1.EnterMailingStreetAddress2(Mailing_Street_Address2);
            PG1.EnterMailingAddressCity(Mailing_Address_City);
            PG1.SelectState_Or_Territory(Mailing_Address_State);

            //PG1.VerifyIfStateteOrTerritoryDropdownIsInAlphabaticalOrder();
            //Assert.That(PG1.VerifyIfStateteOrTerritoryDropdownIsInAlphabaticalOrder(), Is.True, "State/territory dropdown list is not in alphabetic order");

            PG1.EnterMailingAddressZipCode(Mailing_Address_Zip);
            Assert.That(CommonHelpers.ValidationerrorExists(Driver), Is.False, $"Invalid email ID '{Mailing_Address_Zip}' entered");
        }

        [Then("verify Dropdown lists are in alphabetical order {string} on the page {string}")]
        public void ThenVerifyDropdownListsAreInAlphabeticalOrder(string dropdownName, string pageName)
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            Assert.That(PG1.VerifyIfStateOrTerritoryDropdownIsInAlphabeticalOrder(), Is.True, dropdownName+ "dropdown list is not in alphabetic order in :" +pageName );

        }

        [Then("verify  referral Dropdown lists are in alphabetical order {string} on the page {string}")]
        public void ThenVerifyReferralDropdownListsAreInAlphabeticalOrder(string dropdownName, string pageName)
        {
            var PG2= new  OnlineReferral_Referral_Page2(Driver); 
            Assert.That(PG2.VerifyIfReferralDropdownIsInAlphabeticalOrder(), Is.True, dropdownName + "dropdown list is not in alphabetic order in :" + pageName);

        }




        [When("I click on the emailverification button on the Initial User Data Page")]
        public void WhenIClickOnTheEmailverificationButtonOnTheInitialUserDataPage()
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.clickEmailAddressVerificationButton();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 60);
        }

        [When("Referral Type is selected  on the second User Data Page")]
        public void WhenReferralTypeIsSelectedAsOnTheSecondUserDataPage(DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.SelectRefType(data.referralType);
        }
        [When("Suspect or Subject or Involved Party Type dropdown is selected  on the {string}")]
        public void WhenSuspectOrSubjectOrInvolvedPartyTypeAs(string dropdown, DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.SelectInvolvedPartyType(data.involvedPartyType);
        }
        [When("enter case or reference number  on the {string}")]
        public void WhenEnterCaseOrReferenceNumberAsOnTheSecondUserDataPage(string pageName, DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.EnterCase_Or_Reference_Or_TrackingNumber(data.caseOrReferenceNumber);
        }


        [Then("verify Dropdown lists are in alphabetical order {string} on the {string} in involved party page")]
        public void ThenVerifyDropdownListsAreInAlphabeticalOrderOnTheThirdUserDataPage(string dropdownName, string pageName)
        {
            //var PG3 = new InvolvedParties_Page3(Driver); 

            Assert.That(PG3_InvParty.VerifyIfStateOrTerritoryDropdownIsInAlphabeticalOrder(), Is.True, dropdownName + "dropdown list is not in alphabetic order in :" + pageName);

        }
        [Then("verify county Dropdown lists are in alphabetical order {string} on the page {string}")]
        public void ThenVerifyCountyDropdownListsAreInAlphabeticalOrderOnTheThirdUserDataPage(string dropdownName, string pageName)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);

            Assert.That(PG3_InvParty.VerifyIfCountyDropdownIsInAlphabeticalOrder(), Is.True, dropdownName + "dropdown list is not in alphabetic order in :" + pageName);

        }

        [When("How was this detected  ,please provide  a Summary of this referral  on the {string}")]
        public void ThenHowWasThisDetectedAsPleaseProvideASummaryOfThisReferralAsOnTheSecondUserDataPage(string pageName, DataTable dataTable)
        {
            ////var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.EnterHowWasThisDetected(data.detectedAs);
            PG2.EnterReferralSummary(data.summary);
        }
        [When("enter Amount ,detectiondate")]
        public void WhenEnterAmountDetectiondateOnTheSecondUserDataPage(DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.EnterEstimatedAmount(data.amount);
            PG2.EnterOriginalDetectionDate(data.detectionDate);
        }

        [When("enter invalid incidentStartDate , incidentEndDate and validate the error message  on the {string}")]
        public void WhenEnterIncidentStartDateAndEndDateOnTheSecondUserDataPage(string pageName, DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.EnterIncidentStartDate(data.InvalidIncidentStartDate);
            PG2.EnterIncidentEndDate(data.InvalidIncidentEndDate);
            string actualEndError = PG2.GetErrorMessage();
            string actualstartError = PG2.GetErrorMessageStartDate();
            Assert.That(actualEndError.Contains(data.errormessage) || actualstartError.Contains(data.errormessage)
                        , $"No valid date error message displayed for the page: '{pageName}'");
        }


        [When("enter valid incidentStartDate , incidentEndDate  on the {string}")]
        public void WhenEnterValidIncidentStartDateAndEndDateOnTheSecondUserDataPage(string pageName, DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.EnterIncidentStartDate(data.incidentValidStartDate);
            PG2.EnterIncidentEndDate(data.incidentValidEndDate);
        }


        //validation of $ symbol
        [Then("validate the  dollar symbol is displayed in the amount field on the {string}")]
        public void ThenValidateTheSymbolIsDisplayedInTheAmountField(string pageName, DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            PG2.ValidateTheAmountField();
            Assert.That(PG2.ValidateTheAmountField(), Is.True, $"The $ symbol is not displayed in the amount field for the page: '{pageName}'");

        }





        [When("User enters Incident Start Date")]
        public void WhenUserEntersIncidentStartDateAs(DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.EnterIncidentStartDate(data.incidentStartDate);

        }

        [When("User enters Incident End Date")]
        public void WhenUserEntersIncidentEndDateAs(DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.EnterIncidentEndDate(data.incidentEndDate);
        }


        //[Then("validate error message should be displayed")]
        //public void ThenValidateShouldBeDisplayed(DataTable dataTable)
        //{
        //    //var PG2 = new OnlineReferral_Referral_Page2(Driver);


        //    var data = dataTable.CreateInstance<OnlineReferralData>();
        //    string actualEndError = PG2.GetErrorMessage();

        //    string actualstartError = PG2.GetErrorMessageStartDate();




        //    Assert.That(actualEndError.Contains(data.errormessage) || actualstartError.Contains(data.errormessage)
        //                , "No valid date error message displayed");


        //}




        [Then("get the Original detection date")]
        public void ThenGetTheOriginalDetectionDate()
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var referraldate = PG2.GetOriginalDetectionDate();
            Console.WriteLine(referraldate);
        }

        [When("enter state  and city  on the {string}")]
        public void WhenEnterStateAsAndCityAsOnTheSecondUserDataPage(string pageName, DataTable dataTable)
        {
            //var PG2 = new OnlineReferral_Referral_Page2(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG2.SelectState_Or_Territory(data.State2);
            PG2.SelectCounty_Or_District(data.City2);
        }



        [When("was there a witness or external referring party dropdown is selected as {string} on the third User Data Page")]
        public void WhenWasThereAWitnessOrExternalReferringPartyDropdownIsSelectedAsOnTheThirdUserDataPage(string option)
        {
            //var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3Witness.SelectisExtRefType(option);
        }

        [Then("enter ReferralFN,ReferralLN, Orgname as {string},{string},{string} on the third User Data Page")]
        public void ThenEnterReferralFNReferralLNOrgnameAsOnTheThirdUserDataPage(string firstname, string lastname, string orgname)
        {
            //var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3Witness.EnterWitnessFirstName(firstname);
            PG3Witness.EnterWitnessLastName(lastname);
            PG3Witness.EnterWitnessOrgAgencyName(orgname);
        }

        [Then("referral party relationship to the involved party is selected as {string} on the third User Data Page")]
        public void ThenReferralPartyRelationshipToTheInvolvedPartyIsSelectedAsOnTheThirdUserDataPage(string relation)
        {
            //var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3Witness.EnterWitnessRelationship(relation);
        }

        [Then("enter Referral party email and phone number as {string},{string} on the third User Data Page")]
        public void ThenEnterReferralPartyEmailAndPhoneNumberAsOnTheThirdUserDataPage(string email, string phoneno)
        {
            //var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3Witness.EnterWitnessEmail(email);
            PG3Witness.EnterWitnessPhoneNumber(phoneno);
        }
        [Then("street_Address_lineone as {string}, street_Address_linetwo as {string}, city as ,{string}, state as {string} and zip code as {string} on the third User Data Page")]
        public void ThenStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsAndZipCodeAsOnTheThirdUserDataPage(string address1, string address2, string city, string state, string zipcode)
        {
            //var PG3 = new WitnessOrExternalRefParty_Page3(Driver);
            PG3Witness.EnterWitnessAddress1(address1);
            PG3Witness.EnterWitnessAddress2(address2);
            PG3Witness.EnterWitnessCity(city);
            PG3Witness.SelectWitnessState(state);
            PG3Witness.EnterWitnessZipCode(zipcode);
        }


        // Page3 new UI online referral changes

        [When("Is thisInvolved Party dropdown is selected  on the {string}")]
        public void WhenIsThisInvolvedPartyDropdownIsSelectedAsOnTheThirdUserDataPage(string pageName, DataTable dataTable)
        {

            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.SelectIsExternalReferringPartyFromDropdown(data.witnessDropdown);
        }

        [When("enter InvolvedParty orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix  on the {string}")]
        public void WhenEnterInvolvedPartyOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(string pageName, DataTable dataTable)
        {

            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            DateTime dateTime = DateTime.Now;
            data.firstName = data.firstName + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            data.lastName = data.lastName + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            if (!_scenarioContext.ContainsKey("UserFN") || !_scenarioContext.ContainsKey("UserLN"))
            {
                _scenarioContext["UserFN"] = data.firstName;
                _scenarioContext["UserLN"] = data.lastName;

            }

            PG3_InvParty.FillOrganizationField(data.orgname);
            PG3_InvParty.FillNamePrefixField(data.namePrefix);
            PG3_InvParty.FillFirstNameField(data.firstName);
            PG3_InvParty.FillMiddleNameField(data.middleName);
            PG3_InvParty.FillLastNameField(data.lastName);
            PG3_InvParty.FillNameSuffixField(data.nameSuffix);
        }
        [Then("i enter invalid date of birth and validate for {string}")]
        public void ThenIEnterInvalidDateOfBirthAndValidateForPage(string pageName, DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.ScrollDown(Driver);
            PG3_InvParty.FillDOBField(data.InvalidDOB);
            Assert.That(PG3_InvParty.IsValidationDateErrorDisplayed(), Is.True, $"DOB: Date validation error message is not displayed for the page: '{pageName}'");

            string actualErrorMessage = PG3_InvParty.GetValidationDateErrorMessage();

            Assert.That(actualErrorMessage, Is.EqualTo("Date cannot be in the future."),
                $"Expected error message: '{"Date cannot be in the future."}', but got: '{actualErrorMessage}'");
        }

       
        [When("enter InvolvedParty Designation")]
        public void WhenEnterInvolvedPartyDesignation(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.FillDesignationField(data.designation);
        }



        [When("enter ,DOB as {string},SSN as {string}, licenseNumber as {string}, How witness or external party reported this as {string},any additional info as {string} ID Test as {string}")]
        public void WhenEnterDOBAsSSNAsLicenseNumberAsHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAsIDTestAs(string dob, string ssn, string licenseno, string text, string text1, string idTest)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            PG3_InvParty.FillDOBField(dob);
            PG3_InvParty.FillSSNField(ssn);
            PG3_InvParty.FillLicenseNumberField(licenseno);
            PG3_InvParty.FillHowDidThisExternalReferringPartyreportThisTextarea(text);
            PG3_InvParty.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(text);
            PG3_InvParty.FillIDTestField(idTest);
        }


        [When("enter InvolvedParty NPI , TIN ,medicaid ID ,Medicare ID , otherID on the {string}")]
        public void WhenEnterInvolvedPartyNPIAsTINAsMedicaidIDAsMedicareIDAsOtherIDAsOnTheFourthUserDataPage(string pageName, DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.FillNPIField(data.NPI);
            PG3_InvParty.FillTIN_EINField(data.TIN);
            PG3_InvParty.FillMedicaidIDField(data.medicaidID);
            PG3_InvParty.FillMedicareIDField(data.MedicareID);
            PG3_InvParty.FillOtherIDField(data.otherID);
        }


        [When("enter DOB")]
        public void WhenEnterDOBAs(DataTable dataTable)
        {
           // var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.FillDOBField(data.DOB);
        }

        [When("enter SSN , licenseNumber ,ID Test")]
        public void WhenEnterSSNAsLicenseNumberAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.FillSSNField(data.SSN);
            PG3_InvParty.FillLicenseNumberField(data.licenseNumber);
            PG3_InvParty.FillIDTestField(data.IDTest);
        }


        [When("enter How witness or external party reported this ,any additional info")]
        public void WhenEnterHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAsIDTestAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
           
            if (PG3_InvParty.getWitnessDropdownValue().Equals("Yes"))
            {
                CommonHelpers.WaitForPageLoading(Driver);
                CommonHelpers.ScrollDown(Driver);

                PG3_InvParty.FillHowDidThisExternalReferringPartyreportThisTextarea(data.involvedPartyType);
                PG3_InvParty.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.detectedAs);
            }

        }



        [When("enter InvolvedParty provider type , provider specialty ,Taxonomy  and other  on the {string}")]
        public void WhenEnterInvolvedPartyProviderTypeAsProviderSpecialtyAsTaxonomyAsAndOtherAsOnTheFourthUserDataPage(string pageName, DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.FillProviderTypeField(data.providerType);
            PG3_InvParty.FillProviderSpecialtyField(data.providerSpecialty);
            PG3_InvParty.FillTaxonomyField(data.Taxonomy);
            PG3_InvParty.FillOtherField(data.other);
        }

        [When("InvolvedParty street_Address_lineone , street_Address_linetwo , city as, state  , county   and zip code")]
        public void WhenInvolvedPartyStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsCountyAsAndZipCodeAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.FillAddress1Field(data.Address1);
            PG3_InvParty.FillAddress2Field(data.Address2);
            PG3_InvParty.FillCityField(data.City);
            PG3_InvParty.SelectStateFromDropdown(data.State2);
            PG3_InvParty.SelectCountyFromDropdown(data.City2);
            PG3_InvParty.FillZipCodeField(data.Zipcode);
        }

        [Then("I enter the invalid email id  and validate for {string}")]
        public void ThenEnterTheInvalidEmailIdAndValidateForInvolvedpartyAsProvider(string pageTitle,DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.ScrollDown(Driver);
            CommonHelpers.WaitForPageLoading(Driver);
            PG3_InvParty.FillEmailField(data.Invalidemail);
            Assert.That(PG3_InvParty.IsValidationErrorDisplayed(), Is.True, "Email validation error message is not displayed: "+ pageTitle);

            string actualErrorMessage = PG3_InvParty.GetValidationErrorMessage();
            Console.WriteLine(actualErrorMessage);
            Assert.That(actualErrorMessage, Is.EqualTo(data.Emailvalidationerrormessage),
                $"Expected error message: '{data.Emailvalidationerrormessage}', but got: '{actualErrorMessage}'");
        }

      

        [When("I enter the valid email id for involvedparty as provider")]
        public void WhenEnterThevalidEmailId(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForPageLoading(Driver);
            PG3_InvParty.FillEmailField(data.EmailAddress);
        }

        [When("InvolvedParty country,  phone number , fax  and email address")]
        public void WhenInvolvedPartyCountryAsPhoneNumberAsFaxAsAndEmailAddressAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.FillCountryField(data.Country);
            PG3_InvParty.FillPhoneNumberField(data.Phonenumber);
            PG3_InvParty.FillFaxField(data.fax);
            PG3_InvParty.FillEmailField(data.EmailAddress);
        }

        [When("I click on the continue button on the {string}")]
        public void WhenIClickOnTheContinueButtonOnTheThirdUserDataPage(string pageTitle)
        {

            var PG3 = new InvolvedParties_Page3(Driver);
            PG3_InvParty.ClickProceedToNextSectionButton();
        }



        [Given("enter associated orgname as {string}, name prefix as {string}, associated party first name as {string},associated party middle name as {string}, associated party last name as {string} and name suffix as {string} on the fourth User Data Page")]
        public void GivenEnterAssociatedOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(string orgname, string nameprefix, string FN, string MN, string LN, string namesuffix)
        {
            //var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterOrgName(orgname);
            PG4.EnterNamePrefix(nameprefix);
            PG4.EnterFirstName(FN);
            PG4.EnterMiddleName(MN);
            PG4.EnterLastName(LN);
            PG4.EnterNameSuffix(namesuffix);

        }
        [When("I should be navigated to the {string}")]
        public void WhenIShouldBeNavigatedToTheNextPage(string pageName)
        {

        }


        [When("enter associated orgname as {string}, name prefix as {string}, associated party first name as {string},associated party middle name as {string}, associated party last name as {string} and name suffix as {string} on the fourth User Data Page")]
        public void WhenEnterAssociatedOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(string orgname, string nameprefix, string FN, string MN, string LN, string namesuffix)
        {
            //var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
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
            ////var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterDesignation_or_Title(testDesignation);
            PG4.EnterDOB(dob);
            PG4.EnterSSN(ssn);
            PG4.EnterLicenseNo(licenseno);
            PG4.EnterIDTest(IDtest);
        }

        [When("enter NPI as {string}, TIN as {string},medicaid ID as {string},Medicare ID as {string}, otherID as {string} on the fourth User Data Page")]
        public void WhenEnterNPIAsTINAsMedicaidIDAsMedicareIDAsOtherIDAsOnTheFourthUserDataPage(string Npi, string Tin, string Medicaid, string Medicare, string OtherID)
        {
            ////var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterNPI(Npi);
            PG4.EnterTIN(Tin);
            PG4.EnterMedicaidID(Medicaid);
            PG4.EnterMedicareID(Medicare);
            PG4.EnterOtherID(OtherID);


        }

        [When("enter provider type as {string}, provider specialty as {string},Taxonomy as {string} and other as {string} on the fourth User Data Page")]
        public void WhenEnterProviderTypeAsProviderSpecialtyAsTaxonomyAsAndOtherAsOnTheFourthUserDataPage(string ProType, string ProSpec, string Taxonomy, string Other)
        {
            ////var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterProviderType(ProType);
            PG4.EnterProviderSpecialty(ProSpec);
            PG4.EnterTaxonomy(Taxonomy);
            PG4.EnterOther(Other);

        }

        [When("country as {string},  phone number as {string}, fax as {string} and email address as {string}")]
        public void WhenCountryAsPhoneNumberAsFaxAsAndEmailAddressAs(string country, string phoneno, string fax, string email)
        {
            ////var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterCountry(country);
            PG4.EnterPhoneNumber(phoneno);
            PG4.EnterFax(fax);
            PG4.EnterEmail(email);
        }




        [When("street_Address_lineone as {string}, street_Address_linetwo as {string}, city as ,{string}, state as {string} , county as {string} and zip code as {string}")]
        public void WhenStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsCountyAsAndZipCodeAs(string address1, string address2, string city, string state, string county, string zipcode)
        {
            //var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
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
            //var PG4 = new InvolvedPartyTypeInfo_Page4(Driver);
            PG4.EnterCountry(country);
            PG4.EnterPhoneNumber(primaryPhNo);
            PG4.EnterFax(secondayPhNo);
            PG4.EnterEmail(email);

        }


        [When("is there anotherinvolved party dropdown is selected on the {string}")]
        public void WhenIsThereAnotherinvolvedPartyDropdownIsSelectedAsOnTheFourthUserDataPage(string pageName, DataTable dataTable)
        {

            //var PG4 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG4_AddtnlInvldParty.SelectisThereAnotherInvolvedParty(data.IsthereanyInvolvedPartyDropdown);

            PG4_AddtnlInvldParty.ClickContinueWithInvolvedPartySelectionButton();


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


        [When("Questionone Is this a resubmission")]
        public void WhenQuestiononeIsThisAResubmissionAs(DataTable dataTable)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG5.SelectQuestion1Dropdown(data.Question1);
        }
        [When("Questionone as {string}")]
        public void WhenQuestiononeAs(string test)
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.SelectQuestion1Test(test);
        }


        [When("Questiontwo, QuestionThree")]
        public void WhenQuestiontwoAsQuestionThreeAsQuestionfourAsQuestionfiveAsQuestionsixAs(DataTable dataTable)
        {
            var PG5 = new New_UI_Questions_Page5(Driver);
            var dat = dataTable.CreateInstance<OnlineReferralData>();
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


        [When("then uploading a file using file path")]
        public void WhenThenUploadingAFileUsingFilePathAs(DataTable dataTable)
        {
            var PG5 = new New_UI_Questions_Page5(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Attachments\";
            PG5.ClickUploadFileArrow(filePath + data.TestFile);
        }

        [Then("click on proceed to next session button")]
        public void ThenClickOnProceedToNextSessionButton()
        {


            var PG5 = new New_UI_Questions_Page5(Driver);
            PG5.ClickProceedToNextSessionButton();
        }


        [When("Click on Submit Button")]
        public void ThenSubmittingAReferral()
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.ClickSubmitReferralButton();

        }



        [Then("validate Enter New Referral is displayed")]
        public void ThenValidateEnterNewReferralIsDisplayed()
        {
            var PG5 = new ResponseToQuestions_Page5(Driver);
            PG5.EnterNewReferralButtonIsDisplayed();

        }

        // member page

        [When("enter InvolvedParty  name prefix , associated party first name ,associated party middle name , associated party last name and name suffix")]
        public void WhenEnterInvolvedPartyNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();

            DateTime dateTime = DateTime.Now;
            data.firstName = data.firstName + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            data.lastName = data.lastName + dateTime.ToString("HH:mm") + dateTime.ToString("MMddyyyy");
            if (!_scenarioContext.ContainsKey("UserFN") || !_scenarioContext.ContainsKey("UserLN"))
            {
                _scenarioContext["UserFN"] = data.firstName;
                _scenarioContext["UserLN"] = data.lastName;

            }

            PG3_Member.FillNamePrefixField(data.NamePrefix);
            PG3_Member.FillFirstNameField(data.firstName);
            PG3_Member.FillMiddleNameField(data.middleName);
            PG3_Member.FillLastNameField(data.lastName);
            PG3_Member.FillNameSuffixField(data.nameSuffix);
        }


        [When("enter InvolvedParty DOB , Gender , other")]
        public void WhenEnterInvolvedPartyDOBAsGenderAsOther(DataTable dataTable)
        {

            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_Member.FillDOBField(data.DOB);
            PG3_Member.FillGenderField(data.Gender);
            PG3_Member.FillOtherField(data.Other);
           
        }

        [When("enter How witness or external party reported this ,any additional info as member")]
        public void WhenEnterHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAs(DataTable dataTable)
        {

            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            if (PG3_Member.getWitnessDropdownValue().Equals("Yes"))
            {
                PG3_Member.FillHowDidThisExternalReferringPartyreportThisTextarea(data.involvedPartyType);
                PG3_Member.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.detectedAs);
            }
        }
        [When("enter How witness or external party reported this ,any additional info as for additionalinvolvedType")]
        public void WhenEnterHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAsMemberForAdditionalInvolvedType(DataTable dataTable)
        {

            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            //var PG4 = new additionalInvolvedParty_page4(Driver);
            if (PG4_AddtnlInvldParty.getWitnessadditionalDropdownValue().Equals("Yes"))
            {
                PG3_Member.FillHowDidThisExternalReferringPartyreportThisTextarea(data.involvedPartyType);
                PG3_Member.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.detectedAs);
            }
        }



        [When("enter InvolvedParty ID ,ssn  medicaid ID ,Medicare ID, otherID")]
        public void WhenEnterInvolvedPartyIDAsSsnAsMedicaidIDAsMedicareIDAsOtherIDAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_Member.FillIDField(data.Other);
            PG3_Member.FillSSNField(data.SSN);
            PG3_Member.FillMedicaidIDField(data.medicaidID);
            PG3_Member.FillMedicareIDField(data.MedicareID);
            PG3_Member.FillOtherIDField(data.otherID);
        }

        [When("enter InvolvedParty plan , Program  ,LOB  and Group")]
        public void WhenEnterInvolvedPartyPlanAsProgramAsLOBAsAndGroupAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);

            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_Member.FillPlanField(data.planType);
            PG3_Member.FillProgramField(data.Program);
            PG3_Member.FillLOBField(data.LOB);
            PG3_Member.FillGroupField(data.Group);
        }
        [When("InvolvedParty member street_Address_lineone , street_Address_linetwo , city , state  , county  and zip code")]
        public void WhenInvolvedPartyMemberStreet_Address_LineoneAsStreet_Address_LinetwoAsCityAsStateAsCountyAsAndZipCodeAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_Member.FillAddress1Field(data.Address1);
            PG3_Member.FillAddress2Field(data.Address2);
            PG3_Member.FillCityField(data.City);
            PG3_Member.SelectStateFromDropdown(data.State2);
            PG3_Member.SelectCountyFromDropdown(data.City2);
            PG3_Member.FillZipCodeField(data.Zipcode);
        }

        [When("InvolvedParty Primary phoneNo ,  Secondary phone number  and email address")]
        public void WhenInvolvedPartyPrimaryPhoneNoAsSecondaryPhoneNumberAsAndEmailAddressAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_Member.FillPrimaryPhoneNumberField(data.PrimaryPhone);
            PG3_Member.FillSecondaryPhoneNumberField(data.SecondaryPhone);
            PG3_Member.FillEmailField(data.EmailAddress);
        }


        // Non-Enumerated provider
        [When("enter InvolvedParty Non-Enumertaed Provider orgname , name prefix , associated party first name ,associated party middle name , associated party last name  and name suffix")]
        public void WhenEnterInvolvedPartyNon_EnumertaedProviderOrgnameAsNamePrefixAsAssociatedPartyFirstNameAsAssociatedPartyMiddleNameAsAssociatedPartyLastNameAsAndNameSuffixAsOnTheFourthUserDataPage(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3InvPrtyNONEnum.EnterOrganization(data.orgname);
            PG3InvPrtyNONEnum.EnterNamePrefix(data.namePrefix);
            PG3InvPrtyNONEnum.EnterFirstName(data.firstName);
            PG3InvPrtyNONEnum.EnterMiddleName(data.middleName);
            PG3InvPrtyNONEnum.EnterLastName(data.lastName);
            PG3InvPrtyNONEnum.EnterNameSuffix(data.nameSuffix);

        }


        [When("enter InvolvedParty Designation  ,DOB , SSN  ,other ID ,other")]
        public void WhenEnterInvolvedPartyDesignationAsDOBAsSSNAsHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAsLicenseNumberAsOtherIDAsOtherAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3InvPrtyNONEnum.EnterDesignation(data.designation);
            PG3InvPrtyNONEnum.EnterDOB(data.DOB);
            PG3InvPrtyNONEnum.EnterSSN(data.SSN);
            
            PG3InvPrtyNONEnum.EnterLicenseNumber(data.licenseNumber);
            PG3InvPrtyNONEnum.EnterOtherID(data.otherID);
            PG3InvPrtyNONEnum.EnterOther(data.other);
        }

        [When("How witness or external party reported this, any additional info  licenseNumber")]
        public void WhenHowWitnessOrExternalPartyReportedThisAsAnyAdditionalInfoAsLicenseNumberAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            //var PG4 = new InvolvedPartyTypeasMember_page3(Driver);
            if (PG3_Member.getWitnessDropdownValue().Equals("Yes"))
            {
                PG3InvPrtyNONEnum.FillHowDidThisExternalReferringPartyreportThisTextarea(data.involvedPartyType);
                PG3InvPrtyNONEnum.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.detectedAs);
                PG3InvPrtyNONEnum.EnterLicenseNumber(data.licenseNumber);
            }
        }

        [When("enter primary phone number ,secondary phone number , fax aand email address  for the involved party")]
        public void WhenEnterPrimaryPhoneNumberAsSecondaryPhoneNumberAsFaxAsAndEmailAddressAsForTheInvolvedParty(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3InvPrtyNONEnum.EnterPrimaryPhoneNumber(data.PrimaryPhone);
            PG3InvPrtyNONEnum.EnterSecondaryPhoneNumber(data.SecondaryPhone);
            PG3InvPrtyNONEnum.EnterFax(data.fax);
            PG3InvPrtyNONEnum.EnterEmail(data.EmailAddress);
        }

        [When("street address line one , street address line two, city , state , county , zip code and country for the involved party")]
        public void WhenStreetAddressLineOneAsStreetAddressLineTwoAsCityAsStateAsCountyAsZipCodeAsAndCountryAsForTheInvolvedParty(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3InvPrtyNONEnum.EnterAddress1(data.Address1);
            PG3InvPrtyNONEnum.EnterAddress2(data.Address2);
            PG3InvPrtyNONEnum.EnterCity(data.City);
            PG3InvPrtyNONEnum.SelectState(data.State2);
            PG3InvPrtyNONEnum.SelectCounty(data.City2);
            PG3InvPrtyNONEnum.EnterZipCode(data.Zipcode);
            PG3InvPrtyNONEnum.EnterCountry(data.Country);


        }

        //Header logo Validation




        [Then("Validate header appears aligned and not distorted on the {string}")]
        public void ValidateHeaderAppearsAlignedAndNotDistorted(string title)
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
          
            Assert.That(PG1.IsLogoDisplayed(), Is.True, "Logo is not visible on the page: " +title);

            Assert.That(PG1.IsLogoAtTopCenter(), Is.True, "Logo is not at top center: " +title);
        }

        

        [Then(@"Logo should be aligned to the left of the header")]
        public void ThenLogoLeftAligned()
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);
            Assert.That(PG1.IsLogoLeftAligned(), Is.True, "Logo is not left aligned");
        }

        [Then("Required CSS glow appears with correct configured color controlled in Admin {string}")]
        public void ThenRequiredCSSGlowAppearsWithCorrectConfiguredColorControlledInAdmin(string pageTitle)
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);


            CommonHelpers.ScrollDown(Driver);

            Assert.That(PG1.VerifyBGColorOnRequiredFieldsPage1(), Is.True, "Required field glow color is not correct");
        }

        [Then("the same fields should be displayed as required in the portal with a red asterisk mark")]
        public void ThenTheSameFieldsShouldBeDisplayedAsRequiredInThePortalWithARedAsteriskMark()
        {
            //var PG1 = new LoginOnlineRef_Page1(Driver);

        }



        //[When("I enter initial user details:")]
        //public void WhenIEnterInitialUserDetails(DataTable dataTable)
        //{
        //    //var PG1 = new LoginOnlineRef_Page1(Driver);


        //    var data = dataTable.CreateInstance<OnlineReferralData>();
        //    PG1.EnterUserFName(data.UserFirstName);
        //    PG1.EnterUserLastName(data.UserLastName);
        //    PG1.EnterUserEmailName(data.Email);
        //    PG1.SelectOrgAgency(data.Orgname);
        //    PG1.EnterUserTitle(data.title);
        //    PG1.EnterPhoneNumberAndExtension(data.Phonenumber);

        //}



        //[When("I enter the address:")]
        //public void WhenIEnterTheAddress(DataTable dataTable)
        //{
        //    //var PG1 = new LoginOnlineRef_Page1(Driver);


        //    var data = dataTable.CreateInstance<CommonData.UserCredentials>();
        //    //PG1.EnterAddress1(data.Address1);
        //    //PG1.EnterAddress2(data.Address2);
        //    //PG1.EnterCity(data.City);
        //    //PG1.SelectState(data.State);
        //    //PG1.EnterZipCode(data.Zipcode);

        //}

        [When("I select the another involved Party from the drop down menu")]
        public void WhenISelectTheAnotherInvolvedPartyFromTheDropDownMenu(DataTable dataTable)
        {
            //var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG4_AddtnlInvldParty.SelectisThereAnotherInvolvedParty(data.isAnotherInvolvedPartyAvailable);
            PG4_AddtnlInvldParty.SelectPleaseSelectTheAdditionalInvolvedPartyType(data.additionalInvolvedPartyType);
            PG4_AddtnlInvldParty.SelectIsThisInvolvedPartyAnExternalReferringParty(data.isAnotherExternalInvolvedPartyAvailable);
        }
        [When("the following fields should be displayed:")]
        public void WhenTheFollowingFieldsShouldBeDisplayed(DataTable dataTable)
        {
            //var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG4_AddtnlInvldParty.FillOrganizationField(data.Organization1);
            PG4_AddtnlInvldParty.FillNamePrefixField(data.NamePrefix);
            PG4_AddtnlInvldParty.FillFirstNameField(data.FirstName1);
            PG4_AddtnlInvldParty.FillMiddleNameField(data.MiddleName1);
            PG4_AddtnlInvldParty.FillLastNameField(data.LastName1);
            PG4_AddtnlInvldParty.FillNameSuffixField(data.NameSuffix);
            PG4_AddtnlInvldParty.FillDesignationField1(data.Designation1);
            PG4_AddtnlInvldParty.FillDOBField(data.DOB);
            PG4_AddtnlInvldParty.FillSsnField(data.Ssn);
            PG4_AddtnlInvldParty.FillOtherIdField(data.OtherId);
            PG4_AddtnlInvldParty.FillOtherField(data.Other);
            PG4_AddtnlInvldParty.FillStreetAddress1Field(data.StreetAddress3);
            PG4_AddtnlInvldParty.FillStreetAddress2Field(data.StreetAddress4);
            PG4_AddtnlInvldParty.FillCityField(data.City);
            PG4_AddtnlInvldParty.SelectState(data.State2);
            PG4_AddtnlInvldParty.SelectCountyField(data.City2);


            //PG3.SelectCountyField(data.County);
            PG4_AddtnlInvldParty.FillZipField(data.Zipcode);
           
            PG4_AddtnlInvldParty.FillCountryField(data.Country); 
            PG4_AddtnlInvldParty.FillPrimaryPhoneField(data.PrimaryPhone);
            PG4_AddtnlInvldParty.FillSecondaryPhoneField(data.SecondaryPhone);


            PG4_AddtnlInvldParty.FillEmailField(data.Email1);
           






        }


        [Then("I enter the Text for How did this witness\\/external referring party report this? \\(Required) and Any Additonal Information regarding the witness or external referring party? \\(Optional)field")]
        public void ThenIEnterTheTextForHowDidThisWitnessExternalReferringPartyReportThisRequiredAndAnyAdditonalInformationRegardingTheWitnessOrExternalReferringPartyOptionalField(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_Member.FillHowDidThisExternalReferringPartyreportThisTextarea(data.report);
            PG3_Member.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.additionalInfo);
        }
        [Then("I enter the Text for How did this witness\\/external referring party report this? \\(Required) and Any Additonal Information regarding the witness or external referring party? \\(Optional)field on Second Time")]
        public void ThenIEnterTheTextForHowDidThisWitnessExternalReferringPartyReportThisRequiredAndAnyAdditonalInformationRegardingTheWitnessOrExternalReferringPartyOptionalFieldOnSecondTime(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            //var PG4 = new additionalInvolvedParty_page4(Driver); 
            var data = dataTable.CreateInstance<OnlineReferralData>();
            if (PG4_AddtnlInvldParty.getWitnessadditionalDropdownValue().Equals("Yes"))
            {
                CommonHelpers.WaitForPageLoading(Driver);
                CommonHelpers.ScrollDown(Driver);

                PG3_Member.FillHowDidThisExternalReferringPartyreportThisTextarea(data.involvedPartyType);
                PG3_Member.FillAnyAdditionalInformationRegardingTheWitnessOrExternalReferringPartyTextarea(data.detectedAs);
            }
        }
        [When ("I continue with Involved Party Selection and proceed to the next page")]
        public void ThenIContinueWithInvolvedPartySelectionAndProceedToTheNextPage()
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            PG3_Member.ClickProceedToNextSectionButton();

        }

        [When ("I Select the  another involved Party from the drop down menu as NO")]
        public void ThenISelectTheAnotherInvolvedPartyFromTheDropDownMenuAsNO(DataTable dataTable)
        {
            //var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG4_AddtnlInvldParty.FillisThereAnotherInvolvedParty(data.isAnotherInvolvedPartyAvailable1);
        }
        [Then("I Click Finish Involved Party Selection and Proceed to Next Section button")]
        public void ThenIClickFinishInvolvedPartySelectionAndProceedToNextSectionButton()
        {
            //var PG3 = new additionalInvolvedParty_page4(Driver);
            PG4_AddtnlInvldParty.ClickfinishInvolvedPartySelectionAndProceedToNectSectionButton();
        }
        [Then("I select the Involved party an external referring Party or Witness dropdown as {string}")]
        public void ThenISelectTheInvolvedPartyAnExternalReferringPartyOrWitnessDropdownAs(DataTable dataTable)
        {
            //var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG4_AddtnlInvldParty.SelectIsThisInvolvedPartyAnExternalReferringParty(data.isAnotherExternalInvolvedPartyAvailable);
        }


        public void UpdateOrganizationName(string newOrganizationName)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            PG3.EnterOrganizationName(newOrganizationName);
        }

        [When("Edit Primary InvovePartyType,Change the data and save the changes")]
        public void WhenEditPrimaryInvovePartyTypeChangeTheDataAndSaveTheChanges(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.ClickEditButton();
            PG3_InvParty.updateOrganizationField(data.updatedOrgname);
            PG3_InvParty.clickSaveButton();
        }

        [When("Edit Primary InvovePartyType for member,Change the data and save the changes")]
        public void WhenEditPrimaryInvovePartyTypeForMemberChangeTheDataAndSaveTheChanges(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_Member.ClickEditButton();
            PG3_Member.updateFirstNameField(data.updatedFirstName);
            PG3_Member.clickSaveButton();
        }

        [When("Edit Primary InvovePartyType for non-Enumerated provider,Change the data and save the changes")]
        public void WhenEditPrimaryInvovePartyTypeForNonEnumeratedProviderChangeTheDataAndSaveTheChanges(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3_InvParty.ClickEditButton();
            PG3_InvParty.updateOrganizationField(data.updatedOrgname);
            PG3_InvParty.clickSaveButton();
        }


        [When("Edit additionalInvolvedPartyType for non-Enumerated provider,Change the data and save the changes")]
        public void WhenEditAdditionalInvolvedPartyTypeForNonEnumeratedProviderChangeTheDataAndSaveTheChanges(DataTable dataTable)
        {
            var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.ClickInvolvedPartyEditButton();
            PG3.updateOrganizationField(data.updatedOrgname);
            PG3.clickSaveButton();
        }

        [When("Delete additionalInvolvedPartyType")]
        public void WhenDeleteAdditionalInvolvedPartyType()
        {
            var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            PG3.ClickInvolvedPartyDeleteButton();
            
        }

        [When("Edit Primary InvovePartyType for non-Enumerated member,Change the data and save the changes")]
        public void WhenEditPrimaryInvovePartyTypeForNonEnumeratedMemberChangeTheDataAndSaveTheChanges(DataTable dataTable)
        {
            var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.ClickEditButton();
            PG3.updateOrganizationField(data.updatedOrgname);
            PG3.clickSaveButton();
        }


        [When("Edit Primary InvovePartyType for non-Enumerated organization,Change the data and save the changes")]
        public void WhenEditPrimaryInvovePartyTypeForNonEnumeratedOrganizationChangeTheDataAndSaveTheChanges(DataTable dataTable)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.ClickEditButton();
            PG3.updateOrganizationField(data.updatedOrgname);
            PG3.clickSaveButton();
        }


        [Then("Validate the updated data of the Primary Subject type")]
        public void ThenValidateTheUpdatedDataOfThePrimarySubjectType(DataTable dataTable)
        {
            //var PG3 = new InvolvedParties_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 400);
            PG3_InvParty.clickGoToPreviousSectionButton();
            Assert.That(PG3_InvParty.GetOrganizationFieldValue(), Is.EqualTo(data.updatedOrgname), "Organization name was not updated correctly");
            PG3_InvParty.ClickProceedToNextSectionButton();
        }

        [Then("Validate the updated data of the Primary Subject type as member")]
        public void ThenValidateTheUpdatedDataOfThePrimarySubjectTypeAsMember(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyTypeasMember_page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 400);
            PG3_Member.clickGoToPreviousSectionButton();
            Assert.That(PG3_Member.getFirstName(), Is.EqualTo(data.updatedFirstName), "First name was not updated correctly");
            PG3_Member.ClickProceedToNextSectionButton();
        }

        [Then("Validate the updated data of the Primary Subject type as non-enumerated provider")]
        public void ThenValidateTheUpdatedDataOfThePrimarySubjectTypeAsNonEnumeratedProvider(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 400);
            PG3InvPrtyNONEnum.clickGoToPreviousSectionButton();
            Assert.That(PG3InvPrtyNONEnum.GetOrganizationFieldValue(), Is.EqualTo(data.updatedOrgname), "Organization name was not updated correctly");
            PG3InvPrtyNONEnum.ClickProceedToNextSectionButton();
        }
        [Then("Validate the updated data of the additional involved party Subject type as non-enumerated provider")]
        public void ThenValidateTheUpdatedDataOfTheAdditionalInvolvedPartySubjectTypeAsNonEnumeratedProvider(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 400);
            PG3InvPrtyNONEnum.ClickInvolvedPartyEditButton();
            Assert.That(PG3InvPrtyNONEnum.GetOrganizationFieldValue(), Is.EqualTo(data.updatedOrgname), "Organization name was not updated correctly");
            PG3InvPrtyNONEnum.clickCancelButton();

        }

        [Then("Validate the updated data of the Primary Subject type as non-enumerated Organization")]
        public void ThenValidateTheUpdatedDataOfThePrimarySubjectTypeAsNonEnumeratedOrganization(DataTable dataTable)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 400);
            PG3.clickGoToPreviousSectionButton();
            Assert.That(PG3.GetOrganizationFieldValue(), Is.EqualTo(data.updatedOrgname), "Organization name was not updated correctly");
            PG3.ClickProceedToNextSectionButton();
        }

        [Then("Validate the updated data of the Primary Subject type as non-enumerated member")]
        public void ThenValidateTheUpdatedDataOfThePrimarySubjectTypeAsNonEnumeratedMember(DataTable dataTable)
        {
            var PG3 = new additionalInvolvedParty_page4(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 400);
            PG3.clickGoToPreviousSectionButton();
            Assert.That(PG3.GetOrganizationFieldValue(), Is.EqualTo(data.updatedOrgname), "Organization name was not updated correctly");
            PG3.ClickProceedToNextSectionButton();
        }




        [When("enter InvolvedParty Non-Enumertaed Organization orgname , Tin , LicenseNumber ,other and other ID")]
        public void WhenEnterInvolvedPartyNon_EnumertaedOrganizationOrgnameTinLicenseNumberOtherAndOtherID(DataTable dataTable)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.EnterOrganizationName(data.orgname);
            PG3.EnterTIN_OR_EIN(data.TIN);
            PG3.EnterLicenseNumber(data.licenseNumber);
            PG3.EnterOther(data.other);
            PG3.EnterOtherID(data.otherID);
        }

        [When("enter  how witness or external party reported this, any additional info")]
        public void WhenEnterNameprefixFirstnameMiddlenameLastnameDesignationHowWitnessOrExternalPartyReportedThisAnyAdditionalInfo(DataTable dataTable)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
           
            PG3.EnterHowDidThisExternalReferringPartyReportThis(data.detectedAs);
            PG3.EnterAnyAdditionalInformationRegardingTheWitnessOrExternalReferringParty(data.detectedAs);
        }

        [When("enter nameprefix,firstname, middlename, lastname, designation")]
        public void WhenEnterNameprefixFirstnameMiddlenameLastnameDesignation(DataTable dataTable)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.EnterContactNamePrefix(data.namePrefix);
            PG3.EnterContactFirstName(data.firstName);
            PG3.EnterContactMiddleName(data.middleName);
            PG3.EnterContactLastName(data.lastName);
            PG3.EnterContactDesignation(data.designation);
            
        }
        [When("enter how witness or external party reported this, any additional info")]
        public void WhenEnterHowWitnessOrExternalPartyReportedThisAnyAdditionalInfo(DataTable dataTable)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            //var PG4 = new InvolvedPartyTypeasMember_page3(Driver);
            if (PG3_Member.getWitnessDropdownValue().Equals("Yes"))
            {
                PG3.EnterHowDidThisExternalReferringPartyReportThis(data.detectedAs);
                PG3.EnterAnyAdditionalInformationRegardingTheWitnessOrExternalReferringParty(data.detectedAs);
            }
        }
           




        [When("street address line one , street address line two, city , state , county , zip code, country, fax and email  for the involved party")]
        public void WhenStreetAddressLineOneStreetAddressLineTwoCityStateCountyZipCodeCountryFaxAndEmailForTheInvolvedParty(DataTable dataTable)
        {
            var PG3 = new OnlineReferral_Referral_Page_Organization(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3.EnterAddress1(data.Address1);
            PG3.EnterAddress2(data.Address2);
            PG3.EnterCity(data.City);
            PG3.EnterState(data.State2);
            PG3.EnterCounty(data.City2);
            PG3.EnterZipCode(data.Zip);
            PG3.EnterCountry(data.Country);
            PG3.EnterFax(data.fax);
            PG3.EnterEmail(data.EmailAddress);
        }


       




        [When("enter InvolvedParty Designation  ,DOB , SSN ,  licenseNumber ,other ID ,other")]
        public void WhenEnterInvolvedPartyDesignationAsDOBAsSSNAsLicenseNumberAsOtherIDAsOtherAs(DataTable dataTable)
        {
            //var PG3 = new InvolvedPartyasNonEnumeratedProvider_Page3(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            PG3InvPrtyNONEnum.EnterDesignation(data.designation);
            PG3InvPrtyNONEnum.EnterDOB(data.DOB);
            PG3InvPrtyNONEnum.EnterSSN(data.SSN);
            PG3InvPrtyNONEnum.EnterLicenseNumber(data.licenseNumber);
            PG3InvPrtyNONEnum.EnterOtherID(data.otherID);
            PG3InvPrtyNONEnum.EnterOther(data.other);
        }






       



    }

    }




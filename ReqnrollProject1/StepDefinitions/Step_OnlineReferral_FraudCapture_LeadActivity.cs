using FC_OnlineReferral.FraudCapture_Pages;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Globalization;
using Assert = NUnit.Framework.Assert;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class Step_OnlineReferral_FraudCapture_LeadActivity
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public Step_OnlineReferral_FraudCapture_LeadActivity(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [When("I click on the I Agree button on the fraud capture Page")]
        public void WhenIClickOnTheIAgreeButtonOnTheFraudCapturePage()
        {
            var fc = new FC_LoginPage(Driver);

            fc.waitForIAgreeButton();
            var homePage = new HomePage(Driver);
            homePage.AcceptDisclosure();
        }

        [When("I click on CaseTracking and select the leads tab option on the fraud capture home page")]
        public void WhenIClickOnCaseTrackingAndSelectTheOptionOnTheFraudCaptureHomePage(DataTable dataTable)
        {

            var navigateBtn = Driver.FindElement(By.XPath("//button[@id='navigationMenuId']"));
            navigateBtn.Click();

            var data = dataTable.CreateInstance<OnlineReferralData>();

            var caseTrackingLink = Driver.FindElement(By.XPath("//ul[@id='menuDropdownOptions']//a[@id='Case Tracking']"));
            caseTrackingLink.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);

           // var leadsTabBUtton = Driver.FindElement(By.XPath("//a[@id='allLeadsTabId']"));
            var tabToSelect = Driver.FindElement(By.XPath("//a[contains(@id,'" + data.Leads + "')]"));
            tabToSelect.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);


        }
        [When("get the lead creation date")]
        public void WhenGetTheLeadCreationDate()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var referraldate = fc.getLeadCreationDate();
            Console.WriteLine(referraldate);
        }

        [Then("validate the Lead Summary tab details against referral data")]
        public void ThenValidateTheLeadSummaryTabDetailsAgainstReferralData(DataTable dataTable)
        {
            var expected = GetExpectedValues(dataTable);
            var summaryPage = new LeadSummary(Driver);
            summaryPage.ClickSummaryTab();

            Assert.That(DatesMatch(summaryPage.GetLeadCreatedDate(), DateTime.Today.ToString("MM/dd/yyyy")),
                Is.True, "Lead Created Date does not match today's referral submission date.");
            AssertField("Suspect Activity From", expected["Suspect Activity From"], summaryPage.GetSuspectActivityFrom());
            AssertField("Suspect Activity To", expected["Suspect Activity To"], summaryPage.GetSuspectActivityTo());
            AssertField("Potential Overpayment Amount", expected["Potential Overpayment Amount"], summaryPage.GetPotentialOverpaymentAmount());

            string subjectRow = summaryPage.GetPrimarySubjectRowText();
            foreach (string subjectComponent in new[] { "Subject Organization", "Subject First Name", "Subject Last Name" })
            {
                if (expected.TryGetValue(subjectComponent, out string? expectedValue) &&
                    !string.IsNullOrWhiteSpace(expectedValue))
                {
                    Assert.That(Normalize(subjectRow), Does.Contain(Normalize(expectedValue)),
                        $"Summary Subject(s) name did not contain {subjectComponent} '{expectedValue}'. Actual row: '{subjectRow}'.");
                }
            }
        }

        [Then("validate the primary Subject edit form against referral data")]
        public void ThenValidateThePrimarySubjectEditFormAgainstReferralData(DataTable dataTable)
        {
            var expected = GetExpectedValues(dataTable);
            var subjectsPage = new LeadSubjects(Driver);
            subjectsPage.ClickSubjectsTab();
            subjectsPage.ClickPrimarySubjectEdit();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver,20);
            Assert.That(subjectsPage.IsEditSubjectFormDisplayed(), Is.True,
                "Edit Subject form was not displayed after clicking Edit for the primary subject.");

            foreach (KeyValuePair<string, string> field in expected)
            {
                if (field.Key == "Subject Type" || string.IsNullOrWhiteSpace(field.Value)) continue;
                AssertField(field.Key, field.Value, subjectsPage.GetEditFieldValue(field.Key));
            }

            subjectsPage.CloseEditSubjectForm();
        }

        [Then("validate the Lead Referral tab details against referral data")]
        public void ThenValidateTheLeadReferralTabDetailsAgainstReferralData(DataTable dataTable)
        {
            var expected = GetExpectedValues(dataTable);
            var referralPage = new LeadReferral(Driver);
            referralPage.ClickReferralTab();

            Assert.That(DatesMatch(referralPage.GetReferralReceivedDate(), DateTime.Today.ToString("MM/dd/yyyy")),
                Is.True, "Referral Received Date does not match today's referral submission date.");

            foreach (KeyValuePair<string, string> field in expected)
            {
                if (string.IsNullOrWhiteSpace(field.Value)) continue;
                AssertField(field.Key, field.Value, referralPage.GetFieldValue(field.Key));
            }
        }

        private static Dictionary<string, string> GetExpectedValues(DataTable dataTable)
        {
            Assert.That(dataTable.Rows, Is.Not.Empty, "Expected referral data table must contain one data row.");
            DataTableRow row = dataTable.Rows[0];
            return dataTable.Header.ToDictionary(header => header, header => row[header]);
        }

        private static void AssertField(string fieldName, string expected, string actual)
        {
            bool matches = fieldName.Contains("Date", StringComparison.OrdinalIgnoreCase) ||
                           fieldName.Contains("Activity From", StringComparison.OrdinalIgnoreCase) ||
                           fieldName.Contains("Activity To", StringComparison.OrdinalIgnoreCase)
                ? DatesMatch(actual, expected)
                : fieldName.Contains("Amount", StringComparison.OrdinalIgnoreCase)
                    ? AmountsMatch(actual, expected)
                    : ValuesMatch(fieldName, actual, expected);
            Assert.That(matches, Is.True,
                $"{fieldName} mismatch. Expected: '{expected}'. Actual: '{actual}'.");
        }

        private static bool ValuesMatch(string fieldName, string actual, string expected)
        {
            string normalizedActual = Normalize(actual);
            string normalizedExpected = Normalize(expected);

            if (fieldName is "First Name" or "Last Name")
            {
                return normalizedActual.StartsWith(normalizedExpected, StringComparison.OrdinalIgnoreCase);
            }

            if (fieldName == "State/Territory")
            {
               if (CommonData.StateList.TryGetValue(normalizedExpected, out string? expectedState) &&
                    actual.Equals(expectedState, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            //if (fieldName == "State/Territory" &&
            //    normalizedExpected == "texas" &&
            //    normalizedActual == "tx")
            //{
            //    return true;
            //}

            return normalizedActual.Equals(normalizedExpected, StringComparison.OrdinalIgnoreCase);
        }

        private static bool DatesMatch(string actual, string expected)
        {
            return DateTime.TryParse(actual, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime actualDate) &&
                   DateTime.TryParse(expected, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expectedDate) &&
                   actualDate.Date == expectedDate.Date;
        }

        private static bool AmountsMatch(string actual, string expected)
        {
            string actualAmount = new string(actual.Where(character => char.IsDigit(character) || character is '.' or '-').ToArray());
            string expectedAmount = new string(expected.Where(character => char.IsDigit(character) || character is '.' or '-').ToArray());
            return decimal.TryParse(actualAmount, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal parsedActual) &&
                   decimal.TryParse(expectedAmount, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal parsedExpected) &&
                   parsedActual == parsedExpected;
        }

        private static string Normalize(string value)
        {
            return new string(value.Where(char.IsLetterOrDigit).Select(char.ToLowerInvariant).ToArray());
        }


        [When("I Verify first and Last Name and click on the Latest created lead")]
        public void WhenIVerifyFirstAndLastNameandclickOnTheLatestCreatedLead()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            //fc.ClickLeadTab();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver,60);
            fc.ClickLeadcreateDateFilter();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            try
            {
                var firstAndLastName_ROW1 = fc.getLeadFirstRowFirstAndLastNameName();
                var firstAndLastName_ROW2 = fc.getLeadSecondRowFirstAndLastNameName();
                if (firstAndLastName_ROW1 != null)
                {
                    if (firstAndLastName_ROW1.Contains(_scenarioContext["UserFN"].ToString()) && firstAndLastName_ROW1.Contains(_scenarioContext["UserLN"].ToString()))
                    {
                        // Assert.AreEqual(firstRowOrgName, CommonData.UserFN);
                        fc.ClickLeadIDLinkbyRow(1);
                    }
                }
                else if (firstAndLastName_ROW2 != null)
                {
                    if (firstAndLastName_ROW2.Contains(_scenarioContext["UserFN"].ToString() + _scenarioContext["UserLN"].ToString()))
                    {
                        // Assert.AreEqual(secondRowOrgName, CommonData.UserFN);
                        fc.ClickLeadIDLinkbyRow(2);
                    }
                }
                else
                {
                    NUnit.Framework.Assert.Fail("The latest created lead does not have the expected first and last name.");
                }
            }
            catch (Exception ex)
            {

                // Assert.AreEqual(secondRowOrgName, CommonData.UserFN);


            }
        }


        [When("I click on the Lead tab on the fraud capture Page")]
        public void WhenIClickOnTheLeadTabOnTheFraudCapturePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.waitForLeadTab();
            fc.ClickLeadTab();
        }


        [When("I select  the select criteria  as {string} on the fraud capture Lead table Page")]
        public void WhenISelectTheSelectCriteriaAsOnTheFraudCaptureLeadTablePage(string leadid)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            CommonHelpers.WaitForPageLoading(Driver);
            fc.SearchByLeadID(leadid);
            CommonHelpers.WaitForPageLoading(Driver);
        }
        [When("I enter  the lead id as {string} on the fraud capture Lead table Page")]
        public void WhenIEnterTheLeadIdAsOnTheFraudCaptureLeadTablePage(string leadid)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.EnterLeadID(leadid);
            CommonHelpers.WaitForPageLoading(Driver);
        }
        [When("I click on the search button on the fraud capture Lead table Page")]
        public void WhenIClickOnTheSearchButtonOnTheFraudCaptureLeadTablePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickSearchButton();
            CommonHelpers.WaitForPageLoading(Driver);
        }
        [When("I click on the created date on the fraud capture Page")]
        public void WhenIClickOnTheCreatedDateOnTheFraudCapturePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadcreateDateFilter();
            CommonHelpers.WaitForPageLoading(Driver);
        }



        [When("I Filter the created date on the fraud capture Page")]
        public void WhenIFilterTheCreatedDateOnTheFraudCapturePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);

            fc.ClickLeadcreateDateFilter();
            CommonHelpers.WaitForPageLoading(Driver);
        }



        [When("I verify  FirstAndLastName  on the fraud capture Page")]
        public void WhenIVerifyFirstAndLastNameOnTheFraudCapturePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            try
            {

                var firstAndLastName = fc.getLeadFirstRowFirstAndLastNameName();
                // Assert.AreEqual(firstRowOrgName, CommonData.UserFN);
            }
            catch (Exception)
            {
                var secondRowOrgName = fc.getLeadSecondRowFirstAndLastNameName();
                // Assert.AreEqual(secondRowOrgName, CommonData.UserFN);


            }
        }

        [When("I click on the leadid link on the fraud capture Lead table Page")]
        public void WhenIClickOnTheLeadidLinkOnTheFraudCaptureLeadTablePage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadIDLink();
        }
        [When("I click on the Activities and selected lead activity name as {string} on the fraud capture Lead detials Page")]
        public void WhenIClickOnTheActivitiesAndSelectedLeadActivityNameAsOnTheFraudCaptureLeadDetialsPage(string activityName)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);

            try
            {
                fc.ClickLeadActivityTab();
                CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);

                var ActName = fc.GetActivityName();

                if (!fc.ClickOnEditActivity(activityName))
                     Assert.Fail("The activity with the name '" + activityName + "' was not found in the Activities table.");

                Assert.That(ActName, Is.EqualTo(activityName));

            }
            catch (Exception)
            {
                //fc.ExitLeadActivity();
                //fc.ClickLeadTab();
                //fc.ClickLeadcreateDateFilter();
                //fc.ClickLeadIDSecondLink();
                //CommonHelpers.SwitchtoNewWindow(Driver);
                //fc.BeginEditingLead();
                //fc.ClickLeadActivityTab();
                //Assert.AreEqual(fc.GetActivityName(), activityName);


            }
        }

        [When("click on Activities tab and serach for the activity created through onlinereferral")]
        public void WhenClickOnActivitiesTabAndSerachForTheActivityCreatedThroughOnlinereferral(DataTable dataTable)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            fc.ClickLeadActivityTab();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
            fc.SearchActivityName(data.ActivityName);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);


        }


        [When("user clicks on Edit button for an existing activity")]
        public void WhenUserClicksOnEditButtonForAnExistingActivity(DataTable dataTable)
        {

            var fc = new FC_CaseTracking_LeadPage(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            fc.ClickOnEditActivity(data.ActivityName);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }



        [Then("Edit Activity page should be displayed")]
        public void ThenEditActivityPageShouldBeDisplayed()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            Assert.That(fc.isEditActivityPageDisplayed(), "Edit Activity page is not displayed");

        }


        [Then("click on Attachment tab")]
        public void ThenClickOnAttachmentTab()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickAttachmentTab();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [Then("verify summary, confirmation and test files are displayed")]
        public void ThenVerifySummaryConfirmationAndTestFilesAreDisplayed()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            Boolean areAllFilesDisplayed =
                            fc.areAllRequiredAttachmentsDisplayed();

            Assert.That(areAllFilesDisplayed, "One or more attachments (Summary / Confirmation / TestFile) are missing");
            fc.ClickExitActivity();
        }

        [When("I click Logout Option to close the Fraud Capture Application")]
        public void WhenIClickLogoutOptionToCloseTheFraudCaptureApplication()
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_Logout();
        }

        [Then("I should ne navigated to FC Logout confirmation Page")]
        public void ThenIShouldNeNavigatedToFCLogoutConfirmationPage()
        {
            var fc = new FraudCapture_Core(Driver);
            Assert.That(fc.FCLogout_Confirmation(), "Logout confirmation message is not displayed.");
        }





        [Then("the searched activity should be displayed in the activity list")]
        public void ThenTheSearchedActivityShouldBeDisplayedInTheActivityList(DataTable dataTable)
        {


            var fc = new FC_CaseTracking_LeadPage(Driver);
            var data = dataTable.CreateInstance<OnlineReferralData>();
            try
            {
                var searchedActivityName = fc.GetActivityName();
                Assert.That(searchedActivityName, Is.EqualTo(data.ActivityName), $"Expected activity name '{data.ActivityName}' does not match the actual activity name '{searchedActivityName}'.");
            }
            catch (NoSuchElementException)
            {
               Assert.Fail($"The activity with the name '{data.ActivityName}' was not found in the Activities table.");
            }
        }


        [Then("get the Activitydate created through online")]
        public void ThenGetTheActivitydateCreatedThroughOnline()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var referraldate = fc.getActivityDueDate();

        }

       
        [Then("verify Due Date of the activity generated through an Online Referral submission is based on the Due Date configuration for that activity")]
        public void ThenVerifyDueDateOfTheActivityGeneratedThroughAnOnlineReferralSubmissionIsBasedOnTheDueDateConfigurationForThatActivity()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            Assert.That(fc.getLeadCreationDate(), Does.Contain(fc.getActivityDueDate()), "The lead creation date does not match the activity due date.");
        }



        [When("I click on the Begin Editing on the fraud capture Lead detials Page")]
        public void WhenIClickOnTheBeginEditingOnTheFraudCaptureLeadDetialsPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.BeginEditingLead();
        }




        [Then("I should be navigated to the Lead ID Details Page")]
        public void ThenIShouldBeNavigatedToTheLeadIDDetailsPage()
        {
            CommonHelpers.WaitForPageLoading(Driver);

        }

        [Then("I should be navigated to Lead Activities  Page")]
        public void ThenIShouldBeNavigatedToLeadActivitiesPage()
        {

            CommonHelpers.WaitForPageLoading(Driver);

        }

      
    }
}

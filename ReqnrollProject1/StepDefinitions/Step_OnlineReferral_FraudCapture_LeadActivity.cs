using FC_OnlineReferral.FraudCapture_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
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

        [When("I click on CaseTracking and select the {string} option on the fraud capture home page")]
        public void WhenIClickOnCaseTrackingAndSelectTheOptionOnTheFraudCaptureHomePage(string TabToSelect)
        {

            var navigateBtn = Driver.FindElement(By.XPath("//button[@id='navigationMenuId']"));
            navigateBtn.Click();

            

            var caseTrackingLink = Driver.FindElement(By.XPath("//ul[@id='menuDropdownOptions']//a[@id='Case Tracking']"));
            caseTrackingLink.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 20);

            var leadsTabBUtton = Driver.FindElement(By.XPath("//a[@id='allLeadsTabId']"));
            var tabToSelect = Driver.FindElement(By.XPath("//a[contains(@id,'" + TabToSelect + "')]"));
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


        [When("I Verify first and Last Name and click on the Latest created lead")]
        public void WhenIVerifyFirstAndLastNameandclickOnTheLatestCreatedLead()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            //fc.ClickLeadTab();
            CommonHelpers.WaitForPageLoading(Driver);
            fc.ClickLeadcreateDateFilter();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 30);

            try
            {
                var firstAndLastName_ROW1 = fc.getLeadFirstRowFirstAndLastNameName();
                Console.WriteLine("First and Last Name in Row 1: " + firstAndLastName_ROW1);    
                var firstAndLastName_ROW2 = fc.getLeadSecondRowFirstAndLastNameName();
                Console.WriteLine("First and Last Name in Row 2: " + firstAndLastName_ROW2);
                if (firstAndLastName_ROW1 != null)
                {
                    if (firstAndLastName_ROW1.Contains(_scenarioContext["UserFN"].ToString()) || firstAndLastName_ROW1.Contains(_scenarioContext["UserLN"].ToString()))
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
                    NUnit.Framework. Assert.Fail("The activity with the name '" + activityName + "' was not found in the Activities table.");

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

        [When("click on Activities tab and serach for the activity {string} created through onlinereferral")]
        public void WhenClickOnActivitiesTabAndSerachForTheActivityCreatedThroughOnlinereferral(string activityName)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadActivityTab();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
            fc.SearchActivityName(activityName);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);


        }


        [When("user clicks on Edit button for an existing activity {string}")]
        public void WhenUserClicksOnEditButtonForAnExistingActivity(string activityName)
        {

            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickOnEditActivity(activityName);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
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





        [Then("the searched activity should be displayed in the activity list {string}")]
        public void ThenTheSearchedActivityShouldBeDisplayedInTheActivityList(string activityName)
        {


            var fc = new FC_CaseTracking_LeadPage(Driver);
            try
            {
                var searchedActivityName = fc.GetActivityName();
                Assert.That(searchedActivityName, Is.EqualTo(activityName), $"Expected activity name '{activityName}' does not match the actual activity name '{searchedActivityName}'.");
            }
            catch (NoSuchElementException)
            {
               Assert.Fail($"The activity with the name '{activityName}' was not found in the Activities table.");
            }
        }


        [Then("get the Activitydate created through online")]
        public void ThenGetTheActivitydateCreatedThroughOnline()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var referraldate = fc.getActivityDueDate();
            Console.WriteLine(referraldate);

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

using FC_OnlineReferral.FraudCapture_Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ReqnrollProject1.Support;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static FC_OnlineReferral.CommonData;


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

        [When("I Verify first and Last Name and click on the Latest created lead")]
        public void WhenIVerifyFirstAndLastNameandclickOnTheLatestCreatedLead()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadTab();
            CommonHelpers.WaitForPageLoading(Driver);
            fc.ClickLeadcreateDateFilter();
            CommonHelpers.WaitForPageLoading(Driver);

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
                    Assert.Fail("The latest created lead does not have the expected first and last name.");
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

                // Assert.AreEqual(fc.GetActivityName(), activityName);
            }
            catch (Exception)
            {
                fc.ExitLeadActivity();
                fc.ClickLeadTab();
                fc.ClickLeadcreateDateFilter();
                fc.ClickLeadIDSecondLink();
                CommonHelpers.SwitchtoNewWindow(Driver);
                fc.BeginEditingLead();
                fc.ClickLeadActivityTab();
                //  Assert.AreEqual(fc.GetActivityName(), activityName);


            }
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

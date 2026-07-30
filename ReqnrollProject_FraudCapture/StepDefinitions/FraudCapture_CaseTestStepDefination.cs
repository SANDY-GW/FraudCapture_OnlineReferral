using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FC_OnlineReferral.FraudCapture_Pages;
using FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace FraudCapture_BDD.StepDefinitions
{
    [Binding]
    public class FraudCapture_CaseTestStepDefination
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));

        public FraudCapture_CaseTestStepDefination(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("I filter Assigned To Dropdown with {string}")]
        public void WhenIFilterAssignedToDropdownWith(string assignedTo)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
            Driver.FindElement(By.Id("dropdownLeadListUser")).Click();
            Driver.FindElement(By.XPath($"//ul[@id='leadListAssignedTo']//a[normalize-space()='{assignedTo}']")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I search for {string} under Select Criteria dropdown")]
        public void WhenISearchForUnderSelectCriteriaDropdown(string criteria)
        {
            var select = new SelectElement(Driver.FindElement(By.Id("leadSearchCriteria")));
            select.SelectByText(criteria);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I search for Lead ID as {string}")]
        public void WhenISearchForLeadIDAs(string leadId)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath("//form[@id='LeadSearchForm']/descendant::input[@id='searchInputField']"), 20);
            var input = Driver.FindElement(By.XPath("//form[@id='LeadSearchForm']/descendant::input[@id='searchInputField']"));
            input.Clear();
            input.SendKeys(leadId);
        }

        [When("I click on search button for lead search")]
        public void WhenIClickOnSearchButtonForLeadSearch()
        {
            CommonHelpers.WaitForElementClickable(Driver, By.XPath("//form[@id='LeadSearchForm']/descendant::button[@id='searchStartButton']"), 20);
            Driver.FindElement(By.XPath("//form[@id='LeadSearchForm']/descendant::button[@id='searchStartButton']")).Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I click on the Lead ID Link {string}")]
        public void WhenIClickOnTheLeadIDLink(string leadId)
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.ClickLeadIDLinkbyRow(1);
        }

        [When("I click on the Begin Editing on the fraud capture Lead detials Page")]
        public void WhenIClickOnTheBeginEditingOnTheFraudCaptureLeadDetialsPage()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            fc.BeginEditingLead();
        }

        [When("I verify the Lead ID link {string} is opened")]
        public void WhenIVerifyTheLeadIDLinkIsOpened(string leadId)
        {
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);

            var leadIdElement = Driver.FindElement(By.XPath($"//h1[contains(text(),'{leadId}')]"));
            if (leadIdElement.Displayed)
            {
                _scenarioContext["VerifiedLeadId"] = leadId;
            }

            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }

        //[When("I click on Begin Editing button")]
        //public void WhenIClickOnBeginEditingButton()
        //{
        //    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        //    var BeginEditingButton = Driver.FindElement(By.XPath("//div[@id='leadcomponent']/descendant::button[@id='leadViewEditEndButton']"));


        //    try
        //    {
        //        if (BeginEditingButton.Displayed)
        //        {
        //            BeginEditingButton.Click();
        //            CommonHelpers.WaitForPageLoading(Driver);
        //        }
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        //already in Edit mode, move along
        //    }
        //}


        [When("I store all lead summary dropdown values")]
        public void WhenIStoreAllLeadSummaryDropdownValues()
        {
            var leadSummary = new LeadSummary(Driver);
            var leadData = leadSummary.GetAllLeadSummaryData();
            _scenarioContext["LeadSummaryData"] = leadData;

            // Log all values for reference
            foreach (var kvp in leadData)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        [When("I change the Lead Status dropdown to {string}")]
        public void WhenIChangeTheLeadStatusDropdownTo(string leadStatus)
        {
            var leadStatusElement = Driver.FindElement(By.Id("leadStatusNR"));
            var select = new SelectElement(leadStatusElement);
            select.SelectByText(leadStatus);
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);
        }

        [When("I validate Status Change and Case Creation popup is displayed")]
        public void WhenIValidateStatusChangeAndCaseCreationPopupIsDisplayed()
        {
            try
            {
                CommonHelpers.WaitForElementVisiblity(Driver,
                    By.XPath("//div[contains(@class,'darkNavy-fc title1') and contains(normalize-space(),'Status Change & Case Creation')]"),
                    20);
                var popup = Driver.FindElement(By.XPath("//div[contains(@class,'darkNavy-fc title1') and contains(normalize-space(),'Status Change & Case Creation')]"));
                if (popup.Displayed)
                {
                    _scenarioContext["PopupDisplayed"] = true;
                }
            }
            catch
            {
                _scenarioContext["PopupDisplayed"] = false;
            }
        }

        [When("I click on {string} button")]
        public void WhenIClickOnButton(string buttonText)
        {
            var button = Driver.FindElement(By.XPath($"//button[contains(normalize-space(),'{buttonText}')]"));
            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath($"//button[contains(normalize-space(),'{buttonText}')]"), 20);
            button.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }
    }
}

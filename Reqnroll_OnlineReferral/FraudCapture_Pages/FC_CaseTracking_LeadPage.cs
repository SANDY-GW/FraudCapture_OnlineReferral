using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    internal class FC_CaseTracking_LeadPage: BaseSettings
    {
        public FC_CaseTracking_LeadPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        //Add xpath here
        private readonly By LeadTab = By.XPath("//a[@idallLeadsTabId");
        private readonly By LeadSearchCriteria = By.XPath("//select[@id='leadSearchCriteria']");
        private readonly By LeadSearchTextBox = By.XPath("//input[@id='searchInputField']");
        private readonly By LeadSearchButton = By.XPath("//button[@id='searchStartButton']");
        private readonly By LeadSearchClearButton = By.XPath("//button[@id='searchClearButton']");
        private readonly By LeadIDLink= By.XPath("//table/tbody/tr/td[2]/small");
        private readonly By BeginEditing = By.XPath("//button[@id='leadViewEditEndButton']");
        private readonly By ActivitiesDetailsTab = By.XPath("//button[@id='activitiesDetailsTabId']");
        private readonly By ActivitiesEditButton = By.XPath("//button[@id='editActivityId']");
        private readonly By ActivitiesViewButton = By.XPath("//button[@id='editActivityId']//following-sibling::button[contains(text(),'View')");
        private readonly By ActivitiesAttachmentTab = By.XPath("//button[@id='attachmentTabId']");
        #endregion
        public void ClickLeadTab() { 
            Driver.FindElement(LeadTab).Click();
        }
        public void SelectLeadSearchCriteria(string searchCriteria)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, LeadSearchCriteria, 10);
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadSearchCriteria), searchCriteria);

        }
        public void EnterLeadSearchCriteriaText(string searchCriteriaText)
        {
            Driver.FindElement(LeadSearchTextBox).SendKeys(searchCriteriaText);
        }
        public void ClickLeadActivitiesEdit()
        {
            Driver.FindElement(ActivitiesEditButton).Click();
        }
       
        public void ClickLeadActivitiesDetailsTab()
        {
            Driver.FindElement(ActivitiesDetailsTab).Click();
        }
        public void ClickLeadActivitiesView()
        {
            Driver.FindElement(ActivitiesViewButton).Click();
        }
        public void ClickLeadSearch()
        {
            Driver.FindElement(LeadSearchButton).Click();
        }
        public void ClickLeadSearchClear()
        {
            Driver.FindElement(LeadSearchClearButton).Click();
        }
        public void ClickLeadIDLink()
        {
            Driver.FindElement(LeadIDLink).Click();
        }
        public void ClickBeginEditing()
        {
            Driver.FindElement(BeginEditing).Click();
        }
        public void ClickLeadActivitiesAttachment()
        {
            Driver.FindElement(ActivitiesAttachmentTab).Click();
        }
    }
}


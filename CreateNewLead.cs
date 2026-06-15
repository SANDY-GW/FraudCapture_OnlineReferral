using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab
{
    public class CreateNewLead : BaseSettings
    {
        public CreateNewLead(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By CreateNewLeadBtn = By.XPath("//button[contains(normalize-space(.),'Create New Lead')]");
        private readonly By LeadWorkflowTypeDropDown = By.XPath("//select[@id='leadCaseType']");
        private readonly By DetectionMethodDropDown = By.XPath("//select[@id='leadDetection']");
        private readonly By SourceTypeDropDown = By.XPath("//select[@id='leadSource']");
        private readonly By ReasonDropDown = By.XPath("//select[@id='leadReason']");
        private readonly By AssignedToDropDown = By.XPath("//select[@id='leadAssignedTo']");
        private readonly By NextBtn = By.XPath("//button[@id='next']");
        private readonly By SubjectTypeDropDown = By.XPath("//select[@id='subjectTypeVal']");
        private readonly By SubjectTypeSelectionDropDown = By.XPath("//select[@id='subjectTypeSelection']");
        #endregion

        public void ClickCreateNewLeadBtn()
        {
            Driver.FindElement(CreateNewLeadBtn).Click();
        }
        public void SelectLeadWorkflowType(string workflowType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(LeadWorkflowTypeDropDown), workflowType);
        }
        public void SelectDetectionMethod(string detectionMethod)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(DetectionMethodDropDown), detectionMethod);
        }
        public void SelectSourceType(string sourceType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(SourceTypeDropDown), sourceType);
        }
        public void SelectReason(string reason)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(ReasonDropDown), reason);
        }
        public void SelectAssignedTo(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(AssignedToDropDown), assignedTo);
        }
        public void ClickNextBtn()
        {
            Driver.FindElement(NextBtn).Click();
        }
        public void SelectSubjectType(string subjectType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(SubjectTypeDropDown), subjectType);
        }
        public void SelectSubjectTypeSelection(string subjectTypeSelect)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(SubjectTypeSelectionDropDown), subjectTypeSelect);
        }
    }
}
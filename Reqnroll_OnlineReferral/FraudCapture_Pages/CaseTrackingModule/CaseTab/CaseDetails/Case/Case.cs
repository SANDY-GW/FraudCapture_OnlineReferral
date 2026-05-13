using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Case
{
    public class Case : BaseSettings
    {
        public Case(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By caseTab = By.XPath("//*[@id=\"caseTabId\"]");
        private readonly By caseSummaryTab = By.XPath("//*[@id=\"summaryTabId\"]");
        private readonly By subjectNewTab = By.XPath("//*[@id=\"subjectNewTabId\"]");

        private readonly By relatedCasesTab = By.XPath("//*[@id=\"relatedCasesId\"]");
        private readonly By auditLogTab = By.XPath("//*[@id=\"auditlogTabId\"]");
        private readonly By editSubjectBtn = By.XPath("//*[@id=\"SubjectsNew0C110C20\"]");

        private readonly By deleteSubjectBtn = By.XPath("//*[@id=\"SubjectsNew0C110C21\"]");
        private readonly By caseViewSummaryAssignedToGorupDDL = By.XPath("//*[@id=\"caseViewSummaryAssignedToGroup\"]");
        private readonly By caseViewSummaryReferencedTxt = By.XPath("//*[@id=\"caseViewSummaryReferenceId\"]");
        private readonly By caseAssignedSupervisorDDL = By.XPath("//*[@id=\"caseAssignedSupervisorDisplayname\"]");
       
        private readonly By caseViewSummaryCaseStatusDDL = By.XPath("//*[@id=\"caseViewSummaryCaseStatusInfoNR\"]");

        private readonly By addSubjectBtn = By.XPath("//*[@id=\"subjectNew\"]/form/div/div[1]/button");

       

        #endregion

        public void ClickeditSubject()
        {
            Driver.FindElement(editSubjectBtn).Click();
        }
        public void ClickdeleteSubject()
        {
            Driver.FindElement(deleteSubjectBtn).Click();
        }
        public void ClickaddSubject()
        {
            Driver.FindElement(addSubjectBtn).Click();
        }
        public void SelectcaseViewSummaryAssignedToGorup(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseViewSummaryAssignedToGorupDDL), assignedTo);
        }
        public void SelectcaseAssignedSupervisor(string supervisor)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseAssignedSupervisorDDL), supervisor);
        }

        public void SelectcaseViewSummaryCaseStatus(string status)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(caseViewSummaryCaseStatusDDL), status);
        }

        public void EntercaseViewSummaryReferenced(string refId)
        {
            Driver.FindElement(caseViewSummaryReferencedTxt).SendKeys(refId);
        }
        public void ClickauditLogTab()
        {
            Driver.FindElement(auditLogTab).Click();
        }
        public void ClicksubjectNewTab()
        {
            Driver.FindElement(subjectNewTab).Click();
        }
        public void ClickrelatedCasesTab()
        {
            Driver.FindElement(relatedCasesTab).Click();
        }
        public void ClickCaseTab()
        {
            Driver.FindElement(caseTab).Click();
        }
        public void ClickcaseSummaryTab()
        {
            Driver.FindElement(caseSummaryTab).Click();
        }
    }
}

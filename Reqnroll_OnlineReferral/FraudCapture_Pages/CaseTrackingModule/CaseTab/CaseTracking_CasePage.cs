using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab
{
    public class CaseTracking_CasePage : BaseSettings
    {
        public CaseTracking_CasePage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        //Add xpath here
        
        private readonly By CasesTab = By.XPath("//a[@id='allCasesTabId']");
        private readonly By CaseCreateAdministrativeCase = By.XPath("//*[@id='CaseListAddButton']");
        private readonly By CaseWorkloadReassignment = By.XPath("//*[@id='reassignUserCaseTabId']/b");
        private readonly By CaseApplyCaseDynamicFiltering = By.XPath("//*[@id='applyCaseDynamicId']/b");
        private readonly By CaseAssignedTo = By.XPath("//*[@id='dropdownCaseListUser']");
        private readonly By CaseAssignedSupervisor = By.XPath("//*[@id='dropdownCaseListSupervisor']");
        private readonly By CaseDivisionDepartmentDDL = By.XPath("//*[@id='dropdownDepartmentDivision']");
        private readonly By CaseTypeDDL = By.XPath("//*[@id='dropDownCaseType']");
        private readonly By CaseStatus = By.XPath("//*[@id='caseStatus']");

        private readonly By CaseSearchCriteria = By.XPath("//*[@id='caseSearchCriteria']");
        private readonly By CaseSearchCriteriaTxtBox = By.XPath("//*[@id='searchInputField']");
        private readonly By CaseSearchCriteriaSearchBtn = By.XPath("//*[@id='searchStartButton']");
        private readonly By CaseSearchCriteriaClearBtn = By.XPath("//*[@id='searchClearButton']");
        private readonly By CaseExportList = By.XPath("//*[@id='allCases']/div[3]/div[1]/div/div[2]/div/button");


        private readonly By CaseHeaderCaseType = By.XPath("//*[@id='headerTableCases']/thead/tr/th[1]/small/b");
        private readonly By CaseHeaderCaseID = By.XPath("//*[@id='headerTableCases']/thead/tr/th[2]/small/b");
        private readonly By CaseHeaderCaseAltCaseID= By.XPath("//*[@id='headerTableCases']/thead/tr/th[3]/small/b");
        private readonly By CaseHeaderCaseRelatedCaseOrLeads = By.XPath("//*[@id='headerTableCases']/thead/tr/th[4]/small/b");
        private readonly By CaseHeaderAssignedTo = By.XPath("//*[@id='headerTableCases']/thead/tr/th[5]/small/b");
        private readonly By CaseHeaderAssignedSupervisor = By.XPath("//*[@id='headerTableCases']/thead/tr/th[6]/small/b");
        private readonly By CaseHeaderDivDept = By.XPath("//*[@id='headerTableCases']/thead/tr/th[7]/small/b");
        
        private readonly By CaseHeaderCreatedDate = By.XPath("//*[@id='headerTableCases']/thead/tr/th[9]/small/b");
        private readonly By CaseHeaderClosedDate = By.XPath("//*[@id='headerTableCases']/thead/tr/th[10]/small/b");
        private readonly By CaseHeaderStatus = By.XPath("//*[@id='headerTableCases']/thead/tr/th[11]/small/b");
        private readonly By CaseHeaderOverPayment = By.XPath("//*[@id='headerTableCases']/thead/tr/th[13]/small/b");

        #endregion

        public void ClickCaseTab()
        {
            driver.FindElement(CasesTab).Click();
        }
        public void ClickCaseCreateAdministrationCase()
        {
            driver.FindElement(CaseCreateAdministrativeCase).Click();
        }
        public void ClickCaseWorkLoadReassignment()
        {
            driver.FindElement(CaseWorkloadReassignment).Click();
        }
        public void ClickCaseApplyCaseDynamicFiltering()
        {
            driver.FindElement(CaseApplyCaseDynamicFiltering).Click();
        }
        public void SelectCaseAssignedTo(string assignedTo)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseAssignedTo, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(CaseAssignedTo), assignedTo);
        }
        public void SelectCaseAssignedSupervisor(string assignedSupervisor)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseAssignedSupervisor, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(CaseAssignedSupervisor), assignedSupervisor);
        }
        public void SelectCaseDivisionDept(string divDept)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseDivisionDepartmentDDL, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(CaseDivisionDepartmentDDL), divDept);
        }
        public void SelectCaseType(string caseType)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseTypeDDL, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(CaseTypeDDL), caseType);
        }
        public void SelectCaseStatus(string caseStatus)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseStatus, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(CaseStatus), caseStatus);
        }
        public void SelectCaseSearchCriteriaOption(string searchCriteria)
        {
            CommonHelpers.WaitForElementVisiblity(driver, CaseSearchCriteria, 10);
            CommonHelpers.selectOptionByValue(driver.FindElement(CaseSearchCriteria), searchCriteria);
        }
        public void EnterCaseSearchCriteria(string searchCriteriaValue)
        {
            driver.FindElement(CaseSearchCriteriaTxtBox).SendKeys(searchCriteriaValue);
        }
        public void ClickCaseSearchCriteriaSearchBtn()
        {
            driver.FindElement(CaseSearchCriteriaSearchBtn).Click();
        }
        public void ClickCaseSearchCriteriaClearBtn()
        {
            driver.FindElement(CaseSearchCriteriaClearBtn).Click();
        }
        public void ClickCaseExportList()
        {
            driver.FindElement(CaseExportList).Click();
        }
        public void ClickHeaderCaseType()
        {
            driver.FindElement(CaseHeaderCaseType).Click();
        }
        public void ClickHeaderCaseID()
        {
            driver.FindElement(CaseHeaderCaseRelatedCaseOrLeads).Click();
        }
        public void ClickHeaderAltCaseID()
        {
            driver.FindElement(CaseHeaderCaseAltCaseID).Click();
        }
        public void ClickHeaderRelatedCaseLeads()
        {
            driver.FindElement(CaseHeaderCaseRelatedCaseOrLeads).Click();
        }
        public void ClickHeaderAssignedTo()
        {
            driver.FindElement(CaseHeaderAssignedTo).Click();
        }
        public void ClickHeaderAssignedSupervisor()
        {
            driver.FindElement(CaseHeaderAssignedSupervisor).Click();
        }
        public void ClickHeaderDivDept()
        {
            driver.FindElement(CaseHeaderDivDept).Click();
        }
        public void ClickHeaderCreatedDate()
        {
            driver.FindElement(CaseHeaderCreatedDate).Click();
        }
        public void ClickHeaderClosedDate()
        {
            driver.FindElement(CaseHeaderClosedDate).Click();
        }
        public void ClickHeaderStatus()
        {
            driver.FindElement(CaseHeaderStatus).Click();
        }
        public void ClickHeaderOverPayment()
        {
            driver.FindElement(CaseHeaderOverPayment).Click();
        }

    }
}

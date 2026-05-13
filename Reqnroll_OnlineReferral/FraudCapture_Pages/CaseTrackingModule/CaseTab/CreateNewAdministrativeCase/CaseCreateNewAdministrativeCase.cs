using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CreateNewAdministrativeCase
{
    public class CaseCreateNewAdministrativeCase : BaseSettings
    {
        public CaseCreateNewAdministrativeCase(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By caseTab = By.XPath("//*[@id='allCasesTabId']");
        private readonly By creatAdministrativeCaseBtn = By.XPath("//*[@id='content-wrapper']/div/div[2]/div/fc-case-list/div/div/div[2]/div[1]");

        private readonly By projectNameTxt = By.XPath("//*[@id='caseProjectName']");
        private readonly By workflowTypeDDL = By.XPath("//*[@id='dropdownMenuWorkflowType']");
        private readonly By assignedWorkflowToDDL= By.XPath("//*[@id='dropdownMenuCaseUser']");

        private readonly By assignSupervisorDDL = By.XPath("//*[@id='dropdownMenuCaseSupervisor']");
        private readonly By assignDeptDivDDL = By.XPath("//*[@id='niDropdownMenuDepartment']");
        private readonly By assignSectionOrTeamDDL = By.XPath("//*[@id='niDropdownMenuSection']");
        private readonly By cancelBtn = By.XPath("//*[@id='CreateNonInvestigativeCase']/div[2]/button[1]");

        private readonly By createNewCaseBtn = By.XPath("//*[@id='CreateNonInvestigativeCase']/div[2]/button[2]");

        #endregion

        public void SelectAssignSectionOrTeam(string assignSectionOrTeam)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(assignSectionOrTeamDDL), assignSectionOrTeam);
        }
        public void SelectAssignDeptDiv(string assignDeptDiv)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(assignDeptDivDDL), assignDeptDiv);
        }
        public void SelectAssignSuperVisor(string assignSupervisor)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(assignSupervisorDDL), assignSupervisor);
        }

        public void SelectAssignedWorkFlow(string assignedWorkFlow)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(assignedWorkflowToDDL), assignedWorkFlow);
        }
        public void SelectworkflowType(string workFlowType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(workflowTypeDDL), workFlowType);
        }
        public void ClickCase()
        {
            Driver.FindElement(caseTab).Click();
        }
        public void ClickCreateAdministrationCase()
        {
            Driver.FindElement(creatAdministrativeCaseBtn).Click();
        }
        public void ClickCancel()
        {
            Driver.FindElement(cancelBtn).Click();
        }
        public void ClickCreateNewCase()
        {
            Driver.FindElement(createNewCaseBtn).Click();
        }
        public void EnterProjectName(string projectName)
        {
            Driver.FindElement(projectNameTxt).SendKeys(projectName);
        }
    }
}

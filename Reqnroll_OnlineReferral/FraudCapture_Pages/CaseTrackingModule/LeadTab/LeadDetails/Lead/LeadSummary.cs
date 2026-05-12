using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.LeadTab.LeadDetails.Lead
{
    public class LeadSummary : BaseSettings
    {
        public LeadSummary(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By alternateLeadIdTxt = By.XPath("//*[@id='altleadId']");
        private readonly By leadTypeDDL = By.XPath("//*[@id='leadCaseTypeEditNR']");
        private readonly By leadStatusDDL = By.XPath("//*[@id='leadStatusNR']");
        private readonly By leadAssignedToDDL = By.XPath("//*[@id=\"dropdownMenuLeadAssign\"]");
        private readonly By leadSupervisorDDL = By.XPath("//*[@id='dropdownMenuLeadSupervisorAssign']");
        private readonly By leadDivDeptDDL = By.XPath("//*[@id='divisiondep']");
        private readonly By leadSectionTeamDDL = By.XPath("//*[@id='SectionId']");

        #endregion
        public void SelectSectionTeam(string sectionId)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSectionTeamDDL), sectionId);
        }
        public void EnterAlernateLeadID(string altLeadID)
        {
            Driver.FindElement(alternateLeadIdTxt).SendKeys(altLeadID);
        }
        public void SelectLeadType(string leadType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadTypeDDL), leadType);
        }
        public void SelectLeadStatus(string leadStatus)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadStatusDDL), leadStatus);
        }
        public void SelectAssignedTo(string assignedTo)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadAssignedToDDL), assignedTo);
        }
        public void SelectSuperVisior(string supervisior)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadSupervisorDDL), supervisior);
        }
        public void SelectDivDept(string divDept)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(leadDivDeptDDL), divDept);
        }
    }
}

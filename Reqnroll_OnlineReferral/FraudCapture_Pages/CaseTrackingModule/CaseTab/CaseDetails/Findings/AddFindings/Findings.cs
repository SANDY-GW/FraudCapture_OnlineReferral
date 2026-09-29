using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Findings.AddFindings
{
    public class Findings : BaseSettings
    {
        public Findings(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By addFindingsBtn = By.XPath("//*[@id=\"finding\"]/div[1]/button");
        private readonly By subjectDDL = By.XPath("//*[@id=\"subjectId\"]");
        private readonly By findingReason = By.XPath("//*[@id=\"findingReasonId\"]");
        private readonly By LOBDDL = By.XPath("//*[@id=\"LOB\"]");

        private readonly By cancleBtn = By.XPath("//*[@id=\"detailsTab\"]/div[1]/button[1]");
        private readonly By saveBtn = By.XPath("//*[@id=\"btnOk\"]");

        private readonly By staticsticsByLOBDDL = By.XPath("//*[@id=\"LOB\"]");
        private readonly By finalizeFindingsBtn = By.XPath("//*[@id=\"finding\"]/div[1]/button[1]");
        private readonly By undoFinalizeBtn = By.XPath("//*[@id=\"finding\"]/div[1]/button[2]");


        private readonly By findingsEntityBreakDown = By.XPath("//*[@id=\"finding\"]/div[2]/div[1]/form/div/p/i");
        private readonly By findingDetailsSubjectName = By.XPath("//*[@id=\"Findings\"]/thead/tr/th[1]");
        private readonly By findingDetailsFinding = By.XPath("//*[@id=\"Findings\"]/thead/tr/th[2]");

        private readonly By findingDetailsFindingDate = By.XPath("//*[@id=\"Findings\"]/thead/tr/th[3]");
        private readonly By findingDetailsUnderPayment = By.XPath("//*[@id=\"Findings\"]/thead/tr/th[4]");
        private readonly By findingDetailsOverPayament= By.XPath("//*[@id=\"Findings\"]/thead/tr/th[5]");

        private readonly By findingsEntitySoftSaving = By.XPath("//*[@id=\"Findings\"]/thead/tr/th[6]");
       
        #endregion
        public void ClickAddFinding()
        {
            driver.FindElement(addFindingsBtn).Click();
        }
        public void ClickfindingsEntityBreakDown()
        {
            driver.FindElement(findingsEntityBreakDown).Click();
        }
        public void ClickfindingDetailsSubjectName()
        {
            driver.FindElement(findingDetailsSubjectName).Click();
        }
        public void ClickfindingDetailsFinding()
        {
            driver.FindElement(findingDetailsFinding).Click();
        }
        public void ClickfindingDetailsFindingDate()
        {
            driver.FindElement(findingDetailsFindingDate).Click();
        }
        public void ClickfindingDetailsUnderPayment()
        {
            driver.FindElement(findingDetailsUnderPayment).Click();
        }

        public void ClickfindingDetailsOverPayament()
        {
            driver.FindElement(findingDetailsOverPayament).Click();
        }

        public void ClickfindingsEntitySoftSaving()
        {
            driver.FindElement(findingsEntitySoftSaving).Click();
        }

        public void SelectSubject(string subject)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(subjectDDL), subject);

        }
        public void ClickCancel()
        {
            driver.FindElement(cancleBtn).Click();
        }
        public void ClickSave()
        {
            driver.FindElement(saveBtn).Click();
        }
        public void SelectLOB(string lob)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(LOBDDL), lob);

        }
        public void SelectFindingReason(string reason)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(findingReason), reason);

        }
        public void ClickFinalizeFindings()
        {
            driver.FindElement(finalizeFindingsBtn).Click();
        }
        public void ClickUndoFinalize()
        {
            driver.FindElement(undoFinalizeBtn).Click();
        }
        public void selectStaticsticsLOB(string lob)
        {
            CommonHelpers.selectOptionByValue(driver.FindElement(staticsticsByLOBDDL), lob);
           
        }
    }
}

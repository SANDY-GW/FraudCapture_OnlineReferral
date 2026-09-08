using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Amounts
{
    public class Amounts : BaseSettings
    {
        public Amounts(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By amountTab = By.XPath("//*[@id=\"recoveryTabId\"]");
        private readonly By amountTableSubjectName = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[1]/small/div/span");

        private readonly By amountTableLOB = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[2]/small/div/span");
        private readonly By amountTableAmountType = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[4]");
        private readonly By amountTableAmountCategory = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[5]/small/div/span");
        private readonly By amountTableAmount = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[6]/small/div/span");
        private readonly By amountTableComments = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[7]/small/div/span");
        private readonly By amountTableEnteredBy = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[8]/small/div/span");


        private readonly By amountTableDateEntered = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[9]/small/div/span");
        private readonly By amountTableModifiedBy = By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[10]/small/div/span");
        private readonly By amountTableDateModified= By.XPath("//*[@id=\"Recoveries\"]/thead/tr/th[11]/small/div/span");

        #endregion
        public void ClickAmountTab()
        {
            driver.FindElement(amountTab).Click();
        }

        public void SortamountTableDateModified()
        {
            driver.FindElement(amountTableDateModified).Click();
        }
        public void SortamountTableModifiedBy()
        {
            driver.FindElement(amountTableModifiedBy).Click();
        }
        public void SortamountTableDateEntered()
        {
            driver.FindElement(amountTableDateEntered).Click();
        }
        public void SortamountTableSubjectName()
        {
            driver.FindElement(amountTableSubjectName).Click();
        }
        public void SortamountTableEnteredBy()
        {
            driver.FindElement(amountTableEnteredBy).Click();
        }
        public void SortamountTableComments()
        {
            driver.FindElement(amountTableComments).Click();
        }
        public void SortamountTableAmount()
        {
            driver.FindElement(amountTableAmount).Click();
        }
        public void SortamountTableAmountCategory()
        {
            driver.FindElement(amountTableAmountCategory).Click();
        }
        public void SortamountTableAmountType()
        {
            driver.FindElement(amountTableAmountType).Click();
        }
        public void SortamountTableLOB()
        {
            driver.FindElement(amountTableLOB).Click();
        }
    }
}

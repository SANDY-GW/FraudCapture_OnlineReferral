using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.Reports.SelfServiceAnalytics
{
    public class NewReport : BaseSettings
    {
        public NewReport(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By ReportsTab = By.XPath("//a[contains(text(),'Reports')]");
        private readonly By SelfServiceAnalyticsTab = By.XPath("//button[contains(text(),'Self Service Analytics')]");
        private readonly By NewReportDropDown = By.XPath("//button[@id='dropdownMenuLink']");
        private readonly By Template_Claims = By.XPath("//a[contains(text(),' Template_Claims')]");
        private readonly By BackBtn = By.XPath("//button[@id='BackButton']");


        #endregion
        public void ClickReportsTab()
        {
            driver.FindElement(ReportsTab).Click();
        }
        public void ClickSelfServiceTab()
        {
            driver.FindElement(SelfServiceAnalyticsTab).Click();
        }
        public void ClickNewReportDropDown()
        {
            driver.FindElement(NewReportDropDown).Click();
        }
        public void ClickTemplateClaims()
        {
            driver.FindElement(Template_Claims).Click();
            CommonHelpers.WaitForPageLoading(driver);

        }
        public void ClickBackBtn()
        {
            driver.FindElement(BackBtn).Click();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.CaseTrackingModule.CaseTab.CaseDetails.Claims
{
    public class Claims : BaseSettings
    {
        public Claims(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By amountTab = By.XPath("//*[@id=\"recoveryTabId\"]");

        #endregion
        public void ClickAmountTab()
        {
            driver.FindElement(amountTab).Click();
        }
    }
}

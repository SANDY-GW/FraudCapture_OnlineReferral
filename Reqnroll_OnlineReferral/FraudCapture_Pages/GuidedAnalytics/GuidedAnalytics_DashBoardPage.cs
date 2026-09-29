using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics
{
    public class GuidedAnalytics_DashBoardPage : BaseSettings
    {
        public GuidedAnalytics_DashBoardPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By DashBoardBtn = By.XPath("//*[@id='reportsTabId']");

        #endregion
        public void ClickDashaBoardBtn()
        {
            driver.FindElement(DashBoardBtn).Click();
        }
    }
}

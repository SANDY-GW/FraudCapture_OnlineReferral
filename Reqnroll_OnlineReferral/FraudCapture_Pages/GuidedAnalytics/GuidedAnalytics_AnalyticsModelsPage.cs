using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics
{
    public class GuidedAnalytics_AnalyticsModelsPage : BaseSettings
    {
        public GuidedAnalytics_AnalyticsModelsPage(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By AnalyticModelsBtn = By.XPath("//*[@id='reportsTabId']");
        private readonly By MyFavoritesBtn = By.XPath("//*[contains(text(),'My Favorites ')]");
        private readonly By AllAnalyticsBtn = By.XPath("//*[contains(text(),'All Analytics ')]");
        private readonly By GlobalAnalyticsBtn = By.XPath("//*[contains(text(),'Global Analytics ')]");
        private readonly By ProviderAnalyticsBtn = By.XPath("/*[contains(text(),'Provider Analytics ')]");
        private readonly By PatientAnalyticsBtn = By.XPath("//*[contains(text(),'Patient Analytics ')]");
        private readonly By DentalAnalyticsBtn = By.XPath("//*[contains(text(),'Dental Analytics ')]");
        private readonly By RxAnalyticsBtn = By.XPath(" //*[contains(text(),'RX Analytics ')]");

       
        #endregion
        public void ClickAnalyticModelsBtn()
        {
            driver.FindElement(AnalyticModelsBtn).Click();
        }
        public void ClickMyFavoritesBtn()
        {
            driver.FindElement(MyFavoritesBtn).Click();
        }
        public void ClickAllAnalyticsBtn()
        {
            driver.FindElement(AllAnalyticsBtn).Click();
        }
        public void ClickGlobalAnalyticsBtn()
        {
            driver.FindElement(GlobalAnalyticsBtn).Click();
        }
        public void ClickProviderAnalyticsBtn()
        {
            driver.FindElement(ProviderAnalyticsBtn).Click();
        }
        public void ClickPatientAnalyticsBtn()
        {
            driver.FindElement(PatientAnalyticsBtn).Click();
        }
        public void ClickDentalAnalyticsBtn()
        {
            driver.FindElement(DentalAnalyticsBtn).Click();
        }
        public void ClickRxAnalyticsBtn()
        {
            driver.FindElement(RxAnalyticsBtn).Click();
        }

        
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.AnalyticModels.RXAnalytics
{
    public class RXAnalytics : BaseSettings
    {
        public RXAnalytics(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By AnalyticModelsBtn = By.XPath("//a[contains(text(),'Analytic Models')]");
        private readonly By RXAnalyticsBtn = By.XPath("//button[contains(text(),'RX Analytics')]");
        private readonly By SearchBtn = By.XPath("(//button[contains(text(),'Search')])[2]");
        private readonly By ClearBtn = By.XPath("(//button[contains(text(),'Clear')])[2]");
        private readonly By SearchTextBox = By.XPath("//input[@class='form-control ng-pristine ng-valid ng-touched']");
        private readonly By Title = By.XPath("(//span[contains(text(),' Title')])[1]");
        private readonly By Description = By.XPath("(//span[contains(text(),'Description ')])[1]");
        private readonly By Category = By.XPath("(//span[contains(text(),' Category ')])[1]");
        private readonly By PatientsIdentified = By.XPath("(//span[contains(text(),'Patients Identified')])[1]");
        private readonly By ProviderIdentified = By.XPath("(//span[contains(text(),'Providers Identified ')])[1]");
        private readonly By Associated = By.XPath("(//span[contains(text(),'$ Associated')])[1]");
        private readonly By ViewBtn = By.XPath("(//button[contains(text(),'View')])[1]");
        private readonly By OpenBtn = By.XPath("(//button[contains(text(),'Open')])[1]");


        #endregion
        public void ClickAnalyticModelsBtn()
        {
            driver.FindElement(AnalyticModelsBtn).Click();
        }
        public void ClickRXAnalyticsBtn()
        {
            driver.FindElement(RXAnalyticsBtn).Click();
        }
        public void ClickSearchBtn()
        {
            driver.FindElement(SearchBtn).Click();
        }
        public void ClickClearBtn()
        {
            driver.FindElement(ClearBtn).Click();
        }
        public void ClickSearchTextBox()
        {
            driver.FindElement(SearchTextBox).Click();
        }
        public void ClickTitle()
        {
            driver.FindElement(Title).Click();
        }
        public void ClickDescription()
        {
            driver.FindElement(Description).Click();
        }
        public void ClickCategory()
        {
            driver.FindElement(Category).Click();
        }
        public void ClickPatientsIdentified()
        {
            driver.FindElement(PatientsIdentified).Click();
        }
        public void ClickProviderIdentified()
        {
            driver.FindElement(ProviderIdentified).Click();
        }
        public void ClickAssociated()
        {
            driver.FindElement(Associated).Click();
        }
        public void ClickViewBtn()
        {
            driver.FindElement(ViewBtn).Click();
        }
        public void ClickOpenBtn()
        {
            driver.FindElement(OpenBtn).Click();
        }


    }
}

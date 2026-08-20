using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.GuidedAnalytics.LinkAnalysis.Options
{
    public class Options : BaseSettings
    {
        public Options(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements
        private readonly By LinkAnalysisTab = By.XPath("//a[contains(text(),'Link Analysis')]");
        private readonly By OptionsButton = By.XPath("(//button[@class='dropdown-toggle-grid dropdown-toggle orangeBtn'])[1]");
        private readonly By OpenGraphValue = By.XPath("(//a[contains(text(),'Open Graph')])[1]");
        private readonly By EditGraphSettings = By.XPath(" (//a[contains(text(),'Edit Graph Settings')])[1]");
        private readonly By Delete = By.XPath("(//a[contains(text(),'Delete')])[1]");


        #endregion
        public void ClickLinkAnalysisTab()
        {
            driver.FindElement(LinkAnalysisTab).Click();
        }
        
        public void ClickOptionsButton()
        {
            driver.FindElement(OptionsButton).Click();
        }
        public void ClickOpenGraphValue()
        {
            driver.FindElement(OpenGraphValue).Click();
        }
        public void ClickEditGraphSettings()
        {
            driver.FindElement(EditGraphSettings).Click();
        }
        public void ClickDelete()
        {
            driver.FindElement(Delete).Click();
        }
    }
}

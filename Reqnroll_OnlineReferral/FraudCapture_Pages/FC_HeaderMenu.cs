using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    internal class FC_HeaderMenu : BaseSettings
    {
        public FC_HeaderMenu(IWebDriver driver) : base(driver) { }

        #region Elements
        private readonly By HeaderMenu_MainMenu = By.XPath("//button[@id='navigationMenuId']");
        private readonly By HeaderMenu_GuidedAnalytics = By.XPath("//a[@id='Guided Analytics']");
        private readonly By HeaderMenu_DataQueryAndExtraction = By.XPath("//a[@id='Data Query & Extraction']");
        private readonly By HeaderMenu_CaseTracking = By.XPath("//a[@id='Case Tracking']");
        private readonly By HeaderMenu_CustomAnalysisAndReports = By.XPath("//a[@id='Custom Analysis & Reports']");
        private readonly By HeaderMenu_Search = By.XPath("//fc-app-header/button[contains(text(),'Search')]");
        private readonly By HeaderMenu_EventCalendar = By.XPath("//label[contains(text(),'Event Calendar')]");
        private readonly By HeaderMenu_AlertsAndExports = By.XPath("//label[contains(text(),'Alerts & Exports')]");
        private readonly By HeaderMenu_DemoClient = By.XPath("//b[contains(text(),'Demo Client')]");

        #endregion
        public void ClickHeaderMainMenu()
        {
            Driver.FindElement(HeaderMenu_MainMenu).Click();
        }
        
        public void ClickHeaderCustomAnalysisAndReports()
        {
            Driver.FindElement(HeaderMenu_CustomAnalysisAndReports).Click();
        }
        public void ClickHeaderCaseTracking()
        {
            Driver.FindElement(HeaderMenu_CaseTracking).Click();
        }
        public void ClickHeaderGuidedAnalytics()
        {
            Driver.FindElement(HeaderMenu_GuidedAnalytics).Click();
        }
        public void ClickHeaderDataQueryAndExtraction()
        {
            Driver.FindElement(HeaderMenu_DataQueryAndExtraction).Click();
        }
        public void ClickHeaderDemoClinet()
        {
            Driver.FindElement(HeaderMenu_DemoClient).Click();
        }
        public void ClickHeaderAlertsAndExports()
        {
            Driver.FindElement(HeaderMenu_AlertsAndExports).Click();
        }
        public void ClickHeaderEventCalendar()
        {
            Driver.FindElement(HeaderMenu_EventCalendar).Click();
        }
        public void ClickHeaderSearch()
        {
            Driver.FindElement(HeaderMenu_Search).Click();
        }
    }
}

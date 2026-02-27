using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages
{
    public class FraudCapture_Core : BaseSettings
    {
        public FraudCapture_Core(IWebDriver driver) : base(driver) { }

        #region Elements
        private readonly By PayorSelect = By.XPath("//input[@id='firstName']");
        private readonly By LogOutButton = By.XPath("//input[@id='firstName']");

        #endregion


        public void FC_Login(string URL = "https://dev.fraudcapture.hms.com/#/")
        {
            Driver.Navigate().GoToUrl(URL);
            CommonHelpers.WaitForPageToLoad(Driver, 10);
        }

        public void FC_SelectPayor()
        {
            Driver.FindElement(PayorSelect).Click();
            //CommonHelpers.WaitForElementVisiblity(Driver, By.Id("welcomeMessage"), 20);
        }

        public void FC_Logout()
        {
            try
            {
                Driver.FindElement(LogOutButton).Click();
                CommonHelpers.WaitForPageToLoad(Driver, 10);
            }
            catch (Exception)
            {
                // Handle exceptions if necessary
            }
        }
        public string GetActivityName()
        {
            var fc = new FC_CaseTracking_LeadPage(Driver);
            var common = new CommonHelpers(Driver);
            common.WaitForPageLoading();
            var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[1]")).Text;

            Console.WriteLine(activityName);
            return activityName;

        }
    }
}

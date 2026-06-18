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
        private readonly By UserSelect = By.XPath("//img[@class='float-start userInfo-img']");
        private readonly By Settings = By.XPath("//a[text()='Settings']");
        private readonly By HelpIcon = By.XPath("//i[@class='fa-regular fa-question-circle fa-2x greenColor helpContentIcon-a-i']");
        

        #endregion


        public void FC_Login(string URL = "https://test.fraudcapture.hms.com")
        {
            Driver.Navigate().GoToUrl(URL);
            //CommonHelpers.WaitForPageToLoad(Driver, 10);
        }

        public void FC_SelectPayor(string payorName)
        {
            var payorDropField = By.XPath("//ul[@id='payorSelector']");
            CommonHelpers.WaitForElementVisiblity(Driver, payorDropField, 120);
            Driver.FindElement(payorDropField).Click();
            Driver.FindElement(By.XPath($"//ul[@id='payorSelector']//a[normalize-space(.)='{payorName}']")).Click();
        }
        public void FC_UserSelect(string UserSelectoption)
        {
            CommonHelpers.WaitForElementVisiblity(Driver, UserSelect, 120);
            CommonHelpers.selectOptionByValue(Driver.FindElement(UserSelect), UserSelectoption);
            //Driver.FindElement(PayorSelect).Click();
        }
        public void FC_Settings()
        {
            Driver.FindElement(Settings).Click();
        }
        public void FC_HelpIcon()
        {
            Driver.FindElement(HelpIcon).Click();
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
            CommonHelpers.WaitForPageLoading(Driver);
            var activityName = Driver.FindElement(By.XPath("//*[@id='activityForm']/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[1]")).Text;

            Console.WriteLine(activityName);
            return activityName;

        }
    }
}

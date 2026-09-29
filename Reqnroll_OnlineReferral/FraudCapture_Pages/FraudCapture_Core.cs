using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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
        private readonly By UserLogout = By.XPath("//a[contains(@class,'userInfo') and contains(@aria-label,'Option')]");
        private readonly By LogOutButton = By.XPath("//a[contains(@class,'userInfo') and contains(@id,'Logout')]"); //a[text()='Log Out']
        private readonly By UserSelect = By.XPath("//img[@class='float-start userInfo-img']");
        private readonly By Settings = By.XPath("//a[text()='Settings']");
        private readonly By HelpIcon = By.XPath("//i[@class='fa-regular fa-question-circle fa-2x greenColor helpContentIcon-a-i']");
        private readonly By LogoutConfirmationMessage = By.XPath("//*[contains(text(),'You have successfully logged out of')]");


        #endregion


        public void FC_Login(string URL = "https://test.fraudcapture.hms.com")
        {
            driver.Navigate().GoToUrl(URL);
            //CommonHelpers.WaitForPageToLoad(Driver, 10);
        }

        public void FC_SelectPayor(string payorName)
        {
            var payorDropField = By.XPath("//ul[@id='payorSelector']");
            CommonHelpers.WaitForElementVisiblity(driver, payorDropField, 120);
            driver.FindElement(payorDropField).Click();
            driver.FindElement(By.XPath($"//ul[@id='payorSelector']//a[normalize-space(.)='{payorName}']")).Click();
        }
        public void FC_UserSelect(string UserSelectoption)
        {
            CommonHelpers.WaitForElementVisiblity(driver, UserSelect, 120);
            CommonHelpers.selectOptionByValue(driver.FindElement(UserSelect), UserSelectoption);
            //Driver.FindElement(PayorSelect).Click();
        }
        public void FC_Settings()
        {
            driver.FindElement(Settings).Click();
        }
        public void FC_HelpIcon()
        {
            driver.FindElement(HelpIcon).Click();
        }

        public void FC_Logout()
        {
            try
            {
                driver.FindElement(UserLogout).Click();
                driver.FindElement(LogOutButton).Click();
                CommonHelpers.WaitForPageToLoad(driver, 10);
            }
            catch (Exception)
            {
                // Handle exceptions if necessary
            }
        }

        public bool FCLogout_Confirmation()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(ExpectedConditions.ElementExists(LogoutConfirmationMessage));

                return driver.FindElement(LogoutConfirmationMessage).Displayed ? true : false;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public string GetActivityName()
        {
            var fc = new FC_CaseTracking_LeadPage(driver);
            CommonHelpers.WaitForPageLoading(driver);
            var activityName = driver.FindElement(By.XPath("//*[@id='activityForm']/div/div[2]/div[2]/cdk-virtual-scroll-viewport/div[1]/div/table/tbody/tr/td[1]")).Text;

            Console.WriteLine(activityName);
            return activityName;

        }
    }
}

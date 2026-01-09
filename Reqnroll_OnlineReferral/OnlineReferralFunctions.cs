using OpenQA.Selenium;
using FC_OnlineReferral;



namespace Reqnroll_OnlineReferral
{
    public class OnlineReferral: BaseSettings
    {
       // private readonly IWebDriver Driver;
        public OnlineReferral(IWebDriver driver) : base(driver) { }
        //public OnlineReferral()
        //{
        //    Driver = base.Driver;
        //}

        public void Login()
        {
            // Login code here
            FC_OnlineReferralLogin();
            CommonHelpers.WaitForPageToLoad(Driver, 10);
            CommonHelpers.WaitForInstructionsButton(Driver, 180);

            CommonHelpers.WaitForElementVisiblity(Driver, By.XPath("//button[contains(.,'Instructions')]"), 120);

        }

        




        // Use context injection to share the driver instance across steps in the same scenario



    }

}

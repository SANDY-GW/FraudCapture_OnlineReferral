using OpenQA.Selenium;
using FC_OnlineReferral;



namespace FC_OnlineReferral.OnlineReferral_Pages
{
    public class OnlineReferral : BaseSettings
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
            
            
            CommonHelpers.WaitForPageToLoad(driver, 10);
            CommonHelpers.WaitForInstructionsButton(driver, 180);

            CommonHelpers.WaitForElementVisiblity(driver, By.XPath("//button[contains(.,'Instructions')]"), 120);
            CommonHelpers.WaitForLoadingOverlayToDisappear(driver, 60);
            CommonHelpers.CloseAllOtherTabs(driver);
        }






        // Use context injection to share the driver instance across steps in the same scenario



    }

}

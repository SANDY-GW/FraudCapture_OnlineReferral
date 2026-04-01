using FC_OnlineReferral.FraudCapture_Pages;
using OpenQA.Selenium;


namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    internal class Step_OnlineReferral_FraudCapture
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public Step_OnlineReferral_FraudCapture(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;
        [Given("when I open the fraud capture  application")]
        public void GivenWhenIOpenTheFraudCaptureApplication()
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_OnlineLogin();
            CommonHelpers.WaitForPageToLoad(Driver, 100);
            CommonHelpers.WaitForPageLoading(Driver);
        }

        [When("I select the payor as {string}")]
        public void WhenISelectThePayorAs(string demo)
        {
            var fc = new FC_HeaderMenu(Driver);
            fc.SelectPayor(demo);
        }


        [When("I enter the {string} on the welcome fraude capture page")]
        public void WhenIEnterTheOnTheWelcomeFraudeCapturePage(string userEmail)
        {
            
            var fc = new FC_LoginPage(Driver);
            fc.EnterLoginUserEmail(userEmail);
            fc.EnterLoginUserEmail(userEmail);
        }
        [When("I click on the Procced to login button on the welcome fraude capture page")]
        public void WhenIClickOnTheProccedToLoginButtonOnTheWelcomeFraudeCapturePage()
        {

            var fc = new FC_LoginPage(Driver);
            fc.ClickProceedToLogin();
        }


        [When("I enter the ping email address as  {string}, the ping password as  {string}, filled on the hms  page")]
        public void WhenIEnterThePingEmailAddressAsThePingPasswordAsFilledOnTheHmsPage(string pingUserID, string pingPassword)
        {
            var fc = new FC_LoginPage(Driver);
            fc.EnterPingUsername(pingUserID);
            fc.EnterPingPassword(pingPassword);
            fc.ClickPingOneSignOnButton();

        }
        [When("I enter the {string}, filled on the  hms  page")]
        public void WhenIEnterTheFilledOnTheHmsPage(string passCode)
        {
            var fc = new FC_LoginPage(Driver);
            fc.waitForPingOnePassCodeSignOnButton();
            fc.EnterPingPassCode(passCode);
            fc.ClickPingOnePassCodeSignOnButton();
        }

        [Then("I should be navigated to fraud capture Page")]
        public void ThenIShouldBeNavigatedToFraudCapturePage()
        {
            throw new PendingStepException();
        }

    }
}

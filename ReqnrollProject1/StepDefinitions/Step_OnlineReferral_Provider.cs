using OpenQA.Selenium;
using ReqnrollProject1.Support;

namespace ReqnrollProject1.StepDefinitions
{
    

    [Binding]
    public sealed class Step_OnlineReferral_Provider
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public Step_OnlineReferral_Provider(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;


        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            var Ol = new OnlineReferral(Driver);
            Ol.Login();
            
            _scenarioContext["FirstNumber"] = number;   

        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            var PG1 = new LoginOnlineRefPage1(Driver);
            PG1.EnterUserFName("TestFirstName");

            var xxx = _scenarioContext["FirstNumber"];
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
           //Ol.AddNumbers(1,2);
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }
    }
}

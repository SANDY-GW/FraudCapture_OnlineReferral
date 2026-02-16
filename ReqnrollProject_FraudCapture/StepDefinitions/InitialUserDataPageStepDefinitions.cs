using System;
using FC_OnlineReferral.OnlineReferral_Pages;
using OpenQA.Selenium;
using Reqnroll;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public class InitialUserDataPageStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public InitialUserDataPageStepDefinitions(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given("when I open the Online referral application")]
        public void GivenWhenIOpenTheOnlineReferralApplication()
        {
            var Ol = new OnlineReferral(Driver);
            Ol.Login();
        }

        [Given("I enter the {string} on the Initial User Data Page for this demo")]
        public void GivenIEnterTheOnTheInitialUserDataPageForThisDemo(string userFirstName)
        {
            throw new PendingStepException();
        }



        [Given("I enter the {string} on the Initial User Data Page")]
        public void GivenIEnterTheOnTheInitialUserDataPage(string userName)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterUserFName(userName);

            var xxx = _scenarioContext["FirstNumber"];
        }

        [Given("I enter the {string},{string},{string},{string}  filled on the Initial User Data Page")]
        public void GivenIEnterTheFilledOnTheInitialUserDataPage(string userFName, string usersName, string orgAgency, string userEmail)
        {
            var PG1 = new LoginOnlineRef_Page1(Driver);
            PG1.EnterUserFName(userFName);
            PG1.EnterUserLastName(usersName);
            PG1.SelectOrgAgency(orgAgency);
            PG1.EnterUserEmailName(userEmail);

        }


        [Given("I enter the {int} on the Initial User Data Page")]
        public void GivenIEnterTheOnTheInitialUserDataPage(int p0)
        {
            throw new PendingStepException();
        }


        [When("I click on the Next button on the Initial User Data Page")]
        public void WhenIClickOnTheNextButtonOnTheInitialUserDataPage()
        {
            throw new PendingStepException();
        }

        [Then("I should be navigated to the Next Page")]
        public void ThenIShouldBeNavigatedToTheNextPage()
        {
            throw new PendingStepException();
        }

        [Given("I enter the {string},{string},{string},{string} filled on the Initial User Data Page")]
        public void GivenIEnterTheFilledOnTheInitialUserDataPage(string userFName, string userLastName, string p2, string p3, DataTable dataTable)
        {
            
            throw new PendingStepException();
        }

    }
}

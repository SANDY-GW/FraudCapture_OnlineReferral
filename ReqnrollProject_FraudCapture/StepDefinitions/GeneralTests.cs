
using FC_OnlineReferral.OnlineReferral_Pages;
using OpenQA.Selenium;

namespace FC_OnlineReferral.FraudCapture_Pages.HeaderComponent
{
    [Binding]
    public class GeneralTests
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver Driver => _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
        public GeneralTests(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [Given("when I open the Fraud Capture application to launch the welcome page")]
        public void GivenWhenIOpenTheFraudCaptureApplicationToLaunchTheWelcomePage()
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_OnlineLogin();
            CommonHelpers.WaitForPageToLoad(Driver, 100);
        }

        [When("I enter the {string} on the welcome fraude capture page for General Test:")]
        public void WhenIEnterTheOnTheWelcomeFraudeCapturePageForGeneralTest(string userEmail, DataTable dataTable)
        {
            var fc = new FC_LoginPage(Driver);
            var data = dataTable.CreateInstance<FC_OnlineReferral.Data.GeneralTestData>();
            fc.EnterLoginUserEmail(data.UserEmail);
        }
        [When("I click on the Procced to login button on the welcome fraude capture page for General Tests")]
        public void WhenIClickOnTheProccedToLoginButtonOnTheWelcomeFraudeCapturePageForGeneralTests()
        {
            var fc = new FC_LoginPage(Driver);
            fc.ClickProceedToLogin();
        }

        
        [When("I click on the I Agree button on the fraud capture Page for General Tests")]
        public void WhenIClickOnTheIAgreeButtonOnTheFraudCapturePageForGeneralTests()
        {
            var fc = new FC_LoginPage(Driver);

            fc.waitForIAgreeButton();
            var homePage = new HomePage(Driver);
            homePage.AcceptDisclosure();
        }
        [When("I can able to see the Default Landing Page {string} of Fraud Capture Application")]
        public void WhenICanAbleToSeeTheDefaultLandingPageOfFraudCaptureApplication(string TabToSelect)
        {
            var navigateBtn = Driver.FindElement(By.XPath("//button[@id='navigationMenuId']"));
            navigateBtn.Click();

            var caseTrackingLink = Driver.FindElement(By.XPath("//ul[@id='menuDropdownOptions']//a[@id='Case Tracking']"));
            caseTrackingLink.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 50);

            var leadsTabBUtton = Driver.FindElement(By.XPath("//a[@id='allLeadsTabId']"));
            var tabToSelect = Driver.FindElement(By.XPath("//a[contains(@id,'" + TabToSelect + "')]"));
            tabToSelect.Click();
            CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 100);
        }
        

        [When("I can switch the Payor to {string} on the fraud capture Page for General Tests")]
        public void WhenICanSwitchThePayorToDemoClientOnTheFraudCapturePageForGeneralTests(string payorName)
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_SelectPayor(payorName);
        }
        [When("I click Settings options to see the selection of Landing Page Details")]
        public void WhenIClickSettingsOptionsToSeeTheSelectionOfLandingPageDetails()
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_Settings();
        }
        [When("I click Logout Option to close the Fraud Capture Application")]
        public void WhenIClickLogoutOptionToCloseTheFraudCaptureApplication()
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_Logout();
        }

        [When("I click Help symbol to see the QuickLinks and click on the User Guide to view the help article in new tab")]
        public void WhenIClickHelpSymbolToSeeTheQuickLinksAndClickOnTheUserGuideToViewTheHelpArticleInNewTab()
        {
            var fc = new FraudCapture_Core(Driver);
            fc.FC_HelpIcon();
        }

        [When("Loggingout from the Fraud Capture Application")]
        public void WhenLoggingoutFromtheFraudCaptureApplication()
        {
            var headerComponent = new HeaderComponent(Driver);
            headerComponent.Logout();


        }
//        public void User_Can_Login()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.Logout();

//            var loginPage = new LoginPage(Driver);
//            loginPage.GoTo();
//            var userData = ExcelDataAccess.GetLoginTestData("LoginTest");
//            loginPage.Login(userData.Email, userData.Username, userData.Password);

//            var homePage = new HomePage(Driver);
//            homePage.AcceptDisclosure();

//            Assert.IsTrue(homePage.IsAt, "Failed to Login.");
//        }

//        [Test]
//        public void Can_Switch_Payor()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.SwitchPayor(generalData.PayorName);
//            var selectedPayor = headerComponent.GetSelectedPayor;
//            Assert.AreEqual(generalData.PayorName, selectedPayor, $"Payor switch unsuccessful. Attempted to switch to {generalData.PayorName}, actual is {selectedPayor}");
//        }

        
//        public void AMA_Appears()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.SwitchPayor(generalData.PayorName);
//            headerComponent.DismissPayorAlert();

//            headerComponent.Logout();

//            var loginPage = new LoginPage(Driver);
//            loginPage.GoTo();
//            var userData = ExcelDataAccess.GetLoginTestData(generalData.LoginKey);
//            loginPage.Login(userData.Email, userData.Username, userData.Password);

//            var expectedAMAText =
//@"CPT® Copyright 2022 American Medical Association. All rights reserved. Fee schedules, relative value units, conversion factors and/or related components are not assigned by the AMA, are not part of CPT®, and the AMA is not recommending their use. The AMA does not directly or indirectly practice medicine or dispense medical services. The AMA assumes no liability for the data contained or not contained herein.

//CPT® is a registered trademark of the American Medical Association.

//The responsibility for the content of any “National Correct Coding Policy” included in this product is with the Centers for Medicare and Medicaid Services and no endorsement by the AMA is intended or should be implied. The AMA Disclaims responsibility for any consequences or liability attributable to or related to any user, nonuse or interpretation of information contained in this product.

//U.S. Government End Users. CPT is commercial technical data, which was developed exclusively at private expense by the American Medical Association (AMA), 330 North Wabash Avenue, Chicago, Illinois 60611. Use of CPT in connection with this product shall not be construed to grant the Federal Government a direct license to use CPT based on FAR 52.227-14 (Data Rights - General) and DFARS 252.227-7015 (Technical Data - Commercial Items).";

//            var homePage = new HomePage(Driver);
//            var actualAMAText = homePage.GetAMAText();
//            homePage.AcceptDisclosure();

//            Assert.AreEqual(expectedAMAText, actualAMAText);
//        }

//        //[Test]
//        //public void Modules_Appear()
//        //{
//        //    var expectedModules = new List<string>()
//        //            {
//        //                "Guided Analytics",
//        //                "Advanced Search",
//        //                "Case Tracking",
//        //                "Link Visualization",
//        //                "Custom Analysis & Reports",
//        //                "Administrator"
//        //            };

//        //    var homePage = new HomePage(Driver);
//        //    var actualModules = homePage.GetLoadedModules();

//        //    // find any modules in our expected list that aren't in the actual list
//        //    var missingModules = expectedModules.Where(e => !actualModules.Contains(e));
//        //    Assert.IsTrue(missingModules.Count() == 0, $"Some modules not found: {string.Join(", ", missingModules)}");
//        //}

//        [Test]
//        public void Can_View_Help_Article()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.SwitchPayor(generalData.PayorName);
//            headerComponent.DismissPayorAlert();

//            headerComponent.SearchHelpArticle(generalData.ArticleTitle);

//            var homePage = new HomePage(Driver);
//            Assert.AreEqual(generalData.ExpectedArticleText, homePage.GetArticleText());
//        }

//        [Test]
//        public void Default_Landing_Page_Appears()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.SwitchPayor(generalData.PayorName);
//            headerComponent.DismissPayorAlert();

//            headerComponent.GoToSettings();
//            headerComponent.SetDefaultLandingPage(generalData.ModuleName_2);
//            headerComponent.ApplySettings();

//            headerComponent.Logout();

//            var loginPage = new LoginPage(Driver);
//            loginPage.GoTo();
//            var userData = ExcelDataAccess.GetLoginTestData(generalData.LoginKey);
//            loginPage.Login(userData.Email, userData.Username, userData.Password);
//            var homePage = new HomePage(Driver);
//            homePage.AcceptDisclosure();

//            var customAnalysisAndReportsPage = new CustomAnalysisAndReportsPage(Driver);
//            Assert.That(customAnalysisAndReportsPage.IsAt);
//        }

//        [Test]
//        public void Alerts_And_Exports_Works()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.SwitchPayor(generalData.PayorName);
//            headerComponent.DismissPayorAlert();

//            headerComponent.OpenQuickSearch();
//            headerComponent.SearchByProviderID(generalData.ProviderId);

//            var providerProfilePage = new ProviderProfilePage(Driver);
//            headerComponent.ViewProviderProfile(generalData.ProviderId, providerProfilePage);
//            providerProfilePage.ShowClaims();
//            providerProfilePage.ExportMedicalClaimsHistory(generalData.Title);
//            headerComponent.ShowAlertsAndExports();
//            Assert.True(headerComponent.NewClaimExportAppearsInAlertsAndExports(generalData.Title), "New export did not appear in Alerts & Exports");
//        }

//        [Test]
//        public void Settings_Works()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.SwitchPayor(generalData.PayorName);
//            headerComponent.DismissPayorAlert();

//            headerComponent.GoToSettings();
//            headerComponent.SetDefaultLandingPage(generalData.ModuleName_1);
//            headerComponent.ApplySettings();

//            Assert.True(headerComponent.CanViewAppliedSettings(generalData.ModuleName_2), "Applied settings did not appear");
//        }

//        [Test]
//        public void User_Can_Logout()
//        {
//            var headerComponent = new HeaderComponent(Driver);
//            headerComponent.Logout();

//            var homePage = new HomePage(Driver);
//            Assert.IsTrue(homePage.IsLoggedOut(), "Did not logout successfully");

//            var loginPage = new LoginPage(Driver);
//            loginPage.GoTo();
//            var userData = ExcelDataAccess.GetLoginTestData("LoginTest");
//            loginPage.Login(userData.Email, userData.Username, userData.Password);

//            homePage.AcceptDisclosure();
//        }
    }
}

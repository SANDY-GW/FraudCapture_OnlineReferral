using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FC_OnlineReferral;
//using ReqnrollProject1.Drivers;
using ReqnrollProject1.Support;
using Allure.Net.Commons;

namespace ReqnrollProject1.Hooks
{
    [Binding]
    internal class Hooks_FC
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;
        static IWebDriver loc_driver;
        //public Hooks_FC(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;
        public Hooks_FC(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }
        //public Hooks_FC(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}

        [BeforeTestRun(Order = 0)]
        public static void BeforeTestRun()
        {
            System.Console.WriteLine("[Init] Test run starting...");
        }

        [BeforeFeature(Order = 0)]
        public static void BeforeFeature(FeatureContext featureContext)
        {
           var driver = BaseSettings.Create();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            ((IJavaScriptExecutor)driver).ExecuteScript("document.body.style.zoom='80%';");
            loc_driver = driver;
            featureContext.Set(driver, nameof(IWebDriver));

        }

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            _scenarioContext.Set(loc_driver, nameof(IWebDriver));
            var xxx = _featureContext.Get<IWebDriver>(nameof(IWebDriver));
            

        }

        [AfterStep]
        public void AfterStep()
        {
            if (_scenarioContext.TestError != null)
            {
                var driver = _scenarioContext.Get<IWebDriver>(nameof(IWebDriver));
                var path = Support_FC.ScreenshotHelper.TakeScreenshot(driver, "step-failure");
                System.Console.WriteLine($"[Failure] {_scenarioContext.TestError.Message}");
                if (!string.IsNullOrEmpty(path))
                {
                    System.Console.WriteLine($"[Screenshot] {path}");
                    using var fs = System.IO.File.OpenRead(path);
                    AllureApi.AddAttachment(
                        name: "Failure Screenshot",
                        type: "image/png",
                        path
                    );
                }
                try
                {
                    var source = driver.PageSource;
                    AllureApi.AddAttachment(
                        name: "Page Source",
                        type: "text/html",
                        path
                    );
                    AllureApi.AddAttachment("Screenshot", "image/png", path);


                    AllureApi.AddAttachment(
                        name: "Failure Screenshot",
                        type: "image/png",
                        ""//stream: fs // Change 'FileStream' to 'stream'
                    );
                }
                catch { }
            }
        }

        [AfterScenario(Order = 100)]
        public void AfterScenario()
        {
            if (_scenarioContext.TryGetValue(nameof(IWebDriver), out IWebDriver driver))
            {
                try { loc_driver= driver; } catch { }
            }
            System.Console.WriteLine($"[Teardown] Finished scenario: {_scenarioContext.ScenarioInfo.Title}");
        }

        [AfterTestRun(Order = 100)]
        public static void AfterTestRun()
        {
            System.Console.WriteLine("[Done] Test run complete.");
        }



        [AfterFeature(Order = 100)]
        public static void AfterFeature(FeatureContext featureContext)
        {
            BaseSettings.QuitDriver(featureContext.Get<IWebDriver>(nameof(IWebDriver)));
            //try { loc_driver.Quit(); } catch { }
        }
    }
}

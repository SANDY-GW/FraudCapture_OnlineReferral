using OpenQA.Selenium;

namespace ReqnrollProject1.Support
{
    public class Support_FC
    {
        public static class ScreenshotHelper
        {
            public static string TakeScreenshot(IWebDriver driver, string namePrefix = "step-failure")
            {
                try
                {
                    var ss = ((ITakesScreenshot)driver).GetScreenshot();
                    var dir = Path.Combine(Directory.GetCurrentDirectory(), "TestResults", "Screenshots");
                    Directory.CreateDirectory(dir);
                    var file = Path.Combine(dir, $"{namePrefix}_{DateTime.Now:yyyyMMdd_HHmmssfff}.png");


                    ss.SaveAsFile(file); 
                    return file;
                }
                catch { return string.Empty; }
            }
        }

        public static class TestSettings
        {
            public static string BaseUrl => Environment.GetEnvironmentVariable("BASE_URL") ?? "https://fc-referrals-dev.gainwelltechnologies.com/#/DEMO-498B";
            public static string Username => Environment.GetEnvironmentVariable("TEST_USERNAME") ?? "Test_Username";
            public static string Password => Environment.GetEnvironmentVariable("TEST_PASSWORD") ?? "Test_Password";
        }

       

    }
}

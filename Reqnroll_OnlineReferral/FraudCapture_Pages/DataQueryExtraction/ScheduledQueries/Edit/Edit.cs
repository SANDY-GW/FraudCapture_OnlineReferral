using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.DataQueryExtraction.ScheduledQueries.Edit
{
    public class Edit : BaseSettings
    {
        public Edit(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By editBtn = By.XPath("//*[@id=\"allScheduledQueryTbl0C13C20\"]");
        private readonly By scheduleDDL = By.XPath("//*[@id=\"schedule\"]");
        private readonly By runtimeDDL = By.XPath("//*[@id=\"runtime\"]");
        private readonly By isEveryDayRdBtn = By.XPath("//*[@id=\"isEvery\"]");
        private readonly By everyDayRdBtn = By.XPath("//*[@id=\"dailyInput\"]");
        private readonly By everyBusinessDayRdBtn = By.XPath("//*[@id=\"EveryBusinessDay\"]");

        private readonly By dailyInputTxt = By.XPath("//*[@id=\"dailyInput\"]");
        private readonly By cancelBtn = By.XPath("//*[@id=\"createSchedule\"]/div/div/div[2]/button[1]");
        private readonly By nextBtn = By.XPath("//*[@id=\"EveryBusinessDay\"]");
        private readonly By saveBtn = By.XPath("//*[@id=\"createSchedule\"]/div/div/div[2]/button[2]");

        private readonly By descriptionDDL = By.XPath("//*[@id=\"description\"]");
        private readonly By alwayExportNoDDL = By.XPath("//*[@id=\"alwaysExportNo\"]");
        private readonly By distributionDDL = By.XPath("//*[@id=\"pn_id_6\"]/div[2]/div");

        #endregion
        public void ClickSave()
        {

            Driver.FindElement(saveBtn).Click();
        }
        public void ClickCancle()
        {

            Driver.FindElement(cancelBtn).Click();
        }
        public void SelectAlwaysExport(string alwaysExport)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(alwayExportNoDDL), alwaysExport);
        }
        public void SelectDistribution(string distribution)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(distributionDDL), distribution);
        }
        public void SelectDescription(string description)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(descriptionDDL), description);
        }
        public void ClickNext()
        {

            Driver.FindElement(nextBtn).Click();
        }

        public void EnterDailyInput(string value)
        {

            Driver.FindElement(dailyInputTxt).SendKeys(value);
        }
        public void SelectRunTime(string runtime)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(runtimeDDL), runtime);
        }
        public void SelectSchedule(string schedule)
        {

            CommonHelpers.selectOptionByValue(Driver.FindElement(scheduleDDL), schedule);
        }
        public void ClickEveryBusinessDay()
        {

            Driver.FindElement(everyBusinessDayRdBtn).Click();
        }
        public void ClickEvery()
        {

            Driver.FindElement(isEveryDayRdBtn).Click();
        }
        public void ClicEveryDay()
        {

            Driver.FindElement(everyDayRdBtn).Click();
        }
        public void ClickEdit()
        {

            Driver.FindElement(editBtn).Click();
        }
        
    }
}

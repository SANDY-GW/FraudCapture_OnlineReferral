using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.DataQueryExtraction.CustomList.Options.Update
{
    public class Update : BaseSettings
    {
        public Update(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here

        private readonly By listNameTxt = By.XPath("//*[@id=\"customListForm\"]/div[2]/div[1]/div[2]/input");
        private readonly By updateOption = By.XPath("//*[@id=\"allCustomListTbl0C15C20\"]/span/a[1]");

        private readonly By areaTypeDDL = By.XPath("//*[@id=\"AreaType\"]");

        private readonly By submitBtn = By.XPath("//*[@id=\"btnOk\"]");

        #endregion
       
        public void ClickSubmit()
        {

            Driver.FindElement(submitBtn).Click();
        }
        public void EnterListName(string listName)
        {

            Driver.FindElement(listNameTxt).SendKeys(listName);
        }

        public void ClickUpdateOption()
        {

            Driver.FindElement(updateOption).Click();
        }
        public void SelectAreaType(string areaType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(areaTypeDDL), areaType);

        }
    }
}

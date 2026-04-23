using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC_OnlineReferral.FraudCapture_Pages.DataQueryExtraction.CustomList.Add
{
    public class Add : BaseSettings
    {
        public Add(IWebDriver driver) : base(driver) { }

        protected readonly WebDriverWait Wait;
        protected readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);
        #region Elements


        //Add xpath here
        private readonly By addBtn = By.XPath("//*[@id=\"customList\"]/div/div[1]/div[1]/button[1]");
        private readonly By chooseFileBtn = By.XPath("//*[@id=\"file1\"]");
        private readonly By uploadBtn = By.XPath("//*[@id=\"customListForm\"]/div[1]/div[2]/input");
        private readonly By listNameTxt = By.XPath("//*[@id=\"customListForm\"]/div[2]/div[1]/div[2]/input");

        private readonly By areaTypeDDL = By.XPath("//*[@id=\"AreaType\"]");

        private readonly By submitBtn = By.XPath("//*[@id=\"btnOk\"]");
       
        #endregion
        public void ClickAdd()
        {

            Driver.FindElement(addBtn).Click();
        }
        public void ClickSubmit()
        {

            Driver.FindElement(submitBtn).Click();
        }
        public void EnterListName(string listName)
        {

            Driver.FindElement(listNameTxt).SendKeys(listName);
        }
        public void ClickUpload()
        {

            Driver.FindElement(uploadBtn).Click();
        }
        public void ClickChooseFile()
        {

            Driver.FindElement(chooseFileBtn).Click();
        }

        public void SelectAreaType(string areaType)
        {
            CommonHelpers.selectOptionByValue(Driver.FindElement(areaTypeDDL), areaType);

        }
        
    }
}

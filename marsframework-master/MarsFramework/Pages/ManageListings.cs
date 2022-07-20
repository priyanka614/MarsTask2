using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        [System.Obsolete]
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//A[@class='item'][text()='Manage Listings']")]
        private IWebElement manageListingsLink { get; set; }

        //Click on Camera
        [FindsBy(How = How.XPath, Using = " //I[@class='huge circular camera retro icon']")]
        private IWebElement Camera { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }
        //Yes Button
        [FindsBy(How = How.XPath, Using ="//BUTTON[@class='ui icon positive right labeled button']")]
        private IWebElement Yes { get; set; }

        //Deletion popup
        [FindsBy(How = How.XPath, Using = "//DIV[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")]
        private IWebElement Popup { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            Thread.Sleep(1000);
            // GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Thread.Sleep(2000);
            manageListingsLink.Click();
            Thread.Sleep(2000);

            //Click on delete from listing
            delete.Click();
            Thread.Sleep(2000);
            Yes.Click();  

           


            }

       

        }

}     


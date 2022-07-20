using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutoItX3Lib;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        [System.Obsolete]
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.XPath, Using = "//SELECT[@name='subcategoryId']")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.Id, Using = "requiredField")]
        private IWebElement ServiceType { get; set; }

        //Select the Service type 1 is selected
        [FindsBy(How = How.Name, Using = "//INPUT[@name='serviceType'][1]")]

        private IWebElement ServiceTypeOption1{ get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationType { get; set; }

        //Select the Location Type option
        [FindsBy(How = How.XPath, Using = "//INPUT[@name='locationType'])[2]")]

        private IWebElement LocationTypeOption { get; set; }


        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "(//INPUT[@tabindex='0'])[6]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on StartTimeonTue dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[8]")]
        private IWebElement StartTimeonTue { get; set; }

        //Click on EndTimeonTue dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[9]")]
        private IWebElement EndTimeonTue { get; set; }

        //Click on StartTimeonWed dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[11]")]
        private IWebElement StartTimeonWed { get; set; }

        //Click on EndTimeonWed dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']//following::input[12]")]
        private IWebElement EndTimeonWed { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement Credit { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[1]/div[1]/input[1]")]
        private IWebElement CreditAmount { get; set; }

        //click on Sample
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement Sample { get; set; }



        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //click on managelistings
        [FindsBy(How = How.XPath, Using = "//a[text()='Manage Listings']")]
        private IWebElement managelistings { get; set; }
        internal void EnterShareSkill()
        {
           //Populate Excelsheet
            Thread.Sleep(1000);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");
            Thread.Sleep(1000);
            
            //Click on shareSkill Button
            ShareSkillButton.Click();
            Thread.Sleep(2000);
          
            //Click on title and enter title textbox and give value 
            Title.Click();
            Thread.Sleep(2000);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Thread.Sleep(2000);

            //Click on Description and enter Description textbox and give value 
            Description.Click();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            
            //Select category
            CategoryDropDown.Click();
            SelectElement SubDropdown = new SelectElement(CategoryDropDown);
            SubDropdown.SelectByValue("6");
            Thread.Sleep(2000);

            //select SubCategory
            SubCategoryDropDown.Click();
           SelectElement SubDropdown1 = new SelectElement(SubCategoryDropDown);
            SubDropdown1.SelectByValue("4");

            //Enter Tags
            Tags.Click();
            //adding tags
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Thread.Sleep(2000);
            Tags.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Tags"));
            Thread.Sleep(2000);
            Tags.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Tags"));
            Thread.Sleep(2000);

            //Click on service Type
            IList<IWebElement> service = GlobalDefinitions.driver.FindElements(By.XPath("//input[@name='serviceType']"));

            int count = service.Count;

            for (int i = 0; i < count; i++)
            {
                int j = i + 1;

                String before_xpath = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[";
                String after_xpath = "]/div/label";
                var serviceType_name = GlobalDefinitions.driver.FindElement(By.XPath(before_xpath + j + after_xpath)).Text;

                Console.WriteLine(serviceType_name);

                if (serviceType_name.Equals(GlobalDefinitions.ExcelLib.ReadData(3, "ServiceType")))
                {
                    service.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Select the ServiceType");

                    break;

                }
            }

            Thread.Sleep(2000);
              //entering location type

                IList<IWebElement> location = GlobalDefinitions.driver.FindElements(By.XPath("//input[@name='locationType']"));

                int locationtype_count = location.Count;

                for (int i = 0; i < locationtype_count; i++)
                {
                    int j = i + 1;
                    String before_xpath = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div[1]/div[";
                    String after_xpath = "]/div/label";
                    var locationType_name = GlobalDefinitions.driver.FindElement(By.XPath(before_xpath + j + after_xpath)).Text;

                    Console.WriteLine(locationType_name);

                    if (locationType_name.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "LocationType")))
                    {
                        location.ElementAt(i).Click();
                        Base.test.Log(LogStatus.Info, "Select the locationType");
                        break;
                    }
                }
                Thread.Sleep(2000);

            //selecting days

            IList<IWebElement> avilabledays = GlobalDefinitions.driver.FindElements(By.XPath("//input[@name='Available']"));
            int avilabledays_count = avilabledays.Count;
            for (int i = 0; i < avilabledays_count; i++)
            {

                int j = i + 2;

                String before_xpath = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[";
                String after_xpath = "]/div[1]/div/label";
                var avilabledays_name = GlobalDefinitions.driver.FindElement(By.XPath(before_xpath + j + after_xpath)).Text;

                Console.WriteLine(avilabledays_name);

                if (avilabledays_name.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Days")))
                {
                    avilabledays.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Select the monday");

                }

                if (avilabledays_name.Equals(GlobalDefinitions.ExcelLib.ReadData(3, "Days")))
                {
                    avilabledays.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Select the tuesday");

                }

                if (avilabledays_name.Equals(GlobalDefinitions.ExcelLib.ReadData(4, "Days")))
                {
                    avilabledays.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Select the wednesday");
                    break;
                }


            }


            // entering startdate
            StartDateDropDown.Click();
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            
            Base.test.Log(LogStatus.Info, "enter the start date");
            Thread.Sleep(2000);
            Save.Click();


            //entering end date
            EndDateDropDown.Click();
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            
            Base.test.Log(LogStatus.Info, "enter the end date");
            Thread.Sleep(2000);

            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Thread.Sleep(2000);
            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Thread.Sleep(2000);

            StartTimeonTue.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "StartTime"));
            EndTimeonTue.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "EndTime"));
            Thread.Sleep(2000);

           StartTimeonWed.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "StartTime"));
           EndTimeonWed.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "EndTime"));
            Thread.Sleep(2000);
            Base.test.Log(LogStatus.Info, "enter the start time and end time for all days ");

            //selecting skills trade

            IList<IWebElement> trade = GlobalDefinitions.driver.FindElements(By.XPath("//input[@name='skillTrades']"));

            int trade_count = trade.Count;

            for (int i = 0; i < trade_count; i++)
            {
                int j = i + 1;
                String before_xpath = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[";
                String after_xpath = "]/div/label";
                var trade_name = GlobalDefinitions.driver.FindElement(By.XPath(before_xpath + j + after_xpath)).Text;

                Console.WriteLine(trade_name);

                if (trade_name.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "skillTrade")))
                {
                    trade.ElementAt(i).Click();
                    Thread.Sleep(2000);
                    Base.test.Log(LogStatus.Info, "Select the skillTrade as credit");
                    Credit.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
                    Base.test.Log(LogStatus.Info, "credit value entered");

                }


                

            }
           

            //click on sampleButton

            Sample.Click();
          
            Thread.Sleep(2000);

            AutoItX3 auto = new AutoItX3();
            auto.WinActivate("Open");
            Thread.Sleep(3000);
            auto.Send(GlobalDefinitions.ExcelLib.ReadData(2, "Sample"));
            Thread.Sleep(3000);
            auto.Send("{Enter}");
            Thread.Sleep(5000);
            Base.test.Log(LogStatus.Info, "upload the sample document");

            Thread.Sleep(2000);
                //clicking save button
                Save.Click();

                Base.test.Log(LogStatus.Info, "Select the save option");
                Thread.Sleep(3000);

            //choosing Hidden radio button

            IList<IWebElement> activebtn = GlobalDefinitions.driver.FindElements(By.XPath("//input[@name='isActive']"));

            int activebtn_count = activebtn.Count;

            for (int i = 0; i < activebtn_count; i++)
            {
                int j = i + 1;
                String before_xpath = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[";
                String after_xpath = "]/div/label";
                var activebtn_name = GlobalDefinitions.driver.FindElement(By.XPath(before_xpath + j + after_xpath)).Text;

                Console.WriteLine(activebtn_name);

                if (activebtn_name.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Active")))
                {
                    activebtn.ElementAt(i).Click();
                    Base.test.Log(LogStatus.Info, "Select the hidden");
                    break;
                }
            }


            managelistings.Click();
            Thread.Sleep(2000);

            IList<IWebElement> verify = GlobalDefinitions.driver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr"));

            int verify_count = verify.Count;
            for (int i = 0; i < verify_count; i++)
            {
                int j = i + 1;
                String before_xpath = "//*[@id='listing-management-section']/div[2]/div[1]/table/tbody/tr[";
                String after_xpath = "]/td[3]";
                var verify_name = GlobalDefinitions.driver.FindElement(By.XPath(before_xpath + j + after_xpath)).Text;

                Console.WriteLine(verify_name);

                if (verify_name.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Verification")))
                {

                    Base.test.Log(LogStatus.Info, "Added share skills  with skillstrade as credit successfully");
                    break;
                }
            }

        }
    }

}

using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {
        [System.Obsolete]
        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }





        #region  Initialize Web Elements 

        //Click on titleName Dropdownarrow
        [FindsBy(How = How.XPath, Using = "(//I[@class='dropdown icon'])[2]")]
        private IWebElement TitleName { get; set; }

        //Edit Firstname
        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[2]")]
        private IWebElement FirstName { get; set; }

        //Edit Lastname
        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[3]")]
        private IWebElement LastName { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='ui teal button'][text()='Save']")]
        private IWebElement SaveName1 { get; set; }
       
        //Click on profileTab
        [FindsBy(How = How.XPath, Using = "//A[@class='item'][text()='Profile']")]
        private IWebElement ProfileTab { get; set; }

        //Click on Availability Time 
        [FindsBy(How = How.XPath, Using = "//I[@class='large calendar icon']")]
        private IWebElement AvailabilityTime { get; set; }

        //Edit on Availability Time dropdown
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/span[1]/i[1]")]

        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Edit Availability Time

        [FindsBy(How = How.XPath, Using = "//SELECT[@class='ui right labeled dropdown']")]
        private IWebElement AvailabilityTimeDropDown { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/span[1]")]

        private IWebElement AvailabilityHours { get; set; }

        //Click on Earn Target
        [FindsBy(How = How.XPath, Using = "//STRONG[text()='Earn Target']")]
        private IWebElement EarnTarget { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//div[text()='Add New']")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]

        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//select[@class='ui dropdown']")]
        private IWebElement ChooseLang { get; set; }

  
             //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on skill tab
        [FindsBy(How = How.XPath, Using = "//a[text()='Skills']")]
        private IWebElement SkillTab { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//select[@class='ui fluid dropdown']")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddSkill { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//h3[text()='Description']//following::i[1]")]
        private IWebElement Description { get; set; }

        //TextArea
        [FindsBy(How = How.XPath, Using = " //textarea[@name='value']")]
        private IWebElement DescriptionText { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//textarea[@name='value']//following::button")]
        private IWebElement SaveName { get; set; }

        //Click on Education Tab
        [FindsBy(How = How.XPath, Using = "//a[text()='Education']")]
        private IWebElement EducationTab { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//th[text()='Graduation Year']//following::div[1]")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the Country option as India
        [FindsBy(How = How.XPath, Using = "//option[text()='India']")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//option[text()='M.A']")]
        private IWebElement ChooseTitleName { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//option[text()='2011']")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide field']/input[1]")]
        private IWebElement AddEdu { get; set; }


        //Click on Certification tab
        [FindsBy(How = How.XPath, Using = "//a[text()='Certifications']")]
        private IWebElement CertificationTab { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "(//DIV[@class='ui teal button '][text()='Add New'])[3]")]
        private IWebElement AddNewCertification { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
        
        private IWebElement CertificationName { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
        private IWebElement CertifiedFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement CertifiedYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']//following::option[2]")]
        private IWebElement CertiYearOpt { get; set; }

        
        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddCerti { get; set; }

        
        #endregion

        internal void EditProfile()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);

            ProfileTab.Click();
            TitleName.Click();
            Thread.Sleep(2000);
            

            FirstName.Click();
            FirstName.Clear();
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));
            LastName.Click();
            LastName.Clear();
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));
            SaveName1.Click();
            Thread.Sleep(200);


            AvailabilityTime.Click();
            AvailabilityTimeOpt.Click();
            AvailabilityTimeDropDown.Click();
            AvailabilityTimeDropDown.SendKeys(Keys.ArrowDown);
            SelectElement Timedropdown = new SelectElement(AvailabilityTimeDropDown);
            Timedropdown.SelectByValue("Full Time");
            AvailabilityTimeDropDown.SendKeys(Keys.Enter);
            Thread.Sleep(200);



            //Availability Hours
            AvailabilityHours.Click();
            //Availability Hours option
            Actions actions = new Actions(GlobalDefinitions.driver);
            actions.MoveToElement(AvailabilityHours).Click();
            actions.MoveToElement(AvailabilityHours).SendKeys(Keys.ArrowDown);
            Thread.Sleep(2000);
            actions.MoveToElement(AvailabilityHours).SendKeys(Keys.Enter);

            //Earn Target
            EarnTarget.Click();
            //Choose the option from salary dropdown
            Actions actions1 = new Actions(GlobalDefinitions.driver);
            actions1.MoveToElement(EarnTarget).SendKeys(Keys.ArrowDown);

            Thread.Sleep(500);
            actions1.MoveToElement(EarnTarget).SendKeys(Keys.Enter);

            //---------------------------------------------------------
            //Click on Add New Language button

            // AddNewLangBtn.Click();

            // Thread.Sleep(1000);
            //Enter the Language
            //AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Choose Lang
            //ChooseLang.Click();

            //SelectElement dropdown3 = new SelectElement(ChooseLang);
            //dropdown3.SelectByValue("Basic");
            //Thread.Sleep(1000);


            // Thread.Sleep(500);
            // AddLang.Click();
            // Base.test.Log(LogStatus.Info, "Added Language successfully");

            //-----------------------------------------------------------
            //Click on SkillTab Button

            // Thread.Sleep(2000);
            // SkillTab.Click();
            // Thread.Sleep(5000);

            //  AddNewSkillBtn.Click();
            //  Thread.Sleep(5000);

            //Enter the skill 
            //AddSkillText.Click();
            // AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

            //  ChooseSkill.Click();
            //  Thread.Sleep(500);
            // ChooseSkilllevel.Click();

            //   SelectElement Dropdown4 = new SelectElement(ChooseSkilllevel);
            // Dropdown4.SelectByValue("Expert");
            // Thread.Sleep(500);


            // AddSkill.Click();
            // Thread.Sleep(500);
            // Base.test.Log(LogStatus.Info, "Added Skills successfully");

         //description
            //Click on Description Tab 
            //Description.Click();
            // Thread.Sleep(500);

            // DescriptionText.Clear();
            // DescriptionText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            // Thread.Sleep(500);
            // Save.Click();
            // Base.test.Log(LogStatus.Info, "Added Description successfully");

            //Click on Education
            // Thread.Sleep(500);
            //  EducationTab.Click();
            // Thread.Sleep(500);

            //Click on AddnewEducation Button
            //AddNewEducation.Click();
            //Click on University
            //EnterUniversity.Click();
            //Enter University details from excel sheet
            // EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));
            // Thread.Sleep(500);
            //click on country and Choose country
            // ChooseCountry.Click();
            //ChooseCountryOpt.Click();
            //Click on title and enter title
            //ChooseTitle.Click();
            //ChooseTitleName.Click();
            //Click on Degree and take degree value from excel
            //Degree.Click();
            // Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));
            //Thread.Sleep(100);
            //Enter year of graduation and choose one option
            // DegreeYear.Click();
            // Thread.Sleep(500);
            //DegreeYearOpt.Click();
            //click on save button
            // AddEdu.Click();


            //Click on Certification Tab
            //  Thread.Sleep(500);
            // CertificationTab.Click();

            //Actions actions2 = new Actions(GlobalDefinitions.driver);
            //actions2.MoveToElement(AddNewCertification).Click();



            // AddNewCertification.Click();
            // CertificationName.Click();
            // CertificationName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certification Name"));
            // CertifiedFrom.Click();
            // CertifiedFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certified from"));
            // CertifiedYear.Click();
            // CertiYearOpt.Click();
            // AddCerti.Click();
            // Thread.Sleep(200);


        }
    }
}
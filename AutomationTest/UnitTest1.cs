using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

namespace AutomationTest
{

    [TestClass]
    public class UnitTest1
    {
        private readonly ChromeDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Manage().Window.Maximize();
            // Navigate to craftbet
            PropertiesCollection.driver.Navigate().GoToUrl("https://craftbet.com/home");

        }

        [TestMethod]
        public void Login_Logout1()
        {
            try
            {
                Console.WriteLine("Craftbet hes been successfully opened");
                System.Threading.Thread.Sleep(4000);// sellp 4 sec
                SeleniumSetMethods.Click("global_login-btn", ElementTypes.ClassName); //click in "Login" button to open "Login" popup
                Debug.WriteLine("Login popup successfully opens");
                System.Threading.Thread.Sleep(4000);// sellp 4 sec
                Console.WriteLine("Watermark for username is" + SeleniumGetMethods.GetWatermark(".input_field.ng-pristine.ng-valid.ng-touched", ElementTypes.CssSelector));
                System.Threading.Thread.Sleep(4000);// sellp 4 sec
                //EAPageObject page = new EAPageObject();
                //page.usertxt.SendKeys("c.mkrtchyan@iqsoft.am");
                //Console.WriteLine("The username is " + SeleniumGetMethods.GetWatermark("username", ElementTypes.Name));
                SeleniumSetMethods.EnterText("username", "c.mkrtchyan@iqsoft.am", ElementTypes.Name);
                // Console.WriteLine("The username is " +  SeleniumGetMethods.GetText("username", ElementTypes.Name));
              //  SeleniumSetMethods.EnterText("//input[@ formcontrolname='Password']",password shoud be, ElementTypes.Xpath);
                // SeleniumGetMethods.GetWatermark("//input[@ placeholder='Password']", ElementTypes.Xpath);
                // Console.WriteLine("The password  is" + SeleniumGetMethods.GetText("//input[@ formcontrolname='Password']", ElementTypes.Xpath));
               // SeleniumSetMethods.Click("change-password-field-type", ElementTypes.ClassName);// click on eye icon to see password
                //System.Threading.Thread.Sleep(1000);
              //  PropertiesCollection.driver.FindElement(By.Id("remeberMe")).Click();
               // System.Threading.Thread.Sleep(1000);
              //  SeleniumSetMethods.Click("craft_btn", ElementTypes.ClassName);
               // System.Threading.Thread.Sleep(4000);
                // SeleniumSetMethods.SelectDropDown(PropertiesCollection.PropertiesCollection.driver,"current_item","4","Id");
              //  SeleniumSetMethods.Click(".flex_between.current_item", ElementTypes.CssSelector); // find drop down 
                //System.Threading.Thread.Sleep(4000);
             //  SeleniumSetMethods.Click(".global_logout.button-style2-type-btn", ElementTypes.CssSelector);

                // PropertiesCollection.driver.FindElement(By.CssSelector(".global_logout.button-style2-type-btn")).Click();
            }  // find drop down     




            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        [TestCleanup]
           public void CleanUp()
           {
            PropertiesCollection.driver.Close();
           }

    }
}

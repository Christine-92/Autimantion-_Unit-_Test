using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTest
{
    class SeleniumSetMethods
    {
        
        public static void EnterText( string element, string value,  ElementTypes elementtype)   // Enter text in text box
        {
            if (elementtype == ElementTypes.ClassName)
            {
                PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
            }
            if (elementtype == ElementTypes.CssSelector)
            {
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
            }
            if (elementtype == ElementTypes.Name)
            {
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            }
            if (elementtype == ElementTypes.Xpath)
            {
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
            }
        }
        public static void Click(string element, ElementTypes elementtype) // Click in button, checkbox, option button

        {
            if (elementtype == ElementTypes.ClassName)
            {
                PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
            }
            if (elementtype == ElementTypes.CssSelector)
            {
                PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
            }
        }

        public static void SelectDropDown( string element, string value, ElementTypes elementtype) // Click in button, checkbox, option button

        {

            if (elementtype == ElementTypes.ClassName)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByValue(value);
            }
            if (elementtype == ElementTypes.ClassName)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).SelectByValue(value);
            }
            if (elementtype == ElementTypes.Id)
            {
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByValue(value);

            }
           
        }
    }
}







using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace AutomationTest
{
    class SeleniumGetMethods
    {
        public static string GetWatermark(string element, ElementTypes elementtype)
        {
            switch (elementtype)
            {
                case ElementTypes.Id:
                    return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("placeholder"); 
                case ElementTypes.CssSelector:
                    return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("placeholder");
                case ElementTypes.ClassName:
                    return PropertiesCollection.driver.FindElement(By.ClassName(element)).Text;
                case ElementTypes.Name:
                    return PropertiesCollection.driver.FindElement(By.Name(element)).Text;
                case ElementTypes.Xpath:
                    return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("placeholder");
                default:
                    return string.Empty;
            }
        }

        public static string GetText(string element, ElementTypes elementtype)
        {
            if (elementtype==ElementTypes.Id)
            {
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            else if (elementtype == ElementTypes.CssSelector)
            {
                return PropertiesCollection.driver.FindElement(By.CssSelector(element)).GetAttribute("value");
            }
            else if (elementtype ==ElementTypes.ClassName)
            {
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).GetAttribute("value");
            }
            else if (elementtype==ElementTypes.Name)
            {
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).GetAttribute("value");
            }
            else if (elementtype == ElementTypes.Xpath)
            {
                return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");
            }
            else
                return String.Empty;
        }
            public static string GetTextFromDDL( string element, ElementTypes elementtype)
            {
                switch (elementtype)
                {
                    case ElementTypes.Id:

                        return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementTypes.CssSelector:

                        return new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).AllSelectedOptions.SingleOrDefault().Text;
                    case ElementTypes.ClassName:

                        return new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).AllSelectedOptions.SingleOrDefault().Text;
                    default:
                        return String.Empty;

                }
            }



        }
    }






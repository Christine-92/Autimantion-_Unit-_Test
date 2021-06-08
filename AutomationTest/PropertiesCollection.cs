using OpenQA.Selenium;

namespace AutomationTest
{
    public enum ElementTypes
    {
        Id = 1,
        CssSelector,
        ClassName,
        Name,
        Xpath
    }
  public  class PropertiesCollection
    {
   
        //Auto-implemented property
      public static IWebDriver driver { get; set; }

       
    }

}

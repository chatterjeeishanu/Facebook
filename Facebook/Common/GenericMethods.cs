using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Common
{
    class GenericMethods
    {
        public static void TextBox(IWebDriver driver, string LocatorType, string LocatorValue, string Text)
        {
            if (LocatorType == "Id")
            {
                driver.FindElement(By.Id(LocatorValue)).SendKeys(Text);
            }
            if (LocatorType == "XPath")
            {
                driver.FindElement(By.XPath(LocatorValue)).SendKeys(Text);
            }
        }
        public static void ButtonClick(IWebDriver driver, string LocatorType, string LocatorValue)
        {
            if (LocatorType == "Id")
            {
                driver.FindElement(By.Id(LocatorValue)).Click();
            }
            if (LocatorType == "XPath")
            {
                driver.FindElement(By.XPath(LocatorValue)).Click();
            }
        }
    }
}

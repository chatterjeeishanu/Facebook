using Facebook.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facebook.Pages
{
    class LogIn
    {
        
        public static void Navigation()
        {
            Common.ExcelDataReader.PopulateInCollection(CommonFeatures.ExcelPath, "Login");
            GlobalDefinition.driver.Navigate().GoToUrl(Common.ExcelDataReader.ReadData(2, "Url"));
        }
        
        public static void UserNamePassWord()
        {
            Common.ExcelDataReader.PopulateInCollection(CommonFeatures.ExcelPath, "Login");
            GenericMethods.TextBox(GlobalDefinition.driver, "XPath", "//*[@id='email']", Common.ExcelDataReader.ReadData(2, "UserName"));
            GenericMethods.TextBox(GlobalDefinition.driver, "Id", "pass", Common.ExcelDataReader.ReadData(2, "PassWord"));
        }
        public static void ClickLogin()
        {
            GenericMethods.ButtonClick(GlobalDefinition.driver, "XPath", "//*[@id='loginbutton']");
            var ScreenshotPath = ScreenShot.SaveScreenshot(GlobalDefinition.driver,"Home Page");
            
            try
            {
                Assert.AreEqual("(1) Facebook",GlobalDefinition.driver.Title);
                Console.WriteLine("Login Successful");
            }
            catch
            {
                Console.WriteLine("Login Failure");
            }
        }
    }
}

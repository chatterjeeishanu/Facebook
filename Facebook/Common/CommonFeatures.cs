using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook.Configuration;
using OpenQA.Selenium.Firefox;
using System.Data;
using ExcelDataReader;
using System.IO;
using Facebook.Common;

namespace Facebook.Common
{
     class CommonFeatures
    {
        public static int browser = Int32.Parse(ResourceFile.Browser);
        public static string ExcelPath = ResourceFile.ExcelPath;
        public static string ScreenshotPath = ResourceFile.ScreenshotPath;

        public static void Initialize()
        {
            switch (browser)
            {
                case 1:
                    GlobalDefinition.driver = new ChromeDriver();
                    break;
                case 2:
                    GlobalDefinition.driver = new FirefoxDriver();
                    break;
            } 
          
            GlobalDefinition.driver.Manage().Window.Maximize();            
            
        }
       
        public static void Teardown()
        {
            GlobalDefinition.driver.Close();
        }
                
    }
    
}

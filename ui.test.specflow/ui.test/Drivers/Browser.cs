using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ui.test.Drivers
{
    public class Browser
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        public static IWebDriver getCurrentDriver()
        {
            if (driver == null)
            {
                try
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--no-sandbox");
//                    driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
                    driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(1));
                    driver.Manage().Window.Minimize();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                    driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(30));
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return driver;
        }

        public static void loadPage(String url)
        {
            getCurrentDriver().Url = url;
        }

        public static void closeDriver()
        {
            try
            {
                getCurrentDriver().Close();
                driver = null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

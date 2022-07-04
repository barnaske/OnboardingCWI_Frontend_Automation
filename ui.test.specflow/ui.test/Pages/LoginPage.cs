using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class LoginPage : Browser
    {
        private IWebElement botImg => driver.FindElement(By.XPath("//*[@id=\"root\"]/ div/div[2]/div[1]/div[2]"));
        public bool isBotImgExist() => botImg.Displayed;

        private IWebElement userNameTxt => driver.FindElement(By.XPath("//*[@id=\"user-name\"]"));

        private IWebElement passWordTxt => driver.FindElement(By.XPath("//*[@id=\"password\"]"));

        private IWebElement loginBtn => driver.FindElement(By.XPath("//*[@id=\"login-button\"]"));

        private IWebElement errorMsg => driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]/h3"));

        public void loginSendKeys(String username, String password)
        {
            userNameTxt.SendKeys(username);
            passWordTxt.SendKeys(password);
        }

        public void loginClick() => loginBtn.Click();

        public string getErrorMsg() => errorMsg.Text;
    }
}

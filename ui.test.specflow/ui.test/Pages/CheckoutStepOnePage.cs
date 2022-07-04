using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class CheckoutStepOnePage : Browser
    {
        private IWebElement firstNameTxt => driver.FindElement(By.XPath("//*[@id=\"first-name\"]"));

        private IWebElement lastNameTxt => driver.FindElement(By.XPath("//*[@id=\"last-name\"]"));

        private IWebElement zipPostalCodeTxt => driver.FindElement(By.XPath("//*[@id=\"postal-code\"]"));

        private IWebElement checkoutYourInformationBtn => driver.FindElement(By.XPath("//*[@id=\"continue\"]"));

        public void yourInformationSendKeys(string firstname, string lastname, string zipcode)
        {
            firstNameTxt.SendKeys(firstname);
            lastNameTxt.SendKeys(lastname);
            zipPostalCodeTxt.SendKeys(zipcode);
        }

        public void checkoutYourInformationClick() => checkoutYourInformationBtn.Click();
    }
}

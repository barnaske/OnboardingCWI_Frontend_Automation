using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class CheckoutStepTwoPage : Browser
    {
        private IWebElement finishCheckoutBtn => driver.FindElement(By.XPath("//*[@id=\"finish\"]"));

        public void finishCheckoutClick() => finishCheckoutBtn.Click();
    }
}

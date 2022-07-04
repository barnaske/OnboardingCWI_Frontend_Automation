using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class InventoryItemPage : Browser
    {
        private IWebElement productValueDiv => driver.FindElement(By.XPath("//*[@id=\"inventory_item_container\"]/div/div/div[2]/div[3]"));
        public void addToCartClick(string produto) => driver.FindElement(By.XPath("//*[@id=\"add-to-cart-"+ produto.Replace(" ", "-").ToLower() + "\"]")).Click();

        public string getProductValueDivText() => productValueDiv.Text;
    }
}

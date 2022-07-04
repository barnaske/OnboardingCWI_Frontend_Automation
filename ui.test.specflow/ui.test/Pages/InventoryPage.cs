using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using ui.test.Drivers;

namespace ui.test.Pages
{
    public class InventoryPage : Browser
    {
        private IWebElement menuBtn => driver.FindElement(By.XPath("//*[@id=\"react-burger-menu-btn\"]"));

        private IWebElement menuWindow => driver.FindElement(By.XPath("//*[@id=\"menu_button_container\"]/div/div[2]"));

        private IWebElement logoutLnk => driver.FindElement(By.XPath("//*[@id=\"logout_sidebar_link\"]"));

        public void getProduto(string produto) => driver.FindElement(By.XPath("//*[text()='" + produto + "']"));

        public void searchingProduct(string produto) => driver.FindElement(By.XPath("//div[contains(@class, 'inventory_item_name')][contains(text(), '" + produto + "')]"));

        //div[contains(@class, 'inventory_item_name')][contains(text(), '" + produto + "')]

        //private IWebElement productPrice => ;

        public void getProdutoAndClick(string produto) => driver.FindElement(By.XPath("//*[text()='" + produto + "']")).Click();

        public void menuClick() => menuBtn.Click();

        public bool isMenuWindowVisible() => menuWindow.Displayed;

        public bool isLogoutLnkVisible() => logoutLnk.Displayed;

        //válido estudar como implementar usando FindElements, retornando a lista dos elementos selecionados e depois iterando com um foreach
        public string getProductValueText(string product) => driver.FindElement(By.XPath("//div[contains(@class,'inventory_item_price')][preceding::div[contains(text(), '" + product + "')]]")).Text;
    }
}



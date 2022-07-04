using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ui.test.Drivers;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    public class LoginSteps : Browser
    {
        private LoginPage loginPage = new LoginPage();

        private InventoryPage inventoryPage = new InventoryPage();

        [Given(@"que acesso o site")]
        public void GivenQueAcessoOSite()
        {
            Browser.loadPage("https://www.saucedemo.com/");
        }

        [Then(@"vejo que estou na login page")]
        public void ThenVejoQueEstouNaLoginPage()
        {
            Assert.That(loginPage.isBotImgExist(), Is.True);
            Console.WriteLine("Resultado do método por escrito: " + loginPage.isBotImgExist());
        }

        [When(@"informo as seguintes credenciais")]
        public void WhenInformoAsSeguintesCredenciais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.loginSendKeys((string)data.Username, (string)data.Password);
        }

        [When(@"me autentico no sistema")]
        public void WhenMeAutenticoNoSistema()
        {
            loginPage.loginClick();
        }

        [Then(@"o menu de usuário fica visível")]
        public void ThenOMenuDeUsuarioFicaVisivel()
        {
            inventoryPage.menuClick();
            Assert.That(inventoryPage.isMenuWindowVisible(), Is.EqualTo(true));
        }

        [Then(@"o usuário aparece logado")]
        public void ThenOUsuarioApareceLogado()
        {
            //pesquisar sobre lib Wait Helpers, implementar thread.sleep gera tempo de espera desnecessário
            Thread.Sleep(1000);
            Assert.That(inventoryPage.isLogoutLnkVisible(), Is.EqualTo(true));
        }

        [Then(@"um erro aparece informando que o usuário está bloqueado")]
        public void ThenUmErroApareceInformandoQueOUsuarioEstaBloqueado()
        {
            Assert.That(loginPage.getErrorMsg(), Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

    }
}

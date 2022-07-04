using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ui.test.Drivers;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    public class CheckoutSteps : Browser
    {
        InventoryPage inventoryPage = new InventoryPage();
        InventoryItemPage inventoryItemPage = new InventoryItemPage();
        CartPage cartPage = new CartPage();
        CheckoutStepOnePage checkoutStepOnePage = new CheckoutStepOnePage();
        CheckoutStepTwoPage checkoutStepTwoPage = new CheckoutStepTwoPage();
        CheckoutCompletePage checkoutCompletePage = new CheckoutCompletePage();
        
        [When(@"adiciono o produto (.+)")]
        public void WhenAdicionoOProdutoSauceLabsBackpack(string produto)
        {
            inventoryPage.getProduto(produto);
            inventoryItemPage.addToCartClick(produto);
        }
        
        [When(@"visualizo o carrinho")]
        public void WhenVisualizoOCarrinho()
        {
            cartPage.cartClick();
        }

        [When(@"sigo para as informações de Checkout")]
        public void WhenSigoParaAsInformacoesDeCheckout()
        {
            cartPage.checkoutCartClick();
        }

        [When(@"insiro as seguintes informações pessoais")]
        public void WhenInsiroAsSeguintesInformacoesPessoais(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            checkoutStepOnePage.yourInformationSendKeys((string)data.FirstName, (string)data.LastName, (string)data.ZipPostalCode);
            
        }

        [When(@"sigo para o Overview do Checkout")]
        public void WhenSigoParaOOverviewDoCheckout()
        {
            checkoutStepOnePage.checkoutYourInformationClick();
        }

        [When(@"finalizo a compra")]
        public void WhenFinalizoACompra()
        {
            checkoutStepTwoPage.finishCheckoutClick();
        }

        [Then(@"a página de pedido completo é exibida contendo a mensagem (.+)")]
        public void ThenAPaginaDePedidoCompletoEExibidaContendoAMensagem(string texto)
        {
            Assert.That(checkoutCompletePage.getThankYouForYourOrder(), Is.EqualTo("THANK YOU FOR YOUR ORDER"));
        }

    }
}

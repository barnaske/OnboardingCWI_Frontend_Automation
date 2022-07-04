using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ui.test.Drivers;
using ui.test.Pages;

namespace ui.test.Steps
{
    [Binding]
    public class VerificaPrecoSteps : Browser
    {
        InventoryPage inventoryPage = new InventoryPage();
        InventoryItemPage inventoryItemPage = new InventoryItemPage();
        string nomeProduto;

        [Then(@"olho para o produto (.+) e verifico que o valor está de acordo com (.+)")]
        public void ThenOlhoParaOProdutoSauceLabsBackpackEVerificoQueOValorEstaDeAcordoCom(string produto, string p0)
        {
            Assert.That(inventoryPage.getProductValueText(produto), Is.EqualTo(p0));
        }
    }
}
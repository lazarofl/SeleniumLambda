using System;
using OpenQA.Selenium;
namespace Selenium.PageObjects
{
    public class ResultadoDeBusca
    {
        public static string ObterLinkDeResultado(IWebDriver driver, int numeroDoResultado)
        {
            var primeiroResultado = driver.FindElement(By.CssSelector($"#rso > div:nth-child(1) > div > div:nth-child({numeroDoResultado}) > div > h3 > a"));
            return primeiroResultado.GetAttribute("href");
        }

        public static object ObterTituloDaPagina(IWebDriver driver)
        {
            System.Threading.Thread.Sleep(2000);
            return driver.Title;
        }
    }
}

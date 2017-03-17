using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium.PageObjects;

namespace Selenium
{
    [TestClass]
    public class TestesDeBuscaNoGoogle
    {
        [TestMethod]
        public void DeveEncontrarOBlogDoLazaroNoPrimeiroResultadoDaPesquisa()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                HomeDoGoogle.Pesquisar(driver, "Lazaro Fernandes Lima Suleiman");
                var link = ResultadoDeBusca.ObterLinkDeResultado(driver, 1);

                Assert.AreEqual("http://lazarofl.github.io/", link);
            }
        }

        [TestMethod]
        public void DeveEncontrarOLinkedinDoLazaroNoSegundoResultadoDaPesquisa()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                HomeDoGoogle.Pesquisar(driver, "Lazaro Fernandes Lima Suleiman");
                var link = ResultadoDeBusca.ObterLinkDeResultado(driver, 2);

                Assert.AreEqual("https://br.linkedin.com/in/lazaroflima", link);
            }
        }

        [TestMethod]
        public void DeveTerOValorPesquisaNoTítuloDaPáginadeResultadoDaPesquisa()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                HomeDoGoogle.Pesquisar(driver, "Lazaro Fernandes Lima Suleiman");
                var titulodaPagina = ResultadoDeBusca.ObterTituloDaPagina(driver);

                Assert.AreEqual("Lazaro Fernandes Lima Suleiman - Pesquisa Google", titulodaPagina);
            }
        }
    }
}

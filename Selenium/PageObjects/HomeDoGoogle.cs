using OpenQA.Selenium;
using System;

namespace Selenium.PageObjects
{
    public class HomeDoGoogle
    {
        public static void Pesquisar(IWebDriver driver, string pesquisa)
        {
            driver.Url = "https://www.google.com.br/";
            driver.FindElement(By.Id("lst-ib")).SendKeys(pesquisa);
            driver.FindElement(By.Id("lst-ib")).Submit();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
    }
}

using OpenQA.Selenium;
using System;

namespace TestingForTinex
{
    internal class LoginPage
    {
        public IWebDriver driver { get; }

        public LoginPage(IWebDriver driver)
            {
            this.driver = driver;
            }

        public IWebElement login => driver.FindElement(By.CssSelector("img[src='img/user.png']"));
       
       public IWebElement username => driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtUsername"));

        public IWebElement pass => driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtPassword"));

        public IWebElement submit => driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnLogIn"));

        //koga se registrira nevaliden korisnik
        public IWebElement nevalidenLoginPoraka => driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_litErr"));

      
internal void GoTo()
        {
            driver.Navigate().GoToUrl("https://www.e-tinex.mk/#");
        }

        internal MainPage LoginTinex(string email, string password)
        {
            username.SendKeys(email);
            pass.SendKeys(password);
            submit.Click();
            return new MainPage(driver);


        }
    }
}
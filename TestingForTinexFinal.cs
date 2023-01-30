using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingForTinex
{
    [TestFixture]
    public class TestingForTinexFinal
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        internal MainPage page2;
        internal LoginPage page;

        [SetUp]
        public void setiranje()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(32);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(32);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(22));
            page2 = new MainPage(driver);
            page = new LoginPage(driver);


        }
        [TearDown]
        public void tearDownMethod()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]

        public void testLogiranjeZaTinexPozitinoScenario()
        {

            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            Assert.IsTrue(driver.FindElement(By.Id("ctl00_btnLogOut")).Text.Contains("Одјавете се"));



        }
        [Test]

        public void testLogiranjeZaTinexNegativnoScenario()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dd", "ssd");
            Assert.IsTrue(page.nevalidenLoginPoraka.Text.Contains("Нема регистрирано таков корисник"));

        }
        [Test]
        [Category("After Login Click osnovniproizvodi")]
        public void CheckIsOsnovniProizvodiClickable()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.op();
            Assert.IsTrue(driver.FindElement(By.XPath("//label[@for='checkbox205']")).Text.Contains("Брашно"));

        }
        [Test]

        public void CheckIfUserCanSelectCard()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.op();
            
            page2.openZelatinCard();
            Assert.IsTrue(page2.dokazDekaEOtvorenZelatin.Text.Contains("BASSO"));


        }
        [Test]
        public void CheckAkciiNamaluvanje()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.op();
            page2.akciiZaNamaluvanjeClick();
            Assert.IsTrue(driver.Url.Contains("a=1&f5=1"));


        }
        [Test]
        public void CestoPostavuvaniPrasanja()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.cestoPostavuvaniFunckija();
            Assert.IsTrue(driver.FindElement(By.CssSelector(".naslov_tekstualna.input_naslov")).Text.Contains("Често поставувани прашања"));

        }
        [Test]
        public void AddingToCartMaslo()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.op();
            page2.closeCookies();
            page2.addtoCart1();
            page2.clickCardIcon();
            Assert.IsTrue(driver.FindElement(By.CssSelector(".info_txt_cart")).Text.Contains("Производи кои се во вашата кошнич"));

        }
        [Test]
        public void specificTest2()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.op();
            page2.moniniElement.Click();
            Assert.IsTrue(page2.naslovZaMonin.Text.Contains("MONINI"));


        }
        [Test]
        public void CheckPijalociCanBeOppened()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.openVater();
            Assert.IsTrue(page2.alkoholniPijaloci.Text.Contains("Алкохолни пијалоци"));



        }
        [Test]
        public void CheckIfSliderIsWorkingOnVaterPage()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.openVater();
            page2.closeCookies();
            page2.ClickSlajder();
            string vrednostNaValue = page2.brojNaStrana.GetAttribute("value");
            Assert.IsTrue(vrednostNaValue.Contains("2"));




        }
        [Test]
        public void EndToEndOrderLessThen600Denars()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.op();
            page2.closeCookies();
            page2.ClickBrasno();
            page2.closeCookies();
            page2.ClickOdredenoBrasno();
            page2.ClickKosnicka();
            Thread.Sleep(2000);
            page2.NaplataClick();
            page2.ProdolziClick();
            var alert = driver.SwitchTo().Alert();
            Assert.IsTrue(alert.Text.Contains("Мининмалната нарачка треба да е над 600 денари"));

        }
        [Test]
        public void EndToEndOrderMoreThan600Denars()
        {
            page.GoTo();
            page.login.Click();
            page.LoginTinex("dejanovski_a@yahoo.com", "ubavovreme1");
            page2.op();
            page2.closeCookies();
            page2.ClickBrasno();
            page2.closeCookies();
            page2.ClickOdredenoBrasno();
            page2.ClickKosnicka();
            page2.PlusClick10();
            page2.NaplataClick();
            page2.ProdolziClick();
            var alert = driver.SwitchTo().Alert();
            Assert.IsTrue(alert.Text.Contains("Моментално не вршиме достава во општината со која"));


        }
    }
}

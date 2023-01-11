using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TestingForTinex
{
    internal class MainPage
    {
        private IWebDriver driver;
        public WebDriverWait wait;
        public IWebElement basso => driver.FindElement(By.CssSelector("img[title='МАСЛО маслиново Extra virgin BASSO 750мл']"));



        public MainPage(IWebDriver driver)
        {

            this.driver = driver;

        }

        public IWebElement osnovniProizvodi => driver.FindElement(By.LinkText("Основни производи"));

        public IWebElement ekstraVergin => driver.FindElement(By.CssSelector("img[title='МАСЛО маслиново Extra virgin BASSO 750мл']"));

        public IWebElement dokazDekaEOtvorenZelatin => driver.FindElement(By.ClassName("naslov_produkt"));

        //Check akcii namaluvanje webelement
        public IWebElement akciiZaNamaluvanje => driver.FindElement(By.Id("akcii_btn1"));

        //Check cesto postavuvani prasanja
        public IWebElement cestoPostavuvani => driver.FindElement(By.CssSelector("a[class='cpp_btn'] div[class='naslov_kopc']"));

        //slag pena element
        public List<IWebElement> slagpena => driver.FindElements(By.CssSelector("img[alt='Основни производи']")).ToList();


        // slag pena dodavanje u cart
        public IWebElement slagpenaPlus => driver.FindElement(By.CssSelector("div[class='kolichina_contt'] div[class='increment']"));

        //Slag pena element za dodavanje vo cart
        public IWebElement slagPenaAddToCart => driver.FindElement(By.CssSelector(".kopce_add_cart"));

        //Posle dodavanje na item vo karticka klikanje na karticka element
        public IWebElement cardIcon => driver.FindElement(By.XPath("//a[@class='koshnichka_btn']//div[@class='naslov_kopc']"));

        //element specijalno za test2
        public IWebElement naslovZaMonin => driver.FindElement(By.CssSelector(".naslov_produkt"));

        //element da se najde element za PIJALOCI
        public IWebElement pijalociElement => driver.FindElement(By.CssSelector("a[href='default.aspx?b=32']"));

        //element da se dokaze deka pijaloci e otvorena
        public IWebElement alkoholniPijaloci => driver.FindElement(By.CssSelector("label[for='checkbox135']"));

        //element da se najde VODA
        public IWebElement vodaElement => driver.FindElement(By.XPath("//label[contains(text(),'Вода')]"));

        // element da se zatvorat cookies
        public IWebElement CookiesClose => driver.FindElement(By.Id("closeCookiesMob"));

        //element da se najde slajderot
        public IWebElement slajderVoda => driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_btnNextPage2"));

        //Element da se najde broj na strana 2
        public IWebElement brojNaStrana => driver.FindElement(By.Id("ctl00_ContentPlaceHolder1_txtBrojNaStrana"));

        // Element za brasno
        public IWebElement BrasnoCheckBox => driver.FindElement(By.CssSelector("label[for='checkbox205']"));

        //Element klik na odredeno brasno
        public IWebElement BrasnoOdredeno => driver.FindElement(By.CssSelector("div[data-naziv='БРАШНО пченкарно ЖИТО ЛУКС 750гр']"));

        //Element za kosnicka CART
        public IWebElement Kosnicka => driver.FindElement(By.XPath("//a[@class='koshnichka_btn']//div[@class='slika_kopc_menu']"));

        //Element za naplata na pop upot
        public IWebElement Naplata => driver.FindElement(By.Id("naplatiBtn"));

        //Element prodolzi za naplata
        public IWebElement Prodolzi => driver.FindElement(By.Id("popup-article-submit"));

        //element Plus na narackata 
        public IWebElement PlusZnak => driver.FindElement(By.CssSelector(".increment[data-id='602947']"));



        public void op()
        {

            osnovniProizvodi.Click();
        }
        public void openZelatinCard()
        {
            ekstraVergin.Click();
        }
        // Funkcija za proverka dali raboti akcii za namaluvanje
        public void akciiZaNamaluvanjeClick()
        {
            akciiZaNamaluvanje.Click();
        }

        //Funkcija za cesto postavuvani prasanja
        public void cestoPostavuvaniFunckija()
        {
            cestoPostavuvani.Click();
        }

        //Funkcija za klik na slag pena
        public void addtoCart1()
        {
            basso.Click();


        }
        
        public void addToCartClick()
        {
            slagPenaAddToCart.Click();
        }

        //funkcija za klikanje na kard ikona
        public void clickCardIcon()
        {
            cardIcon.Click();
        }
        //funkcija da se otvori elementot za pijaloci
        public void openVater()
        {
            pijalociElement.Click();
        }
        // funkcija da se klikne slajderot
        public void clickSlajderonVater()
        {
           
            slajderVoda.Click();
        }
        //funckija da se zatvori cookies
        public void closeCookies()
        {
            CookiesClose.Click();
        }
        
        //klik na cekboks brasno
        public void ClickBrasno()
        {
            BrasnoCheckBox.Click();
        }

        //klik na odredeno brasno od grupata
        public void ClickOdredenoBrasno()
        {
            BrasnoOdredeno.Click();
        }
        public void ClickKosnicka()
        {
            Kosnicka.Click();
        }

        //funckija za klik na naplata
        public void NaplataClick()
        {
            Naplata.Click();
        }
        //funkcija za prodolzi
        public void ProdolziClick()
        {
            Prodolzi.Click();
        }
        //klikanje na plus 7 pati
        public void PlusClick10()
        {
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
            PlusZnak.Click();
        }
    }

}
using DataDrivenWithExample.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenWithExample.PageObject
{
     class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage() 
        {
            driver = Hooks1.driver;
        }

             IWebDriver driver;


        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement UserName => driver.FindElement(By.XPath("//input[@type='text']"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));












        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void ClickOnSignUp()
        {
            SignUp.Click();
        }
        public void EnterUsername(string username)
        {
            UserName.SendKeys(username);
        }
       public void EnterEmail(string email) 
        {
            Email.SendKeys(email);
        }
        public void EnterPassword(string password) 
        {
            Password.SendKeys(password);
        }
        public void ClickOnSignUpButton() 
        { 
            SignUpButton.Click();
        }

        public bool IsNewArticleDisplaced()

        {
            return NewArticle.Displayed;       
        }















    }
}

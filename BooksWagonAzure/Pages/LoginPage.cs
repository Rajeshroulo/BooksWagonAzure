﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace Bookswagon.Page
{
    public class LoginPage
    {
        public IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtEmail")]
        public IWebElement mail;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_txtPassword")]
        public IWebElement bookPassword;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_btnLogin")]
        public IWebElement loginButton;
        
        public void AccountLogin(string email, string bookspassword)
        {
            Thread.Sleep(10000);
            mail.SendKeys(email);
            bookPassword.SendKeys(bookspassword);
            loginButton.Click();
            Thread.Sleep(2000);
        }        
    }
}

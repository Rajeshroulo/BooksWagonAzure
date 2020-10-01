using Bookswagon.Page;
using BooksWagonAzure.Base;
using NUnit.Framework;
using System;
using System.Configuration;

namespace BooksWagonAzure.Test
{
    public class BookswagonTests : BaseClass
    {

        [Test, Order(1)]
        public void BookswagonLogin()
        {
            var login = new LoginPage(driver);
            login.AccountLogin();
            string title = "Online BookStore India, Buy Books Online, Buy Book Online India - Bookswagon.com";
            Assert.AreEqual(driver.Title, title);
        }

        [Test, Order(2)]
        public void SearchBooks()
        {
            var search = new BookSearchPage(driver);
            search.BookSearching();
            string title = "Buy Wings of Fire book by Au,Apj Abdul Kalam,Arun Tiwari, 9788173711466 - Bookswagon.com";
            Assert.AreEqual(driver.Title, title);
        }

        [Test, Order(3)]
        public void AddtoCart()
        {
            var cart = new MyCartPage(driver);
            cart.AddToShoppingCart();
            string mail = "Hi, rajraval017@gmail.com";
            Assert.AreEqual(mail, cart.MailId());
        }

        [Test, Order(4)]
        public void DeliveryAddress()
        {
            var address = new AddressPage(driver);
            address.ShippingAddress();
            address.Payment();
            string url = "https://www.bookswagon.com/login";
            Assert.AreEqual(driver.Url, url);
        } 

    }
}

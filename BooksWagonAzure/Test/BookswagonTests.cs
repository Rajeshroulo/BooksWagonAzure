using Bookswagon.Page;
using BooksWagonAzure.Base;
using NUnit.Framework;
using System.Configuration;

namespace BooksWagonAzure.Test
{
    public class BookswagonTests : BaseClass
    {

        [Test, Order(1)]
        public void BookswagonLogin()
        {
            var login = new LoginPage(driver);
            login.AccountLogin(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["bookspassword"]);
            Assert.AreEqual("TextBooks", login.TextBooks()); 
        }

       [Test, Order(2)]
        public void SearchBooks()
        {
            var search = new BookSearchPage(driver);
            search.BookSearching();
            string text = "Bestsellers";
            Assert.AreEqual(text, search.BookTitle());
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
            string expected = "TextBooks";
            Assert.AreEqual(expected, address.Books());
        }

    }
}

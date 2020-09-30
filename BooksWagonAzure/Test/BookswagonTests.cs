﻿using Bookswagon.Data;
using Bookswagon.Page;
using BooksWagonAzure.Base;
using NUnit.Framework;

namespace BooksWagonAzure.Test
{
    public class BookswagonTests : BaseClass
    {
        UserData data = new UserData();
        [Test, Order(1)]
        public void BookswagonLogin()
        {
            var login = new LoginPage(driver);
            login.AccountLogin(data.email, data.bookspassword);
            Assert.AreEqual("TextBooks", login.TextBooks());
        }

    }
}

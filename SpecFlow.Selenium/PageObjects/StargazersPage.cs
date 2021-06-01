using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Xunit;

namespace SpecFlow.Selenium.PageObjects
{
    public class Stargazers : PageObject
    {
        private readonly IWebDriver _driver;

        public Stargazers(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void clickOnStaredUsers()
        {
            staredUsers.Click();
        }

        public int getStaredUsersCount()
        {
            return Users.Count;
        }

        public int displayedCount()
        {
            return Int32.Parse(staredUsers.Text);
        }

        public void AssertCountsAndList()
        {
            Assert.Equal(getStaredUsersCount(), displayedCount());
        }

        public IWebElement staredUsers => _driver.FindElement(By.XPath("//a[contains(@class,'social-count js-social-count')]"));

        public IList<IWebElement> Users => _driver.FindElements(By.XPath("//*[@id='repos']/ol/li"));
    }
}





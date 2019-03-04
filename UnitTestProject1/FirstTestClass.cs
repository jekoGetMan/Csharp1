using System;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    [TestClass]
    public class someTestWebDriver
    {
        IWebDriver driver = new FirefoxDriver(); // Chrome didn't launch on this PC

        [SetUp]
        public void Before()
        {
            //Some default setup before every tes
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
//            driver.Close();
//            driver.Quit();
//            driver.Quit();
        }
        [Test]
        public void SearchUser()
        {
            driver.Navigate().GoToUrl("https://github.com");
            driver.FindElement(By.XPath("//input[@placeholder='Search GitHub']")).SendKeys("ViacheslavMelnichenko" + Keys.Enter);
            driver.FindElement(By.XPath("(//a[@class='menu-item selected'])[last()]")).Click();
//            driver.FindElement(By.XPath("(//button[text()='Sign up for GitHub'])[1]"));
        }

        [TearDown]
        public void After()
        {
            driver.Quit();
        }
    }
}
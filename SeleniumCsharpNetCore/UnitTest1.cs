using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharpNetCore
{
    public class Tests
    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            Console.WriteLine("Test 1");
        }

        [Test]
        public void Test1()
        {
            string url = "http://eaapp.somee.com/";
            driver.Navigate().GoToUrl(url);
            Console.WriteLine("Test running...");
            Assert.Pass();
        }
        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
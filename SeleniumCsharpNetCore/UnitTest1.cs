using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCsharpNetCore
{
    public class Tests
    {
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {

            ChromeOptions option = new ChromeOptions(); ;
            option.AddArgument("--headless");

        //    new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Test 1");
            driver = new ChromeDriver(option);
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
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeOptions chromeOptions = new ChromeOptions();
            Console.WriteLine(Path.GetFullPath(@"..\..\..\driver"));
            chromeOptions.AddArguments("--start-maximized");
            Driver = new ChromeDriver(Path.GetFullPath(@"..\..\..\driver"), chromeOptions);
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://executeautomation.com");
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}
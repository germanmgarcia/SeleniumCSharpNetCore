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
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("tomato");

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));

            comboControl.Clear();
            comboControl.SendKeys("Almond");
            Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}
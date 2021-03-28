using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPageLinks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Since I am using Firefox I downloaded the Selenium.Firefox-package.
            IWebDriver driver = new FirefoxDriver();

            //Big quiz-fan, so lets check out the Sporcle website.
            driver.Navigate().GoToUrl("https://www.sporcle.com/");

            int counter = 0;

            foreach (var link in driver.FindElements(By.TagName("a")))
            {
                Console.WriteLine(link.GetAttribute("href"));
                counter++;
            }
            Console.WriteLine($"\nThere are {counter} links on the page");
            driver.Quit();
            Console.ReadKey();
        }
    }
}

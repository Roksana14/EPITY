using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;


class Pit11
{

	static IWebDriver driver = new ChromeDriver();
	static IWebElement button;
	static IWebElement textbox;
	static IWebElement checkbox;
	static Actions builder = new Actions(driver);
	


	static void Main()
	{

		string url = "https://www.e-pity.pl/pit-online/index.php?partner=aepmnoliclpephome#/kreator/sposob-opodatkowania";

		driver.Navigate().GoToUrl(url);
		driver.Manage().Window.Maximize();
		

		button = driver.FindElement(By.CssSelector("#app > ons-splitter > ons-splitter-content > div.appPopupManager > div:nth-child(1) > ons-modal > div > div > div > div.buttonsHGroup > ons-button:nth-child(1)"));
		button.Click();
		Thread.Sleep(2000);
		button = driver.FindElement(By.CssSelector("#app > ons-splitter > ons-splitter-content > div.appContent > ons-navigator > ons-page > div.page__content.page--material__content > div > div.buttonsVGroup.flex-vert.center-align.buttonsVGroup2 > ons-button > div > div"));
		button.Click();
		Thread.Sleep(3000);
		button = driver.FindElement(By.CssSelector("body > div:nth-child(33) > ons-dialog > div.dialog.dialog-container.dialog--material.dialog-container--material > div > div.buttons > ons-button:nth-child(2)"));
		button.Click();
		Thread.Sleep(3000);
		button = driver.FindElement(By.CssSelector("#app > ons-splitter > ons-splitter-content > div.appContent > ons-navigator > ons-page.page.page--material.BaseKreatorPage.KreatorSposobOpodatkowania > div.page__content.page--material__content > div > div > div.page-buttons-inline > ons-button"));
		button.Click();
		Thread.Sleep(3000);

		//DANE OSOBOWE
		textbox = driver.FindElement(By.ClassName("text-input__container"));
		textbox.Click();
		textbox.SendKeys("KOWALSKI");
		Thread.Sleep(3000);
		builder.SendKeys(Keys.Tab).Build().Perform();
		textbox = driver.FindElement(By.CssSelector("div.fields-BaseField:nth-child(3) > div:nth-child(2) > ons-input:nth-child(1) > label:nth-child(1) > input:nth-child(1)"));
		textbox.Click();
		textbox.SendKeys("TOMEK");
		Thread.Sleep(3000);
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		textbox = driver.FindElement(By.CssSelector("div.fields-BaseField:nth-child(5) > div:nth-child(2) > ons-input:nth-child(1) > label:nth-child(1) > input:nth-child(1)"));
		textbox.SendKeys("79092981421");
		Thread.Sleep(3000);
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		textbox = driver.FindElement(By.CssSelector("div.fields-BaseField:nth-child(9) > div:nth-child(2) > ons-input:nth-child(1) > label:nth-child(1) > input:nth-child(1)"));
		textbox.SendKeys("53-338");
		Thread.Sleep(3000);
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		textbox = driver.FindElement(By.CssSelector("div.fields-BaseField:nth-child(16) > div:nth-child(2) > ons-input:nth-child(1) > label:nth-child(1) > input:nth-child(1)"));
		textbox.SendKeys("2");
		Thread.Sleep(3000);
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		builder.SendKeys(Keys.Tab).Build().Perform();
		button = driver.FindElement(By.CssSelector(".info-header > a:nth-child(2)"));
		button.Click();
		Thread.Sleep(3000);


		button = driver.FindElement(By.Id("_omitValidation"));
		button.Click();
		

		Thread.Sleep(3000);

		button = driver.FindElement(By.CssSelector("ons-button.button:nth-child(3)"));
		button.Click();
		//builder.SendKeys(Keys.PageDown).Build().Perform(); // strona na dół
		
		Thread.Sleep(3000);

		//kolejna strona

		button = driver.FindElement(By.CssSelector("div.buttonsVGroup:nth-child(1) > ons-button:nth-child(1)")); // wybor pit 11
		button.Click();


		// strona z naleznosciami

		button = driver.FindElement(By.CssSelector("div.KreatorPrzychodyPIT11Dane > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2) > ons-list:nth-child(1) > ons-list-item:nth-child(2) > label:nth-child(2) > ons-input:nth-child(1) > label:nth-child(1) > input:nth-child(1)"));
		button.Click();

		button = driver.FindElement(By.CssSelector("div.fields-FieldGroup:nth-child(5) > div:nth-child(1)"));
		button.Click();

		textbox = driver.FindElement(By.CssSelector("div.fields-CurrencyField:nth-child(2) > div:nth-child(2) > ons-input:nth-child(1) > label:nth-child(1) > input:nth-child(1)"));
		textbox.SendKeys("56000");

		textbox = driver.FindElement(By.CssSelector("div.fields - CurrencyField:nth - child(3) > div:nth - child(2) > ons - input:nth - child(1) > label:nth - child(1) > input:nth - child(1)"));
		textbox.SendKeys("2850");

		textbox = driver.FindElement(By.CssSelector("div.fields-CurrencyField:nth-child(5) > div:nth-child(2) > ons-input:nth-child(1) > label:nth-child(1) > input:nth-child(1)"));
		textbox.SendKeys("280");

		//checkbox = driver.FindElement(By.ClassName("#app > ons-splitter > ons-splitter-content > div.appContent > ons-navigator > ons-page.page.page--material.BaseKreatorPage.KreatorDanePodatnika > div.page__content.page--material__content > div > div > div.page-buttons-inline > ons-button.button.button--material.forwardButton"));
		//checkbox.Click();
		//Thread.Sleep(3000);

		//button = driver.FindElement(By.CssSelector("#app > ons-splitter > ons-splitter-content > div.appContent > ons-navigator > ons-page:nth-child(13) > div.page__content.page--material__content > div > div > div.page-buttons-inline > ons-button.button.button--material.forwardButton"));
		//button.Click();
		//Thread.Sleep(3000);

		//button = driver.FindElement(By.CssSelector("#app > ons-splitter > ons-splitter-content > div.appContent > ons-navigator > ons-page:nth-child(14) > div.page__content.page--material__content > div > div > div.kreatorPrzychodyPodsumowanie-full > div > div > div:nth-child(1) > ons-button:nth-child(1)"));
		//button.Click();

		//builder.MoveToElement(driver.FindElement(By.CssSelector("#app > ons-splitter > ons-splitter-content > div.appPopupManager > div:nth-child(2) > ons-page > div.page__content.page--material__content > div > div > div.fields-BaseForm > div:nth-child(5) > div > ons-icon"))).Click();

		////button = driver.FindElement(By.CssSelector)
	}

	
}

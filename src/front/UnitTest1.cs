using Microsoft.Playwright;
namespace poc_Playwright.NET;

public class UnitTest1
{
    [TestMethod]
    [Description("ID: 0001 - Efetuar Login no portal EAApp")]
    public async Task TestMethod1()
    {
        //Playwright
        using var playwright = await Playwright.CreateAsync();

        //Browser
        await using var browser = await playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions {
                Headless = false
            }
        );

        //Page
        var page = await browser.NewPageAsync();
        await page.GotoAsync("http://eaapp.somee.com/");
        await page.ClickAsync("text=Login");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "EAApp.jpg"
        });
        await page.FillAsync("#UserName", "admin");
        await page.FillAsync("#Password", "password");
        await page.ClickAsync("text=Log in");
        var isExist = await page.Locator("text='Employee Details'").IsVisibleAsync();
        Assert.IsTrue(isExist);


    }
}
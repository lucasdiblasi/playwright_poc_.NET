using Microsoft.Playwright;

namespace poc_Playwright.NET;

[TestClass]
public class frontPlaywrightPoc
{
    [TestMethod]
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
        await page.GotoAsync("https://playwright.dev/dotnet/");
        await page.ClickAsync("text=API");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "google.jpg"
        });

    }
}
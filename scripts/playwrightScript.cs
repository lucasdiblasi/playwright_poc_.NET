using Microsoft.Playwright;

class Program
{
    static async Task Main(string[] args)
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync();
        var page = await browser.NewPageAsync();

        await page.GotoAsync("https://www.example.com");
        await page.ScreenshotAsync(new PageScreenshotOptions { Path = "example.png" });

        await browser.CloseAsync();
    }
}

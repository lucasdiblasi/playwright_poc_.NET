using Microsoft.Playwright.MSTest;

namespace poc_Playwright.NET;

public class frontPlaywrightPoc : PageTest
{
    [TestInitialize]
    public async Task Setup()
    {
        await Page.GotoAsync("http://eaapp.somee.com/");
    }
    [TestMethod]
    [Description("ID: 0001 - Efetuar Login no portal EAApp")]
    public async Task TestMethod1()
    {
        await Page.ClickAsync("text=Login");
        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        await Page.ClickAsync("text=Log in");
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();


    }
}
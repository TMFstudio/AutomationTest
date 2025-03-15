using TechTalk.SpecFlow.Assist;
using WebBddSut.Model;
using WebBddSut.Page;

namespace WebBDDSut.StepDefinitions;

[Binding]
public sealed class ProductSteps
{
    private readonly IHomePage _homePage;
    private readonly ICreateProductPage _productPage;
    private readonly ScenarioContext _scenarioContext;
    public ProductSteps(IHomePage homePage, ICreateProductPage createProductPage, ScenarioContext scenarioContext)
    {
        _homePage = homePage;
        _productPage = createProductPage;
        _scenarioContext = scenarioContext;
    }

    [Given(@"I click the Product menu")]
    public void GivenIClickTheProductMenu()
    {
        _homePage.ClickProduct();
    }

    [Given(@"I click the ""([^""]*)"" link")]
    public void GivenIClickTheLink(string create)
    {
        _homePage.ClickCreateProduct();
    }

    [Given(@"I create product with this details")]
    public void GivenICreateProductWithFollowingDetails(Table table)
    {
        var product = table.CreateInstance<Product>();

        _productPage.NewPorduct(product);

        //set data in scenarioContext
        _scenarioContext.Set<Product>(product);
    }

    [Then(@"I see all the product details are created as expected")]
    public void ThenISeeAllTheProductDetailsAreCreatedAsExpected()
    {
        var product= _scenarioContext.Get<Product>();

        var actualProduct = _productPage.GetProductDetails(product.Name);

        actualProduct.Name.Should().Be(product.Name);

    }

}

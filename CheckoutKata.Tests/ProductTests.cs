namespace CheckoutKata.Tests;

public class ProductTests {

    [Fact]
    public void Can_Construct()
    {
        var product = new Product();
    }

    [Theory]
    [InlineData("Banana")]
    [InlineData("Matt Spray Paint - White")]
    public void Can_Construct_With_Name(string name) {
        var product = new Product(name);
        product.Name.Should().Be(name);
    }

}
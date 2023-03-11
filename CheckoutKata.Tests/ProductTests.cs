namespace CheckoutKata.Tests;

public class ProductTests {

    [Theory]
    [InlineData("A", "Banana")]
    [InlineData("B", "Matt Spray Paint - White")]
    public void When_Construct_Product_It_Holds_Properties(string sku, string name) {
        var product = new Product(sku, name);
        product.Sku.Should().Be(sku);
        product.Name.Should().Be(name);
    }

}
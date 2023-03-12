namespace CheckoutKata.Tests;

public class ProductTests
{
    [Theory]
    [InlineData("A", "Banana", 0.15)]
    [InlineData("B", "Matt Spray Paint - White", 9.00)]
    public void When_Construct_Product_It_Holds_Properties(string sku, string name, decimal price) {
        var product = new Product(sku, name, price);
        product.Sku.Should().Be(sku);
        product.Name.Should().Be(name);
    }
}
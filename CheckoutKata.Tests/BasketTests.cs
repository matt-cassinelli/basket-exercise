namespace CheckoutKata.Tests;

public class BasketTests {

    [Fact]
    public void Can_Construct()
    {
        var basket = new Basket();
    }

    [Fact]
    public void When_Construct_Then_Total_Is_Zero()
    {
        var basket = new Basket();
        basket.Total.Should().Be(0);
    }

    [Fact]
    public void When_Construct_Then_Is_Empty()
    {
        var basket = new Basket();
        basket.Contents.Should().BeEmpty();
    }

    [Fact]
    public void Given_Missing_Product_When_Call_Add_Then_Throw_ArgumentNullException()
    {
        var basket = new Basket();
        Action add = () => basket.Add(null);
        add.Should().Throw<ArgumentNullException>();
    }

    [Theory]
    [InlineData(1)]
    [InlineData(20)]
    public void Given_Product_Added_Then_Quantity_Should_Increment(int amountOfProducts)
    {
        var basket = new Basket();

        for (int i = 0; i < amountOfProducts; i++) {
            basket.Add(new Product("A", "Apple", 0.41m));
        }
        
        basket.Quantity.Should().Be(amountOfProducts);
    }

    [Fact]
    public void Can_Add_Product_With_Properties()
    {
        
        var basket = new Basket();
        var product = new Product("A", "Apple", 0.41m);

        basket.Add(product);

        basket.Contents.Should().Contain(product);
    }

    [Fact]
    public void When_Products_Added_Then_Total_Calculated()
    {
        var basket = new Basket();

        basket.Add(new Product("A", "Apple", 0.41m));
        basket.Add(new Product("B", "Washing Machine", 210.00m));

        basket.Total.Should().Be(210.41m);
    }

}
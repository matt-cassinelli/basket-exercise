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
    public void Given_A_Product_When_Call_Add_Then_Quantity_Should_Increment(int amountOfProducts)
    {
        var basket = new Basket();

        for (int i = 0; i < amountOfProducts; i++) {
            basket.Add(new Product());
        }
        
        basket.Quantity.Should().Be(amountOfProducts);
    }

    [Theory]
    [InlineData("Banana")]
    [InlineData("Matt Spray Paint - White")]
    public void Given_A_Named_Product_When_Call_Add_Then_Basket_Should_Contain_Name(string name)
    {
        var product = new Product(name);
        product.Name.Should().Be(name);
    }

    [Fact]
    public void Can_Add_Product_To_Basket() {
        var basket = new Basket();
    }

}
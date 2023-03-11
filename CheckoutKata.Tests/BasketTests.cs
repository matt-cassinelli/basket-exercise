using FluentAssertions;

namespace CheckoutKata;

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
        basket.Total.ShouldBe(0);
    }

    [Fact]
    public void When_Construct_Then_Is_Empty()
    {
        var basket = new Basket();
        basket.Contents.ShouldBeEmpty();
    }

    [Fact]
    public void Can_Call_Add()
    {
        var basket = new Basket();
        basket.Add();
    }

    [Fact]
    public void Given_Missing_A_Product_When_Call_Add_Then_Throw_ArgumentNullException() {
        var basket = new Basket();
        Action add = () => basket.Add(null);
        add.Should().ThrowExactly<ArgumentNullException>();
    }
}
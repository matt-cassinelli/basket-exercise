namespace CheckoutKata.Tests;

public class PromotionTests
{

    [Fact]
    public void When_2_Of_Product_B_Then_Total_Returns_30()
    {
        var basket = new Basket();
        basket.Add(new Product("B", "Fire Extinguisher", 15m));
        basket.Add(new Product("B", "Fire Extinguisher", 15m));

        basket.Total.Should().Be(30m);
    }

    [Fact]
    public void When_3_Of_Product_B_Then_Total_Returns_40()
    {
        var basket = new Basket();
        basket.Add(new Product("B", "Fire Extinguisher", 15m));
        basket.Add(new Product("B", "Fire Extinguisher", 15m));
        basket.Add(new Product("B", "Fire Extinguisher", 15m));

        basket.Total.Should().Be(40m);
    }

    [Fact]
    public void When_4_Of_Product_B_Then_Total_Returns_55()
    {
        var basket = new Basket();
        basket.Add(new Product("B", "Fire Extinguisher", 15m));
        basket.Add(new Product("B", "Fire Extinguisher", 15m));
        basket.Add(new Product("B", "Fire Extinguisher", 15m));
        basket.Add(new Product("B", "Fire Extinguisher", 15m));

        basket.Total.Should().Be(55m);
    }

}
namespace CheckoutKata;

public class Promotion
{
    public Promotion(string name, string forSku, decimal discount)
    {
        Name = name;
        ForSku = forSku;
        Discount = discount;
    }

    public string Name { get; }
    public string ForSku { get; }
    public decimal Discount { get; }
}
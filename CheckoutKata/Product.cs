namespace CheckoutKata;

public class Product
{
    public Product(string sku, string name, decimal price)
    {
        Sku = sku;
        Name = name;
        UnitPrice = price;
    }

    public string Sku { get; }
    public string Name { get; }
    public decimal UnitPrice { get; }
}
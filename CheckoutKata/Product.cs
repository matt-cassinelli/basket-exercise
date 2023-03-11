namespace CheckoutKata;

public class Product {

    public Product(string sku, string name)
    {
        Sku = sku;
        Name = name;
    }

    public string Sku { get; set; }
    public string Name { get; set; }
}
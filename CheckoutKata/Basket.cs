namespace CheckoutKata;

public class Basket {

    public decimal Total => 0;
    public List<Product> Contents = new List<Product>();
    public int Quantity => Contents.Count();

    public void Add(Product product) {
        if (product != null)
            Contents.Add(product);
        else
            throw new ArgumentNullException();
    }

}
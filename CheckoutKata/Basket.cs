namespace CheckoutKata;

public class Basket {

    public List<Product> Contents = new List<Product>();
    public int Quantity => Contents.Count();
    public decimal Total => Contents.Sum(p => p.Price);

    public void Add(Product product) {
        if (product != null)
            Contents.Add(product);
        else
            throw new ArgumentNullException();
    }

}
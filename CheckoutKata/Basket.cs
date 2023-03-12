namespace CheckoutKata;

public class Basket
{
    private PromotionFactory _promotionFactory = new PromotionFactory();

    public List<Promotion> FulfilledPromotions => _promotionFactory.GetFulfilledPromotions(Contents);
    public List<Product> Contents = new List<Product>();
    public int Quantity => Contents.Count();
    public decimal Total => Contents.Sum(p => p.UnitPrice) - FulfilledPromotions.Sum(p => p.Discount);

    public void Add(Product product)
    {
        if (product != null)
            Contents.Add(product);
        else
            throw new ArgumentNullException();
    }
}
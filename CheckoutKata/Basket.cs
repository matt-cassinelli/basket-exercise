namespace CheckoutKata;

public class Basket
{
    public List<Promotion> FulfilledPromotions
    {
        get
        {
            var output = new List<Promotion>();

            var productBs = Contents.Where(p => p.Sku == "B");

            int countOfBPromotionsToAdd = productBs.Count() / 3;

            for (int i = 0; i < countOfBPromotionsToAdd; i++)
            {
                output.Add(new Promotion("3 for £40", "B", 5m));
            }

            return output;
        }
    }
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
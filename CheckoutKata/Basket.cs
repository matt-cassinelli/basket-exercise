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

public class PromotionFactory
{
    private List<Promotion> _availablePromotions = new List<Promotion>
    {
        new Promotion(
            name: "3 for £40",
            forSku: "B",
            batchSize: 3,
            originalUnitPrice: 15m,
            fixedFee: 40m,
            multiplier: null
        )
    };

    public List<Promotion> GetFulfilledPromotions(List<Product> products)
    {
        var output = new List<Promotion>();

        foreach (var promotion in _availablePromotions)
        {
            var productsEligibleForPromos = products.Where(p => p.Sku == promotion.ForSku);
            int countOfPromotionsFulfilled = productsEligibleForPromos.Count() / 3;

            for (int i = 0; i < countOfPromotionsFulfilled; i++)
            {
                output.Add(promotion);
            }
        }

        //var productLines = products.GroupBy(p => p.Sku);

        return output;
    }
}
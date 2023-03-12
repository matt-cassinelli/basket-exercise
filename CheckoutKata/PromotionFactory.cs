using System;
namespace CheckoutKata;

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
        ),
        new Promotion(
            name: "25% off for every 2",
            forSku: "D",
            batchSize: 2,
            originalUnitPrice: 55m,
            fixedFee: null,
            multiplier: 0.75m
        )
    };

    public List<Promotion> GetFulfilledPromotions(List<Product> products)
    {
        var output = new List<Promotion>();

        foreach (var promotion in _availablePromotions)
        {
            var productsEligibleForPromos = products.Where(p => p.Sku == promotion.ForSku);
            int countOfPromotionsFulfilled = productsEligibleForPromos.Count() / promotion.BatchSize;

            for (int i = 0; i < countOfPromotionsFulfilled; i++)
            {
                output.Add(promotion);
            }
        }

        //var productLines = products.GroupBy(p => p.Sku);

        return output;
    }
}
namespace CheckoutKata;

public class Promotion
{
    private readonly decimal _originalUnitPrice;
    private readonly decimal? _fixedFee;
    private readonly decimal? _multiplier;

    public Promotion(string name, string forSku, int batchSize, decimal originalUnitPrice, decimal? fixedFee, decimal? multiplier)
    {
        Name = name;
        ForSku = forSku;
        BatchSize = batchSize;
        _originalUnitPrice = originalUnitPrice;
        _fixedFee = fixedFee;
        _multiplier = multiplier;
    }

    public string Name { get; }
    public string ForSku { get; }
    public int BatchSize { get; }
    public decimal Discount
    {
        get
        {
            var withoutDiscount = BatchSize * _originalUnitPrice;

            if (_fixedFee.HasValue)
                return withoutDiscount - _fixedFee.Value;

            if (_multiplier.HasValue)
                return withoutDiscount - (withoutDiscount * _multiplier.Value);

            return 0;
        }
    }
}
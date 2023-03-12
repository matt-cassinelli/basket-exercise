namespace CheckoutKata;

public class Promotion
{
    private readonly int _batchSize;
    private readonly decimal _originalUnitPrice;
    private readonly decimal? _fixedFee;
    private readonly decimal? _multiplier;

    public Promotion(string name, string forSku, int batchSize, decimal originalUnitPrice, decimal? fixedFee, decimal? multiplier)
    {
        Name = name;
        ForSku = forSku;
        _batchSize = batchSize;
        _originalUnitPrice = originalUnitPrice;
        _fixedFee = fixedFee;
        _multiplier = multiplier;
    }

    public string Name { get; }
    public string ForSku { get; }
    public decimal Discount
    {
        get
        {
            if (_fixedFee != null)
                return (decimal)((_batchSize * _originalUnitPrice) - _fixedFee);

            if (_multiplier.HasValue)
                return (decimal)(_batchSize * _originalUnitPrice * _multiplier);

            return 0;
        }
    }
}
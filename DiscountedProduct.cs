class DiscountedProduct : Product
{
    public double DiscountPercent { get; set; }

    public DiscountedProduct(string name,double price,double discountPercent): base(name, price)
    {
        DiscountPercent = discountPercent;
    }

    public override double GetFinalPrice()
    {
        return Price - Price * DiscountPercent / 100;
    }
}
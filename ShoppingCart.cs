class ShoppingCart
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public bool RemoveProduct(string name)
    {
        Product product = products.Find( p=> p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product != null)
        {
            products.Remove(product);
            return true;
        }

        return false;
    }

    public double GetTotal()
    {
        double total = 0;

        foreach (Product product in products)
        {
            total += product.GetFinalPrice();
        }

        return total;
    }

    public void PrintAll()
    {
        Console.WriteLine("Shopping Cart:");

        foreach (Product product in products)
        {
            Console.WriteLine(
                $"{product.Name}: {product.GetFinalPrice():F2}");
        }

        Console.WriteLine($"Total: {GetTotal():F2}");
    }
}
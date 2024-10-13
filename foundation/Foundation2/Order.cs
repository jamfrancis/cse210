public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }

        // Add shipping cost based on whether the customer is in the USA or not
        decimal shippingCost = _customer.IsInUSA() ? 5m : 35m;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (Product ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
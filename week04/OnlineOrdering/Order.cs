using System.Collections.Generic;
using System.Text;


public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalOrderCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        return total + shippingCost;
    }

    public string packingLabel()
    {
        StringBuilder label = new StringBuilder("Packing label: ");
        foreach (var product in _products)
        {
            label.AppendLine($"- {product.Name()} (ID: {product.ProductId()})");
        }
        return label.ToString();
    }

    public string shippingLabel()
    {
        return $"Shipping label: {_customer.GetName()} {_customer.AddressDetails()}";
    }
}
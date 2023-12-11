using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customers;
    private double _totalCostOfOrder;

    public Order(Customer customer)
    {
        _customers = customer;
        _totalCostOfOrder = 0;
    }
    
    public void ProductList(Product product) // Add products to the Product list created
    {
        _products.Add(product);
    }

    public void TotalCostOfOrder() // Calculate the total number of price in the Product List
    {
        int tax;
        
        if(_customers.IsInUSA()) // Check if customer Country is USA, then Add $5
        {
            foreach (Product pd in _products)
            {
                _totalCostOfOrder += pd.ProductPrice();      
            }
           
            tax = 5;
            Console.WriteLine($"Tax: {tax}\nTotal Cost: ${_totalCostOfOrder + tax}");
        }
        else // Check if customer Country is not USA, then Add $35
        {
            foreach (Product pd in _products)
            {
                _totalCostOfOrder += pd.ProductPrice();      
            }
            tax = 35;
            Console.WriteLine($"Tax: {tax}\nTotal Cost: ${_totalCostOfOrder + tax}");
        }
        
    }

    public void PackingLabel() // Package label for each product in the Product list
    {
        Console.WriteLine("_____PRODUCT PURCHASED_____");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.Displayproduct());
        }
    }

    public void ShippingLabel() // Shipping Label
    {       
        Console.WriteLine (_customers.DisplayCustomerDetils());
    }
}
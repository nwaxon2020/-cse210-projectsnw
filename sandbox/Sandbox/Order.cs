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
    
    public void ProductList(Product product)
    {
        _products.Add(product);
    }

    public void TotalCostOfOrder()
    {
        int tax;
        
        if(_customers.IsInUSA())
        {
            foreach (Product pd in _products)
            {
                _totalCostOfOrder += pd.ProductPrice();      
            }
           
            tax = 5;
            Console.WriteLine($"Tax: {tax}\nTotal Cost: ${_totalCostOfOrder + tax}");
        }
        else
        {
            foreach (Product pd in _products)
            {
                _totalCostOfOrder += pd.ProductPrice();      
            }
            tax = 35;
            Console.WriteLine($"Tax: {tax}\nTotal Cost: ${_totalCostOfOrder + tax}");
        }
        
    }

    public void PackingLabel()
    {
        Console.WriteLine("_____PRODUCT PURCHASED_____");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.Displayproduct());
        }
    }

    public void ShippingLabel()
    {       
        Console.WriteLine (_customers.DisplayCustomerDetils());
    }
}

using System;

public class Item
{
    private double shippingWeight;
    private string description;

    public Item(double shippingWeight, string description)
    {
        this.shippingWeight = shippingWeight;
        this.description = description;
    }

    public double GetPriceForQuantity()
    {
        return 0.0;
    }

    public double GetTax()
    {
        return 0.0;
    }

    public bool InStock()
    {
        return true;
    }
}

public class OrderDetail
{
    private int quantity;
    private string taxStatus;

    public OrderDetail(int quantity, string taxStatus)
    {
        this.quantity = quantity;
        this.taxStatus = taxStatus;
    }

    public double CalcSubTotal()
    {
        return 0.0;
    }

    public double CalcWeight()
    {
        return 0.0;
    }

    public double CalcTax()
    {
        return 0.0;
    }
}

public class Order
{
    private DateTime date;
    private string status;

    public Order(DateTime date, string status)
    {
        this.date = date;
        this.status = status;
    }

    public double CalcSubTotal()
    {
        return 0.0;
    }

    public double CalcTax()
    {
        return 0.0;
    }

    public double CalcTotal()
    {
        return 0.0;
    }

    public double CalcTotalWeight()
    {
        return 0.0;
    }
}

public class Customer
{
    private string name;
    private string address;

    public Customer(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
}

public class Payment
{
    private float amount;

    public Payment(float amount)
    {
        this.amount = amount;
    }
}

public class Cash : Payment
{
    private float cashTendered;

    public Cash(float amount, float cashTendered) : base(amount)
    {
        this.cashTendered = cashTendered;
    }
}

public class Check : Payment
{
    private string name;
    private string bankID;

    public Check(float amount, string name, string bankID) : base(amount)
    {
        this.name = name;
        this.bankID = bankID;
    }

    public bool Authorized()
    {
        return true;
    }
}

public class Credit : Payment
{
    private string name;
    private string type;
    private DateTime expDate;

    public Credit(float amount, string name, string type, DateTime expDate) : base(amount)
    {
        this.name = name;
        this.type = type;
        this.expDate = expDate;
    }

    public bool Authorized()
    {
        return true;
    }
}



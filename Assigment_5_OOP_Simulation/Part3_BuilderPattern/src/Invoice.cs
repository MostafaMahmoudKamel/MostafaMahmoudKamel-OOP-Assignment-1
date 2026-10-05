using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part3_BuilderPattern.src;

public class Invoice
{


    // Customer
    public int InvoiceId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }

    //Task 3.2 => seperate Address[Billing,shipping] and order
    public Address BillingAddress { get; set; }

    public Address ShippingAddress { get; set; }

    public OrderInvoice Order { get; set; }

    //new constructor
    public Invoice(int invoiceId, string customerName, string customerEmail, string customerPhone, Address billingAddress, Address shippingAddress, OrderInvoice order)
    {
        InvoiceId = invoiceId;
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;
        BillingAddress = billingAddress;
        ShippingAddress = shippingAddress;
        Order = order;
    }

    // Billing Address
    //public string BillingStreet { get; set; }
    //public string BillingCity { get; set; }
    //public string BillingState { get; set; }
    //public string BillingZipCode { get; set; }
    //public string BillingCountry { get; set; }

    //// Shipping Address
    //public string ShippingStreet { get; set; }
    //public string ShippingCity { get; set; }
    //public string ShippingState { get; set; }
    //public string ShippingZipCode { get; set; }
    //public string ShippingCountry { get; set; }

    // Order & Payment
    //public DateTime OrderDate { get; set; }
    //public string PaymentMethod { get; set; }
    //public string Currency { get; set; }
    //public decimal SubTotal { get; set; }
    //public decimal DiscountAmount { get; set; }
    //public decimal TaxAmount { get; set; }
    //public decimal TotalAmount { get; set; }

    //public Invoice(int invoiceId, string customerName, string customerEmail, string customerPhone, string billingStreet, string billingCity, string billingState, string billingZipCode, string billingCountry, string shippingStreet, string shippingCity, string shippingState, string shippingZipCode, string shippingCountry, DateTime orderDate, string paymentMethod, string currency, decimal subTotal, decimal discountAmount, decimal taxAmount, decimal totalAmount)
    //{
    //    InvoiceId = invoiceId;
    //    CustomerName = customerName;
    //    CustomerEmail = customerEmail;
    //    CustomerPhone = customerPhone;
    //    BillingStreet = billingStreet;
    //    BillingCity = billingCity;
    //    BillingState = billingState;
    //    BillingZipCode = billingZipCode;
    //    BillingCountry = billingCountry;
    //    ShippingStreet = shippingStreet;
    //    ShippingCity = shippingCity;
    //    ShippingState = shippingState;
    //    ShippingZipCode = shippingZipCode;
    //    ShippingCountry = shippingCountry;
    //    OrderDate = orderDate;
    //    PaymentMethod = paymentMethod;
    //    Currency = currency;
    //    SubTotal = subTotal;
    //    DiscountAmount = discountAmount;
    //    TaxAmount = taxAmount;
    //    TotalAmount = totalAmount;
    //}


    //override public string ToString()
    //{
    //    return $"InvoiceId: {InvoiceId}, CustomerName: {CustomerName}, CustomerEmail: {CustomerEmail}, CustomerPhone: {CustomerPhone}, BillingStreet: {BillingStreet}, BillingCity: {BillingCity}, BillingState: {BillingState}, BillingZipCode: {BillingZipCode}, BillingCountry: {BillingCountry}, ShippingStreet: {ShippingStreet}, ShippingCity: {ShippingCity}, ShippingState: {ShippingState}, ShippingZipCode: {ShippingZipCode}, ShippingCountry: {ShippingCountry}, OrderDate: {OrderDate}, PaymentMethod: {PaymentMethod}, Currency: {Currency}, SubTotal: {SubTotal}, DiscountAmount: {DiscountAmount}, TaxAmount: {TaxAmount}, TotalAmount: {TotalAmount}";
    //}
}

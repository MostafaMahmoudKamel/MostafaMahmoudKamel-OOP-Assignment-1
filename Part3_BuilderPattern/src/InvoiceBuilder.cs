using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part3_BuilderPattern.src;

public class InvoiceBuilder
{
    private int _invoiceId;
    private string? _customerName;
    private string? _customerEmail;
    private string? _customerPhone;

    private Address? _billingAddress;
    private Address? _shippingAddress;
    private OrderInvoice? _order;

    public InvoiceBuilder(int invoiceId, string customerName, string customerEmail)
    {
        _invoiceId = invoiceId;
        _customerName = customerName;
        _customerEmail = customerEmail;
    }

    public InvoiceBuilder WithCustomerPhone(string customerPhone)
    {
        _customerPhone = customerPhone;
        return this;
    }

    public InvoiceBuilder WithBillingAddress(Address billingAddress)
    {
        _billingAddress = billingAddress;
        return this;
    }

    public InvoiceBuilder WithShippingAddress(Address shippingAddress)
    {
        _shippingAddress = shippingAddress;
        return this;
    }

    public InvoiceBuilder WithOrder(OrderInvoice order)
    {
        _order = order;
        return this;
    }

    public override string ToString()
    {
        return $"InvoiceBuilder: InvoiceId={_invoiceId}, CustomerName={_customerName}, CustomerEmail={_customerEmail}, CustomerPhone={_customerPhone}, BillingAddress={_billingAddress}, ShippingAddress={_shippingAddress}, Order={_order}";
    }

    public Invoice Build()
    {
        //if (_billingAddress == null)
        //    throw new InvalidOperationException("Billing address is required.");

        //if (_shippingAddress == null)
        //    throw new InvalidOperationException("Shipping address is required.");

        //if (_order == null)
        //    throw new InvalidOperationException("Order is required.");

        return new Invoice(
            _invoiceId,
            _customerName!,
            _customerEmail!,
            _customerPhone ?? "",
            _billingAddress,
            _shippingAddress,
            _order
        );
    }
}

//internal class InvoiceBuilder(int InvoiceId, string CustomerName, string CustomerEmail)
//{
//    private string? _customerPhone;

//    private string? _billingStreet;
//    private string? _billingCity;
//    private string? _billingState;
//    private string? _billingZipCode;
//    private string? _billingCountry;

//    private string? _shippingStreet;
//    private string? _shippingCity;
//    private string? _shippingState;
//    private string? _shippingZipCode;
//    private string? _shippingCountry;

//    private DateTime _orderDate;
//    private string? _paymentMethod;
//    private string? _currency;

//    private decimal _subTotal;
//    private decimal _discountAmount;
//    private decimal _taxAmount;

//    public InvoiceBuilder WithCustomerPhone(string customerPhone)
//    {
//        _customerPhone = customerPhone;
//        return this;
//    }

//    public InvoiceBuilder WithBillingStreet(string billingStreet)
//    {
//        _billingStreet = billingStreet;
//        return this;
//    }

//    public InvoiceBuilder WithBillingCity(string billingCity)
//    {
//        _billingCity = billingCity;
//        return this;
//    }

//    public InvoiceBuilder WithBillingState(string billingState)
//    {
//        _billingState = billingState;
//        return this;
//    }

//    public InvoiceBuilder WithBillingZipCode(string billingZipCode)
//    {
//        _billingZipCode = billingZipCode;
//        return this;
//    }

//    public InvoiceBuilder WithBillingCountry(string billingCountry)
//    {
//        _billingCountry = billingCountry;
//        return this;
//    }

//    public InvoiceBuilder WithOrderDate(DateTime orderDate)
//    {
//        _orderDate = orderDate;
//        return this;
//    }

//    public InvoiceBuilder WithPaymentMethod(string paymentMethod)
//    {
//        _paymentMethod = paymentMethod;
//        return this;
//    }

//    public InvoiceBuilder WithCurrency(string currency)
//    {
//        _currency = currency;
//        return this;
//    }

//    public InvoiceBuilder WithSubTotal(decimal subTotal)
//    {
//        _subTotal = subTotal;
//        return this;
//    }

//    public InvoiceBuilder WithDiscountAmount(decimal discountAmount)
//    {
//        _discountAmount = discountAmount;
//        return this;
//    }

//    public InvoiceBuilder WithTaxAmount(decimal taxAmount)
//    {
//        _taxAmount = taxAmount;
//        return this;
//    }

//    public Invoice Build()
//    {
//        return new Invoice(
//            InvoiceId,
//            CustomerName,
//            CustomerEmail,
//            _customerPhone ?? "",
//            _billingStreet ?? "",
//            _billingCity ?? "",
//            _billingState ?? "",
//            _billingZipCode ?? "",
//            _billingCountry ?? "",
//            _shippingStreet ?? "",
//            _shippingCity ?? "",
//            _shippingState ?? "",
//            _shippingZipCode ?? "",
//            _shippingCountry ?? "",
//            _orderDate,
//            _paymentMethod ?? "",
//            _currency ?? "",
//            _subTotal,
//            _discountAmount,
//            _taxAmount,
//            _subTotal - _discountAmount + _taxAmount
//        );
//    }
//}

using Assigment_5_OOP_Simulation.Part1_ProceduralToOOP.src;

public class OrderBuilder
{
    private DateTime _orderDate;
    private string? _paymentMethod;
    private string? _currency;
    private decimal _subTotal;
    private decimal _discountAmount;
    private decimal _taxAmount;

    private decimal _totalAmount;

    public OrderBuilder WithOrderDate(DateTime orderDate)
    {
        _orderDate = orderDate;
        return this;
    }

    public OrderBuilder WithPaymentMethod(string paymentMethod)
    {
        _paymentMethod = paymentMethod;
        return this;
    }

    public OrderBuilder WithCurrency(string currency)
    {
        _currency = currency;
        return this;
    }

    public OrderBuilder WithSubTotal(decimal subTotal)
    {
        _subTotal = subTotal;
        return this;
    }

    public OrderBuilder WithDiscountAmount(decimal discountAmount)
    {
        _discountAmount = discountAmount;
        return this;
    }

    public OrderBuilder WithTaxAmount(decimal taxAmount)
    {
        _taxAmount = taxAmount;
        return this;
    }

    public OrderInvoice Build()
    {
        return new OrderInvoice(
            _orderDate,
            _paymentMethod ?? "",
            _currency ?? "",
            _subTotal,
            _discountAmount,
            _taxAmount,
            -_totalAmount
        );
    }
}
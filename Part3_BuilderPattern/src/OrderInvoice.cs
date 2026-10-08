public class OrderInvoice
{
    public DateTime OrderDate { get; set; }
    public string PaymentMethod { get; set; }
    public string Currency { get; set; }
    public decimal SubTotal { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal TotalAmount { get; set; }

    public OrderInvoice(
        DateTime orderDate,
        string paymentMethod,
        string currency,
        decimal subTotal,
        decimal discountAmount,
        decimal taxAmount,
        decimal v)
    {
        OrderDate = orderDate;
        PaymentMethod = paymentMethod;
        Currency = currency;
        SubTotal = subTotal;
        DiscountAmount = discountAmount;
        TaxAmount = taxAmount;

        TotalAmount = subTotal - discountAmount + taxAmount;
    }
}
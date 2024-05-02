// Define interfaces
public interface IProductManager
{
    void AddProduct(string name, decimal price, int quantity);
}

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public interface INotificationSender
{
    void SendOrderConfirmationEmail(Order order);
}

// Concrete implementations
public class ProductManager : IProductManager
{
    private readonly List<Product> products = new List<Product>();

    public void AddProduct(string name, decimal price, int quantity)
    {
        products.Add(new Product { Name = name, Price = price, Quantity = quantity });
    }
}

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        // Process credit card payment
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        // Process PayPal payment
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }
}

public class EmailNotificationSender : INotificationSender
{
    public void SendOrderConfirmationEmail(Order order)
    {
        string message = $"Order confirmation for order by {order.CustomerName}:\n";
        message += $"Total Cost: ${order.TotalCost}\n";
        message += "Products:\n";
        foreach (Product product in order.Products)
        {
            message += $"{product.Name} (${product.Price})\n";
        }
        // Send email
        Console.WriteLine(message);
    }
}

// Order processing class
public class OrderProcessor
{
    private readonly IProductManager productManager;
    private readonly IPaymentProcessor paymentProcessor;
    private readonly INotificationSender notificationSender;

    public OrderProcessor(IProductManager productManager, IPaymentProcessor paymentProcessor, INotificationSender notificationSender)
    {
        this.productManager = productManager;
        this.paymentProcessor = paymentProcessor;
        this.notificationSender = notificationSender;
    }

    public void PlaceOrder(string customerName, List<int> productIds, decimal totalCost, string paymentMethod)
    {
        // Process order logic
  
        // Call paymentProcessor.ProcessPayment(totalCost);

        // notificationSender.SendOrderConfirmationEmail(order);
    }
}

// Usage example
public static void Main()
{
    var productManager = new ProductManager();
    var creditCardPaymentProcessor = new CreditCardPaymentProcessor();
    var emailNotificationSender = new EmailNotificationSender();

    var orderProcessor = new OrderProcessor(productManager, creditCardPaymentProcessor, emailNotificationSender);

    // Example: Place an order
    // ...
}

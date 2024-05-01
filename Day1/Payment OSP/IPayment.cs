namespace Day1.Payment
{
    //    public interface IPayment
    //    {
    //        void ProcessPayment(double amount);
    //    }

    //    public class CreditCardPayment : IPayment
    //    {
    //        public void ProcessPayment(double amount)
    //        {
    //            // Process credit card payment logic
    //        }
    //    }

    //    public class PayPalPayment : IPayment
    //    {
    //        public void ProcessPayment(double amount)
    //        {
    //            // Process PayPal payment logic
    //        }
    //    }

    //    public class BankTransferPayment : IPayment
    //    {
    //        public void ProcessPayment(double amount)
    //        {
    //            // Process bank transfer payment logic
    //        }
    //    }

    //    // Refactored PaymentProcessor
    //    public class PaymentProcessor
    //    {
    //        public static void ProcessPayment(IPayment payment, double amount)
    //        {
    //            payment.ProcessPayment(amount);
    //        }
    //    }

    public class Account
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
    }

    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public override void Withdraw(decimal amount)
        {
            // Apply withdrawal fee
            const decimal withdrawalFee = 5;
            if (amount + withdrawalFee <= Balance)
            {
                Balance -= (amount + withdrawalFee);
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
    }

















}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDem
{
    //strategy pattern payment method (credit card, mobild banking, crypto)

    public interface  IPaymentStrategy
    {
        void pay(decimal amount);
    }
    //concreate strateggy #1
    public class CreaditCardStrategy : IPaymentStrategy
    {
        private readonly string _cardNumber;
            
            public CreaditCardStrategy(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void pay(decimal amount)
        {
            string masked = "**** **** **** " + _cardNumber[0];
            Console.WriteLine($"[CreditCard Charging {amount:C} to card {masked}");
        }
    }

    //concreate strategy #2
    public class MobileBankingStrategy : IPaymentStrategy 
    {
        private readonly string  _walletPhone;

        public MobileBankingStrategy(string walletPhone)
        {
            _walletPhone = walletPhone;
        }
        public void pay (decimal amount)
        {
            Console.WriteLine($"[MobileBanking] Sending {amount:C} request to wallet {_walletPhone}");
        }
    }

    //concreate strategy #3
    public class CryptoCurrencyStrategy : IPaymentStrategy
    {
        private readonly string _walletAddress;

        public CryptoCurrencyStrategy(string walletAddress)
        {
            _walletAddress = walletAddress;
        }
        public void pay (decimal amount )
        {
            Console.WriteLine($"[Crypto] Broadcasting transaction of {amount: C} equivalent to {_walletAddress}");
        }
    }

    //the context: holds a strategy and delegates to it.  Doesn't care which
    //concreate strategy it has that's the whole point of the pattern 

    public class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        //client can swa[ the strategy at runtime.

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy=strategy;
        }
    public void Checkout (decimal amount)
        {
            _strategy.pay(amount);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Strategy Pattern Demo: payment methods ===\n ");

            var payment = new PaymentContext(new CreaditCardStrategy("4111111111111"));
            payment.Checkout(49.99m);

            payment.SetStrategy(new MobileBankingStrategy("+8801XXXXXXX"));
            payment.Checkout(19.99m);

            payment.SetStrategy(new CryptoCurrencyStrategy("0x1234567890abcdef"));
            payment.Checkout(99.99m);
        }
    }
}

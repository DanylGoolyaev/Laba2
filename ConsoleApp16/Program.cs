using System;

namespace ConsoleApp16
{
    public class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        private string _article = String.Empty;
        private int _quantity;

        public string Article
        {
            get => _article;
            set => _article = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public double GetAccountWithNds(double nds = 0.2)
        {
            return Account + (Account * nds);
        }

        public void Show()
        {
            Console.WriteLine($" {Customer} сделал заказ у {Provider} {_quantity} {_article} и выставил счет," +
                $"\n который будет составлять {Account} без Ндс, и {GetAccountWithNds()} с Ндс");
        }
    }

    class starter
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(2000, "ФОП БургерСити", "ТОВ Фритюрня")
            {
                Quantity = 1000,
                Article = "Котлет"
            };
            invoice.GetAccountWithNds();
            invoice.Show();
        }
    }
}

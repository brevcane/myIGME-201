using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
        string Mood
        {
            get;
        }
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public virtual void AddSugar(byte amount) { }

        public abstract void Steam();

        public HotDrink(bool instant, bool milk, byte sugar, string size, Customer customer) { }

        public HotDrink(string brand) { }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public class Waiter : IMood
    {
        public string Mood
        {
            get;
        }

        public string name;
        public void ServeCustomer(HotDrink cup) { }
    }

    public class Customer : IMood
    {
        public string Mood
        {
            get;
        }

        public string name;
        public string creditCardNumber;
    }

    public class CupOfCoffee : HotDrink
    {

        public string beanType;
        public CupOfCoffee(bool instant, bool milk, byte sugar, string size, Customer customer) : base(instant, milk, sugar, size, customer) { }

        public CupOfCoffee(string brand) : base(brand) { }

        public void TakeOrder() { }


        public override void Steam()
        {
            throw new NotImplementedException();
        }
    }

    public class CupOfTea : HotDrink
    {
        public string leafType;
        public CupOfTea(bool instant, bool milk, byte sugar, string size, Customer customer) : base(instant, milk, sugar, size, customer) { }

        public override void Steam()
        {
            throw new NotImplementedException();
        }

        
    }

    public class CupOfCocoa : HotDrink
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public CupOfCocoa(bool instant, bool milk, byte sugar, string size, Customer customer) : base(instant, milk, sugar, size, customer)
        {
        }

        public string Source { set { source = value; } }

        public override void Steam()
        {
                throw new NotImplementedException();
        }

        public override void AddSugar(byte amount)
        {
            
        }

        public void TakeOrder() { };
    }
}

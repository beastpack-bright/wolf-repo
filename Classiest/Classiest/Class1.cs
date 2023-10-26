using System;
//others should be unneeded? 

namespace Classiest
{
    public interface IMood
    {
        string Mood { get; set; }
    }

    public class Waiter
    {
        public string Mood { get; set; }
        public string Name { get; set; }

        public void ServeCustomer(HotDrink cup)
        {
            //Empty
        }

    }

    public class Customer : IMood
    {
        public string Name { get; set; }
        public string Mood { get; set; }

        public string creditCardNumber { get; set; }
    }

    public abstract class HotDrink
    {
        public bool Instant { get; set; }
        public bool Milk { get; set; }
        private byte sugar;
        public string Size { get; set; }
        public Customer Customer { get; set; }

        public HotDrink(string brand)
        {
            //Empty
        }

        public void AddSugar(byte amount)
        {
            //Empty
        }
        public abstract void Steam();
    }
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string BeanType { get; set; }

        public CupOfCoffee(string brand) : base(brand)
        {
            // Empty
        }
        public void TakeOrder()
        {
            // Empty
        }

        public override void Steam()
        {
            // Empty
        }
    }
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string LeafType { get; set; }

        public CupOfTea(bool customerIsWealthy)
            : base("Tea Brand")
        {
            //Empty
        }

        public void TakeOrder()
        {
            //Empty
        }

        public override void Steam()
        {
            //Empty
        }
    }
    public class CupOfCocoa : HotDrink, ITakeOrder
    { 
        public int NumCups { get; set; } 
        public bool Marshmallows { get; set; }
        private string source;

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {
            NumCups = 1;
            Marshmallows = marshmallows;
        }

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }
        public override void Steam()
        {
            //Empty
        }

        public virtual void AddSugar(byte amount)
        {
            //Empty
        }

        public void TakeOrder()
        {
            //Empty
        }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }
}
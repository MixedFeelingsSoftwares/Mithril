using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mithril.Core.Data
{
    class DataManager
    {
        public static Random rnd = new Random();

        public void SaveCustomer(Customer customer)
        {
        }

        public class Customer
        {
            public Customer(int totalPeople)
            {
                TotalPeople = totalPeople;
            }

            public enum PaymentInfo
            {
                VISA,
                Mastercard,
                Other,
            }
            public class Person
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public int Age { get; private set; }
                private DateTime birth;
                public DateTime BirthDate
                {
                    get
                    {
                        return birth;
                    }
                    set
                    {
                        if (birth != value)
                        {
                            birth = value;
                            Age = DateTime.Now.Year - birth.Year;
                        }
                    }
                }

            }
            public List<Person> GetPeople { get; set; }
            public PaymentInfo CardInfo { get; set; }
            public readonly int TotalPeople = 0;

            public Customer GenerateRandom()
            {
                GetPeople = new List<Person>();

                for (int i = 0; i < TotalPeople; i++)
                {
                    Customer.Person p = new Person();
                    p.FirstName = $"Leonora {i}";
                    p.LastName = "Magnusson";
                    p.BirthDate = new DateTime(DateTime.Now.Year - i^i, rnd.Next(1, 12), rnd.Next(1, 30), rnd.Next(0, 24), rnd.Next(1, 60), rnd.Next(0, 60));
                    GetPeople.Add(p);
                }
                this.CardInfo = (PaymentInfo)rnd.Next(0, typeof(PaymentInfo).GetEnumValues().Length);
                return this ?? null;
            }
        }
    }
}

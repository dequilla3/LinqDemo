using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Customer
    {
        private int customer_id;
        private string customer_name;
        private City city;

        public Customer(int id, string name, City city)
        {
            this.customer_id = id;
            this.customer_name = name;
            this.city = city;
        }

        public int CustomerId { get { return this.customer_id; } }
        public string CustomerName { get { return this.customer_name; } }
        public City City { get { return this.city; } }

    }
}

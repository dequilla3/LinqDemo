using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Model
    {
        private List<City> cities = new List<City>();
        private List<Customer> customerList = new List<Customer>();

        public List<City> Cities { get { return cities; } }
        public List<Customer> CustomerList { get { return customerList; } }


        public void InsertCity()
        {
            City city1 = new City(1, "Koronadal City");
            City city2 = new City(2, "Gensan City");
            City city3 = new City(3, "Davao City");
            cities.Add(city1);
            cities.Add(city2);
            cities.Add(city3);
        }

        public void InsertCustomer()
        {
            customerList.Add(new Customer(1, "Kim Ariel", GetCity("Koronadal City")));
            customerList.Add(new Customer(2, "Mitchell", GetCity("Koronadal City")));
            customerList.Add(new Customer(1, "Arthur", GetCity("Koronadal City")));
            customerList.Add(new Customer(1, "Glaiza", GetCity("Gensan City")));
            customerList.Add(new Customer(1, "Mia", GetCity("Davao City")));
        }

        public City GetCity(string name)
        {
            var cityQry = (from city in cities where city.CityName == name select city).Take(1);

            if (!cityQry.Any())
            {
                Console.WriteLine("City not found!");
                throw new Exception("City not found!");
            }

            City tempCity = new City();
            foreach(var city in cityQry)
            {
                tempCity = city;
            }

            return tempCity;
        }

        
    }
}

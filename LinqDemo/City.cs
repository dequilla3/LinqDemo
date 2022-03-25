using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class City
    {
        private int city_id;
        private string city_name;

        public City() { }
 
        public City(int id, string city_name)
        {
            this.city_id = id;
            this.city_name = city_name;
        }

        public int CityId { get { return this.city_id; } }
        public string CityName { get { return this.city_name; } }
    }
}

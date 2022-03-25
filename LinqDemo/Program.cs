// See https://aka.ms/new-console-template for more information
using LinqDemo;

Model model = new Model();
model.InsertCity();
model.InsertCustomer();

List<Customer> customers = model.CustomerList;
List<City> cities = model.Cities;

var customerQry = from cust in customers
                  join cit in cities on cust.City equals cit
                  where cit.CityName == "Koronadal City"
                  select cust;

foreach (var customer in customerQry)
{
    Console.WriteLine(customer.CustomerName);
}



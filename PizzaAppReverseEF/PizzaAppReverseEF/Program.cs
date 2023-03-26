
using PizzaAppReverseEF.Data;
using PizzaAppReverseEF.Models;

using PizzaDbContext context = new PizzaDbContext();

foreach (Customer c in context.Customers)
{
    Console.WriteLine($"Name: {c.FirstLast}");
}

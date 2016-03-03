using System;
using System.CodeDom;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Schema;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */

        static void Main()
        {
            //PrintOutOfStock();
            //InStockMoreThan3();
            //CustomerInRegion();
            //JustProductNames();
            //HugeMarkUp();
            //ToUpper();
            //EvenNumberUnits();
           //ProductPriceNameChange();
           //LessThan500();
           //First3Elements();
           //First3InWA();



            Console.ReadLine();
        }

        private static void PrintOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                where p.UnitsInStock == 0
                select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            var results = from p in products
                where p.UnitsInStock > 0 && p.UnitPrice > 3
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has {1} in stock with unit price {2}", product.ProductName,
                    product.UnitsInStock, product.UnitPrice);
            }
        }

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        private static void CustomerInRegion()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                where c.Region == "WA"
                select c;

            foreach (var customer in results)
            {
                Console.WriteLine(customer.CompanyName);

                foreach (var order in customer.Orders)
                {
                    Console.WriteLine(order.OrderID);
                }
            }

        }

        //4. Names of Products Only
        private static void JustProductNames()
        {
            var name = DataLoader.LoadProducts();

            var results = from n in name
                select n.ProductName;

            foreach (var product in results)
            {
                Console.WriteLine(product);
            }
        }

        //5.Create a new sequence of products and unit prices where price is + 25%
        private static void HugeMarkUp()
        {
            var name = DataLoader.LoadProducts();

            var results = from n in name
                select new {n.ProductName, markUp = n.UnitPrice *= 1.25m};

            foreach (var result in results)
            {
                Console.WriteLine(result.ProductName + result.markUp);
            }

        }

        //6. Product name in ToUpper
        private static void ToUpper()
        {
            var name = DataLoader.LoadProducts();

            var results = from n in name
                select n.ProductName.ToUpper();

            foreach (var product in results)
            {
                Console.WriteLine(product);
            }
        }

        //7. Even numbers of units in stock
        private static void EvenNumberUnits()
        {
            var units = DataLoader.LoadProducts();

            var results = from u in units
                where u.UnitsInStock%2 == 0
                select u.UnitsInStock;

            foreach (var product in results)
            {
                Console.WriteLine(product);
            }
        }


        //8. New Sequence of Products with ProductName, Category and UnitPrice = Price
        private static void ProductPriceNameChange()
        {
            var product = DataLoader.LoadProducts();

            var results = from p in product
                select new {p.ProductName, p.Category, Price = p.UnitPrice};

            foreach (var result in results)
            {
                Console.WriteLine($"{result.ProductName} {result.Category} {result.Price}");
            }

        }

        //9. NEED TO BE FIGURED OUT

        //10.Select CustomerID, OrderID, Total where order is < $500
        private static void LessThan500()
        {
            var total = DataLoader.LoadCustomers();

            var results = from t in total
                from o in t.Orders
                where o.Total < 500m
                select new { o.Total, t.CustomerID};

            foreach (var result in results)
            {
                Console.WriteLine(result.CustomerID + result.Total);
            }
        }

        //11. Write a query take only first 3 elements
        private static void First3Elements()
        {
            var first = DataLoader.NumbersA;

            var results = first.Take(3);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //12. Get only the first 3 orders from customers in WA
        private static void First3InWA()
        {
            var firstThree = DataLoader.LoadCustomers();

            var results = (from f in firstThree
                          from o in f.Orders
                where f.Region == "WA"
                select new {f.CompanyName, o = o.OrderID}).Take(3);

            foreach (var result in results)
            {
                Console.WriteLine(result.CompanyName);
                Console.WriteLine("\t" + result.o);
            }
        }
    }
}
using System;
using System.CodeDom;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
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
            //NumBLessThanNumC();
            //LessThan500();
            //First3Elements();
            //First3InWA();
            //Skip3InA();
            //EverythingButFirstTwoInWa();
            //NumberCUntilGreaterOrEqualTo6();
            //NumberLessThanPosition();
            //NumbersCDivisbleBy3();
            //AlphabeticallyOrderedProductName();
            //UnitsInStock();
            //ProductSortByCategoryThenPrice();
            //ReverseNumbersC();
            //RemainderDividedBy5();
            //DisplayProductsByCategory();
            //OrdersByYearThanMonth();
            //ListUniqueProducts();
            //UniqueNumbersAAndB();
            //SharedValuesInAAndB();
            //NumbersANotInNumbersB();
            //ProductWithID12();
            //Does789Exist();
            //AtLeastOneProductOutOfStock();
            //DoesNumbersBContainOnlyLessThan9();
            //NumbersACountOdds();
            //CustomerIDAndCountOfOrders();
            //ListOfCategoriesAndCountOfProducts();
            //TotalUnitsInStockForEachCategory();
            //AllProductsInCategoryInStock();
            //LowPriceProductEachCategory();
            //HighestPriceProductEachCategory();
           //AveragePriceProductEachCategory();


            Console.ReadLine();
        }

        //1.

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
                          select new { n.ProductName, markUp = n.UnitPrice *= 1.25m };

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
                          where u.UnitsInStock % 2 == 0
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
                          select new { p.ProductName, p.Category, Price = p.UnitPrice };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.ProductName} {result.Category} {result.Price}");
            }

        }

        //9. Return all pairs of numbers from both arrays that numberB < numberC
        private static void NumBLessThanNumC()
        {
            int[] numbersB = DataLoader.NumbersB;
            int[] numbersC = DataLoader.NumbersC;

            var results = from b in numbersB
                          from c in numbersC
                          where b < c
                          select new { b, c };

            foreach (var result in results)
            {
                Console.WriteLine($"b = {result.b}, c = {result.c}");
            }
        }


        //10.Select CustomerID, OrderID, Total where order is < $500
        private static void LessThan500()
        {
            var total = DataLoader.LoadCustomers();

            var results = from t in total
                          from o in t.Orders
                          where o.Total < 500m
                          select new { o.Total, t.CustomerID };

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
                           select new { f.CompanyName, o = o.OrderID }).Take(3);

            foreach (var result in results)
            {
                Console.WriteLine(result.CompanyName);
                Console.WriteLine("\t" + result.o);
            }
        }

        //13. Skip the first 3 elements of NumbersA
        private static void Skip3InA()
        {
            var numbersA = DataLoader.NumbersA;

            var results = numbersA.Skip(3);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }

        //14. Get all except the first two orders from customers in Washington
        private static void EverythingButFirstTwoInWa()
        {
            var customer = DataLoader.LoadCustomers();

            var results = (from c in customer
                           from o in c.Orders
                           where c.Region == "WA"
                           select new { c.CompanyName, o.OrderID }).Skip(2);

            foreach (var result in results)
            {
                //Console.WriteLine();
                Console.WriteLine($"{result.CompanyName} {result.OrderID}");
            }
        }

        //15 Get all elements in NumberC from start until element >= 6
        private static void NumberCUntilGreaterOrEqualTo6()
        {
            var numbersC = DataLoader.NumbersC;

            var results = (from n in numbersC
                           select n).TakeWhile(x => x < 6);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //16.Return NumbersC until number hit < position in array
        private static void NumberLessThanPosition()
        {
            var numbersC = DataLoader.NumbersC;

            var results = numbersC.TakeWhile((number, index) => number >= index);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }

        //17.Return NumbersC until element is / 3
        private static void NumbersCDivisbleBy3()
        {
            var numbersC = DataLoader.NumbersC;

            var results = from n in numbersC
                          where n % 3 == 0
                          select n;

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //18. Order Products Alpabetically by name
        private static void AlphabeticallyOrderedProductName()
        {
            var product = DataLoader.LoadProducts();

            var results = from p in product
                          orderby p.ProductName
                          select p.ProductName;

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }

        //19. Order products by UnitsInStock
        private static void UnitsInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          orderby p.UnitsInStock descending
                          select p;

            foreach (var result in results)
            {
                Console.WriteLine(result.ProductName);
                Console.WriteLine(result.UnitsInStock);
            }
        }

        //20. Sort list of products by category then unit price, descending
        private static void ProductSortByCategoryThenPrice()
        {
            var products = DataLoader.LoadProducts();

            var results = products.OrderBy(p => p.Category)
                .ThenByDescending(p => p.UnitPrice);

            foreach (var result in results)
            {
                Console.WriteLine(result.ProductName);
                Console.WriteLine(result.UnitPrice);
            }
        }

        //21. Reverse NumbersC
        private static void ReverseNumbersC()
        {
            var numbers = DataLoader.NumbersC;

            var results = (from n in numbers
                           select n).Reverse();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }

        //22. Display NumbersC grouped by their remainder when divided by 5
        private static void RemainderDividedBy5()
        {
            var numbersC = DataLoader.NumbersC;

            var results = from n in numbersC
                          group n by n % 5;

            foreach (var result in results)
            {
                Console.WriteLine("{0}", result.Key);
                foreach (var i in result)
                {
                    Console.WriteLine("\t{0}", i);
                }
            }
        }

        //23. Display products by Category
        private static void DisplayProductsByCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group products by p.Category;

            foreach (var result in results)
            {
                Console.WriteLine("{0}", result.Key);

                foreach (var i in result)
                {
                    foreach (var product in i)
                    {
                        Console.WriteLine("{0}", product.ProductName);
                    }

                }
            }
        }

        //24.Group orders by year than month
        private static void OrdersByYearThanMonth()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                          select new
                          {
                              ComapnyName = c.CompanyName,
                              yearGroups = from o in c.Orders
                                           group o by o.OrderDate.Year
                                  into yearGroup
                                           select new
                                           {
                                               Year = yearGroup.Key,
                                               monthGroups = from order in yearGroup
                                                             group order by order.OrderDate.Month
                                                   into monthGroup
                                                             select new
                                                             {
                                                                 Month = monthGroup.Key,
                                                                 Orders = monthGroup
                                                             }
                                           }
                          };

            foreach (var result in results)
            {
                Console.WriteLine(result.ComapnyName);

                foreach (var yearGroup in result.yearGroups)
                {
                    Console.WriteLine("\t{0}", yearGroup.Year);

                    foreach (var monthGroup in yearGroup.monthGroups)
                    {
                        Console.WriteLine("\t\t{0}",
                            CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthGroup.Month));

                        foreach (var order in monthGroup.Orders)
                        {
                            Console.WriteLine($"\t\t\t{order.OrderDate}, {order.OrderID}");
                        }
                    }
                }
            }
        }

        //25. List of unique product categories
        private static void ListUniqueProducts()
        {
            var products = DataLoader.LoadProducts();

            var results = (from p in products
                           select p.Category).Distinct();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //26. List of Unique NumbersA and NumbersB
        private static void UniqueNumbersAAndB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Union(numbersB);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //27. Get a List of shared values in NumbersA and Numbers
        private static void SharedValuesInAAndB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Intersect(numbersB);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //28. Get a list of values in NumbersA that are not also in NumbersB
        private static void NumbersANotInNumbersB()
        {
            var numbersA = DataLoader.NumbersA;
            var numbersB = DataLoader.NumbersB;

            var results = numbersA.Except(numbersB);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }

        //29. Select only the first product with ProductID = 12 (not a list).
        private static void ProductWithID12()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          where p.ProductID == 12
                          select new { p.ProductName, p.ProductID };

            foreach (var result in results)
            {
                Console.WriteLine(result.ProductName);
            }
        }

        //30. Does Product 789 exist?
        private static void Does789Exist()
        {
            var products = DataLoader.LoadProducts();

            bool has = products.Any(p => p.ProductID == 789);

            Console.WriteLine(has);
        }

        //31. Get a list of categories that have at least one product out of stock
        private static void AtLeastOneProductOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          select new { p.Category, p.UnitsInStock };

            foreach (var result in results)
            {
                if (result.UnitsInStock == 0)
                {
                    Console.WriteLine(result.Category);
                }
            }


        }

        //32. Determine if NumbersB contains only numbers less than 9.
        private static void DoesNumbersBContainOnlyLessThan9()
        {
            var numbersB = DataLoader.NumbersB;

            var results = numbersB.Any(n => n >= 9);

            Console.WriteLine(results);
        }

        //33. Get a grouped list of product by category for all products in stock
        private static void AllProductsInCategoryInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category
                into pCats
                          where pCats.All(x => x.UnitsInStock > 0)
                          select new { pCats.Key, coll = pCats };

            foreach (var result in results)
            {
                Console.WriteLine(result.Key);
                foreach (var product in result.coll)
                {
                    Console.WriteLine($"\t{product.UnitsInStock} - {product.ProductName}");
                }
            }
        }

        //34. Count the number of odds in NumbersA
        private static void NumbersACountOdds()
        {
            var numbersA = DataLoader.NumbersA;

            var results = from n in numbersA
                          select n;

            int count = 0;
            foreach (var result in results)
            {
                if (result % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        //35. Display a list of CustomerIDs and only the count of their orders
        private static void CustomerIDAndCountOfOrders()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                select new {c.CustomerID, orderCount = c.Orders.Count()};

            foreach (var result in results)
            {
                Console.WriteLine(result.CustomerID);
                Console.WriteLine(result.orderCount);
            }
        }

        //36. Display a list of categories and the count of their products
        private static void ListOfCategoriesAndCountOfProducts()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                select new {p.Category, productCount = p.ProductName.Count()};

            foreach (var result in results)
            {
                Console.WriteLine(result.Category);
                Console.WriteLine(result.productCount);
            }
        }

        //37. Display the total units in stock for each category
        private static void TotalUnitsInStockForEachCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                select new {p.Category, totalUnitsInStock = p.UnitsInStock};

            foreach (var result in results)
            {
                Console.WriteLine(result.Category);
                Console.WriteLine(result.totalUnitsInStock);
            }
        }

        //38. Display lowest price product in each category
        private static void LowPriceProductEachCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category
                into pCats
                          select new
                          {
                              pCats.Key,
                              minprod = pCats.Min(prod => prod.UnitPrice),
                              prodName = pCats.First(prod => prod.UnitPrice == pCats.Min(p => p.UnitPrice))
                          };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} - {result.minprod:C} {result.prodName.ProductName}");
            }
        }

        //39. Display highest priced product in each category
        private static void HighestPriceProductEachCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category
                into pCats
                          select new
                          {
                              pCats.Key,
                              maxprod = pCats.Max(prod => prod.UnitPrice),
                              prodName = pCats.First(prod => prod.UnitPrice == pCats.Max(p => p.UnitPrice))
                          };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} - {result.maxprod:C} {result.prodName.ProductName}");
            }
        }

        //40. Show the average price of product for each category
        private static void AveragePriceProductEachCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category
                into pCats
                select new
                {
                    pCats.Key,
                    avgProd = pCats.Average(prod => prod.UnitPrice)

                };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key}, {result.avgProd:c}");
            }
        }
    }
}
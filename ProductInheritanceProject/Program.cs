using System;
using System.Collections.Generic;

namespace ProductInheritanceProject {
    class Program {
        static void Main(string[] args) {

            List<Product> salesOrder = new List<Product>();

            Product widget1 = new Widget("W1", 50, "Small", "Red");
            Product widget2 = new Widget("W2", 100, "Medium", "White");
            Product widget3 = new Widget("W3", 200, "Large", "Blue");
            Product service = new Service("SVC", 500, "Premium", 5);
            Product software = new Software("SFT", 150, true);

            salesOrder.Add(widget1);
            salesOrder.Add(widget2);
            salesOrder.Add(widget3);
            salesOrder.Add(service);
            salesOrder.Add(software);

            decimal salesOrderTotal = 0;
            foreach(Product p in salesOrder) {
                salesOrderTotal += p.Price;
                if(p is Widget) {
                    Widget w = p as Widget;
                    Console.WriteLine($"{w.Code} {w.Price:c} {w.Size} {w.Color}");
                    continue; // skips if statement below and continues line of code if if statement above is true and completed
                }
                if(p is Service) {
                    Service s = p as Service;
                    Console.WriteLine($"{s.Code} {s.Price:c} {s.ServiceLevel} {s.NumberOfYears}");
                    continue;
                }
                if(p is Software) {
                    Software s = p as Software;
                    Console.WriteLine($"{s.Code} {s.Price:c} {(s.Book ? "With Book" : "Without Book")}");
                    continue;
                }
            }
            Console.WriteLine($"Total sales order is {salesOrderTotal:c}");



            //Service s1 = new Service("BASIC", 100, "Basic", 3);
            //Console.WriteLine(s1.ToPrint());

            //// calls from Widget class that was inherited and displays values
            //Widget w = new Widget("Widget", 543.21m, "Large", "MAX Red");
            //Console.WriteLine(w.ToPrint());

            //Widget w1 = new Widget(); // shows default values from widget class with default constructor
            //Console.WriteLine(w1.ToPrint());

            //// calls from Product class
            //Product p = new Product("Echo", 123.45m); // an instance is a call to one of our constructors, parameters have to match up
            //string message = p.ToPrint(); // calls on the ToPrint() method from Product
            //Console.WriteLine(message); 
        }
    }
}

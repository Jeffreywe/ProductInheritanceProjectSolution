using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritanceProject {
    public class Product {
        private bool Flag { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; } //prop double tab and then enter to confirm

        public virtual string ToPrint() { // sets method for the return value
            return $"{GetType().ToString()} | {Code} | {Price:c}";
        }
        public Product(string Code, decimal price) { // sets default values otherwise hidden constructor sets them
            Flag = true;
            this.Code = Code; // this. identifies only a property if theyre named the same as a variable / or a method
            Price = price;
        }
        public Product() { // sets default values back to hidden default values

        }
    }
}

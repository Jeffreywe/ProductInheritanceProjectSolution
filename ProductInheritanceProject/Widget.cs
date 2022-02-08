using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritanceProject {
    public class Widget : Product {
        public string Size { get; set; } = "Medium"; // assigns a default value to property
        public string Color { get; set; } = "Black";

        public override string ToPrint() {
            return $"{base.ToPrint()} | {Size} | {Color}"; // base calls on the Product class's ToPrint method, Product is widgets parent, and can only have 1 parent
        }
        
        public Widget(string code, decimal price, string size, string color) // creates constructor, to not duplicate code, we
            : base(code, price){ // , we call on the Product constructor in the product class and get the values

            Size = size;
            Color = color;

        }
        public Widget() : base() {

        }
    }
}

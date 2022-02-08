using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritanceProject {
    public class Software : Product {

        public bool Book { get; set; } = true;

        public override string ToPrint() {
            return $"{base.ToPrint()} | {(Book ? "Yes" : "No")}";
        }

        public Software(string code, decimal price, bool book)
            : base(code, price) {
            Book = book;
        }
        public Software() {

        }
    }
}

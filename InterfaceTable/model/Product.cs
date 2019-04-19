using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTable.enums
{
    class Product
    {
        private String name;
        private String code;
        private int cost;

        public Product(String name, String code, int cost)
        {
            this.name = name;
            this.code = code;
            this.cost = cost;
        }

        public String getName() {
            return this.name;
        }

        public String getCode()
        {
            return this.code;
        }

        public int getCost()
        {
            return this.cost;
        }
    }
}

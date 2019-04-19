using InterfaceTable.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTable
{
    class Record
    {
        List<Product> products = new List<Product>
        {
            new Product("Торт", "12", 100),
            new Product("Пирожное", "13", 200),
            new Product("Печенье", "14", 300),
        };
        private String codeProduct;
        private int costProduct;


        private int number;
        private String recname;
        private String nameSystem;
        private int codeOkei, massa, colEnter, sumEnter, colExp, sumExp, colDop, sumDop;


        public Record(int number, String recname, String code, String nameSystem, int codeOkei, int massa, int cost, int colEnter, int sumEnter, int colExp, int sumExp, int colDop, int sumDop)
        {
            this.number = number;
            this.recname = recname;
            this.codeProduct = code;
            this.nameSystem = nameSystem;
            this.codeOkei = codeOkei;
            this.massa = massa;
            this.costProduct = cost;
            this.colEnter = colEnter;
            this.sumEnter = sumEnter;
            this.colExp = colExp;
            this.sumExp = sumExp;
            this.colDop = colDop;
            this.sumDop = sumDop;
        }

        public void setRec(String currentName)
        {
            foreach (Product p in products) {
                if (currentName == p.getName()) {
                    codeProduct = p.getCode();
                    costProduct = p.getCost();
                }
            }
        }

        public void setEdSys(String currentEd)
        {
            if (currentEd == "Г")
            {
                massa = 1000;
                codeOkei = 121;
            }
            else
            {
                massa = 1;
                codeOkei = 222;
            }
        }

        public Record(int number)
        {
            this.number = number;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public String Recname
        {
            get { return recname; }
            set { recname = value; }
        }

        public String Code
        {
            get { return codeProduct; }
            set { codeProduct = value; }
        }

        public String NameSystem
        {
            get { return nameSystem; }
            set { nameSystem = value; }
        }

        public int CodeOkei
        {
            get { return codeOkei; }
            set { codeOkei = value; }
        }

        public int Massa
        {
            get { return massa; }
            set { massa = value; }
        }

        public int Cost
        {
            get { return costProduct; }
            set { costProduct = value; }
        }

        public int ColEnter
        {
            get { return colEnter; }
            set { colEnter = value; }
        }

        public int SumEnter
        {
            get { return sumEnter; }
            set { sumEnter = value; }
        }

        public int ColExp
        {
            get { return colExp; }
            set { colExp = value; }
        }

        public int SumExp
        {
            get { return sumExp; }
            set { sumExp = value; }
        }

        public int ColDop
        {
            get { return colDop; }
            set { colDop = value; }
        }

        public int SumDop
        {
            get { return sumDop; }
            set { sumDop = value; }
        }

        public void calc()
        {
            sumEnterCalc();
            sumExpCalc();
            sumDopCalc();
        }

        public void sumEnterCalc()
        {
            sumEnter = costProduct * colEnter;
        }

        public void sumExpCalc()
        {
            sumExp = costProduct * colExp;
        }

        public void sumDopCalc()
        {
            sumDop = costProduct * colDop;
        }
    }
}

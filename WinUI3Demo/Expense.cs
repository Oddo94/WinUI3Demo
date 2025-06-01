using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3Demo {
    public class Expense {
        public string name { get; set; }
        public String type { get; set; }
        //public String user { get; set; }
        public double value { get; set; }
        public string date { get; set; }

        public Expense(string name, string type, double value, string date) {
            this.name = name;
            this.type = type;
            this.value = value;
            this.date = date;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3DemoCore
{
    public class ExpenseType{
        private String name { get; set; }
        private double percentage { get; set; }

        public ExpenseType(string name, double percentage) {
            this.name = name;
            this.percentage = percentage;
        }
    }
}

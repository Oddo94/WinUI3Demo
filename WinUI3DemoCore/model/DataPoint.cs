using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3DemoCore.model {
    public class DataPoint {
        private string name { get; set; }
        private double value { get; set; }

        public DataPoint(String name, double value) {
            this.name = name;
            this.value = value;
        }

        public String Name {
            get { return name; }

            set { this.name = value; }
        }

        public double Value {
            get { return value; }

            set { this.value = value; }
        }
    }
}

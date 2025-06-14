using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3Demo {
    public class Expense {
        [Display (Name = "Name")]
        public string? name { get; set; }
        [Display (Name = "Type")]
        public String? type { get; set; }

        [Display (Name = "Value")]
        public double? value { get; set; }
        [Display (Name = "Created date")]
        public string? date { get; set; }

        public Expense(string? name, string? type, double? value, string? date) {
            this.name = name;
            this.type = type;
            this.value = value;
            this.date = date;
        }
    }
}

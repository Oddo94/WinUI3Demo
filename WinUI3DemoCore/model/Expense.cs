using System.ComponentModel.DataAnnotations;

namespace WinUI3DemoCore {
    public class Expense {
        [Display(Name="Name")]
        public string name { get; set; }
        [Display(Name = "Type")]
        public String type { get; set; }
        [Display(Name = "User")]
        public String user { get; set; }
        [Display(Name = "Amount")]
        public double amount { get; set; }
        [Display(Name = "Created date")]
        public string date { get; set; }
    }
}

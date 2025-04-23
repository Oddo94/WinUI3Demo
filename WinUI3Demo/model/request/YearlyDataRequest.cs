using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3Demo.model.request {
    public class YearlyDataRequest {
        private int userId { get; set; }
        private int year { get; set; }

        public YearlyDataRequest(int userID, int year) {
            this.userId = userId;
            this.year = year;
        }

        public int UserID {
            get { return this.userId; }
            set {  this.userId = value; }
        }

        public int Year {
            get { return this.year; }
            set { this.year = value; }
        }
    }
}

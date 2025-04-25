using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUI3DemoCore.utils;

namespace WinUI3DemoCore.model {
    public class LoginResponse {
        private ResultCode resultCode;
        private string responseMessage;

        public LoginResponse(ResultCode resultCode, string responseMessage) {
            this.resultCode = resultCode;
            this.responseMessage = responseMessage;
        }

        public ResultCode ResultCode {
            get { return this.resultCode; }
            set { this.resultCode = value; }
        }

        public string ResponseMessage {
            get { return this.responseMessage; }
            set { this.responseMessage = value; }
        }
    }
}

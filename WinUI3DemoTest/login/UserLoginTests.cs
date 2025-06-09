using WinUI3DemoCore.model;
using WinUI3DemoCore.utils;
using WinUI3DemoCore.view_model;

namespace WinUI3DemoTest.login {
    [TestClass]
    public sealed class UserLoginTests {
        private LoginViewModel loginViewModel;
        private String? validUserName;
        private String? validPassword;

        private String? invalidUserName;
        private String? invalidPassword;

        public UserLoginTests() {
            this.loginViewModel = new LoginViewModel();

            this.validUserName = "Admin";
            this.validPassword = "MySecretPassword12&@)";

            this.invalidUserName = "Test user";
            this.invalidPassword = "TcF4#@(uIght%";
        }

        [TestMethod]
        public void TestUserSuccessfulLogin() {
            loginViewModel.UserName = validUserName;
            loginViewModel.Password = validPassword;
            
            loginViewModel.CheckCredentials();

            LoginResponse loginResponse = loginViewModel.LoginResponse;

            ResultCode expectedResultCode = ResultCode.OK;
            String expectedResponseMessage = null;

            ResultCode actualResultCode = loginResponse.ResultCode;
            String actualResponseMessage = loginResponse.ResponseMessage;

            Assert.AreEqual(expectedResultCode, actualResultCode);
            Assert.AreEqual(expectedResponseMessage, actualResponseMessage);

            Console.WriteLine("*********************TestUserSuccessfulLogin*********************");
            Console.WriteLine("Expected result code: {0}; Actual result code: {1}", expectedResultCode, actualResultCode);
            Console.WriteLine("Expected response message: {0}; Actual response message: {1}", expectedResponseMessage, actualResponseMessage);

        }

        [TestMethod]
        public void TestUserFailedLogin() {
            loginViewModel.UserName = invalidUserName;
            loginViewModel.Password = invalidPassword;

            loginViewModel.CheckCredentials();

            LoginResponse loginResponse = loginViewModel.LoginResponse;

            ResultCode expectedResultCode = ResultCode.ERROR;
            String expectedResponseMessage = "Invalid username and/or password!";

            ResultCode actualResultCode = loginResponse.ResultCode;
            String actualResponseMessage = loginResponse.ResponseMessage;

            Assert.AreEqual(expectedResultCode, actualResultCode);
            Assert.AreEqual(expectedResponseMessage, actualResponseMessage);

            Console.WriteLine("*********************TestUserFailedLogin*********************");
            Console.WriteLine("Expected result code: {0}; Actual result code: {1}", expectedResultCode, actualResultCode);
            Console.WriteLine("Expected response message: {0}; Actual response message: {1}", expectedResponseMessage, actualResponseMessage);

        }
    }
}

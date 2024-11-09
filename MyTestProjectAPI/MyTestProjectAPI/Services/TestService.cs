using MyTestProjectAPI.Interfaces;

namespace MyTestProjectAPI.Services
{
    public class TestService : ITestService
    {
        public string GetMessage()
        {
            return "I am new service";
        }
    }
}

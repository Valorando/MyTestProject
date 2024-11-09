using MyTestProjectAPI.Interfaces;
namespace MyTestProjectAPI.Repository
{
    public class HelloRepository : IHelloRepository
    {
        public string Hello()
        {
            return "Hello repository";
        }
    }
}

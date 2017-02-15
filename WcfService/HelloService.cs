using System.ServiceModel;

namespace WcfService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class HelloService : IHelloService
    {
        public string SayHello(string name) => $"Hello {name}";
    }
}

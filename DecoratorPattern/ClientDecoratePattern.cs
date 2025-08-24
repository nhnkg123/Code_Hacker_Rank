namespace Test.DecoratePattern
{
    public class ClientDecoratePattern
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
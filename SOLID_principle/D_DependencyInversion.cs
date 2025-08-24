namespace Test.SOLID_principle
{
    public class D_DependencyInversion
    {
        // Phụ thuộc vào abstraction, không phụ thuộc vào cụ thể.
        public interface IMessageService
        {
            void Send(string message);
        }

        public class EmailService : IMessageService
        {
            public void Send(string message) =>
                Console.WriteLine("Email sent: " + message);
        }

        public class Notification
        {
            private readonly IMessageService _service;

            public Notification(IMessageService service)
            {
                _service = service;
            }

            public void Alert(string message)
            {
                _service.Send(message);
            }
        }

        // Notification không biết gì về EmailService — dễ thay đổi và test.
    }
}
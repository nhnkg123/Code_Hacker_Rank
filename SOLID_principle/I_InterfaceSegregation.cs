namespace Test.SOLID_principle
{
    public class I_InterfaceSegregation
    {
        // Không nên bắt class phải implement các method mà nó không cần.
        public interface IPrinter
        {
            void Print();
        }

        public interface IScanner
        {
            void Scan();
        }

        public class MultiFunctionPrinter : IPrinter, IScanner
        {
            public void Print() { }
            public void Scan() { }
        }

        public class SimplePrinter : IPrinter
        {
            public void Print() { }
        }

        // X Sai
        // public interface IMachine
        // {
        //     void Print();
        //     void Scan();
        // }

        // public class OldPrinter : IMachine
        // {
        //     public void Print() { }
        //     public void Scan() => throw new NotImplementedException();
        // }
    }
}
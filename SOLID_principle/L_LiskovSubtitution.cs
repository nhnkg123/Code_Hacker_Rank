namespace Test.SOLID_principle
{
    public class L_LiskovSubtitution
    {
        // Class con có thể thay thế class cha mà không làm hỏng chương trình
        public class Bird
        {
            public virtual void Fly() => Console.WriteLine("Flying");
        }

        public class Sparrow : Bird { }

        public class Eagle : Bird { }

        // X Sai
        // public class Bird
        // {
        //     public virtual void Fly() { }
        // }

        // public class Ostrich : Bird
        // {
        //     public override void Fly() => throw new Exception("Ostrich can't fly!");
        // }
    }
}
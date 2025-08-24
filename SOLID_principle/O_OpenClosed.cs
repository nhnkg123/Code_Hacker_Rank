namespace Test.SOLID_principle
{
    public class O_OpenClosed
    {
        // Mở rộng được nhưng không thay đổi mã gốc
        // Hệ thống nên cho phép mở rộng chức năng mà không cần sửa đổi mã nguồn hiện tại.

        public abstract class Shape
        {
            public abstract double GetArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double GetArea() => Math.PI * Radius * Radius;
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double GetArea() => Width * Height;
        }

        public class AreaCalculator
        {
            public double TotalArea(List<Shape> shapes) =>
                shapes.Sum(shape => shape.GetArea());
        }

        // Bạn có thể thêm Triangle mà không sửa AreaCalculator.
    }
}
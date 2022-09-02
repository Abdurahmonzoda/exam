namespace Domain.Models
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
        public Rectangle(double width, double height, string name) : base(name)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectange has been Drawed");
        }
    }
}

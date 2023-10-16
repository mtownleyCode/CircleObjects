namespace CircleObjects.Models
{
    public class Circle
    {
        private double radius { get; set; }

        public Circle(double inputtedRadius)
        {
            radius = inputtedRadius;
        }

        public double CalculateDiameter() => radius * 2;

        public double CalculateCircumference() => radius * Math.PI * 2;

        public double CalculateArea() => radius * radius * 3.14;

        public void Grow() => radius = radius * 2;

        public double GetRadius() => radius;

    }
        
}

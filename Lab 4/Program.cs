namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new objects from the Circle class
            // We give them each a radius value, 5 and 6
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            // Get the area values of the 2 circles,
            // calculated using our GetArea method in the Circle class
            double area1 = circle1.GetArea();
            double area2 = circle2.GetArea();

            // Get the circumference values of the 2 circles,
            // calculated using our GetCircumference method in the Circle class
            double circumference1 = circle1.GetCircumference();
            double circumference2 = circle2.GetCircumference();

            // Get the volume values of the 2 circles as if they were spheres,
            // calculated using our GetVolume method in the Circle class
            double volume1 = circle1.GetVolume();
            double volume2 = circle2.GetVolume();

            // We follow the same process with our triangle
            // We create a new Triangle object and give it 2 values of base and height
            // We then calculate the area and circumference,
            // using our 2 methods in the Triangle class
            Triangle triangle = new Triangle(10, 14);
            double area3 = triangle.GetArea();
            double circumference3 = triangle.GetCircumfence();

            // Print out the area, circumeference and volume of the 2 circles/spheres
            // And also the area and circumference of the triangle
            // Added :F2 to display exactly 2 decimals
            Console.WriteLine($"Arean på första cirkeln är: {area1:F2}," +
                $" omkretsen är: {circumference1:F2} och volymen är: {volume1:F2}");
            Console.WriteLine($"Arean på andra cirkeln är: {area2:F2}," +
                $" omkretsen är: {circumference2:F2} och volymen är: {volume2:F2}");
            Console.WriteLine($"Arean på triangeln är {area3:F2} " +
                $"och omkretsen är: {circumference3:F2}");
        }
    }
}

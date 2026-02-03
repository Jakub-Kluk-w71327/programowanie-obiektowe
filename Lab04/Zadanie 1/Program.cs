using Lab03_ćwiczenia;

List<Shape> shapes = new List<Shape>();

shapes.Add(new Rectangle());
shapes.Add(new Triangle());
shapes.Add(new Circle());

foreach (Shape shape in shapes)
{
    shape.Draw();
}

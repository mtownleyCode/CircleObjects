using CircleObjects.Helpers;
using CircleObjects.Models;

double radius;

bool continueGrow = true;

UserInput userInput = new UserInput();

Console.WriteLine("Welcome to the Circle Calculations App!");
Console.WriteLine();

radius = userInput.GetRadius();

Validator validator = new Validator();
Circle circle = new Circle(radius);

Console.WriteLine();

Console.WriteLine($"Your circle's diameter is { circle.CalculateDiameter() }");
Console.WriteLine($"Your circle's circumference is { circle.CalculateCircumference() }");
Console.WriteLine($"Your circle's area is { circle.CalculateArea() }");

while (continueGrow)
{
    Console.WriteLine();
    continueGrow = userInput.GrowCircleQuestion(circle);

}
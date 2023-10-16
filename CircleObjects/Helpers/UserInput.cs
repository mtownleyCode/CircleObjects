using CircleObjects.Models;

namespace CircleObjects.Helpers
{
    public class UserInput
    {
        public double GetRadius()
        {
            double validInput = 0;

            Validator validator = new Validator();

            validInput = validator.ValidateRadius();

            return validInput;

        }
        public bool GrowCircleQuestion(Circle circle)
        {
            string validAnswer = "";

            bool redoLoop = true;
            bool continueRadius = false;

            while (redoLoop)
            {
                Console.WriteLine("Do you want to grow the circle? yes/no");

                validAnswer = Console.ReadLine().ToLower();

                if (validAnswer != "yes" &&
                    validAnswer != "no")
                {
                    Console.WriteLine("Enter yes or no only.");
                    Console.WriteLine();
                    redoLoop = true;
                }

                else
                {
                    if (validAnswer == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose to grow the circle.");
                        Console.WriteLine();
                        
                        circle.Grow();

                        Console.WriteLine($"Your circle's diameter is now { circle.CalculateDiameter() }");
                        Console.WriteLine($"Your circle's circumference is now { circle.CalculateCircumference() }");
                        Console.WriteLine($"Your circle's area is now { circle.CalculateArea() }");

                        continueRadius = true;

                    }
                    else
                    {
                        Console.WriteLine();

                        Console.WriteLine($"Your radius circle's current radius is { circle.GetRadius() }. Have a nice day. Goodbye.");
                        continueRadius = false;
                    }

                    redoLoop = false;
                }

            }

            return continueRadius;

        }

    }

}

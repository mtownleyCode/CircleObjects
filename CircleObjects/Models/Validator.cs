namespace CircleObjects.Models
{
    internal class Validator
    {

        public double ValidateRadius()
        {
            double validNumber = 0;
            
            bool redoLoop = true;


            while (redoLoop)
            {
                Console.WriteLine("Enter a number greater than 0?");

                if (!double.TryParse(Console.ReadLine(), out validNumber) ||
                    validNumber <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter a valid number between greater than 0.");
                    Console.WriteLine();

                    redoLoop = true;
                }

                else
                {
                    redoLoop = false;

                }

            }

            return validNumber;

        }

    }
}

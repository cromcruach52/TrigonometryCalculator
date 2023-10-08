using System;
using TrigonometryLibrary; 

namespace TrigonometryCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("┌──────────────────────────────────────────────────────────┐");
                Console.WriteLine("│                 Trigonometric Calculator                 │");
                Console.WriteLine("├──────────────────────────────────────────────────────────┤");
                Console.WriteLine("│ Options:                                                 │");
                Console.WriteLine("│ 1. Calculate Opposite Side Using Sine                    │");
                Console.WriteLine("│ 2. Calculate Opposite Side Using Tan                     │");
                Console.WriteLine("│ 3. Calculate Hypotenuse Using Sine                       │");
                Console.WriteLine("│ 4. Calculate Hypotenuse Using Cosine                     │");
                Console.WriteLine("│ 5. Calculate Adjacent Side Using Cosine                  │");
                Console.WriteLine("│ 6. Calculate Adjacent Side Using Tan                     │");
                Console.WriteLine("│ 7. Calculate Angle Using Sine                            │");
                Console.WriteLine("│ 8. Calculate Angle Using Cosine                          │");
                Console.WriteLine("│ 9. Calculate Angle Using Tan                             │");
                Console.WriteLine("│ 10. Calculate Radiance Based on Opposite and Hypotenuse  │");
                Console.WriteLine("│ 11. Calculate Radiance Based on Angle                    │");
                Console.WriteLine("│ 0. Exit                                                  │");
                Console.WriteLine("└──────────────────────────────────────────────────────────┘");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                if (choice == 0)
                {
                    break; 
                }

                double result = 0;
                var trigonometryModel = new TrigonometryModel();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter angle in degrees: ");
                        trigonometryModel.Angle = double.Parse(Console.ReadLine());
                        Console.Write("Enter hypotenuse length: ");
                        trigonometryModel.Hypotenuse = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateOppositeSideUsingSine(trigonometryModel);
                        break;
                    case 2:
                        Console.Write("Enter angle in degrees: ");
                        trigonometryModel.Angle = double.Parse(Console.ReadLine());
                        Console.Write("Enter adjacent side length: ");
                        trigonometryModel.Adjacent = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateOppositeSideUsingTan(trigonometryModel);
                        break;
                    case 3:
                        Console.Write("Enter angle in degrees: ");
                        trigonometryModel.Angle = double.Parse(Console.ReadLine());
                        Console.Write("Enter hypotenuse length: ");
                        trigonometryModel.Hypotenuse = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateHypotenuseUsingSine(trigonometryModel);
                        break;
                    case 4:
                        Console.Write("Enter angle in degrees: ");
                        trigonometryModel.Angle = double.Parse(Console.ReadLine());
                        Console.Write("Enter hypotenuse length: ");
                        trigonometryModel.Hypotenuse = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateHypotenuseUsingCosine(trigonometryModel);
                        break;
                    case 5:
                        Console.Write("Enter angle in degrees: ");
                        trigonometryModel.Angle = double.Parse(Console.ReadLine());
                        Console.Write("Enter adjacent side length: ");
                        trigonometryModel.Adjacent = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateAdjacentSideUsingCosine(trigonometryModel);
                        break;
                    case 6:
                        Console.Write("Enter angle in degrees: ");
                        trigonometryModel.Angle = double.Parse(Console.ReadLine());
                        Console.Write("Enter adjacent side length: ");
                        trigonometryModel.Adjacent = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateAdjacentSideUsingTan(trigonometryModel);
                        break;
                    case 7:
                        Console.Write("Enter opposite side length: ");
                        trigonometryModel.Opposite = double.Parse(Console.ReadLine());
                        Console.Write("Enter hypotenuse length: ");
                        trigonometryModel.Hypotenuse = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateAngleUsingSine(trigonometryModel);
                        break;
                    case 8:
                        Console.Write("Enter adjacent side length: ");
                        trigonometryModel.Adjacent = double.Parse(Console.ReadLine());
                        Console.Write("Enter hypotenuse length: ");
                        trigonometryModel.Hypotenuse = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateAngleUsingCosine(trigonometryModel);
                        break;
                    case 9:
                        Console.Write("Enter opposite side length: ");
                        trigonometryModel.Opposite = double.Parse(Console.ReadLine());
                        Console.Write("Enter adjacent side length: ");
                        trigonometryModel.Adjacent = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateAngleUsingTan(trigonometryModel);
                        break;
                    case 10:
                        Console.Write("Enter opposite side length: ");
                        trigonometryModel.Opposite = double.Parse(Console.ReadLine());
                        Console.Write("Enter hypotenuse length: ");
                        trigonometryModel.Hypotenuse = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateRadianceBasedOnOppositeAndHypotenuse(trigonometryModel);
                        break;
                    case 11:
                        Console.Write("Enter angle in degrees: ");
                        trigonometryModel.Angle = double.Parse(Console.ReadLine());
                        result = TrigonometryCalculator.CalculateRadianceBasedOnAngle(trigonometryModel);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        continue;
                }

                result = Math.Round(result, 2, MidpointRounding.AwayFromZero);

                Console.WriteLine($"Result: {result}");


                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

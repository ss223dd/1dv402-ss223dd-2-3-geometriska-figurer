using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    class Program
    {
        // Method which calls the ViewMenu method in order to show the menu, if the user doesn't chose to exit the app the method should call the CreateShape method which
        // creates and returns a reference of either an Ellips- or a Rectangle-object. The reference in turn is being used in the call of the ViewDetail method which presents
        // the object's details. When a calculation/presentation has been made the menu should be shown once again.

        // The menu options are numbered from 0-2 and if the user doesn't chose an option within its interval an error message should be presented and the user is prompted 
        // to press any key to be able to make a valid option.
        private static void Main(string[] args)
        {
            Console.Title = "Geometriska Figurer - Nivå A";

            bool exit = false;
            ShapeType shapeType = ShapeType.Indefinite;
            int index;

            do
            {
                Console.Clear();
                ViewMenu();

                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                {
                    switch (index)
                    {
                        case 0:
                            exit = true;
                            continue;

                        case 1:
                            shapeType = ShapeType.Ellipse;
                            break;

                        case 2:
                            shapeType = ShapeType.Rectangle;
                            break;
                    }

                    Shape shape = CreateShape(shapeType);
                    // ViewShapeDetail();
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 2.\n");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   Tryck tangent för att fortsätta   ");
                Console.ResetColor();
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.Clear();
                Console.CursorVisible = true;

            } while (!exit);
        }

        // Method which reads/gets a shape's length and width, instansiates the object and returns a reference to it.
        private static Shape CreateShape(ShapeType shapeType)
        {
            double length = ReadDoubleGreaterThanZero("\nAnge längden: ");
            double width = ReadDoubleGreaterThanZero("\nAnge bredden: ");

            return new Ellipse (length, width);

            
        }

        // Method should receive the string argument being presented upon prompting the user to enter a shape's values. The method should return a double value greater 
        // than 0 and if the value cannot be interpreted like such, an error message should be shown and the user given a new chance to enter a valid value.
        private static double ReadDoubleGreaterThanZero(string prompt)
        {   
            while (true)
            {
                Console.Write(prompt);
                double input;

                if (double.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    return input;
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nFEL! Ange ett flyttal större än 0.\n");
                Console.ResetColor();
                
            }
            
        }

        // Simply presenting the menu, no readline allowed.
        private static void ViewMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=====================================");
            Console.WriteLine("=                                   =");
            Console.WriteLine("=        Geometriska figurer        =");
            Console.WriteLine("=                                   =");
            Console.WriteLine("=====================================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n 0. Avsluta.");
            Console.WriteLine("\n 1. Ellips.");
            Console.WriteLine("\n 2. Rektangel.");
            Console.WriteLine("\n=====================================");
            Console.Write("\n Ange menyval [0-2]: ");
            Console.ResetColor();
        }

        // To present a shape's details. Upon being called a reference to the relevant object is being received. 
        // The ToString method is being used to present the shape and its details.
        private static void ViewShapeDetail(Shape shape)
        {

        }
    }
}

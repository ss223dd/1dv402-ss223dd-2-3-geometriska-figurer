using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    /// <summary>
    /// The class presents a menu with shape options, prompts the user for shape values, presents any potential error messages upon input, 
    /// instantiates the shape object as well as presents the shape's final details.
    /// </summary>
    class Program
    {
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
                    ViewShapeDetail(shape);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 2.\n");
                }
                
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

        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=====================================");

            if (shapeType == ShapeType.Ellipse)
            {
                Console.WriteLine("=              Ellips               =");
                Console.WriteLine("=====================================");
                Console.ResetColor();
                double length = ReadDoubleGreaterThanZero("\nAnge längden: ");
                double width = ReadDoubleGreaterThanZero("Ange bredden: ");
                return new Ellipse(length, width);
            }
            else
            {
                Console.WriteLine("=             Rektangel             =");
                Console.WriteLine("=====================================");
                Console.ResetColor();
                double length = ReadDoubleGreaterThanZero("\nAnge längden: ");
                double width = ReadDoubleGreaterThanZero("Ange bredden: ");
                return new Rectangle(length, width);
            }
        }

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

        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n=====================================");
            Console.WriteLine("=             Detaljer              =");
            Console.WriteLine("=====================================\n");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("\n=====================================\n");
        }
    }
}

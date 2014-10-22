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

            ViewMenu();



        }

        // Method which reads/gets a shape's length and width, instansiates the object and returns a reference to it.
        private static Shape CreateShape(ShapeType shapeType)
        {

            Ellipse el1 = new Ellipse(0, 0);

            return el1;
        }

        // Method should receive the string argument being presented upon prompting the user to enter a shape's values. The method should return a double value greater 
        // than 0 and if the value cannot be interpreted like such, an error message should be shown and the user given a new chance to enter a valid value.
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            return 1;
        }

        // Simply presenting the menu, no readline allowed.
        private static void ViewMenu()
        {

        // To present a shape's details. Upon being called a reference to the relevant object is being received. 
        // The ToString method is being used to present the shape and its details.
        }
        private static void ViewShapeDetail(Shape shape)
        {

        }
    }
}

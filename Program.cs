namespace GrundernaOOP
{
internal class Program
{
    static void Main(string[] args)
    {
        //Variables of type string to shorten and avoid repeating codes, implementation of DRY
        string circles = "Circles with radiuses 5 and 6 will have";
        string squares = "Squares with sides 5 and 6 will have";

        //Calls the methods GetArea and GetPerimeter and display the circles' area and perimeter
        Console.WriteLine("{0} areas {1} and {2} respectively. \n",
            circles, Circle.GetArea(5), Circle.GetArea(6));
        Console.WriteLine("{0} perimeters {1} and {2} respectively. \n", 
            circles, Circle.GetPerimeter(5), Circle.GetPerimeter(6));

        //Calls the methods GetArea and GetPerimeter and displays the squares' area and perimeter
        Console.WriteLine("{0} areas {1} and {2} respectively. \n",
            squares, Square.GetArea(5), Square.GetArea(6));
        Console.WriteLine("{0} perimeters {1} and {2} respectively. \n",
            squares, Square.GetPerimeter(5), Square.GetPerimeter(6));

        //Calls the method GetArea and displays the area of a triangle
        Console.WriteLine("The area of a triangle with base 5 and height 6 will be: {0}.\n", Triangle.GetArea(5,6));

        //Calculates the area of a circle based on user input
        Console.WriteLine("Vill du räkna ut arean på en cirkel?\nSkriv nedan radien:");
        int radie = int.Parse(Console.ReadLine());
        Console.WriteLine($"The circle will have an area of: {Circle.GetArea(radie)}");
        Console.WriteLine($"The circle will have a perimeter of: {Circle.GetPerimeter(radie)}");

    }
}
    class Circle //A new exterior class named Circle
    {
        //Declaration of new fields
        public float pi; 
        public int radie;

        public Circle() //Constructor
        {
            Circle myCircle = new Circle(); //Creation of a new object from the class Circle
        }
        public static float GetArea(int radie) //Method to calculate area of a circle
        {
            float pi = 3.14f; //Assignment of fields 
            float area = radie * radie * pi;
            return area; //Returns the calculated area when the method GetArea is called
        }
        public static float GetPerimeter(int radie) //Method to calculate the perimeter of a circle 
        {
            float pi = 3.14f;
            float perimeter = 2 * radie * pi;
            return perimeter; //Returns the calculated perimeter when the method GetPerimeter is called 
        }
    }
    class Square //A new exterior class named Square
    {
        public int side;//Declaration of a field
        public Square() //Constructor
        {
            Square mySquare = new Square(); //Creation of a new object from the class Square
        }
        public static int GetArea(int side) //Method to calculate the area of a square
        {
            int area = side * side;
            return area;
        }
        public static int GetPerimeter(int side)//Method to calculate the perimeter of a square
        {
            int perimeter = side * 4;
            return perimeter;
        }
    }
    class Triangle //A new class named Triangle
    {
        public int h; // h for height of the triangle
        public int b; // b for base of the triangle 
        public Triangle()
        {
            Triangle myTriangle = new Triangle(); //A new object from the class Triangle
        }
        public static int GetArea(int h, int b) //A Method that calculates the area of a triangle
        {
            int area = b * h / 2;
            return area; //Returns the calculated area when the method is called 
        }
    }
}

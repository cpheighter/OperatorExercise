using OperatorExercise;

//Exercise 1
int a = 17;
int b = 4;

Console.WriteLine(Methods.Add(a, b));
Console.WriteLine(Methods.Subtract(a, b));
Console.WriteLine(Methods.Multiply(a, b));
Console.WriteLine(Methods.Divide(a, b));
//------------------------------------------------
int quotient = a / b;
int remainder = a % b;

Console.WriteLine($"{a}/{b} is {quotient} reminder {remainder}");
//------------------------------------------------
// Exercise 2

Console.Write("Enter the radius of the circle: ");
    var radius = double.Parse(Console.ReadLine());
Console.WriteLine(Methods.AreaOfCircle(radius));
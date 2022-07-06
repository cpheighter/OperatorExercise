using OperatorExercise;

//Exercise 1
int a = 17;
int b = 4;

int quotient = a / b;
int remainder = a % b;

Console.WriteLine($"17/4 is {quotient} reminder {remainder}");
//------------------------------------------------
// Exercise 2

Console.Write("Enter the radius of the circle: ");
    var radius = double.Parse(Console.ReadLine());
Console.WriteLine(Methods.AreaOfCircle(radius));
Console.WriteLine("What is your name?");
var UserName = Console.ReadLine();
Console.WriteLine("Hello " + UserName);
Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You are {0} years old", age);
Console.ReadKey();
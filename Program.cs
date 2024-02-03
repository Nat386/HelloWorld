
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Enter your last name: ");
string lastName = Console.ReadLine();
Console.WriteLine("Enter your age: ");
string age = Console.ReadLine();
Console.WriteLine("Enter your occupation: ");
string occupation = Console.ReadLine();
int convertedAge = int.Parse(age);
Console.WriteLine("Hello " + name +" " + lastName + " "+ "I didn't think that you are " + convertedAge);
Console.WriteLine(occupation + " is a very interesting job.");


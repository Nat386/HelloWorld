using System.ComponentModel;

int[] numbers = new int[5];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[3]);

string[] fruits = new string[3];
fruits[0] = "Apple";
fruits[1] = "Banana";
fruits[2] = "Orange"; 
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);
fruits[2] = "Mango";
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);

var length = numbers.Length;
Console.WriteLine(length);

var length2 = fruits.Length;
Console.WriteLine(length2);

List<string> fruits2 = new List<string>();
fruits2.Add("Apple");
fruits2.Add("Banana");
fruits2.Add("Orange");

Console.WriteLine(fruits2[0]);
Console.WriteLine(fruits2[2]);

fruits2.Add("Mango");
Console.WriteLine(fruits2[0]);
Console.WriteLine(fruits2[1]);
Console.WriteLine(fruits2[2]);
Console.WriteLine(fruits2[3]);

fruits2.Remove("Banana");


int listlength = fruits2.Count;
Console.WriteLine(listlength);





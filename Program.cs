for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Number: " + i);

    if (i % 2 == 0)
    {
        Console.WriteLine("even number");
    }
    else
    {
        Console.WriteLine("odd number");
    }
}

bool isValidInput = false;
int number = 1;

while (number <= 10)
{
    Console.WriteLine("Number: " + number);

    if (number % 3 == 0)
    {
        Console.WriteLine("can be divided by 3");
    }
    else
    {
        Console.WriteLine("cannot be divided by 3");
    }
    number++;
}



int guess = 0;
do
{
    Console.WriteLine("Try to guess the number:");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess > 5)
        Console.WriteLine("Your number is bigger");
    else if (guess < 5) Console.WriteLine("Your number is smaller");
    else Console.WriteLine("Congratulations! You guessed the number");
}
while (guess != 5);


int[] numbers = { 10, 20, 30, 40, 50 };
foreach (int item in numbers)
{ Console.WriteLine(item);
    if (item < 30)
        Console.WriteLine(item + " is less than 30");
    else if (item > 30) Console.WriteLine(item + " is bigger than 30");
        else if (item == 30) Console.WriteLine(item + " is equal 30");
    }


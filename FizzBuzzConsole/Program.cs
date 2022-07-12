// See https://aka.ms/new-console-template for more information

// What are we testing for
int fizz = 3;
int buzz = 5;
int fizzbuzz = fizz * buzz;

// How often
int max_count = 100;
int iterations = 1;

while (iterations < max_count +1)
{
    // Output message
    string message = "";

    if ((iterations % fizzbuzz) > 0)
    {
        if (iterations % buzz > 0)
        {
            if (iterations % fizz == 0)
            {
                message = "Fizz";
            }
        }
        else
        {
            message = "Buzz";
        }
    }
    else
    {
        message = "Fizzbuzz";
    }

    Console.WriteLine($"{iterations,3} - {message}");
    iterations++;
}
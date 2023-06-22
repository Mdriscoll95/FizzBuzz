static void FizzBuzz(int num)
{
    if (num % 3 == 0 && num % 5 != 0)
    {
        Console.WriteLine("fizz");
    }
    else if (num % 5 == 0 && num % 3 != 0)
    {
        Console.WriteLine("buzz");
    }
    else if (num % 5 == 0 && num % 3 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else
    {
        Console.WriteLine(num);
    }
}





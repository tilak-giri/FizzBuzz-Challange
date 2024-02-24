int number;
for (int i=1; i<=100; i++)
{
    number = i;
    if(number%3 == 0){
        Console.WriteLine($"{number} - Fizz");
        if (number%5 == 0){
            Console.WriteLine($"{number} - FizzBuzz");
        }
    }
    else if(number%5 == 0){
        Console.WriteLine($"{number} - Buzz");
    }
    else{
        Console.WriteLine(number);
    }
}
// simple for loop

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }
// counts down instead, using decreament

//experiment with iterators pattern
// here we use i += 3 to skip two values after each iteration.
// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// use break keyword to break/exit the iteration
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// loop through each element of an array
// We subtract 1 from the value because the index number for array elements is zero-based
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// overcome foreach limitation of updating content using a for loop
// string[] names = { "Alex", "Eddie", "David", "Michael" };

// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David") names[i] = "Sammy";
// }

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }


//FIZZBUZZ CHALLENGE
for (int i = 1; i < 101; i++)

switch(i)
{
    case int n when n % 3 == 0 && n % 5 == 0:
        Console.WriteLine($"{i} - FizzBuzz");
        break;
    case int n when n % 3 == 0:
        Console.WriteLine($"{i} - Fizz");
        break;
    case int n when n % 5 == 0:
        Console.WriteLine($"{i} - Buzz");
        break;
    default:
        Console.WriteLine($"{i}");
        break;
}

// implementation of fizzbuzz using switch-case contruct
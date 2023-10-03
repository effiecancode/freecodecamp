// bool flag = true;
// if(flag){
//     int value = 10;
//     Console.WriteLine($"Inside of code block: + {value}");
// }
// value is a local variable
// we declared and could only access value inside the code block


// bool flag = true;
// int value = 0;

// if(flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside of code block: + {value}");
// }
// Console.WriteLine($"Inside of code block: {value}");

// always initialize local variable with a 0

// string name = "effie"
// if (name == "effie")
//     console.WriteLine("found effie");
// else if (name == "alvin")
//     console.WriteLine("found alvin");
// else (name == "love")
//     console.WriteLine("found love");
// meant to show good practice coding for readable code


//VARIABLE SCOPE CHALLENGE
int [] numbers = {4, 8, 15, 16, 23, 42};
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;
    }
}

if (found)
{
    Console.WriteLine("Set containd 42");
}

Console.WriteLine($"Total {total}");

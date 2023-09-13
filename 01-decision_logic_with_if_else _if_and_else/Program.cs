// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Random dice = new Random();

//         int roll1 = dice.Next(1, 7);
//         int roll2 = dice.Next(1, 7);
//         int roll3 = dice.Next(1, 7);

//         int total = roll1 + roll2 + roll3;

//         Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//         if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
//         {
//             if (roll1 == roll2 && roll2 == roll3)
//             {
//                 Console.WriteLine("You rolled triples!  +6 bonus to total!");
//                 total += 6;
//             }
//             else
//             {
//                 Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//                 total += 2;
//             }
//         }

//         // if (total >= 15)
//         // {
//         //     Console.WriteLine("You win!");
//         // }
//         // else
//         // {
//         //     Console.WriteLine("Sorry, you lose.");
//         // }

//         //instead of the above, give prices instead:

//         if (total >= 16)
//         {
//             Console.WriteLine("You win a car!");
//         }

//         else if (total >= 10)
//         {
//             Console.WriteLine("You win a laptop");
//         }

//         else if (total == 7)
//         {
//             Console.WriteLine("You win a phone!");
//         }

//         else
//         {
//             Console.WriteLine("You win a shoppinf voucher!");
//         }
//     }
// }

//EXAMPLE TWO

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription expired");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

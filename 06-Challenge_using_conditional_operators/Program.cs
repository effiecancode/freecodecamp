// In this challenge, you'll implement a conditional operator
// to simulate a "coin flip". The resulting decision logic will
// display either heads or tails.
// use random class to generate a value

Random random_flip = new Random();
int flip = random_flip.Next(2, 4); //start with smaller value, then upwards 1, 4, could also be same values 2, 2

Console.WriteLine((flip == 1) ? "heads" : "tails");





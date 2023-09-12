using System;

// initialize variables - graded assignments
int currentAssignments = 5;

string[] studentnames = new string[] {"Sophia", "Andrew", "emma", "Logan"};

//array to hold scores of the current student while looping through
int [] studentScores = new int[10];

//hold current the current student grade
string currentStudentLetterGrade = "";


int [] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int [] andrewscores = new int[] {92, 89, 81, 96, 90, 89};
int [] emmaScores = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int [] loganScores = new int[] {90, 95, 87, 88, 96, 96};

Console.WriteLine("Student\t\tGrade\n");//only occur once pale juu tu kama heading.

foreach (string name in studentnames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewscores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = emmaScores;
    }
        else if (currentStudent == "Andrew")
    {
        studentScores = loganScores;
    }

        decimal currentStudentGrade = 0;
        double studentSum = 0;

        // string currentStudentLetterGrade;
        //to add the extra marks, #change the loop to a for loop
        // foreach(var score in studentScores)
        // {
        //     studentSum += score;
        // }

        for (int i = 0; i < studentScores.Length; i++){
            if (i >= currentAssignments)
                studentSum += (double)studentScores[i] * 0.01;
            else
                studentSum += studentScores[i];
        }

        currentStudentGrade = (decimal)studentSum / currentAssignments;

        if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

        else if (currentStudentGrade >= 90)
            currentStudentLetterGrade = "A-";

        else if (currentStudentGrade >= 87)
            currentStudentLetterGrade = "B+";

        else if (currentStudentGrade >= 83)
            currentStudentLetterGrade = "B";

        else if (currentStudentGrade >= 80)
            currentStudentLetterGrade = "B-";
        else if (currentStudentGrade >= 77)
            currentStudentLetterGrade = "C+";

        else if (currentStudentGrade >= 73)
            currentStudentLetterGrade = "C";

        else if (currentStudentGrade >= 70)
            currentStudentLetterGrade = "C-";

        else if (currentStudentGrade >= 67)
            currentStudentLetterGrade = "D+";

        else if (currentStudentGrade >= 63)
            currentStudentLetterGrade = "D";

        else if (currentStudentGrade >= 60)
            currentStudentLetterGrade = "D-";
        else
        currentStudentLetterGrade = "F";

        Console.WriteLine($"{currentStudent}\t\t" + studentScores + $"\t{currentStudentLetterGrade}");

        // break; //makes the loop run once

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

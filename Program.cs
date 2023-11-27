// See https://aka.ms/new-console-template for more information
// initialize variables - all graded assignments
int examAssignments = 5;

int[] dianeScores = new int[] { 90, 81, 72, 98, 100, 94, 80 };
int[] gordonScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] lucyScores = new int[] { 90, 85, 69, 98, 68, 78, 89, 89 };
int[] lauraScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] bobbyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] daleScores = new int[] { 75, 86, 88, 84, 90, 90, 88, 79 };
int[] shellyScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] albertScores = new int[] { 91, 97, 95, 91, 95, 93, 91 };

string[] studentNames = new string[] { "Diane", "Gordon", "Lucy", "Laura", "Bobby", "Dale", "Shelly", "Albert" };
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

// Write the report header to console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Diane")
        studentScores = dianeScores;
    else if (currentStudent == "Gordon")
        studentScores = gordonScores;
    else if (currentStudent == "Lucy")
        studentScores = lucyScores;
    else if (currentStudent == "Laura")
        studentScores = lauraScores;
    else if (currentStudent == "Bobby")
        studentScores = bobbyScores;
    else if (currentStudent == "Dale")
        studentScores = daleScores;
    else if (currentStudent == "Shelly")
        studentScores = shellyScores;
    else if (currentStudent == "Albert")
        studentScores = albertScores;
    else
        continue;

    /*
     * initialize/reset:
     * -the sum of scored assignments,
     * -the average of exam + extra credit score,
     * -counter for the number of assignments
     */
    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
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

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
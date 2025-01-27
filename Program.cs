string studentName = "Sophia";

// Course details
string[] courseNames = { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
int[] courseCredits = { 3, 3, 4, 4, 3 };
int gradeA = 4, gradeB = 3;

// Course grades
int[] courseGrades = { gradeA, gradeB, gradeB, gradeB, gradeA };

// Output student details
Console.WriteLine($"Student Name: {studentName}");
Console.WriteLine();

// Output course details
for (int i = 0; i < courseNames.Length; i++)
{
    Console.ReadKey();
    Console.WriteLine($"{courseNames[i]} Grade: {courseGrades[i]} Credit: {courseCredits[i]}");
}
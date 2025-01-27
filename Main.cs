// getting information from the user
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

// course credit of the user
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// grades of the user
int gradeA = 4;
int gradeB = 3;

// grades for the user whether passed or failed
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

int leadingDigit = (int)gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int)(gradePointAverage * 100) % 10;

// output of the results 
Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course".PadRight(30) + "Grade".PadRight(10) + "Credit Hours");

Console.WriteLine($"{course1Name.PadRight(30)}{course1Grade.ToString().PadRight(10)}{course1Credit}");
Console.WriteLine($"{course2Name.PadRight(30)}{course2Grade.ToString().PadRight(10)}{course2Credit}");
Console.WriteLine($"{course3Name.PadRight(30)}{course3Grade.ToString().PadRight(10)}{course3Credit}");
Console.WriteLine($"{course4Name.PadRight(30)}{course4Grade.ToString().PadRight(10)}{course4Credit}");
Console.WriteLine($"{course5Name.PadRight(30)}{course5Grade.ToString().PadRight(10)}{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");

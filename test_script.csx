// Test C# Script for VS Code
// This demonstrates running .csx files

Console.WriteLine("=================================");
Console.WriteLine("C# Script Running Successfully!");
Console.WriteLine("=================================");

// Basic calculations
var students = 993;
var fullTime = 956;
var partTime = 33;

var ftPercentage = (double)fullTime / students * 100;
var ptPercentage = (double)partTime / students * 100;

Console.WriteLine($"\nStudent Enrollment Summary:");
Console.WriteLine($"Total Students: {students}");
Console.WriteLine($"Full-Time: {fullTime} ({ftPercentage:F1}%)");
Console.WriteLine($"Part-Time: {partTime} ({ptPercentage:F1}%)");

// Date calculation
var today = DateTime.Now;
Console.WriteLine($"\nCurrent Date: {today:yyyy-MM-dd}");
Console.WriteLine($"Academic Year: {(today.Month >= 7 ? today.Year : today.Year - 1)}-{(today.Month >= 7 ? today.Year + 1 : today.Year)}");

Console.WriteLine("\n✓ Script execution complete!");

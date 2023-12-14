// See https://aka.ms/new-console-template for more information
using Day1;
using System.Runtime.InteropServices;

Implementation implementation = new Implementation();
string problem = implementation.ReadInputFile(Environment.CurrentDirectory + "\\input.txt");
Console.WriteLine("Input file read");
long sumOfCalibrationValues = implementation.SolveProblem(problem);
Console.WriteLine("\nSum of Calibration Values for Input: " + sumOfCalibrationValues);
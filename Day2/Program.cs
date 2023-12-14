// See https://aka.ms/new-console-template for more information
using Day2;

Implementation2 implementation = new Implementation2();
string problem = implementation.ReadInputFile(Environment.CurrentDirectory + "\\input.txt");
Console.WriteLine("Input file read");
long sumOfIDs = implementation.SolveProblem(problem);
Console.WriteLine("\nSum of IDs for Input: " + sumOfIDs);
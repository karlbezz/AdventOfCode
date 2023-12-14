// See https://aka.ms/new-console-template for more information
using Day2;

Implementation2 implementation = new Implementation2();
string problem = implementation.ReadInputFile(Environment.CurrentDirectory + "\\input.txt");
Console.WriteLine("Input file read");
long sumOfIDs = implementation.SolveProblem(problem);
Console.WriteLine("\nSum of IDs for Input: " + sumOfIDs);

Implementation2Part2 implementation2Part2 = new Implementation2Part2();
string part2Problem = implementation2Part2.ReadInputFile(Environment.CurrentDirectory + "\\input.txt");
Console.WriteLine("Input file read");
long sumOfCubes = implementation2Part2.SolveProblem(part2Problem);
Console.WriteLine("\nSum of Cubes for Input: " + sumOfCubes);
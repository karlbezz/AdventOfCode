namespace Day2
{
    public class Implementation2Part2
    {
        public string ReadInputFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

        public long SolveProblem(string problem)
        {
            string[] lines = problem.Split("\n");
            long sumOfPowerCubes = 0;
            object lockObject = new object();
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] gameDescription = line.Split(": ");
                    long powerOfCubes = CalculatePowerOfCubes(gameDescription[1]);
                    sumOfPowerCubes += powerOfCubes;
                }
            }

            return sumOfPowerCubes;
        }
        public long CalculatePowerOfCubes(string game)
        {
            long red = 0;
            long green = 0;
            long blue = 0;

            string[] subsets = game.Split("; ");
            foreach (string subset in subsets)
            {
                string[] values = subset.Split(", ");
                foreach (string value in values)
                {
                    string[] cubeColorValue = value.Split(" ");
                    long parsedValue = long.Parse(cubeColorValue[0]);
                    switch (cubeColorValue[1])
                    {
                        case "red":
                            red = red > parsedValue ? red : parsedValue;
                            break;
                        case "green":
                            green = green > parsedValue ? green : parsedValue;
                            break;
                        case "blue":
                            blue = blue > parsedValue ? blue : parsedValue;
                            break;
                    }
                }
            }

            return red * green * blue;
        }
    }
}

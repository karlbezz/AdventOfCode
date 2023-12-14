namespace Day2
{
    public class Implementation2
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
            long sumOfIDs = 0;
            object lockObject = new object();
            foreach(string line in lines)
            {
                if(line != "")
                {
                    string[] gameDescription = line.Split(": ");
                    bool isGameSolvable = CheckIfGameIsSolvable(gameDescription[1]);

                    if (isGameSolvable)
                    {
                        lock (lockObject)
                        {
                            sumOfIDs += long.Parse(gameDescription[0].Split(" ")[1]);
                        }
                    }
                }
            }

            return sumOfIDs;
        }

        public bool CheckIfGameIsSolvable(string game)
        {
            long red = 0;
            long green = 0;
            long blue = 0;
            
            string[] subsets = game.Split("; ");
            foreach (string subset in subsets)
            {
                string[] values = subset.Split(", ");
                foreach(string value in values)
                {
                    string[] cubeColorValue = value.Split(" ");
                    switch (cubeColorValue[1])
                    {
                        case "red":
                            red = long.Parse(cubeColorValue[0]);
                            break;
                        case "green":
                            green = long.Parse(cubeColorValue[0]);
                            break;
                        case "blue":
                            blue = long.Parse(cubeColorValue[0]);
                            break;
                    }

                    if(red > 12 || green > 13 || blue > 14)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

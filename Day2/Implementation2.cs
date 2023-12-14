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
            foreach(string line in lines)
            {
                string[] gameDescription = line.Split(": ");
                CheckIfGameIsSolvable(gameDescription[1]);
            }
        }

        public bool CheckIfGameIsSolvable(string game, Dictionary<string, int> allowableValues)
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            
            string[] subsets = game.Split("; ");
            foreach (string subset in subsets)
            {
                string[] values = subset.Split(", ");
                foreach(string value in values)
                {
                    string[] cubeColorValue = value.Split(" ");

                }
            }
        }
    }
}

namespace Day1
{
    public class Implementation
    {
        public string ReadInputFile(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

        public long SolveProblem(string problem)
        {
            object lockObject = new object();
            string[] lines = problem.Split("\n");
            long sumOfCalibrationValues = 0;
            long completedLines = 0;
            Parallel.ForEach(lines, (line) =>
            {
                long calibrationValue = GetCalibrationValue(line);
                lock (lockObject)
                {
                    sumOfCalibrationValues += calibrationValue;
                    completedLines++;
                    Console.Write($"\rCompleted Lines {completedLines}");
                }
            });

            return sumOfCalibrationValues;
        }

        public long GetCalibrationValue(string line)
        {
            if(line == "")
            {
                return 0;
            }

            int index = 0;
            string firstValue = "";
            string secondValue = "";

            while (index < line.Length)
            {
                if (Char.IsNumber(line[index]))
                {
                    firstValue = line[index].ToString();
                    break;
                }

                index++;
            }

            int endIndex = index;
            index = line.Length - 1;

            while (index >= endIndex)
            {
                if (Char.IsNumber(line[index]))
                {
                    secondValue = line[index].ToString();
                    break;
                }
                index--;
            }

            return long.Parse($"{firstValue}{secondValue}");            
        }
    }
}

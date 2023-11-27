//Câu 1:
/*using System;

class RainfallReport
{
    static void Main()
    {
        string[] monthNames = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        double[] rainfallAmounts = new double[12];

        // Input monthly rainfall amounts
        for (int i = 0; i < 12; i++)
        {
            Console.Write("Enter rainfall amount for {0}: ", monthNames[i]);
            rainfallAmounts[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate average rainfall
        double sum = 0;
        foreach (double amount in rainfallAmounts)
        {
            sum += amount;
        }
        double averageRainfall = sum / 12;

        // Display report
        Console.WriteLine();
        Console.WriteLine("Rainfall Report");
        Console.WriteLine("----------------");
        Console.WriteLine("Month\t\tRainfall\tVariance from Mean");

        for (int i = 0; i < 12; i++)
        {
            double variance = rainfallAmounts[i] - averageRainfall;
            Console.WriteLine("{0}\t\t{1}\t\t{2}", monthNames[i], rainfallAmounts[i], variance);
        }

        Console.WriteLine();
        Console.WriteLine("Average Rainfall for the Year: {0}", averageRainfall);
    }
}

//Câu 2:
using System;

class NameSortingProgram
{
    static void Main()
    {
        Console.WriteLine("Enter names (last name first):");

        // Read names from the user
        string[] names = ReadNamesFromUser();

        // Sort names in ascending order
        Array.Sort(names);

        // Display sorted names
        Console.WriteLine();
        Console.WriteLine("Sorted Names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    static string[] ReadNamesFromUser()
    {
        // Create a dynamic list to store the names
        var nameList = new System.Collections.Generic.List<string>();

        while (true)
        {
            Console.Write("Enter a name (leave empty to finish): ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                break; // Exit the loop if a blank name is entered
            }

            nameList.Add(name);
        }

        // Convert the list to an array and return
        return nameList.ToArray();
    }
}

//Câu 3:
using System;
using System.Formats;
class ArrayProductProgram
{
    public static object MessageBox { get; private set; }

    static void Main()
    {
        double[] array1 = { 1.5, 2.5, 3.5 };
        double[] array2 = { 2.0, 3.0, 4.0, 5.0 };
        double[] productArray = new double[Math.Max(array1.Length, array2.Length)];

        for (int i = 0; i < productArray.Length; i++)
        {
            double value1 = (i < array1.Length) ? array1[i] : 1.0;
            double value2 = (i < array2.Length) ? array2[i] : 1.0;
            productArray[i] = value1 * value2;
        }

        string displayText = "Array1\tArray2\tProduct\n";

        for (int i = 0; i < productArray.Length; i++)
        {
            double value1 = (i < array1.Length) ? array1[i] : 1.0;
            double value2 = (i < array2.Length) ? array2[i] : 1.0;
            string line = $"{value1}\t{value2}\t{productArray[i]}\n";
            displayText += line;
        }

        MessageBox.Show(displayText, "Array Product");
    }
}

//Câu 4:
using System;
using System.Collections.Generic;
using System.Linq;

class ValueTestingApplication
{
    static void Main()
    {
        int[] valueCounts = new int[11];
        int validCount = 0;
        int invalidCount = 0;
        List<int> distinctValidEntries = new List<int>();

        Console.WriteLine("Enter values (integers between 0 and 10, q to quit):");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break; // Exit the loop if 'q' is entered
            }

            if (int.TryParse(input, out int value))
            {
                if (value >= 0 && value <= 10)
                {
                    valueCounts[value]++;
                    validCount++;
                    if (!distinctValidEntries.Contains(value))
                    {
                        distinctValidEntries.Add(value);
                    }
                }
                else
                {
                    invalidCount++;
                }
            }
            else
            {
                invalidCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Statistics");
        Console.WriteLine("----------");
        Console.WriteLine("Total valid values: {0}", validCount);
        Console.WriteLine("Total invalid entries: {0}", invalidCount);
        Console.WriteLine();

        Console.WriteLine("Distinct Valid Entries");
        Console.WriteLine("----------------------");
        Console.WriteLine("Value\tCount");
        foreach (int entry in distinctValidEntries.OrderBy(e => e))
        {
            Console.WriteLine("{0}\t{1}", entry, valueCounts[entry]);
        }
    }
}

//Câu 5: 
using System;
using System.Collections.Generic;

class MonthlySalesApplication
{
    static void Main()
    {
        Console.Write("Enter the number of monthly sales amounts: ");
        int numberOfSales = int.Parse(Console.ReadLine());

        List<decimal> salesList = new List<decimal>();

        for (int i = 1; i <= numberOfSales; i++)
        {
            Console.Write("Enter the sales amount for month {0}: ", i);
            decimal salesAmount = decimal.Parse(Console.ReadLine());
            salesList.Add(salesAmount);
        }

        decimal totalSales = 0;
        foreach (decimal sale in salesList)
        {
            totalSales += sale;
        }

        Console.WriteLine();
        Console.WriteLine("Monthly Sales Report");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Sales Amount\tPercentage Contribution");
        Console.WriteLine("---------------------------------------");

        foreach (decimal sale in salesList)
        {
            decimal percentage = (sale / totalSales) * 100;
            Console.WriteLine("{0}\t\t{1:F1}%", sale.ToString("C"), percentage);
        }

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Total Sales:\t{0}", totalSales.ToString("C"));
    }
}

//Câu 6:
using System;

class TemperatureData
{
    private double[] temperatures;

    public TemperatureData(double[] temperatures)
    {
        this.temperatures = temperatures;
    }

    public double GetHighestTemperature()
    {
        double highest = temperatures[0];
        foreach (double temperature in temperatures)
        {
            if (temperature > highest)
            {
                highest = temperature;
            }
        }
        return highest;
    }

    public double GetLowestTemperature()
    {
        double lowest = temperatures[0];
        foreach (double temperature in temperatures)
        {
            if (temperature < lowest)
            {
                lowest = temperature;
            }
        }
        return lowest;
    }

    public double GetAverageTemperature()
    {
        double sum = 0;
        foreach (double temperature in temperatures)
        {
            sum += temperature;
        }
        return sum / temperatures.Length;
    }

    public double GetAverageTemperatureExcludingLowest()
    {
        double sum = 0;
        double lowest = GetLowestTemperature();
        int count = 0;
        foreach (double temperature in temperatures)
        {
            if (temperature != lowest)
            {
                sum += temperature;
                count++;
            }
        }
        return sum / count;
    }

    public int GetNumberOfDaysBelowTemperature(double temperature)
    {
        int count = 0;
        foreach (double temp in temperatures)
        {
            if (temp < temperature)
            {
                count++;
            }
        }
        return count;
    }

    public override string ToString()
    {
        string output = "Temperature Data\n";
        output += "----------------\n";
        output += "Temperature\t\n";
        output += "----------------\n";
        foreach (double temperature in temperatures)
        {
            output += $"{temperature:F1}\t\n";
        }
        output += "----------------\n";
        output += $"Temperature Range: {GetLowestTemperature():F1} - {GetHighestTemperature():F1}\n";
        return output;
    }
}

class TemperatureDataTest
{
    static void Main()
    {
        double[] temperatures = { 20.5, 22.3, 19.8, 23.1, 21.7, 18.6, 24.4 };
        TemperatureData data = new TemperatureData(temperatures);

        Console.WriteLine(data);

        Console.WriteLine("Highest Temperature: {0}", data.GetHighestTemperature());
        Console.WriteLine("Lowest Temperature: {0}", data.GetLowestTemperature());
        Console.WriteLine("Average Temperature: {0:F1}", data.GetAverageTemperature());
        Console.WriteLine("Average Temperature (Excluding Lowest): {0:F1}", data.GetAverageTemperatureExcludingLowest());

        double threshold = 22.0;
        int daysBelowThreshold = data.GetNumberOfDaysBelowTemperature(threshold);
        Console.WriteLine("Number of Days Below {0}: {1}", threshold, daysBelowThreshold);
    }
}

//Câu 7: 
using System;

class AreaCodeChecker
{
    private string[] areaCodes;

    public AreaCodeChecker(string[] areaCodes)
    {
        this.areaCodes = areaCodes;
    }

    public bool IsAreaCodeInStateExchange(string areaCode)
    {
        return Array.IndexOf(areaCodes, areaCode) != -1;
    }

    public override string ToString()
    {
        string formattedAreaCodes = string.Join(") (", areaCodes);
        return "(" + formattedAreaCodes + ")";
    }
}

class AreaCodeTest
{
    static void Main()
    {
        string[] orderedAreaCodes = { "123", "456", "789", "012", "345" };
        string[] unorderedAreaCodes = { "789", "012", "345", "123", "456" };

        AreaCodeChecker orderedChecker = new AreaCodeChecker(orderedAreaCodes);
        AreaCodeChecker unorderedChecker = new AreaCodeChecker(unorderedAreaCodes);

        // Test area codes
        string testAreaCode1 = "123";
        string testAreaCode2 = "999";

        Console.WriteLine("Ordered State Area Codes: {0}", orderedChecker);
        Console.WriteLine("Unordered State Area Codes: {0}", unorderedChecker);
        Console.WriteLine();

        Console.WriteLine("Testing Area Code: {0}", testAreaCode1);
        bool isAreaCodeInStateExchange1 = orderedChecker.IsAreaCodeInStateExchange(testAreaCode1);
        Console.WriteLine("Is Area Code in State Exchange (Ordered)? {0}", isAreaCodeInStateExchange1);
        isAreaCodeInStateExchange1 = unorderedChecker.IsAreaCodeInStateExchange(testAreaCode1);
        Console.WriteLine("Is Area Code in State Exchange (Unordered)? {0}", isAreaCodeInStateExchange1);
        Console.WriteLine();

        Console.WriteLine("Testing Area Code: {0}", testAreaCode2);
        bool isAreaCodeInStateExchange2 = orderedChecker.IsAreaCodeInStateExchange(testAreaCode2);
        Console.WriteLine("Is Area Code in State Exchange (Ordered)? {0}", isAreaCodeInStateExchange2);
        isAreaCodeInStateExchange2 = unorderedChecker.IsAreaCodeInStateExchange(testAreaCode2);
        Console.WriteLine("Is Area Code in State Exchange (Unordered)? {0}", isAreaCodeInStateExchange2);
    }
}

//Câu 8:
using System;

class HomeworkScoresProgram
{
    static void Main()
    {
        const int MinScore = 0;
        const int MaxScore = 10;

        Console.WriteLine("Enter homework scores (0-10). Enter a negative value to finish.");

        int[] scores = new int[0];
        int score;
        int count = 0;

        while (true)
        {
            Console.Write("Enter score: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out score))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                continue;
            }

            if (score < MinScore || score > MaxScore)
            {
                Console.WriteLine("Invalid score. Please enter a value between {0} and {1}.", MinScore, MaxScore);
                continue;
            }

            Array.Resize(ref scores, scores.Length + 1);
            scores[count] = score;
            count++;

            if (score < 0)
            {
                break;
            }
        }

        if (count < 3)
        {
            Console.WriteLine("Not enough scores entered.");
        }
        else
        {
            int minScore = int.MaxValue;
            int maxScore = int.MinValue;
            int total = 0;

            for (int i = 0; i < count; i++)
            {
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                }

                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                }

                total += scores[i];
            }

            double average = (total - minScore - maxScore) / (count - 2);

            Console.WriteLine("Discarded lowest score: {0}", minScore);
            Console.WriteLine("Discarded highest score: {0}", maxScore);
            Console.WriteLine("Average of remaining scores: {0}", average.ToString("0.00"));
        }
    }
}

//Câu 9:
using System;
using System.Collections.Generic;

class FrequencyDistributionProgram
{
    static void Main()
    {
        const int MinValue = 0;
        const int MaxValue = 10;

        Console.WriteLine("Enter values between {0} and {1}. Enter a negative value to finish.", MinValue, MaxValue);

        List<int> values = new List<int>();
        int value;

        while (true)
        {
            Console.Write("Enter value: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out value))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                continue;
            }

            if (value < 0)
            {
                break;
            }

            if (value < MinValue || value > MaxValue)
            {
                Console.WriteLine("Invalid value. Please enter a value between {0} and {1}.", MinValue, MaxValue);
                continue;
            }

            values.Add(value);
        }

        Console.WriteLine();
        Console.WriteLine("Frequency Distribution:");

        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int val in values)
        {
            if (frequencyMap.ContainsKey(val))
            {
                frequencyMap[val]++;
            }
            else
            {
                frequencyMap[val] = 1;
            }
        }

        foreach (KeyValuePair<int, int> entry in frequencyMap)
        {
            Console.Write("{0,2}: ", entry.Key);

            for (int i = 0; i < entry.Value; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}

//Câu 10:
using System;

class Course
{
    private string name;
    private int currentEnrollment;
    private int maxEnrollment;

    public Course(string name, int currentEnrollment, int maxEnrollment)
    {
        this.name = name;
        this.currentEnrollment = currentEnrollment;
        this.maxEnrollment = maxEnrollment;
    }

    public int GetRemainingSlots()
    {
        return maxEnrollment - currentEnrollment;
    }

    public override string ToString()
    {
        int remainingSlots = GetRemainingSlots();
        return $"{name} - Current Enrollment: {currentEnrollment}, Open Slots: {remainingSlots}";
    }
}

class CourseReport
{
    static void Main()
    {
        string[] courseNames = { "Math", "Science", "English" };
        int[] currentEnrollments = { 20, 15, 18 };
        int[] maxEnrollments = { 30, 25, 20 };

        Course[] courses = new Course[courseNames.Length];

        for (int i = 0; i < courseNames.Length; i++)
        {
            courses[i] = new Course(courseNames[i], currentEnrollments[i], maxEnrollments[i]);
        }

        Console.WriteLine("Course Enrollments Report:");
        Console.WriteLine();

        foreach (Course course in courses)
        {
            Console.WriteLine(course);
        }
    }
}*/
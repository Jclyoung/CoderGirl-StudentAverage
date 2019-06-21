using System;


namespace StudentAverage
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }


        public Student()
        {
            Name = " ";
            Scores = new int[] { };
        }

        public Student(string name, int[] scores)
        {
            Name = name;
            Scores = scores;
        }

        public int? GetAverage()
        {
            
            int sum = 0;
            foreach (int score in Scores)
            {
                sum += score;
            }

            double length = Scores.Length;
            Convert.ToDouble(sum);
            double average = sum / length;
            Math.Round(average);
            int avg = Convert.ToInt32(average);
            return avg;
        }
    }
}
namespace Core.Models
{
    public class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public double AvgPoint { get; set; }


        public Student(string fullName)
        {
            this.FullName = fullName;
        }
    }
}
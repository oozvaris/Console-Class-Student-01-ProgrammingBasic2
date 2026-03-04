namespace Console_Class_Student_01_ProgrammingBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.CourseID = 1;
            course.CourseName = "Programming Basic 2";
            course.CourseCode = "PB2";
            course.CourseCredit = 3;

            Course course2 = new Course();
            course2.CourseID = 2;
            course2.CourseName = "Data Structure";
            course2.CourseCode = "DS";
            course2.CourseCredit = 3;

            Course course3 = new Course();
            course3.CourseID = 3;
            course3.CourseName = "Database Management System";
            course3.CourseCode = "DBMS";
            course3.CourseCredit = 2;

            Console.ReadLine();
        }
    }
}

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

            List<Course> courses = new List<Course>();
            courses.Add(course);
            courses.Add(course2);
            courses.Add(course3);

            Console.WriteLine("Course List:" + courses.Count() + " courses in my School");
            foreach (Course c in courses)
            {
                Console.WriteLine(
                    $"Course ID: {c.CourseID}, " +
                    $"Course Name: {c.CourseName}, " +
                    $"Course Code: {c.CourseCode}, " +
                    $"Course Credit: {c.CourseCredit}");
            }

            //for (int i = 0; i < courses.Count(); i++)
            //{
            //    Course c = courses[i];
            //    Console.WriteLine(
            //        $"Course ID: {c.CourseID}, " +
            //        $"Course Name: {c.CourseName}, " +
            //        $"Course Code: {c.CourseCode}, " +
            //        $"Course Credit: {c.CourseCredit}");
            //}


            while (true)
            {
                Console.WriteLine("Enter Course ID to search:");
                int courseID = Convert.ToInt32(Console.ReadLine());
                Course foundCourse = courses.FirstOrDefault(c => c.CourseID == courseID);

                if (foundCourse != null)
                {
                    Console.WriteLine(
                        $"Course ID: {foundCourse.CourseID}, " +
                        $"Course Name: {foundCourse.CourseName}, " +
                        $"Course Code: {foundCourse.CourseCode}, " +
                        $"Course Credit: {foundCourse.CourseCredit}");
                }
                else
                {
                    Console.WriteLine("Course not found.");
                }
            }


            while (true)
            {

                Console.WriteLine("Enter Course Name to search:");
                string courseName = Console.ReadLine();
                List<Course> lstCourse = courses.Where(c => c.CourseName.Contains(courseName)).ToList();

                foreach (Course c in lstCourse)
                {
                    Console.WriteLine(
                        $"Course ID: {c.CourseID}, " +
                        $"Course Name: {c.CourseName}, " +
                        $"Course Code: {c.CourseCode}, " +
                        $"Course Credit: {c.CourseCredit}");
                }


            }

            Console.ReadLine();
        }
    }
}

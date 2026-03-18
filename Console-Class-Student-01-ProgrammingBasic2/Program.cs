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
            // Console.ReadLine();

            //for (int i = 0; i < courses.Count(); i++)
            //{
            //    Course c = courses[i];
            //    Console.WriteLine(
            //        $"Course ID: {c.CourseID}, " +
            //        $"Course Name: {c.CourseName}, " +
            //        $"Course Code: {c.CourseCode}, " +
            //        $"Course Credit: {c.CourseCredit}");
            //}


            //while (true)
            //{
            //    Console.WriteLine("Enter Course ID to search:");
            //    int courseID = Convert.ToInt32(Console.ReadLine());
            //    Course foundCourse = courses.FirstOrDefault(c => c.CourseID == courseID);

            //    if (foundCourse != null)
            //    {
            //        Console.WriteLine(
            //            $"Course ID: {foundCourse.CourseID}, " +
            //            $"Course Name: {foundCourse.CourseName}, " +
            //            $"Course Code: {foundCourse.CourseCode}, " +
            //            $"Course Credit: {foundCourse.CourseCredit}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Course not found.");
            //    }
            //}


            //while (true)
            //{

            //    Console.WriteLine("Enter Course Name to search:");
            //    string courseName = Console.ReadLine();
            //    List<Course> lstCourse = courses.Where(
            //        c => c.CourseName.Contains(courseName)
            //        ).ToList();

            //    foreach (Course c in lstCourse)
            //    {
            //        Console.WriteLine(
            //            $"Course ID: {c.CourseID}, " +
            //            $"Course Name: {c.CourseName}, " +
            //            $"Course Code: {c.CourseCode}, " +
            //            $"Course Credit: {c.CourseCredit}");
            //    }


            //}

            Course courseVal = new Course();

            // Display menu
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Display all courses");
                Console.WriteLine("2. Search course by ID");
                Console.WriteLine("3. Search course by Name");
                Console.WriteLine("4. Course Registration");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:                        
                        courseVal.GetCourseList(courses);
                        break;
                    case 2:
                        Console.Write("Enter Course ID to search: ");
                        int courseID = Convert.ToInt32(Console.ReadLine());
                        courseVal.FindCourseByID(courses, courseID);
                        break;
                    case 3:
                        Console.Write("Enter Course Name to search: ");
                        string courseName = Console.ReadLine();
                        courseVal.SearchCourseByName(courses, courseName);
                        break;
                    case 4:                                              
                        Console.Write("Enter Course ID: ");
                        int newCourseID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Course Name: ");
                        string newCourseName = Console.ReadLine();
                        Console.Write("Enter Course Code: ");
                        string newCourseCode = Console.ReadLine();
                        Console.Write("Enter Course Credit: ");
                        int newCourseCredit = Convert.ToInt32(Console.ReadLine());
                        Course newCourseVal = courseVal.RegisterCourse(newCourseID, newCourseName, newCourseCode, newCourseCredit);
                        courses.Add(newCourseVal);
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }


            Console.ReadLine();
        }
    }
}

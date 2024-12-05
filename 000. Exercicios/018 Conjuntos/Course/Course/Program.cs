using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<Student> courseA = new HashSet<Student>();
            HashSet<Student> courseB = new HashSet<Student>();
            HashSet<Student> courseC = new HashSet<Student>();


            Console.Write("How many Students for Course A? ");
            int StudentsA = int.Parse(Console.ReadLine());

            for (int i = 0; i < StudentsA; i++)
            {
                int student_Id = int.Parse(Console.ReadLine());
                courseA.Add(new Student(student_Id));
            }

            Console.Write("How many Students for Course B? ");
            int StudentsB = int.Parse(Console.ReadLine());

            for (int i = 0; i < StudentsB; i++)
            {
                int student_Id = int.Parse(Console.ReadLine());
                courseB.Add(new Student(student_Id));
            }

            Console.Write("How many Students for Course C? ");
            int StudentsC = int.Parse(Console.ReadLine());

            for (int i = 0; i < StudentsC; i++)
            {
                int student_Id = int.Parse(Console.ReadLine());
                courseC.Add(new Student(student_Id));
            }

            HashSet<Student> all = new HashSet<Student>(courseA);

            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine("Total Students: " + all.Count());
        }
    }
}

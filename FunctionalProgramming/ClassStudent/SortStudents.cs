using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassStudent
{
    class SortStudents
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Nikolay", "Nenov",18,"1014","02-911","nenov@gamil.fr",new List<int> {5, 3, 5, 6},1,"Web Developer"),
                new Student("Pesho", "Radev",18,"2015","180","radev@abv.bg",new List<int> {5, 2, 5, 6},1,"PHP Developer"),
                new Student("Petko", "Petkov",19,"203114","166","petkov@abv.bg",new List<int> {5, 2, 5, 6},2,"PHP Developer"),
                new Student("Todor", "Todorov",19,"0014","666","todorov@gmail.com",new List<int> {5, 2, 5, 5},2,"QA Engineer"),
                new Student("Mariika", "Mariikova",17,"1414","+3592112","mima@ght.gh",new List<int> {3, 3, 2, 2},1,"Web Developer"),
                new Student("Ralitza", "Roseva",21,"1515","180","rali@abv.bg",new List<int> {4, 2, 6, 3},2,"QA Engineer"),
                new Student("Iliya", "Asenov",36,"2114","+44123456789","ilko@hotmail.com",new List<int> {6, 2, 6, 6},3,"Web Developer")
            };
            //Uncomment what you need !!!
            
            //SortByGroup(students);

            //SortByName(students);

            //SortByAge(students);

            //DescendingOrdeLambda(students);
            
            //DescendingOrderUsingLinQquery(students);

            //SortByEmail(students);

            //SortBySofiaPhone(students);

            //ExellentStudent(students);

            //WeakStudent(students);

            //Enrolled2014(students);

            //StudentsByGroup(students);
        }

        public static void StudentsByGroup(List<Student> students)
        {
            Console.WriteLine("|Students by Groups|\n");

            var byGroupName = from st in students group st by st.GroupName;
            foreach (var st in byGroupName)
            {
                Console.WriteLine("Group Name : {0},Number of Student : {1}", st.Key, st.Count());
                foreach (var std in st)
                {
                    Console.WriteLine("{0} {1}\n", std.FirstName, std.LastName);
                }
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void Enrolled2014(List<Student> students)
        {
            Console.WriteLine("|Students Enrolled in 2014|\n");
            var enrolled14 = from st in students where st.FacultyNumber.EndsWith(("14")) select st;
            foreach (var st in enrolled14)
            {
                Console.WriteLine("Name = {0} {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}," +
                                  " Group Number = {7}\n", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone,
                    st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void WeakStudent(List<Student> students)
        {
            Console.WriteLine("|Weak Student|\n");
            var weak = students.WeeksStudents();
            foreach (var st in weak)
            {
                Console.WriteLine("{0} {1} = {2}", st.FirstName, st.LastName, string.Join(", ", st.Marks));
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void ExellentStudent(List<Student> students)
        {
            Console.WriteLine("|Exellent Student|\n");
            var exellent = students.ExellentStudents();
            foreach (var st in exellent)
            {
                Console.WriteLine("{0} {1} = {2}", st.FirstName, st.LastName, string.Join(", ", st.Marks));
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void SortBySofiaPhone(List<Student> students)
        {
            Console.WriteLine("|Sort ByPhone In Sofia|\n");
            var sortByPhone = from st in students
                where st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2")
                select st;
            foreach (var st in sortByPhone)
            {
                Console.WriteLine("Name = {0} {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}," +
                                  " Group Number = {7}\n", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone,
                    st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void SortByEmail(List<Student> students)
        {
            Console.WriteLine("|Sort By Email|\n");
            var orderByEmail = from st in students where st.Email.Contains("@abv.bg") select st;
            foreach (var st in orderByEmail)
            {
                Console.WriteLine("Name = {0} {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}," +
                                  " Group Number = {7}\n", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone,
                    st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void DescendingOrderUsingLinQquery(List<Student> students)
        {
            Console.WriteLine("Using LINQ query\n");

            var sortStudentsLinq =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;

            foreach (var st in sortStudentsLinq)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void DescendingOrdeLambda(List<Student> students)
        {
            Console.WriteLine("First Name and Last Name in Descending Order Using Lambda\n");
            var lambdaSort =
                students.OrderBy(st => st.FirstName)
                    .ThenByDescending(st => st.LastName)
                    .Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
            foreach (var st in lambdaSort)
            {
                Console.WriteLine(st);
            }
        }

        public static void SortByAge(List<Student> students)
        {
            Console.WriteLine("|SortByAge| 18 - 24 ");
            var sortByAge = from st in students
                where (st.Age >= 18 && st.Age <= 24)
                select new {st.FirstName, st.LastName, st.Age};
            foreach (var st in sortByAge)
            {
                Console.WriteLine("Name = {0} {1} Age = {2}", st.FirstName, st.LastName, st.Age);
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void SortByName(List<Student> students)
        {
            Console.WriteLine("|Sort By First And Second Name|\n");
            var sortByFirstAndLastName =
                students.Where(student => String.Compare(student.FirstName, student.LastName, StringComparison.Ordinal) <= 0);
            foreach (var st in sortByFirstAndLastName)
            {
                Console.WriteLine("Name = {0} {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}," +
                                  " Group Number = {7}\n", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone,
                    st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
            Console.WriteLine("=======================================================\n");
        }

        public static void SortByGroup(List<Student> students)
        {
            Console.WriteLine("|Sort By Group|\n");
            var sortbyGrop = from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var st in sortbyGrop)
            {
                Console.WriteLine("Name = {0} {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}," +
                                  " Group Number = {7}\n", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone,
                    st.Email, string.Join(" ", st.Marks), st.GroupNumber);
            }
            Console.WriteLine("=======================================================\n");
        }
    }
}

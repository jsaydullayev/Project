using StudentsTable.Class;
using StudentsTable.Methodes;


 
        StudentsClass studentsClass = new StudentsClass();
        HelperMethodes helperMethodes = new HelperMethodes();

while (true)
{
    Console.WriteLine("\n1. Show list of students: ");
    Console.WriteLine("2. Add a new student: ");
    Console.WriteLine("3. Exit: ");
    Console.Write("Enter the selected number: ");

    string tanla = Console.ReadLine();

    switch (tanla)
    {
        case "1":
            helperMethodes.AllStudents();
            break;
        case "2":
            Console.Write("FirstName: ");
            string firstName = Console.ReadLine();
            Console.Write("LastName: ");
            string lastName = Console.ReadLine();
            Console.Write("Age Student: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Address Student");
            string address = Console.ReadLine();


            var newStudent = new StudentsClass { FirstName = firstName, LastName = lastName, Age = age, Address = address };
            helperMethodes.AddStudents(newStudent);
            break;
        case "3":
            Console.WriteLine("Break");
            return;
        default:
            Console.WriteLine("Try again");
            break;
    }
}

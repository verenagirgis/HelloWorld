using System.Numerics;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Type your username and press enter
        
        
        List<Student> students = new List<Student>();
        while (true) {
            Console.WriteLine("l- list students, d name- delete name from list, a name age- add student:");
            string input = Console.ReadLine();
            var instructions = input.Split(" ");
            switch (instructions[0]) {
                case "exit":
                    return;
                case "l":
                    ListStudents(students); // need to validate user input, don't have time
                    break;
                case "d":
                    DeleteStudent(students, instructions); // need to validate user input, don't have time
                    break;
                case "a":
                    AddStudent(students, instructions); // need to validate user input, don't have time
                    break;
                default: 
                    Console.WriteLine("Wrong input, please choose from the following:");
                    break;
            }
        }
    }

    // could create class Classroom/Roster, but won't for the sake of time
    static void ListStudents(List<Student> students)
    {
        if (students.Count() == 0) {
            Console.WriteLine("There are no students in the list");
            return;
        }

        foreach (Student student in students) {
            // improvement, write a getStudent method returning the right string.
            Console.WriteLine(student.getName() + " " + student.getAge());
        }
    }

    static void AddStudent (List<Student> students, string[] instructions) {
        var name = instructions[1] + " " + instructions[2];
        var student = new Student(name, int.Parse(instructions[3]));
        students.Add(student);
    }

    public static void DeleteStudent(List<Student> students, string[] instructions) {
        var studentToDelete = -1;
        var name = instructions[1];
        for (int i = 0; i < students.Count; i++) {
            if (students[i].getName().Contains(name)) {
                studentToDelete = i;
                break;
            }
        }

        if (studentToDelete == -1) {
            Console.WriteLine("There is no student with that name");
            return;
        }   
        
        students.RemoveAt(studentToDelete);
    }
}